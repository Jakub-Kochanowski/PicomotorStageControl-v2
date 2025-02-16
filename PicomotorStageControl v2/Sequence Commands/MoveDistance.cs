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
    internal class MoveDistance : Command
    {
        frmMain MainForm;

        public decimal Distance { get; private set; }
        public MovementReferenceType MovementReference { get; private set; }
        BackgroundWorker MoveDistanceBackgroundWorker;
        BackgroundWorker MoveDistanceIndicatorJogWorker;
        bool IndicatorJogWorkerShouldRun;
        float IndicatorMoveToPosition;

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

            MoveDistanceIndicatorJogWorker = new BackgroundWorker();
            MoveDistanceIndicatorJogWorker.DoWork += MoveDistanceIndicatorJogWorker_DoWork;
        }

        private void MoveDistanceIndicatorJogWorker_DoWork(object? sender, DoWorkEventArgs e)
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

        private void MoveDistanceBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (this.MainForm.Motor == null)
            {
                return;                
            }

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
                if (this.MainForm.Indicator == null)
                {
                    return;
                }

                IndicatorMoveToPosition = (float)this.MainForm.Indicator.Position + (float)this.Distance;

                IndicatorJogWorkerShouldRun = true;
                MoveDistanceIndicatorJogWorker.RunWorkerAsync();
            }
        }

        public override void Execute()
        {        
            this.Running = true;
            MoveDistanceBackgroundWorker.RunWorkerAsync();
        }

        public override void Stop()
        {
            base.Stop();

            IndicatorJogWorkerShouldRun = false;

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
