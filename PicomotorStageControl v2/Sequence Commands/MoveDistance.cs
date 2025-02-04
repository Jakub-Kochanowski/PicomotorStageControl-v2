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
    internal class MoveDistance : Command
    {
        frmMain MainForm;
        public decimal Distance { get; private set; }
        private MovementReferenceType MovementReference;
        BackgroundWorker MoveDistanceBackgroundWorker;

        public MoveDistance(frmMain mainForm, decimal distance, MovementReferenceType movementReference) : base()
        {
            this.MainForm = mainForm;
            this.Type = CommandTypes.MoveDistance;
            this.Distance = distance;
            this.DisplayText = "Move By " + Distance.ToString() + " um";
            this.MovementReference = movementReference;
            this.LogMessage = "Move Distance: " + Distance.ToString() + " (" + movementReference.ToString() + ")";
            MoveDistanceBackgroundWorker = new BackgroundWorker();
            MoveDistanceBackgroundWorker.DoWork += MoveDistanceBackgroundWorker_DoWork;
        }

        private void MoveDistanceBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (this.MovementReference == MovementReferenceType.Steps)
            {
                this.MainForm.Motor.RelativeMove_step((int)this.Distance);
            }
            else if (this.MovementReference == MovementReferenceType.Calibration)
            {
                this.MainForm.Motor.RelativeMove_step(this.MainForm.Motor.MicronToStep((float)this.Distance));
            }
            else if (this.MovementReference == MovementReferenceType.Indicator)
            {
                // TO DO: This is an awful implementation. But, it works, so...
                if (this.MainForm.Indicator == null)
                {
                    return;
                }
                if (this.Distance > 0)
                {
                    this.MainForm.IndicatorMoveToPosition = Math.Abs((float)this.Distance - (float)this.MainForm.Indicator.Position);
                }
                else
                {
                    this.MainForm.IndicatorMoveToPosition = -Math.Abs((float)this.Distance - (float)this.MainForm.Indicator.Position);
                }

                this.MainForm.IndicatorJogWorkerShouldRun = true;
                this.MainForm.IndicatorJogWorker.RunWorkerAsync();
            }

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
            MoveDistanceBackgroundWorker.RunWorkerAsync();
        }

        public override void Stop()
        {
            base.Stop();
            this.MainForm.IndicatorJogWorkerShouldRun = false; // ugh

            if (this.MainForm.Motor != null)
            {
                this.MainForm.Motor.StopMotion(); // TO DO: Should this be in the stop button method, instead? Probably.
            }

            MoveDistanceBackgroundWorker.Dispose();
            MoveDistanceBackgroundWorker = new BackgroundWorker();
            MoveDistanceBackgroundWorker.DoWork += MoveDistanceBackgroundWorker_DoWork;
        }
    }
}
