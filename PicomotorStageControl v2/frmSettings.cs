using PicomotorStageControl_v2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicomotorStageControl_v2
{
    public partial class frmSettings : Form
    {
        frmMain MainForm;

        public frmSettings(frmMain mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            PopulateFieldsWithCurrentSettings();
            PopulateCOMPortSelection();
        }

        private void PopulateCOMPortSelection()
        {
            // From: https://stackoverflow.com/questions/2837985/getting-serial-port-information
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portNames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portNames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                foreach (string s in portList)
                {
                    cmbIndicatorPorts.Items.Add(s.ToString());
                }
            }
        }

        private void PopulateFieldsWithCurrentSettings()
        {
            this.cmbIndicatorPorts.Text = Settings.Default.IndicatorCOMPort;
            this.numAvgNegStepSizeUm.Value = Settings.Default.AvgNegativeStepSize_um;
            this.numAvgPosStepSizeUm.Value = Settings.Default.AvgPositiveStepSize_um;

            this.chkStageMovementCreepUp.Checked = Settings.Default.StageMovementCreepUp;
            this.numStageMovementSlowDownDistance.Value = (decimal)Settings.Default.StageMovementSlowDownDistance;
            this.numStageMovementSlowDownVelocity.Value = (decimal)Settings.Default.StageMovementSlowDownVelocity;
            if (this.chkStageMovementCreepUp.Checked == true)
            {
                this.numStageMovementSlowDownVelocity.Enabled = true;
                this.numStageMovementSlowDownDistance.Enabled = true;
            }
        }

        private void ApplySettings()
        {
            Settings.Default.IndicatorCOMPort = this.cmbIndicatorPorts.Text.Split(" ")[0];
            Settings.Default.AvgNegativeStepSize_um = this.numAvgNegStepSizeUm.Value;
            Settings.Default.AvgPositiveStepSize_um = this.numAvgPosStepSizeUm.Value;
            Settings.Default.StageMovementCreepUp = this.chkStageMovementCreepUp.Checked;
            Settings.Default.StageMovementSlowDownDistance = (int)this.numStageMovementSlowDownDistance.Value;
            Settings.Default.StageMovementSlowDownVelocity = (int)this.numStageMovementSlowDownVelocity.Value;


            Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplySettings();
            MainForm.UpdateCalibrationValues();
            this.Close();
        }

        private void chkStageMovementCreepUp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkStageMovementCreepUp.Checked == true)
            {
                this.numStageMovementSlowDownVelocity.Enabled = true;
                this.numStageMovementSlowDownDistance.Enabled = true;
            }
            else
            {
                this.numStageMovementSlowDownVelocity.Enabled = false;
                this.numStageMovementSlowDownDistance.Enabled = false;
            }
        }
    }
}
