using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewFocus.Picomotor;

namespace PicomotorStageControl_v2
{
    public enum MoveState
    {
        Negative,
        Stationary,
        Positive
    }

    public class Motor
    {
        frmMain MainForm;
        int MotorID;
        public MoveState MoveState { get; private set; } = MoveState.Stationary;
        public CmdLib8742.eMotorType MotorType { get; private set; } = CmdLib8742.eMotorType.NoMotor;

        public int Position_step { get; private set; } = 0;
        public int PositionNegative_step { get; private set; } = 0;
        public int PositionPositive_step { get; private set; } = 0;
        public int Velocity_step { get; private set; } = 0;
        public int Acceleration_step { get; private set; } = 0;

        public float CalibrationNegativeStepSize_um { get; private set; } = 0.03f;
        public float CalibrationPositiveStepSize_um { get; private set; } = 0.03f;

        public float PositionFromCalibration_um { get { return PositionNegative_step * CalibrationNegativeStepSize_um + PositionPositive_step * CalibrationPositiveStepSize_um; } }
        public float NegativeVelocityFromCalibration_um { get { return Velocity_step * CalibrationNegativeStepSize_um; } }
        public float PositiveVelocityFromCalibration_um { get { return Velocity_step * CalibrationPositiveStepSize_um; } }
        public float NegativeAccelerationFromCalibration_um { get { return Acceleration_step * CalibrationNegativeStepSize_um; } }
        public float PositiveAccelerationFromCalibration_um { get { return Acceleration_step * CalibrationPositiveStepSize_um; } }

        BackgroundWorker PositionUpdateWorker;

        public Motor(frmMain mainForm, int motorID)
        {
            this.MainForm = mainForm;
            this.MotorID = motorID;

            Initialize();
        }

        public Motor(frmMain mainForm, int motorID, float negativeStepSize_um, float positiveStepSize_um)
        {
            this.MainForm = mainForm;
            this.MotorID = motorID;
            this.CalibrationNegativeStepSize_um = negativeStepSize_um;
            this.CalibrationPositiveStepSize_um = positiveStepSize_um;

            Initialize();
        }

        public void Initialize()
        {
            PositionUpdateWorker = new BackgroundWorker();
            PositionUpdateWorker.DoWork += PositionUpdateWorker_DoWork;

            // Zero every motor upon start.
            // We cannot know what the distance traveled up and down is from the distance in device memory.
            this.ZeroDevicePosition();
            this.GetMotorType();
            this.GetDeviceVelAndAccel();
        }

        private void PositionUpdateWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            // Keep track of positions for negative and positive directions of movement.
            // Update total position from data on the device.
            // Update move state.
            // TO DO: Add error checking? There is no clear error indication. /Could/ do a complicated logical setup, but is it reaaally worth it?
            int pos = 0;
            bool isMotionDone = false;
            while (!isMotionDone)
            {
                MainForm.StageCMD.GetMotionDone(MainForm.DeviceID, this.MotorID, ref isMotionDone);
                MainForm.StageCMD.GetPosition(MainForm.DeviceID, this.MotorID, ref pos);
                
                if (this.MoveState == MoveState.Negative)
                {
                    this.PositionNegative_step += pos - this.Position_step;
                }
                else if (this.MoveState == MoveState.Positive)
                {
                    this.PositionPositive_step += pos - this.Position_step;
                }

                this.Position_step = pos;
            }

            this.MoveState = MoveState.Stationary;
            MainForm.StageCMD.GetPosition(MainForm.DeviceID, this.MotorID, ref pos);
            this.Position_step = pos;
        }

        public void SetCalibrationStepSize_um(float negativeStepSize_um, float positiveStepSize_um)
        {
            this.CalibrationNegativeStepSize_um = negativeStepSize_um;
            this.CalibrationPositiveStepSize_um = positiveStepSize_um;
        }

        public void SetCalibrationNegativeStepSize_um(float negativeStepSize_um)
        {
            this.CalibrationNegativeStepSize_um = negativeStepSize_um;
        }

        public void SetCalibrationPositiveStepSize_um(float positiveStepSize_um)
        {
            this.CalibrationPositiveStepSize_um = positiveStepSize_um;
        }

