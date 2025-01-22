using NewFocus.Picomotor;
using PicomotorStageControl_v2.Properties;
using System.Text;

namespace PicomotorStageControl_v2
{
    public partial class frmMain : Form
    {
        private enum MovementReferenceType
        {
            Calibration,
            Indicator,
            Steps
        }

        public CmdLib8742 StageCMD;
        public string DeviceID { get; private set; } = String.Empty;
        public Motor? Motor { get; private set; } // Bad name?

        public Indicator? Indicator { get; private set; } = null;

        public string IndicatorPosition = "";
        private MovementReferenceType MovementReference = MovementReferenceType.Indicator; // Hard-coded, whatever. Same with initial labels. Cleaner code.
        private bool ReferenceLocked = false;


        public frmMain()
        {
            InitializeComponent();
        }


        #region Handlers
        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateCalibrationValues();
        }

        // Could use this for detecting usb device disconnection
        // First detect change, then check if the change is a bad one
        // Doesn't work for turning off the device. Also, ive never had a disconnection happen,
        // so for now this can just sit here.
        // https://www.codeproject.com/KB/system/DriveDetector.aspx
        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);

        //    if (m.Msg == 0x0219) // WM_DEVICECHANGE
        //    {
        //        MessageBox.Show("HELLO!");
        //    }
        //}

        private void btnOpenSequenceEditor_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmSequenceEditor"] as frmSequenceEditor) != null)
                return;

            frmSequenceEditor calibrationForm = new frmSequenceEditor();
            calibrationForm.Show();
        }

        private void stripAbout_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmAbout"] as frmAbout) != null)
                return;

            frmAbout aboutForm = new frmAbout();
            aboutForm.Show();
        }
        private void stripSettings_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmSettings"] as frmSettings) != null)
                return;

            frmSettings settingsForm = new frmSettings(this);
            settingsForm.Show();
        }
        private void btnLockReference_Click(object sender, EventArgs e)
        {
            if (ReferenceLocked == false)
            {
                this.btnLockReference.Text = "Unlock Reference";
                this.radRefCalibration.Enabled = false;
                this.radRefIndicator.Enabled = false;
                this.radRefSteps.Enabled = false;

                this.ReferenceLocked = true;
            }
            else
            {
                this.btnLockReference.Text = "Lock Reference";
                this.radRefCalibration.Enabled = true;
                this.radRefIndicator.Enabled = true;
                this.radRefSteps.Enabled = true;

                this.ReferenceLocked = false;
            }
        }
        private void stripConnectIndicator_Click(object sender, EventArgs e)
        {
            if (Indicator == null || !Indicator.Connected)
            {
                // Rudimentary check. Realistically, will only either be "COM__" or "".
                if (!Settings.Default.IndicatorCOMPort.Contains("COM"))
                {
                    MessageBox.Show("Invalid COM port! Please check settings!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Indicator = new Indicator(Settings.Default.IndicatorCOMPort); // TO DO: Set from settings

                bool success = Indicator.Connect();

                if (!success)
                {
                    MessageBox.Show("Error connecting to indicator!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Indicator = null;
                    return;
                }

                statusIndicatorConnected.Text = "Connected";
                statusIndicatorConnected.ForeColor = Color.Green;
                tmrIndicatorDisplayUpdate.Enabled = true;
                tmrIndicatorDisplayUpdate.Start();
            }
        }
        private void stripConnectStage_Click(object sender, EventArgs e)
        {
            string dID = "";
            StageCMD = new NewFocus.Picomotor.CmdLib8742(true, 5000, ref dID);

            if (dID == null)
            {
                MessageBox.Show("Could not connect to stage!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.DeviceID = dID;

            string returnStr = "";
            StageCMD.Query(this.DeviceID, "MC", ref returnStr); // What does this do? I forgot. Haha.

            Motor = new Motor(this, 1, (float)Settings.Default.AvgNegativeStepSize_um, (float)Settings.Default.AvgPositiveStepSize_um); // TO DO: Change decimal to float in settings, maybe. Think about it.

            tmrMotorDisplayUpdate.Enabled = true;
            tmrMotorDisplayUpdate.Start();

            statusStageConnected.Text = "Connected";
            statusStageConnected.ForeColor = Color.Green;

            numMotorSettingsVelocity.Value = Motor.Velocity_step;
            numMotorSettingsAcceleration.Value = Motor.Acceleration_step;
        }
        private void tmrIndicatorDisplayUpdate_Tick(object sender, EventArgs e)
        {
            if (Indicator != null && Indicator.Connected)
            {
                this.lblIndicatorDisplayPosition.Text = this.Indicator.Position.ToString();
                this.lblIndicatorDisplayVelocity.Text = this.Indicator.Velocity.ToString();
            }
        }

        private void radRefIndicator_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMovementReference();
        }

        private void radRefCalibration_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMovementReference();
        }

        private void radRefSteps_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMovementReference();
        }

        #endregion

        #region Methods
        private void UpdateMovementReference()
        {
            if (radRefIndicator.Checked)
            {
                MovementReference = MovementReferenceType.Indicator;
                lblGoToUnits.Text = "um";
                lblMoveDistanceUnits.Text = "um";
                lblMotorSettingsVelocityUnits.Text = "um/s";
                lblMotorSettingsAccelerationUnits.Text = "um/s^2";
            }
            else if (radRefCalibration.Checked)
            {
                MovementReference = MovementReferenceType.Calibration;
                lblGoToUnits.Text = "um";
                lblMoveDistanceUnits.Text = "um";
                lblMotorSettingsVelocityUnits.Text = "um/s";
                lblMotorSettingsAccelerationUnits.Text = "um/s^2";
            }
            else if (radRefSteps.Checked)
            {
                MovementReference = MovementReferenceType.Steps;
                lblGoToUnits.Text = "steps";
                lblMoveDistanceUnits.Text = "steps";
                lblMotorSettingsVelocityUnits.Text = "steps/s";
                lblMotorSettingsAccelerationUnits.Text = "steps/s^2";
            }
        }
        #endregion

        private void tmrMotorDisplayUpdate_Tick(object sender, EventArgs e)
        {
            lblCalPositionTotalSteps.Text = this.Motor.Position_step.ToString();
            lblCalPositionNegSteps.Text = this.Motor.PositionNegative_step.ToString();
            lblCalPositionPosSteps.Text = this.Motor.PositionPositive_step.ToString();
            lblCalPositionEstMicronPosition.Text = this.Motor.PositionFromCalibration_um.ToString();

            lblCalVelRaw.Text = this.Motor.Velocity_step.ToString();
            lblCalVelNeg.Text = this.Motor.NegativeVelocityFromCalibration_um.ToString();
            lblCalVelPos.Text = this.Motor.PositiveVelocityFromCalibration_um.ToString();

            lblCalAccelRaw.Text = this.Motor.Acceleration_step.ToString();
            lblCalAccelNeg.Text = this.Motor.NegativeAccelerationFromCalibration_um.ToString();
            lblCalAccelPos.Text = this.Motor.PositiveAccelerationFromCalibration_um.ToString();
        }

        private void btnMotorSettingsApply_Click(object sender, EventArgs e)
        {
            if (this.Motor != null)
            {
                this.Motor.SetVelocity((int)numMotorSettingsVelocity.Value);
                this.Motor.SetAcceleration((int)numMotorSettingsAcceleration.Value);
            }
        }
        public void UpdateCalibrationValues()
        {
            float neg = (float)Settings.Default.AvgNegativeStepSize_um;
            float pos = (float)Settings.Default.AvgPositiveStepSize_um;

            lblCalNegStepSize.Text = neg.ToString();
            lblCalPosStepSize.Text = pos.ToString();

            if (this.Motor != null)
            {
                this.Motor.SetCalibrationNegativeStepSize_um(neg);
                this.Motor.SetCalibrationPositiveStepSize_um(pos);
                lblMotorSettingsEstNegVel.Text = Motor.NegativeVelocityFromCalibration_um.ToString();
                lblMotorSettingsEstPosVel.Text = Motor.PositiveVelocityFromCalibration_um.ToString();
                lblMotorSettingsEstNegAccel.Text = Motor.NegativeAccelerationFromCalibration_um.ToString();
                lblMotorSettingsEstPosAccel.Text = Motor.PositiveAccelerationFromCalibration_um.ToString();

                // TO DO: Set ?
            }
        }

        private void btnStopAllMotion_Click(object sender, EventArgs e)
        {
            if (this.Motor != null)
            {
                this.Motor.StopMotion();
            }
        }

        private void btnActiveControlsUp_Click(object sender, EventArgs e)
        {
            if (this.Motor != null)
            {
                this.Motor.JogPositive();
            }
        }

        private void btnActiveControlsDown_Click(object sender, EventArgs e)
        {
            if (this.Motor != null)
            {
                this.Motor.JogNegative();
            }
        }

        private void btnMoveDistance_Click(object sender, EventArgs e)
        {
            if (this.Motor != null)
            {
                if (this.MovementReference == MovementReferenceType.Steps)
                {
                    this.Motor.RelativeMove_step((int)numMoveDistance.Value);
                }
                else if (this.MovementReference == MovementReferenceType.Indicator)
                {
                    // TO DO: IMPLEMENT
                    // TO DO: Modify numeric input settings based upon mode used
                }
                else if (this.MovementReference == MovementReferenceType.Calibration)
                {
                    this.Motor.RelativeMove_step(this.Motor.MicronToStep((int)numMoveDistance.Value));
                }
            }
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (this.Motor != null)
            {
                if (this.MovementReference == MovementReferenceType.Steps)
                {
                    this.Motor.MoveToRelativePosition_step((int)numGoTo.Value);
                }
                else if (this.MovementReference == MovementReferenceType.Indicator)
                {
                    // TO DO: IMPLEMENT
                }
                else if (this.MovementReference == MovementReferenceType.Calibration)
                {
                    this.Motor.MoveToRelativePosition_step(this.Motor.MicronToStep((int)numGoTo.Value));
                }
            }
        }

        private void btnActiveControlsUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (Motor != null && Motor.MoveState == MoveState.Stationary)
            {
                Motor.JogPositive();
            }
        }

        private void btnActiveControlsUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (Motor != null)
            {
                Motor.StopMotion();
            }
        }

        private void btnActiveControlsDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (Motor != null && Motor.MoveState == MoveState.Stationary)
            {
                Motor.JogNegative();
            }
        }

        private void btnActiveControlsDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (Motor != null)
            {
                Motor.StopMotion();
            }
        }

        private void numMotorSettingsVelocity_ValueChanged(object sender, EventArgs e)
        {
            if (Motor != null)
            {
                lblMotorSettingsEstNegVel.Text = Motor.NegativeVelocityFromCalibration_um.ToString();
                lblMotorSettingsEstPosVel.Text = Motor.PositiveVelocityFromCalibration_um.ToString();
            }
        }

        private void numMotorSettingsAcceleration_ValueChanged(object sender, EventArgs e)
        {
            if (Motor != null)
            {
                lblMotorSettingsEstNegAccel.Text = Motor.NegativeAccelerationFromCalibration_um.ToString();
                lblMotorSettingsEstPosAccel.Text = Motor.PositiveAccelerationFromCalibration_um.ToString();
            }
        }
    }
}