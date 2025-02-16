using PicomotorStageControl_v2.Properties;
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
        private frmMain MainForm;

        public decimal Position { get; private set; }
        public MovementReferenceType MovementReference { get; private set; }

        BackgroundWorker MoveToBackgroundWorker;
        BackgroundWorker MoveToIndicatorJogWorker;
        bool IndicatorJogWorkerShouldRun;
        float IndicatorMoveToPosition;

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

            MoveToIndicatorJogWorker = new BackgroundWorker();
            MoveToIndicatorJogWorker.DoWork += MoveToIndicatorJogWorker_DoWork;
        }

        private void MoveToIndicatorJogWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            bool up = (float)this.MainForm.Indicator.Position > (float)this.IndicatorMoveToPosition;
            int prevVel = this.MainForm.Motor.Velocity_step;

            while ((float)this.MainForm.Indicator.Position > IndicatorMoveToPosition && up == true && IndicatorJogWorkerShouldRun)
            {
                float dist = Math.Abs(IndicatorMoveToPosition - (float)this.MainForm.Indicator.Position);

                if (Settings.Default.StageMovementCreepUp)
                {
                    if (dist < Settings.Default.StageMovementSlowDownDistance && this.MainForm.Motor.Velocity_step > Settings.Default.StageMovementSlowDownVelocity)
                    {
                        this.MainForm.Motor.SetVelocity(Settings.Default.StageMovementSlowDownVelocity);
                    }
                }

                this.MainForm.Motor.JogNegative();
                this.Running = true;
                MoveState a = this.MainForm.Motor.MoveState;
            }

            while ((float)this.MainForm.Indicator.Position < IndicatorMoveToPosition && up == false && IndicatorJogWorkerShouldRun)
            {
                float dist = Math.Abs(IndicatorMoveToPosition - (float)this.MainForm.Indicator.Position);

                if (Settings.Default.StageMovementCreepUp)
                {
                    if (dist < Settings.Default.StageMovementSlowDownDistance && this.MainForm.Motor.Velocity_step > Settings.Default.StageMovementSlowDownVelocity)
                    {
                        this.MainForm.Motor.SetVelocity(Settings.Default.StageMovementSlowDownVelocity);
                    }
                }

                this.MainForm.Motor.JogPositive();
                this.Running = true;
                MoveState a = this.MainForm.Motor.MoveState;
            }

            this.MainForm.Motor.StopMotion();
            if (Settings.Default.StageMovementCreepUp)
            {
                this.MainForm.Motor.SetVelocity(prevVel);
            }
            this.IndicatorJogWorkerShouldRun = false;

            this.Running = false;
        }

        private void MoveToBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (this.MainForm.Motor == null)
            {
                return;
            }

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
                
                IndicatorMoveToPosition = (float)this.Position;

                IndicatorJogWorkerShouldRun = true;
                MoveToIndicatorJogWorker.RunWorkerAsync();
            }
        }

        public override void Execute()
        {
            this.Running = true;
            MoveToBackgroundWorker.RunWorkerAsync();
        }

        public override void Stop()
        {
            base.Stop();

            IndicatorJogWorkerShouldRun = false; // ugh

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
