using NewFocus.Picomotor;
using PicomotorStageControl_v2.Properties;
using ScottPlot.Plottables;
using System.ComponentModel;
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

        public CmdLib8742? StageCMD;
        public string DeviceID { get; private set; } = String.Empty;
        public Motor? Motor { get; private set; } // Bad name?

        public Indicator? Indicator { get; private set; } = null;

        public string IndicatorPosition = "";
        private MovementReferenceType MovementReference = MovementReferenceType.Calibration; // Hard-coded, whatever. Same with initial labels. Cleaner code.
        private bool ReferenceLocked = false;

        BackgroundWorker IndicatorJogWorker;
        float IndicatorMoveToPosition = 0.0f;
        bool IndicatorJogWorkerShouldRun = false;

        private DataLogger LoggerMotorSteps;
        private DataLogger LoggerMotorCalibrationMicrons;
        private DataLogger LoggerIndicatorMicrons;

        public frmMain()
        {
            InitializeComponent();
        }

        #region Handlers
        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateCalibrationValues();
            IndicatorJogWorker = new BackgroundWorker();
            IndicatorJogWorker.WorkerSupportsCancellation = true;
            IndicatorJogWorker.DoWork += IndicatorJogWorker_DoWork;

            InitializePlot();

            this.tmrPlotUpdate.Enabled = true;
            this.tmrPlotUpdate.Start();
        }

        private void InitializePlot()
        {
            LoggerMotorSteps = Plot.Plot.Add.DataLogger();
            LoggerMotorCalibrationMicrons = Plot.Plot.Add.DataLogger();
            LoggerIndicatorMicrons = Plot.Plot.Add.DataLogger();
        }

        private void IndicatorJogWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (Motor == null || Indicator == null)
            {
                return;
            }

            bool up = (float)Indicator.Position > IndicatorMoveToPosition;
            int prevVel = Motor.Velocity_step;

            while ((float)Indicator.Position > IndicatorMoveToPosition && up == true && IndicatorJogWorkerShouldRun)
            {
                float dist = Math.Abs(IndicatorMoveToPosition - (float)Indicator.Position);

                if (Settings.Default.StageMovementCreepUp)
                {
                    if (dist < Settings.Default.StageMovementSlowDownDistance && this.Motor.Velocity_step > Settings.Default.StageMovementSlowDownVelocity)
                    {
                        this.Motor.SetVelocity(100);
                    }
                }

                Motor.JogNegative();
            }

            while ((float)this.Indicator.Position < IndicatorMoveToPosition && up == false && IndicatorJogWorkerShouldRun)
            {
                float dist = Math.Abs(IndicatorMoveToPosition - (float)Indicator.Position);

                if (Settings.Default.StageMovementCreepUp)
                {
                    if (dist < Settings.Default.StageMovementSlowDownDistance && this.Motor.Velocity_step > Settings.Default.StageMovementSlowDownVelocity)
                    {
                        this.Motor.SetVelocity(100);
                    }
                }

                Motor.JogPositive();
            }

            Motor.StopMotion();
            if (Settings.Default.StageMovementCreepUp)
            {
                Motor.SetVelocity(prevVel);
            }
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

                // Enable Indicator Controls
                radRefIndicator.Enabled = true;
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
            StageCMD.Query(this.DeviceID, "MC", ref returnStr); // What does this do? I forgot. Haha. Likely motor check.

            Motor = new Motor(this, 1, (float)Settings.Default.AvgNegativeStepSize_um, (float)Settings.Default.AvgPositiveStepSize_um); // TO DO: Change decimal to float in settings, maybe. Think about it.

            tmrMotorDisplayUpdate.Enabled = true;
            tmrMotorDisplayUpdate.Start();

            statusStageConnected.Text = "Connected";
            statusStageConnected.ForeColor = Color.Green;

            numMotorSettingsVelocity.Value = Motor.Velocity_step;
            numMotorSettingsAcceleration.Value = Motor.Acceleration_step;

            // Enable Stage Controls
            btnActiveControlsUp.Enabled = true;
            btnActiveControlsDown.Enabled = true;
            btnMoveDistance.Enabled = true;
            btnGoTo.Enabled = true;
            btnMotorSettingsApply.Enabled = true;
            btnStopAllMotion.Enabled = true;
            btnMotorSettingsCancel.Enabled = true;
            btnMotorSettingsApplyDefault.Enabled = true;
            btnCalZeroPosition.Enabled = true;
            btnDataCollect.Enabled = true;
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
            }
            else if (radRefCalibration.Checked)
            {
                MovementReference = MovementReferenceType.Calibration;
                lblGoToUnits.Text = "um";
                lblMoveDistanceUnits.Text = "um";
            }
            else if (radRefSteps.Checked)
            {
                MovementReference = MovementReferenceType.Steps;
                lblGoToUnits.Text = "steps";
                lblMoveDistanceUnits.Text = "steps";
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
                this.IndicatorJogWorkerShouldRun = false;
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
                else if (this.MovementReference == MovementReferenceType.Indicator && this.Indicator != null)
                {
                    if (numMoveDistance.Value > 0)
                    {
                        IndicatorMoveToPosition = Math.Abs((float)numMoveDistance.Value - (float)this.Indicator.Position);
                    }
                    else
                    {
                        IndicatorMoveToPosition = -Math.Abs((float)numMoveDistance.Value - (float)this.Indicator.Position);
                    }

                    IndicatorJogWorkerShouldRun = true;
                    IndicatorJogWorker.RunWorkerAsync();
                }
                else if (this.MovementReference == MovementReferenceType.Calibration)
                {
                    this.Motor.RelativeMove_step(this.Motor.MicronToStep((int)numMoveDistance.Value));
                }
            }
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (this.Motor != null && this.Indicator != null)
            {
                if (this.MovementReference == MovementReferenceType.Steps)
                {
                    this.Motor.MoveToRelativePosition_step((int)numGoTo.Value);
                }
                else if (this.MovementReference == MovementReferenceType.Indicator && this.Indicator != null)
                {
                    IndicatorMoveToPosition = (float)numGoTo.Value;
                    IndicatorJogWorkerShouldRun = true;
                    IndicatorJogWorker.RunWorkerAsync();
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

        private void btnCalZeroPosition_Click(object sender, EventArgs e)
        {
            if (this.Motor != null)
            {
                this.Motor.ZeroDevicePosition();
            }
        }

        private void btnDataSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDataDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDataCollect_Click(object sender, EventArgs e)
        {
            string dir = txtDataDirectory.Text;
            string name = txtDataFileName.Text;
            string path = Path.Combine(dir, name);

            // From https://stackoverflow.com/questions/4650462/easiest-way-to-check-if-an-arbitrary-string-is-a-valid-filename
            if (this.txtDataFileName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
            {
                return;
            }
            if (File.Exists(path))
            {
                DialogResult fileExistsResult = MessageBox.Show("File already exists! Would you like to override?", "File Exists!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (fileExistsResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void tmrPlotUpdate_Tick(object sender, EventArgs e)
        {
            if (Motor != null)
            {
                LoggerMotorSteps.Add(this.Motor.Position_step);
                LoggerMotorCalibrationMicrons.Add(this.Motor.PositionFromCalibration_um);
            }
            if (Indicator != null)
            {
                LoggerIndicatorMicrons.Add((float)this.Indicator.Position);
            }
            
            Plot.Refresh();
        }
    }
}