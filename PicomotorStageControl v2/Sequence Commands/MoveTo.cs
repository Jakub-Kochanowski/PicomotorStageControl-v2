using PicomotorStageControl_v2.SequenceCommands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class MoveTo : Command
    {
        public decimal Position { get; private set; }
        private frmMain MainForm;
        MovementReferenceType MovementReference;
        BackgroundWorker MoveToBackgroundWorker;

        public MoveTo(frmMain mainForm, decimal position, MovementReferenceType movementReference) : base()
        {
            this.MainForm = mainForm;
            this.Type = CommandTypes.MoveTo;
            this.Position = position;
            this.DisplayText = "Move To " + position.ToString() + " um";
            this.MovementReference = movementReference;
            this.LogMessage = "Move To: " + position.ToString() + " (" + movementReference.ToString() + ")";

            MoveToBackgroundWorker = new BackgroundWorker();
            MoveToBackgroundWorker.DoWork += MoveToBackgroundWorker_DoWork;
        }

        private void MoveToBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {

            if (this.MovementReference == MovementReferenceType.Steps)
            {
                this.MainForm.Motor.MoveToRelativePosition_step((int)this.Position);
            }
            else if (this.MovementReference == MovementReferenceType.Calibration)
            {
                this.MainForm.Motor.MoveToRelativePosition_step(this.MainForm.Motor.MicronToStep((float)this.Position));
            }
            else if (this.MovementReference == MovementReferenceType.Indicator)
            {
                // TO DO: Again, awful implementation. But, it works, so...
                if (this.MainForm.Indicator == null)
                {
                    return;
                }
                
                this.MainForm.IndicatorMoveToPosition = (float)this.Position;
                this.MainForm.IndicatorJogWorkerShouldRun = true;
                this.MainForm.IndicatorJogWorker.RunWorkerAsync();
            }

            // Not sure why the stationary thing doesn't work here for the indicator. Might be a timing issue due to not synchronized threads.
            // This could cause problems in a weird way, but it works for now, so let's stick with it.
            while (this.MainForm.Motor.MoveState != MoveState.Stationary || this.MainForm.IndicatorJogWorkerShouldRun == true)
            {
                this.Running = true;
                Thread.Yield();
            }
            this.Running = false;
        }

        public override void Execute()
        {
            if (this.MainForm.Motor == null)
            {
                return;
            }

            this.Running = true;
            MoveToBackgroundWorker.RunWorkerAsync();
        }

        public override void Stop()
        {
            this.MainForm.IndicatorJogWorkerShouldRun = false; // ugh

            if (this.MainForm.Motor != null)
            {
                this.MainForm.Motor.StopMotion();
            }

            MoveToBackgroundWorker.Dispose();
            MoveToBackgroundWorker = new BackgroundWorker();
            MoveToBackgroundWorker.DoWork += MoveToBackgroundWorker_DoWork;
        }
    }
}