        public void JogNegative()
        {
            if (this.PositionUpdateWorker.IsBusy)
                return;

            if (MainForm.StageCMD.JogNegative(MainForm.DeviceID, this.MotorID))
            {
                this.MoveState = MoveState.Negative;
                this.PositionUpdateWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Error jogging stage in negative direction!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void JogPositive()
        {
            if (this.PositionUpdateWorker.IsBusy)
                return;
            
            if (MainForm.StageCMD.JogPositive(MainForm.DeviceID, this.MotorID))
            {
                this.MoveState = MoveState.Positive;
                this.PositionUpdateWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Error jogging stage in positive direction!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetDeviceVelAndAccel()
        {
            int vel = 0;
            if (MainForm.StageCMD.GetVelocity(MainForm.DeviceID, this.MotorID, ref vel))
            {
                this.Velocity_step = vel;
            }
            else
            {
                MessageBox.Show("Error getting velocity!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int accel = 0;
            if (MainForm.StageCMD.GetAcceleration(MainForm.DeviceID, this.MotorID, ref accel))
            {
                this.Acceleration_step = accel;
            }
            else
            {
                MessageBox.Show("Error getting acceleration!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StopMotion()
        {
            if (!MainForm.StageCMD.StopMotion(this.MainForm.DeviceID, this.MotorID))
            {
                MessageBox.Show("Error stopping motion!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.MoveState = MoveState.Stationary;
        }

        public void ZeroDevicePosition()
        {
            if (this.PositionUpdateWorker.IsBusy)
                return;

            if (!MainForm.StageCMD.SetZeroPosition(MainForm.DeviceID, this.MotorID))
            {
                MessageBox.Show("Error zeroing position!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.PositionNegative_step = 0;
            this.PositionPositive_step = 0;
            this.PositionUpdateWorker.RunWorkerAsync();
        }

        public void GetMotorType()
        {
            var motorType = CmdLib8742.eMotorType.NoMotor;
            if (MainForm.StageCMD.GetMotorType(MainForm.DeviceID, this.MotorID, ref motorType))
            {
                this.MotorType = motorType;
            }
            else
            {
                this.MotorType = CmdLib8742.eMotorType.NoMotor;
                MessageBox.Show("Unable to get motor type!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RelativeMove_step(int steps)
        {
            if (this.PositionUpdateWorker.IsBusy)
                return;

            if (steps > 0)
            {
                this.MoveState = MoveState.Positive;
            }
            else if (steps < 0)
            {
                this.MoveState = MoveState.Negative;
            }
            else
            {
                return;
            }

            if(MainForm.StageCMD.RelativeMove(MainForm.DeviceID, this.MotorID, steps))
            {
                this.PositionUpdateWorker.RunWorkerAsync();
            }
            else
            {
                this.MoveState = MoveState.Stationary;
                MessageBox.Show("Error with stage relative move!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MoveToRelativePosition_step(int stepPosition)
        {
            if (this.PositionUpdateWorker.IsBusy)
                return;

            int distance = stepPosition - this.Position_step;
            if (distance < 0)
            {
                this.MoveState = MoveState.Negative;
            }
            else if (distance > 0)
            {
                this.MoveState = MoveState.Positive;
            }
            else
            {
                return;
            }

            if (MainForm.StageCMD.RelativeMove(MainForm.DeviceID, this.MotorID, distance))
            {
                this.PositionUpdateWorker.RunWorkerAsync();
            }
            else
            {
                this.MoveState = MoveState.Stationary;
                MessageBox.Show("Error with stage relative move!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public float StepToMicron(int steps)
        {
            if (steps < 0)
                return steps * this.CalibrationNegativeStepSize_um;
            else if (steps > 0)
                return steps * this.CalibrationPositiveStepSize_um;
            else
                return 0;
        }

        public int MicronToStep(float microns)
        {
            if (microns < 0)
                return (int)Math.Round(microns / this.CalibrationNegativeStepSize_um);
            else if (microns > 0)
                return (int)Math.Round(microns / this.CalibrationPositiveStepSize_um);
            else
                return 0;
        }

        public void SetVelocity(int velocity_step)
        {
            if(!MainForm.StageCMD.SetVelocity(MainForm.DeviceID, this.MotorID, velocity_step))
            {
                MessageBox.Show("Error setting device velocity!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.GetDeviceVelAndAccel();
        }

        public void SetAcceleration(int acceleration_step)
        {
            if (!MainForm.StageCMD.SetAcceleration(MainForm.DeviceID, this.MotorID, acceleration_step))
            {
                MessageBox.Show("Error setting device acceleration!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.GetDeviceVelAndAccel();
        }
    }
}
