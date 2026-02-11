using NewFocus.Picomotor;
using PicomotorStageControl_v2;
using PicomotorStageControl_v2.Properties;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace PicomotorStageControl_v2
{
    public partial class frmMain : Form
    {
        public CmdLib8742? StageCMD;
        public string DeviceID { get; private set; } = String.Empty;
        public Motor? MotorZ { get; private set; }
        public Motor? MotorX { get; private set; }
        public Motor? MotorY { get; private set; }

        public Indicator? Indicator { get; private set; } = null;

        public MicroscopeStageController? MicroscopeStageController { get; private set; } = null;
        public IndenterController? IndenterController { get; private set; } = null;

        public string IndicatorPosition = "";
        public MovementReferenceType MovementReference { get; private set; } = MovementReferenceType.Calibration; // Hard-coded, whatever. Same with initial labels. Cleaner code.
        private bool ReferenceLocked = false;

        public BackgroundWorker IndicatorJogWorker;
        public float IndicatorMoveToPosition = 0.0f;
        public bool IndicatorJogWorkerShouldRun = false;

        BackgroundWorker DataCollectionWorker;
        public bool CollectingData { get; private set; } = false;

        public bool IsSequenceRunning { get; set; } = false;

        frmSequenceEditor SequenceEditorForm;

        frmActivePlot PlotForm;

        private int indenterCal_sampleCount = 0;
        private int indenterCal_totalSamples = 200;
        private double indenterCal_sampleSum = 0;
        private int indenterCal_calOption = 0;

        BackgroundWorker springConstantBackgroundWorker;

        string SampleDetails_SampleName;
        string SampleDetails_Location;
        string SampleDetails_Measurement;
        List<(double time, double position, double force)> IndentationContactPoints = new List<(double, double, double)>();


        private enum SpringConstantMeasurementMode
        {
            ByPoints,
            ByDistance,
            ByForce
        }

        SpringConstantMeasurementMode springConstantMeasurementMode = SpringConstantMeasurementMode.ByPoints;

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

            this.tmrPlotUpdate.Enabled = true;
            this.tmrPlotUpdate.Start();

            DataCollectionWorker = new BackgroundWorker();
            DataCollectionWorker.DoWork += DataCollectionWorker_DoWork;

            SequenceEditorForm = new frmSequenceEditor(this);

            PlotForm = new frmActivePlot(this);
            PlotForm.Show();

            springConstantBackgroundWorker = new BackgroundWorker();
            springConstantBackgroundWorker.DoWork += SpringConstantBackgroundWorker_DoWork;
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (StageCMD != null)
                StageCMD.Close(this.DeviceID);
            if (Indicator != null && Indicator.Connected)
                Indicator.Disconnect();
            if (MicroscopeStageController != null && MicroscopeStageController.Connected)
                MicroscopeStageController.Dispose();
            if (IndenterController != null && IndenterController.Connected)
                IndenterController.Dispose();

        }

        private void DataCollectionWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            string fileLocation = txtDataDirectory.Text + "/" + txtDataFileName.Text + ".csv";
            StreamWriter streamWriter = File.AppendText(fileLocation);

            int index = 0;
            string line = "";
            int collectionInterval = (int)numDataCollectionRate.Value;

            // TO DO: There is definitely a better way to do this, but for now...

            line = "Index,Time(ms),MotorZ Position (steps),MotorZ Position Negative (steps),MotorZ Position Positive (steps)," +
                "MotorZ Position From Calibration (microns),MotorZ Velocity Negative From Calibration (microns),MotorZ Velocity Positive From Calibration (microns)," +
                "MotorZ Acceleration Negative From Calibration (microns),MotorZ Acceleration Positive From Calibration (microns)," +
                "MotorZ Calibration Negative Step Size (microns),MotorZ Calibration Positive Step Size (microns)," +
                "MotorZ Velocity (steps/s),MotorZ Acceleration (steps/s^2),Move State," +
                "Indicator Position (microns),Indicator Velocity (microns/s)," +
                "Indenter Force (mg),Indenter Force (N),Indenter Calibration No Probe (mg),Indenter Calibration With Probe (mg),Spring Constant (N/m),Indenter Probe Weight(mg)," +
                "Microscope Stage X Position (mm),Microscope Stage Y Position (mm),Microscope Stage Z Position (mm)," +
                "Spring Constant Worker Running,Sample Name,Sample Location, Sample Measurement";
            streamWriter.WriteLine(line);

            while (CollectingData)
            {
                line = index.ToString() + "," +
                    (DateTime.Now.Ticks / (decimal)TimeSpan.TicksPerMillisecond).ToString();
                if (MotorZ != null)
                {
                    line += "," + MotorZ.Position_step.ToString() + "," +
                        MotorZ.PositionNegative_step.ToString() + "," +
                        MotorZ.PositionPositive_step.ToString() + "," +
                        MotorZ.PositionFromCalibration_um.ToString() + "," +
                        MotorZ.NegativeVelocityFromCalibration_um.ToString() + "," +
                        MotorZ.PositiveVelocityFromCalibration_um.ToString() + "," +
                        MotorZ.NegativeAccelerationFromCalibration_um.ToString() + "," +
                        MotorZ.PositiveAccelerationFromCalibration_um.ToString() + "," +
                        MotorZ.CalibrationNegativeStepSize_um.ToString() + "," +
                        MotorZ.CalibrationPositiveStepSize_um.ToString() + "," +
                        MotorZ.Velocity_step.ToString() + "," +
                        MotorZ.Acceleration_step.ToString() + "," +
                        MotorZ.MoveState.ToString();
                }
                if (Indicator != null)
                {
                    line += "," + Indicator.Position.ToString() + "," +
                        Indicator.Velocity.ToString();
                }
                if (IndenterController != null)
                {
                    line += "," + IndenterController.IndenterForce_mg.ToString() + "," +
                        IndenterController.IndenterForce_N.ToString() + "," +
                        IndenterController.IndenterCalibrationNoProbe_mg.ToString() + "," +
                        IndenterController.IndenterCalibrationWithProbe_mg.ToString() + "," +
                        IndenterController.IndenterSpringConstant_N_m.ToString() + "," +
                        //IndenterController.IndenterCalibration.ToString() + "," +
                        IndenterController.ProbeWeight_mg.ToString();
                }
                if (MicroscopeStageController != null)
                {
                    line += "," + MicroscopeStageController.CurrentPosition[0].ToString() + "," + // X
                        MicroscopeStageController.CurrentPosition[1].ToString() + "," + // Y
                        MicroscopeStageController.CurrentPosition[2].ToString(); // Z
                }
                line += "," + springConstantBackgroundWorker?.IsBusy.ToString() + "," + SampleDetails_SampleName + "," + SampleDetails_Location + "," + SampleDetails_Measurement; // Spring constant worker running

                streamWriter.WriteLine(line);
                index++;
                Thread.Sleep(collectionInterval);
            }

            streamWriter.Flush();
            streamWriter.Close();
        }

        private void IndicatorJogWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (MotorZ == null || Indicator == null)
            {
                return;
            }

            bool up = (float)Indicator.Position > IndicatorMoveToPosition;
            int prevVel = MotorZ.Velocity_step;

            while ((float)Indicator.Position > IndicatorMoveToPosition && up == true && IndicatorJogWorkerShouldRun)
            {
                float dist = Math.Abs(IndicatorMoveToPosition - (float)Indicator.Position);

                if (Settings.Default.StageMovementCreepUp)
                {
                    if (dist < Settings.Default.StageMovementSlowDownDistance && this.MotorZ.Velocity_step > Settings.Default.StageMovementSlowDownVelocity)
                    {
                        this.MotorZ.SetVelocity(Settings.Default.StageMovementSlowDownVelocity);
                    }
                }

                MotorZ.JogNegative();
            }

            while ((float)this.Indicator.Position < IndicatorMoveToPosition && up == false && IndicatorJogWorkerShouldRun)
            {
                float dist = Math.Abs(IndicatorMoveToPosition - (float)Indicator.Position);

                if (Settings.Default.StageMovementCreepUp)
                {
                    if (dist < Settings.Default.StageMovementSlowDownDistance && this.MotorZ.Velocity_step > Settings.Default.StageMovementSlowDownVelocity)
                    {
                        this.MotorZ.SetVelocity(Settings.Default.StageMovementSlowDownVelocity);
                    }
                }

                MotorZ.JogPositive();
            }

            MotorZ.StopMotion();
            if (Settings.Default.StageMovementCreepUp)
            {
                MotorZ.SetVelocity(prevVel);
            }
            this.IndicatorJogWorkerShouldRun = false;
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

            SequenceEditorForm = new frmSequenceEditor(this);
            SequenceEditorForm.Show();
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

            MotorZ = new Motor(this, 1, (float)Settings.Default.AvgNegativeStepSize_um, (float)Settings.Default.AvgPositiveStepSize_um); // TO DO: Change decimal to float in settings, maybe. Think about it.
            MotorX = new Motor(this, 2);
            MotorY = new Motor(this, 3);

            tmrMotorDisplayUpdate.Enabled = true;
            tmrMotorDisplayUpdate.Start();

            statusStageConnected.Text = "Connected";
            statusStageConnected.ForeColor = Color.Green;

            numMotorSettingsVelocity.Value = MotorZ.Velocity_step;
            numMotorSettingsAcceleration.Value = MotorZ.Acceleration_step;

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
            if (this.MotorZ == null)
                return;

            lblCalPositionTotalSteps.Text = this.MotorZ.Position_step.ToString();
            lblCalPositionNegSteps.Text = this.MotorZ.PositionNegative_step.ToString();
            lblCalPositionPosSteps.Text = this.MotorZ.PositionPositive_step.ToString();
            lblCalPositionEstMicronPosition.Text = this.MotorZ.PositionFromCalibration_um.ToString();

            lblCalVelRaw.Text = this.MotorZ.Velocity_step.ToString();
            lblCalVelNeg.Text = this.MotorZ.NegativeVelocityFromCalibration_um.ToString();
            lblCalVelPos.Text = this.MotorZ.PositiveVelocityFromCalibration_um.ToString();

            lblCalAccelRaw.Text = this.MotorZ.Acceleration_step.ToString();
            lblCalAccelNeg.Text = this.MotorZ.NegativeAccelerationFromCalibration_um.ToString();
            lblCalAccelPos.Text = this.MotorZ.PositiveAccelerationFromCalibration_um.ToString();
        }

        private void btnMotorSettingsApply_Click(object sender, EventArgs e)
        {
            if (this.MotorZ != null && this.IsSequenceRunning == false)
            {
                this.MotorZ.SetVelocity((int)numMotorSettingsVelocity.Value);
                this.MotorZ.SetAcceleration((int)numMotorSettingsAcceleration.Value);
            }
        }

        public void UpdateCalibrationValues()
        {
            this.numIndenterSettingsCalNoProbe.Value = Settings.Default.IndenterCalibration_RawNoProbe; // TO DO: Should this be set on connect? Probably.
            this.numIndenterSettingsCalWithProbe.Value = Settings.Default.IndenterCalibration_RawWithProbe;
            this.numIndenterSettingsCalProbeWeight.Value = Settings.Default.IndenterCalibration_ProbeWeight_mg;
            this.numIndenterSettingsSpringConstant_N_m.Value = Settings.Default.IndenterCalibration_SpringConst_N_m;
            this.numIndenterSettingsProbeDiameter_um.Value = Settings.Default.IndenterCalibration_Diameter_um;

            float neg = (float)Settings.Default.AvgNegativeStepSize_um;
            float pos = (float)Settings.Default.AvgPositiveStepSize_um;

            lblCalNegStepSize.Text = neg.ToString();
            lblCalPosStepSize.Text = pos.ToString();

            if (this.MotorZ != null)
            {
                this.MotorZ.SetCalibrationNegativeStepSize_um(neg);
                this.MotorZ.SetCalibrationPositiveStepSize_um(pos);
                lblMotorSettingsEstNegVel.Text = MotorZ.NegativeVelocityFromCalibration_um.ToString();
                lblMotorSettingsEstPosVel.Text = MotorZ.PositiveVelocityFromCalibration_um.ToString();
                lblMotorSettingsEstNegAccel.Text = MotorZ.NegativeAccelerationFromCalibration_um.ToString();
                lblMotorSettingsEstPosAccel.Text = MotorZ.PositiveAccelerationFromCalibration_um.ToString();

                // TO DO: Set ?
            }
        }

        private void btnStopAllMotion_Click(object sender, EventArgs e)
        {
            if (this.SequenceEditorForm != null)
            {
                this.SequenceEditorForm.StopSequence = true; // TO DO: Is this good?
            }

            if (this.MotorZ != null)
            {
                this.IndicatorJogWorkerShouldRun = false;
                this.MotorZ.StopMotion();
            }
        }

        private void btnActiveControlsUp_Click(object sender, EventArgs e)
        {
            if (this.MotorZ != null && this.IsSequenceRunning == false) // TO DO: Should I do is sequence running directly from the form? Probably.
            {
                this.MotorZ.JogPositive();
            }
        }

        private void btnActiveControlsDown_Click(object sender, EventArgs e)
        {
            if (this.MotorZ != null && this.IsSequenceRunning == false)
            {
                this.MotorZ.JogNegative();
            }
        }

        private void btnMoveDistance_Click(object sender, EventArgs e)
        {
            if (this.MotorZ != null && this.IsSequenceRunning == false)
            {
                if (this.MovementReference == MovementReferenceType.Steps)
                {
                    this.MotorZ.RelativeMove_step((int)numMoveDistance.Value);
                }
                else if (this.MovementReference == MovementReferenceType.Indicator && this.Indicator != null)
                {
                    IndicatorMoveToPosition = (float)this.Indicator.Position + (float)numMoveDistance.Value;

                    IndicatorJogWorkerShouldRun = true;
                    IndicatorJogWorker.RunWorkerAsync();
                }
                else if (this.MovementReference == MovementReferenceType.Calibration)
                {
                    this.MotorZ.RelativeMove_step(this.MotorZ.MicronToStep((int)numMoveDistance.Value));
                }
            }
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (this.MotorZ != null && this.IsSequenceRunning == false)
            {
                if (this.MovementReference == MovementReferenceType.Steps)
                {
                    this.MotorZ.MoveToRelativePosition_step((int)numGoTo.Value);
                }
                else if (this.MovementReference == MovementReferenceType.Indicator && this.Indicator != null)
                {
                    IndicatorMoveToPosition = (float)numGoTo.Value;
                    IndicatorJogWorkerShouldRun = true;
                    IndicatorJogWorker.RunWorkerAsync();
                }
                else if (this.MovementReference == MovementReferenceType.Calibration)
                {
                    this.MotorZ.MoveToRelativePosition_step(this.MotorZ.MicronToStep((int)numGoTo.Value));
                }
            }
        }

        private void btnActiveControlsUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (MotorZ != null && MotorZ.MoveState == MoveState.Stationary && IsSequenceRunning == false)
            {
                MotorZ.JogPositive();
            }
        }

        private void btnActiveControlsUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (MotorZ != null)
            {
                MotorZ.StopMotion();
            }
        }

        private void btnActiveControlsDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (MotorZ != null && MotorZ.MoveState == MoveState.Stationary && IsSequenceRunning == false)
            {
                MotorZ.JogNegative();
            }
        }

        private void btnActiveControlsDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (MotorZ != null)
            {
                MotorZ.StopMotion();
            }
        }

        private void numMotorSettingsVelocity_ValueChanged(object sender, EventArgs e)
        {
            if (MotorZ != null)
            {
                lblMotorSettingsEstNegVel.Text = MotorZ.NegativeVelocityFromCalibration_um.ToString();
                lblMotorSettingsEstPosVel.Text = MotorZ.PositiveVelocityFromCalibration_um.ToString();
            }
        }

        private void numMotorSettingsAcceleration_ValueChanged(object sender, EventArgs e)
        {
            if (MotorZ != null)
            {
                lblMotorSettingsEstNegAccel.Text = MotorZ.NegativeAccelerationFromCalibration_um.ToString();
                lblMotorSettingsEstPosAccel.Text = MotorZ.PositiveAccelerationFromCalibration_um.ToString();
            }
        }

        private void btnCalZeroPosition_Click(object sender, EventArgs e)
        {
            if (this.MotorZ != null && this.IsSequenceRunning == false)
            {
                this.MotorZ.ZeroDevicePosition();
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
            if (this.IsSequenceRunning == false)
            {
                if (!CollectingData)
                {
                    StartDataCollection(true);
                    this.btnDataCollect.Text = "Stop Data Collection";
                    this.btnDataSelectDirectory.Enabled = false;
                    this.txtDataFileName.Enabled = false;
                }
                else
                {
                    StopDataCollection();
                    this.btnDataCollect.Text = "Collect";
                    this.btnDataSelectDirectory.Enabled = true;
                    this.txtDataFileName.Enabled = true;
                }
            }
        }

        public void StartDataCollection(bool checkFileAlreadyExists)
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

            CollectingData = true;
            DataCollectionWorker.RunWorkerAsync();
        }

        public void StopDataCollection()
        {
            CollectingData = false;
        }

        public void SetDataDirectory(string directory)
        {
            this.txtDataDirectory.Text = directory;
        }

        public void SetDataFileName(string fileName)
        {
            this.txtDataFileName.Text = fileName;
        }

        private void btnMotorSettingsApplyDefault_Click(object sender, EventArgs e)
        {
            if (this.MotorZ == null || this.IsSequenceRunning == true)
            {
                return;
            }

            numMotorSettingsAcceleration.Value = 10000; // TO DO: Check values
            numMotorSettingsVelocity.Value = 2000;
            this.MotorZ.SetVelocity((int)numMotorSettingsVelocity.Value);
            this.MotorZ.SetAcceleration((int)numMotorSettingsAcceleration.Value);
        }

        private void stripConnectIndenter_Click(object sender, EventArgs e)
        {
            ConnectIndenter();
        }

        private void stripConnectMicroscopeStage_Click(object sender, EventArgs e)
        {
            ConnectMicroscopeStage();
        }

        private void ConnectIndenter()
        {
            if (IndenterController == null || !IndenterController.Connected)
            {
                // Rudimentary check. Realistically, will only either be "COM__" or "".
                if (!Settings.Default.IndicatorCOMPort.Contains("COM"))
                {
                    MessageBox.Show("Invalid COM port! Please check settings!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                IndenterController = new IndenterController(Settings.Default.IndenterCOMPort);
                this.tmrIndenterDisplayUpdate.Enabled = true;
                this.tmrIndenterDisplayUpdate.Start();
                //IndenterController.OnForceUpdated += IndenterController_OnForceUpdated;

                this.numIndenterSettingsCalNoProbe.Enabled = true;
                this.numIndenterSettingsCalWithProbe.Enabled = true; // TO DO: Do an "on-connect" action so that only when its connected it is enabled.
                this.numIndenterSettingsCalProbeWeight.Enabled = true;
                this.numIndenterSettingsProbeDiameter_um.Enabled = true;
                this.numIndenterSettingsSpringConstant_N_m.Enabled = true;
                this.btnIndenterCalWithProbe.Enabled = true;
                this.btnIndenterSettingsCalNoProbe.Enabled = true;
                this.btnIndenterSettingsCalibrate.Enabled = true;
            }
        }

        //private void IndenterController_OnForceUpdated(double rawValue, double force_mg, double force_N)
        //{
        //    lblIndenterDisplayForcemg.Text = force_mg.ToString();
        //    lblIndenterDisplayForceN.Text = force_N.ToString();
        //}

        private void ConnectMicroscopeStage()
        {
            if (IndenterController == null || !IndenterController.Connected)
            {
                // Rudimentary check. Realistically, will only either be "COM__" or "".
                if (!Settings.Default.IndicatorCOMPort.Contains("COM"))
                {
                    MessageBox.Show("Invalid COM port! Please check settings!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                MicroscopeStageController = new MicroscopeStageController(Settings.Default.MicroscopeStageCOMPort);
                this.tmrMicroscopeDisplayUpdate.Enabled = true;
                this.tmrMicroscopeDisplayUpdate.Start();
            }
        }

        #region Microscope Stage Control
        private void btnStageCtrlRunXLeftYUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(-1, 1, 0);
        }

        private void btnStageCtrlRunYUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(0, 1, 0);
        }

        private void btnStageCtrlRunXRightYUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(1, 1, 0);
        }

        private void btnStageCtrlRunZUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(0, 0, 1);
        }

        private void btnStageCtrlRunXLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(-1, 0, 0);
        }

        private void btnStageCtrlRunXRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(1, 0, 0);
        }

        private void btnStageCtrlRunXLeftYDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(-1, -1, 0);
        }

        private void btnStageCtrlRunYDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(0, -1, 0);
        }

        private void btnStageCtrlRunXRightYDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(1, -1, 0);
        }

        private void btnStageCtrlRunZDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.StageRun(0, 0, -1);
        }

        private void btnStageCtrlRunXLeftYUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void btnStageCtrlRunYUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void btnStageCtrlRunXRightYUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void btnStageCtrlRunZUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void btnStageCtrlRunXLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void btnStageCtrlRunXRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void btnStageCtrlRunXLeftYDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void btnStageCtrlRunYDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void btnStageCtrlRunXRightYDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void btnStageCtrlRunZDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }
        #endregion

        private void btnMicroscopeStageHalt_Click(object sender, EventArgs e)
        {
            if (this.MicroscopeStageController == null || !this.MicroscopeStageController.Connected)
                return;

            this.MicroscopeStageController.HaltStage();
        }

        private void tmrMicroscopeDisplayUpdate_Tick(object sender, EventArgs e)
        {
            lblMicroscopeStageDisplayX_mm.Text = MicroscopeStageController?.CurrentPosition[0].ToString() ?? "N/A";
            lblMicroscopeStageDisplayY_mm.Text = MicroscopeStageController?.CurrentPosition[1].ToString() ?? "N/A";
            lblMicroscopeStageDisplayZ_mm.Text = MicroscopeStageController?.CurrentPosition[2].ToString() ?? "N/A";
        }

        private void tmrIndenterDisplayUpdate_Tick(object sender, EventArgs e)
        {
            if (this.IndenterController == null || this.IndenterController.Connected == false)
                return;

            lblIndenterDisplayForcemg.Text = Math.Round(this.IndenterController.IndenterForce_mg, 3).ToString();
            lblIndenterDisplayForceN.Text = Math.Round(this.IndenterController.IndenterForce_N, 2).ToString();
        }

        private void btnIndenterSettingsCalibrate_Click(object sender, EventArgs e)
        {
            if (this.IndenterController != null)
            {
                this.IndenterController.IndenterCalibrationNoProbe_mg = (double)this.numIndenterSettingsCalNoProbe.Value * 100.0D;
                this.IndenterController.IndenterCalibrationWithProbe_mg = (double)this.numIndenterSettingsCalWithProbe.Value * 100.0D;
                this.IndenterController.ProbeWeight_mg = (double)this.numIndenterSettingsCalProbeWeight.Value * 100.0D;
                this.IndenterController.IndenterDiameter_um = (double)this.numIndenterSettingsProbeDiameter_um.Value;
                this.IndenterController.IndenterSpringConstant_N_m = (double)this.numIndenterSettingsSpringConstant_N_m.Value;

                Settings.Default.IndenterCalibration_RawNoProbe = this.numIndenterSettingsCalNoProbe.Value;
                Settings.Default.IndenterCalibration_RawWithProbe = this.numIndenterSettingsCalWithProbe.Value;
                Settings.Default.IndenterCalibration_ProbeWeight_mg = this.numIndenterSettingsCalProbeWeight.Value;
                Settings.Default.IndenterCalibration_Diameter_um = this.numIndenterSettingsProbeDiameter_um.Value;
                Settings.Default.IndenterCalibration_SpringConst_N_m = this.numIndenterSettingsSpringConstant_N_m.Value;
                Settings.Default.Save();
            }
        }

        private void btnIndenterSettingsCalNoProbe_Click(object sender, EventArgs e)
        {
            if (this.IndenterController == null || this.IndenterController.Connected == false)
                return;

            indenterCal_calOption = 0;
            indenterCal_sampleCount = 0;
            indenterCal_sampleSum = 0;
            tmrAverageIndenterValues.Interval = 10;
            tmrAverageIndenterValues.Enabled = true;
            tmrAverageIndenterValues.Start();
        }
        private void btnIndenterCalWithProbe_Click(object sender, EventArgs e)
        {
            if (this.IndenterController == null)
                return;

            indenterCal_calOption = 1;
            indenterCal_sampleCount = 0;
            indenterCal_sampleSum = 0;
            tmrAverageIndenterValues.Interval = 10;
            tmrAverageIndenterValues.Enabled = true;
            tmrAverageIndenterValues.Start();
        }

        private void tmrAverageIndenterValues_Tick(object sender, EventArgs e)
        {
            if (this.IndenterController == null)
                return;

            indenterCal_sampleSum += this.IndenterController.RawIndenterValue;
            indenterCal_sampleCount++;
            if (indenterCal_sampleCount >= indenterCal_totalSamples)
            {
                tmrAverageIndenterValues.Stop();
                if (indenterCal_calOption == 0)
                {
                    this.numIndenterSettingsCalNoProbe.Value = (decimal)(indenterCal_sampleSum / indenterCal_sampleCount) / 100.0M;
                }
                else if (indenterCal_calOption == 1)
                {
                    this.numIndenterSettingsCalWithProbe.Value = (decimal)(indenterCal_sampleSum / indenterCal_sampleCount) / 100.0M;
                }
            }
        }

        private void btnMicroscopeStageHome_Click(object sender, EventArgs e)
        {
            if (this.MicroscopeStageController == null || this.MicroscopeStageController.Connected == false)
                return;

            MicroscopeStageController.SendCommand("! X Y Z");
        }

        private void numStageCtrlXGo_Click(object sender, EventArgs e)
        {
            if (this.MicroscopeStageController == null || this.MicroscopeStageController.Connected == false)
                return;

            decimal value = this.numStageCtrlAbsRelXum.Value * 10.0M;

            if (this.radStageCtrlAbsolute.Checked)
            {
                this.MicroscopeStageController.SendCommand("R X=" + value.ToString());
            }
            else if (this.radStageCtrlRelative.Checked)
            {
                this.MicroscopeStageController.SendCommand("M X=" + value.ToString());
            }
        }

        private void numStageCtrlYGo_Click(object sender, EventArgs e)
        {
            if (this.MicroscopeStageController == null || this.MicroscopeStageController.Connected == false)
                return;

            decimal value = this.numStageCtrlAbsRelYum.Value * 10.0M;

            if (this.radStageCtrlAbsolute.Checked)
            {
                this.MicroscopeStageController.SendCommand("R Y=" + value.ToString());
            }
            else if (this.radStageCtrlRelative.Checked)
            {
                this.MicroscopeStageController.SendCommand("M Y=" + value.ToString());
            }
        }

        private void numStageCtrlZGo_Click(object sender, EventArgs e)
        {
            if (this.MicroscopeStageController == null || this.MicroscopeStageController.Connected == false)
                return;

            decimal value = this.numStageCtrlAbsRelZum.Value * 10.0M;

            if (this.radStageCtrlAbsolute.Checked)
            {
                this.MicroscopeStageController.SendCommand("R Z=" + value.ToString());
            }
            else if (this.radStageCtrlRelative.Checked)
            {
                this.MicroscopeStageController.SendCommand("M Z=" + value.ToString());
            }
        }

        private void numStageCtrlAllGo_Click(object sender, EventArgs e)
        {
            if (this.MicroscopeStageController == null || this.MicroscopeStageController.Connected == false)
                return;

            decimal x = this.numStageCtrlAbsRelXum.Value * 10.0M;
            decimal y = this.numStageCtrlAbsRelYum.Value * 10.0M;
            decimal z = this.numStageCtrlAbsRelZum.Value * 10.0M;


            if (this.radStageCtrlAbsolute.Checked)
            {
                this.MicroscopeStageController.SendCommand("R X=" + x.ToString() + "Y=" + y.ToString() + "Z=" + z.ToString());
            }
            else if (this.radStageCtrlRelative.Checked)
            {
                this.MicroscopeStageController.SendCommand("M X=" + x.ToString() + "Y=" + y.ToString() + "Z=" + z.ToString());
            }
        }

        private void btnStageCtrlSetSpeed_Click(object sender, EventArgs e)
        {
            if (this.MicroscopeStageController == null || this.MicroscopeStageController.Connected == false)
                return;
            decimal val = this.numStageCtrlSpeed_um_s.Value * 1000.0M;
            this.MicroscopeStageController.SendCommand("S X=" + val.ToString() + " Y=" + val.ToString() + " Z=" + val.ToString());

            // TO DO: Implement a way to obtain the current speed from the stage controller and set it as the speed at start.
        }

        private void SpringConstantBackgroundWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            if (MotorZ == null || IndenterController == null || !IndenterController.Connected || Indicator == null)
                return;

            int initialVelocity = MotorZ.Velocity_step;
            int initialAcceleration = MotorZ.Acceleration_step;
            bool initialCreepUp = Settings.Default.StageMovementCreepUp;

            Stopwatch timeObtained = new Stopwatch();
            timeObtained.Start();

            if (springConstantMeasurementMode == SpringConstantMeasurementMode.ByPoints) // ---------------------------------------------------------
            {
                int contactsObtained = 0;

                MotorZ.SetVelocity((int)this.numIndentationCtrlSpringConstByPointsVel_steps.Value);
                MotorZ.SetAcceleration((int)this.numIndentationCtrlSpringConstByPointsAccel_steps.Value);

                if (this.chkIndentationCtrlSpringConstByPointsCreepUp.Checked)
                {
                    Settings.Default.StageMovementCreepUp = true;
                }
                else
                {
                    Settings.Default.StageMovementCreepUp = false;
                }
                Settings.Default.Save(); // TO DO: Do I need to save for settings to to take effect?

                IndentationContactPoints = new List<(double, double, double)>();

                while (contactsObtained < (int)this.numIndentationCtrlSpringConstByPointsPoints.Value) // TO DO: Add a way to stop all of this.
                {
                    IndicatorMoveToPosition = (float)Indicator.Position - (float)this.numIndentationCtrlSpringConstByPointsDistance_um.Value;
                    IndicatorJogWorkerShouldRun = true;
                    IndicatorJogWorker.RunWorkerAsync();

                    while (IndicatorJogWorker.IsBusy == true)
                    {
                        Thread.Yield();
                    }

                    Thread.Sleep((int)this.numIndentationCtrlSpringConstByPointsDelay_ms.Value);

                    IndentationContactPoints.Add(((double)timeObtained.ElapsedMilliseconds, (double)Indicator.Position * 1E-6, IndenterController.IndenterForce_mg * 1E-6 * 9.81));

                    contactsObtained++;
                }

                double slope, intercept, rSquared;
                (slope, intercept, rSquared) = FitLineToPoints(IndentationContactPoints);

                this.Invoke(delegate
                {
                    lblSpringConstFlat.Text = ($"Spring Constant: {slope.ToString("F3")} N/m | R^2: {rSquared.ToString("F3")}");
                    lblSpringConstFlatModulus.Text = "Elastic Modulus: " + CalculateElasticModulusFromFlatSurface(slope).ToString() + " Pa";
                });

                MotorZ.SetVelocity(initialVelocity);
                MotorZ.SetAcceleration(initialAcceleration);
                Settings.Default.StageMovementCreepUp = initialCreepUp;
                Settings.Default.Save(); // TO DO: I should probably just do Settings.Default.Reload();
            }
            else if (springConstantMeasurementMode == SpringConstantMeasurementMode.ByDistance) // ---------------------------------------------------------
            {
                MotorZ.SetVelocity((int)this.numIndentationCtrlSpringConstByDistanceVel_steps.Value);
                MotorZ.SetAcceleration((int)this.numIndentationCtrlSpringConstByDistanceAccel_steps.Value);

                if (this.chkIndentationCtrlSpringConstByDistanceCreepUp.Checked)
                {
                    Settings.Default.StageMovementCreepUp = true;
                }
                else
                {
                    Settings.Default.StageMovementCreepUp = false;
                }
                Settings.Default.Save(); // TO DO: Do I need to save for settings to take effect?

                //double initialPosition = Indicator.Position * 1E-6; // Convert to meters
                //double initialForce = IndenterController.IndenterForce_mg * 1E-6 * 9.81; // Convert to Newtons

                int cyclesToWait = 100000;
                int cycleCount = 100001; // Capture the first one

                IndentationContactPoints = new List<(double, double, double)>();

                IndicatorMoveToPosition = (float)Indicator.Position - (float)this.numIndentationCtrlSpringConstByDistanceDistance_um.Value;
                IndicatorJogWorkerShouldRun = true;
                IndicatorJogWorker.RunWorkerAsync();

                while (IndicatorJogWorker.IsBusy == true)
                {
                    // Figure out a good way to figure out how many points to collect.
                    if (cycleCount > cyclesToWait)
                    {
                        IndentationContactPoints.Add(((double)timeObtained.ElapsedMilliseconds, (double)Indicator.Position * 1E-6, IndenterController.IndenterForce_mg * 1E-6 * 9.81));
                        cycleCount = 0;
                    }
                    else
                    {
                        cycleCount++;
                    }
                    Thread.Yield();
                }
                //double finalPosition = Indicator.Position * 1E-6; // Convert to meters
                //double finalForce = IndenterController.IndenterForce_mg * 1E-6 * 9.81; // Convert to Newtons
                //double slope = (finalForce - initialForce) / (finalPosition - initialPosition);
                //double intercept = initialForce - slope * initialPosition;
                //this.Invoke(delegate
                //{
                //    lblSpringConstant.Text = ($"Spring Constant: {slope.ToString("F3")} N/m");
                //});
                double slope, intercept, rSquared;
                (slope, intercept, rSquared) = FitLineToPoints(IndentationContactPoints);

                this.Invoke(delegate
                {
                    lblSpringConstFlat.Text = ($"Spring Constant: {slope.ToString("F3")} N/m | R^2: {rSquared.ToString("F3")}");
                    lblSpringConstFlatModulus.Text = "Elastic Modulus: " + CalculateElasticModulusFromFlatSurface(slope).ToString() + " Pa";
                });

                MotorZ.SetVelocity(initialVelocity);
                MotorZ.SetAcceleration(initialAcceleration);
                Settings.Default.StageMovementCreepUp = initialCreepUp;
                Settings.Default.Save(); // TO DO: I should probably just do Settings.Default.Reload();
            }
            else if (springConstantMeasurementMode == SpringConstantMeasurementMode.ByForce) // ---------------------------------------------------------
            {
                MotorZ.SetVelocity((int)this.numIndentationCtrlSpringConstByForceVel_steps.Value);
                MotorZ.SetAcceleration((int)this.numIndentationCtrlSpringConstByForceAccel_steps.Value);

                Settings.Default.Save(); // TO DO: Do I need to save for settings to take effect?

                IndentationContactPoints = new List<(double, double, double)>();

                int cyclesToWait = 100000;
                int cycleCount = 100001; // Capture the first one

                while (this.IndenterController.IndenterForce_mg > (double)this.numIndentationCtrlSpringConstByForceEndForce_mg.Value) // TO DO: Add a way to stop all of this.
                {
                    if (cycleCount > cyclesToWait)
                    {
                        IndentationContactPoints.Add(((double)timeObtained.ElapsedMilliseconds, (double)Indicator.Position * 1E-6, IndenterController.IndenterForce_mg * 1E-6 * 9.81));
                        cycleCount = 0;
                    }
                    else
                    {
                        cycleCount++;
                    }
                    this.MotorZ.JogNegative();
                }

                this.MotorZ.StopMotion();

                double slope, intercept, rSquared;

                (slope, intercept, rSquared) = FitLineToPoints(IndentationContactPoints);
                this.Invoke(delegate
                {
                    lblSpringConstFlat.Text = ($"Spring Constant: {slope.ToString("F3")} N/m | R^2: {rSquared.ToString("F3")}");
                    lblSpringConstFlatModulus.Text = "Elastic Modulus: " + CalculateElasticModulusFromFlatSurface(slope).ToString() + " Pa";
                });
                MotorZ.SetVelocity(initialVelocity);
                MotorZ.SetAcceleration(initialAcceleration);
                Settings.Default.StageMovementCreepUp = initialCreepUp;
                Settings.Default.Save(); // TO DO: I should probably just do Settings.Default.Reload();
            }

            if (chkSampleDetailsCollectStressRelaxation.Checked)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int cyclesToWait = 100000;
                int cycleCount = 100001;

                while (stopwatch.ElapsedMilliseconds < numSampleDetailsStressRelaxationTime_ms.Value)
                {
                    if (cycleCount > cyclesToWait)
                    {
                        IndentationContactPoints.Add(((double)timeObtained.ElapsedMilliseconds, (double)Indicator.Position * 1E-6, IndenterController.IndenterForce_mg * 1E-6 * 9.81));
                        cycleCount = 0;
                    }
                    else
                    {
                        cycleCount++;
                    }
                }
            }

            this.Invoke(delegate
            {
                this.btnSampleDetailsSaveCollectedData.Enabled = true;

                if (this.chkSampleDetailsShowPlot.Checked)
                {
                    ShowPlot(this.IndentationContactPoints.Select(p => p.position * 1E-6).ToArray(), this.IndentationContactPoints.Select(p => p.force * 1E-6 * 9.81).ToArray(), "Spring Constant Measurement", "Position (m)", "Force (N)");
                }
            });
        }

        private decimal CalculateElasticModulusFromFlatSurface(double k_Surface)
        {
            double difference = (1 / k_Surface) - (1 / (double)this.IndenterController.IndenterSpringConstant_N_m);
            difference = 1 / difference;
            double poissonsRatio = 0.5; // TO DO: Un-hard-code this

            double elasticModulus = (difference * (1 - poissonsRatio * poissonsRatio)) / ((double)this.IndenterController.IndenterDiameter_um * 1E-6);
            return (decimal)elasticModulus; // To Do: Fix the conversions. Ridiculous.
        }

        private void ShowPlot(double[] X, double[] Y, string title, string xLabel, string yLabel)
        {
            frmStaticPlot staticPlot = new frmStaticPlot(X, Y, title, xLabel, yLabel);
            staticPlot.Show(this);
        }

        private (double Slope, double Intercept, double RSquared) FitLineToPoints(List<(double t, double x, double y)> points) // I added the t. Whatever.
        {
            if (points == null || points.Count < 2)
            {
                MessageBox.Show("At least two points are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (0, 0, 0);
            }

            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0, sumY2 = 0;
            int n = points.Count;

            foreach (var (t, x, y) in points)
            {
                sumX += x;
                sumY += y;
                sumXY += x * y;
                sumX2 += x * x;
                sumY2 += y * y;
            }

            double denominator = n * sumX2 - sumX * sumX;
            if (denominator == 0)
            {
                MessageBox.Show("Cannot fit a line (vertical line or all x are equal).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (0, 0, 0);
            }

            double slope = (n * sumXY - sumX * sumY) / denominator;
            double intercept = (sumY - slope * sumX) / n;

            // Calculate R-squared
            double ssTot = 0, ssRes = 0;
            double meanY = sumY / n;
            foreach (var (t, x, y) in points)
            {
                double yPred = slope * x + intercept;
                ssTot += (y - meanY) * (y - meanY);
                ssRes += (y - yPred) * (y - yPred);
            }
            double rSquared = ssTot == 0 ? 1 : 1 - (ssRes / ssTot);

            return (slope, intercept, rSquared);
        }

        private void btnIndentationCtrlFindSpringConst_Click(object sender, EventArgs e)
        {
            if (MotorZ == null || IndenterController == null || !IndenterController.Connected || Indicator == null)
                return;

            springConstantBackgroundWorker = new BackgroundWorker();
            springConstantBackgroundWorker.DoWork += SpringConstantBackgroundWorker_DoWork;
            springConstantBackgroundWorker.RunWorkerAsync();
        }

        private void btnSampleDetailsSet_Click(object sender, EventArgs e)
        {
            if (this.txtSampleDetailsSampleName.Text.Contains(",") || this.txtSampleDetailsLocation.Text.Contains(",") || this.txtSampleDetailsMeasurement.Text.Contains(","))
            {
                // TO DO: What other checks are needed?
                MessageBox.Show("Text cannot contain a comma!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string potentialName = this.txtSampleDetailsMeasurement.Text + "_" + this.txtSampleDetailsSampleName.Text + "_" + this.txtSampleDetailsLocation.Text + ".csv";

            if (potentialName.IndexOfAny(Path.GetInvalidFileNameChars()) > 0)
            {
                MessageBox.Show("Text must not contain invalid characters for a file name!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.SampleDetails_SampleName = this.txtSampleDetailsSampleName.Text;
            this.SampleDetails_Location = this.txtSampleDetailsLocation.Text;
            this.SampleDetails_Measurement = this.txtSampleDetailsMeasurement.Text;

            btnSampleDetailsSet.Enabled = false;
        }

        private void btnFindSpringConstByPoints_Click(object sender, EventArgs e)
        {
            if (springConstantBackgroundWorker.IsBusy)
                return;

            this.springConstantMeasurementMode = SpringConstantMeasurementMode.ByPoints;
            this.springConstantBackgroundWorker.RunWorkerAsync();
        }

        private void btnFindSpringConstByDistance_Click(object sender, EventArgs e)
        {
            if (springConstantBackgroundWorker.IsBusy)
                return;

            this.springConstantMeasurementMode = SpringConstantMeasurementMode.ByDistance;
            this.springConstantBackgroundWorker.RunWorkerAsync();
        }

        private void btnFindSpringConstByForce_Click(object sender, EventArgs e)
        {
            if (springConstantBackgroundWorker.IsBusy)
                return;

            this.springConstantMeasurementMode = SpringConstantMeasurementMode.ByForce;
            this.springConstantBackgroundWorker.RunWorkerAsync();
        }

        private void chkSampleDetailsCollectStressRelaxation_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkSampleDetailsCollectStressRelaxation.Checked)
            {
                numSampleDetailsStressRelaxationTime_ms.Enabled = true;
            }
            else
            {
                numSampleDetailsStressRelaxationTime_ms.Enabled = false;
            }
        }

        private void txtSampleDetailsSampleName_TextChanged(object sender, EventArgs e)
        {
            if (txtSampleDetailsSampleName.Text != this.SampleDetails_SampleName || txtSampleDetailsLocation.Text != this.SampleDetails_Location || txtSampleDetailsMeasurement.Text != this.SampleDetails_Measurement)
            {
                this.btnSampleDetailsSet.Enabled = true;
            }
            else
            {
                this.btnSampleDetailsSet.Enabled = false;
            }
        }

        private void txtSampleDetailsLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtSampleDetailsSampleName.Text != this.SampleDetails_SampleName || txtSampleDetailsLocation.Text != this.SampleDetails_Location || txtSampleDetailsMeasurement.Text != this.SampleDetails_Measurement)
            {
                this.btnSampleDetailsSet.Enabled = true;
            }
            else
            {
                this.btnSampleDetailsSet.Enabled = false;
            }
        }

        private void txtSampleDetailsMeasurement_TextChanged(object sender, EventArgs e)
        {
            if (txtSampleDetailsSampleName.Text != this.SampleDetails_SampleName || txtSampleDetailsLocation.Text != this.SampleDetails_Location || txtSampleDetailsMeasurement.Text != this.SampleDetails_Measurement)
            {
                this.btnSampleDetailsSet.Enabled = true;
            }
            else
            {
                this.btnSampleDetailsSet.Enabled = false;
            }
        }

        private void btnSampleDetailsSaveCollectedData_Click(object sender, EventArgs e)
        {
            if (IndentationContactPoints.Count == 0)
            {
                MessageBox.Show("No data collected to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(txtDataDirectory.Text))
            {
                MessageBox.Show("Data directory does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fileName = SampleDetails_SampleName + "_" + SampleDetails_Location + "_" + SampleDetails_Measurement;
            string fileLocation = txtDataDirectory.Text + "/" + fileName + ".csv";

            if (File.Exists(fileLocation))
            {
                MessageBox.Show("File already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                StreamWriter streamWriter = new StreamWriter(fileLocation, false);

                string line = "Time (ms),Position (m),Force (N)";

                streamWriter.WriteLine(line);

                foreach (var point in IndentationContactPoints)
                {
                    line = $"{point.time},{point.position * 1E-6},{point.force * 1E-6 * 9.81d}";
                    streamWriter.WriteLine(line);
                }

                line = ",,,Spring Const:," + lblSpringConstFlat.Text;
                streamWriter.WriteLine(line);

                line = ",,,Flat Elastic Modulus:," + lblSpringConstFlatModulus.Text;
                streamWriter.WriteLine(line);

                streamWriter.Flush();
                streamWriter.Close();

                btnSampleDetailsSaveCollectedData.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHolderStageRunYUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.JogPositive();
        }

        private void btnHolderStageRunYUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (MotorY != null && IsSequenceRunning == false)
            {
                MotorY.StopMotion();
            }
        }

        private void btnHolderStageRunXLeftYUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.StopMotion();
            MotorX.StopMotion();
        }

        private void btnHolderStageRunXLeftYUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.JogPositive();
            MotorX.JogNegative();
        }

        private void btnHolderStageRunXRightYUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.JogPositive();
            MotorX.JogPositive();
        }

        private void btnHolderStageRunXRightYUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.StopMotion();
            MotorX.StopMotion();
        }

        private void btnHolderStageRunXLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorX.JogNegative();
        }

        private void btnHolderStageRunXLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorX.StopMotion();
        }

        private void btnHolderStageRunXLeftYDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.JogNegative();
            MotorX.JogNegative();
        }

        private void btnHolderStageRunXLeftYDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.StopMotion();
            MotorX.StopMotion();
        }

        private void btnHolderStageRunYDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.JogNegative();
        }

        private void btnHolderStageRunYDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.StopMotion();
        }

        private void btnHolderStageRunXRightYDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.JogNegative();
            MotorX.JogPositive();
        }

        private void btnHolderStageRunXRightYDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorY == null || MotorY.MoveState != MoveState.Stationary)
            {
                return;
            }

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorY.StopMotion();
            MotorX.StopMotion();
        }

        private void btnHolderStageRunXRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorX.JogPositive();
        }

        private void openSequenceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["frmSequenceEditor"] as frmSequenceEditor) != null)
                return;

            SequenceEditorForm = new frmSequenceEditor(this);
            SequenceEditorForm.Show();
        }

        private void btnHolderStageRunXRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsSequenceRunning == true)
                return;

            if (MotorX == null || MotorX.MoveState != MoveState.Stationary)
            {
                return;
            }

            MotorX.StopMotion();
        }
    }
}