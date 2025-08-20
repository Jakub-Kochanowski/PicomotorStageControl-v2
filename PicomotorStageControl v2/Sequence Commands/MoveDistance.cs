using PicomotorStageControl_v2.Properties;
using System.ComponentModel;

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
            this.DisplayText = "Move Distance: " + Distance.ToString() +" (" + movementReference.ToString() + ")";
            this.MovementReference = movementReference;
            this.LogMessage = "Moved Distance: " + Distance.ToString() + " (" + movementReference.ToString() + ")";
            
            MoveDistanceBackgroundWorker = new BackgroundWorker();
            MoveDistanceBackgroundWorker.DoWork += MoveDistanceBackgroundWorker_DoWork;

            MoveDistanceIndicatorJogWorker = new BackgroundWorker();
            MoveDistanceIndicatorJogWorker.DoWork += MoveDistanceIndicatorJogWorker_DoWork;
        }

        private void MoveDistanceIndicatorJogWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            // TO DO: Handle this potential null indicator case? Will this ever happen?
            bool up = (float)this.MainForm.Indicator.Position > (float)this.IndicatorMoveToPosition;
            int prevVel = this.MainForm.MotorZ.Velocity_step;

            while ((float)this.MainForm.Indicator.Position > IndicatorMoveToPosition && up == true && IndicatorJogWorkerShouldRun)
            {
                float dist = Math.Abs(IndicatorMoveToPosition - (float)this.MainForm.Indicator.Position);

                if (Settings.Default.StageMovementCreepUp)
                {
                    if (dist < Settings.Default.StageMovementSlowDownDistance && this.MainForm.MotorZ.Velocity_step > Settings.Default.StageMovementSlowDownVelocity)
                    {
                        this.MainForm.MotorZ.SetVelocity(Settings.Default.StageMovementSlowDownVelocity);
                    }
                }

                this.MainForm.MotorZ.JogNegative();
                this.Running = true;
                MoveState a = this.MainForm.MotorZ.MoveState;
            }

            while ((float)this.MainForm.Indicator.Position < IndicatorMoveToPosition && up == false && IndicatorJogWorkerShouldRun)
            {
                float dist = Math.Abs(IndicatorMoveToPosition - (float)this.MainForm.Indicator.Position);

                if (Settings.Default.StageMovementCreepUp)
                {
                    if (dist < Settings.Default.StageMovementSlowDownDistance && this.MainForm.MotorZ.Velocity_step > Settings.Default.StageMovementSlowDownVelocity)
                    {
                        this.MainForm.MotorZ.SetVelocity(Settings.Default.StageMovementSlowDownVelocity);
                    }
                }

                this.MainForm.MotorZ.JogPositive();
                this.Running = true;
                // MoveState a = this.MainForm.Motor.MoveState; What was I doing here?
            }

            this.MainForm.MotorZ.StopMotion();
            if (Settings.Default.StageMovementCreepUp)
            {
                this.MainForm.MotorZ.SetVelocity(prevVel);
            }
            this.IndicatorJogWorkerShouldRun = false;

            this.Running = false;
        }

        private void MoveDistanceBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (this.MainForm.MotorZ == null)
            {
                return;                
            }

            if (this.MovementReference == MovementReferenceType.Steps)
            {
                this.MainForm.MotorZ.RelativeMove_step((int)this.Distance);
            }
            else if (this.MovementReference == MovementReferenceType.Calibration)
            {
                this.MainForm.MotorZ.RelativeMove_step(this.MainForm.MotorZ.MicronToStep((float)this.Distance));
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

            // TO DO: Implement this. But, also, need to re-initialize all of them at start of a sequence if this is done.
            //if (this.MovementReference == MovementReferenceType.Steps)
            //{
            //    float movedDistance = Math.Abs(this.MainForm.Motor.Position_step - this.Position_step_atStart);
            //    this.LogMessage = "Moved Distance: " + this.MainForm.Motor.Position_step.ToString() + " (" + MovementReference.ToString() + ")";
            //}
            //else if (this.MovementReference == MovementReferenceType.Calibration)
            //{
            //    this.LogMessage = "Moved Distance: " + this.MainForm.Motor.PositionFromCalibration_um.ToString() + " (" + MovementReference.ToString() + ")";
            //}
            //else if (this.MovementReference == MovementReferenceType.Indicator)
            //{
            //    this.LogMessage = "Moved Distance: " + this.MainForm.Indicator.Position.ToString() + " (" + MovementReference.ToString() + ")";
            //}

            if (this.MainForm.MotorZ != null)
            {
                this.MainForm.MotorZ.StopMotion(); // TO DO: Should this be in the stop button method, instead? Probably.
            }

            MoveDistanceBackgroundWorker.Dispose();
            MoveDistanceBackgroundWorker = new BackgroundWorker();
            MoveDistanceBackgroundWorker.DoWork += MoveDistanceBackgroundWorker_DoWork;
        }
    }
}
