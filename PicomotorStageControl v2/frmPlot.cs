using ScottPlot.Plottables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicomotorStageControl_v2
{
    public partial class frmPlot : Form
    {
        private frmMain MainForm;

        private DataLogger LoggerMotorSteps;
        private DataLogger LoggerMotorCalibrationMicrons;
        private DataLogger LoggerIndicatorMicrons;
        private DataLogger LoggerIndenterForce_mg;

        Stopwatch StopwatchTimeElapsed;

        public frmPlot(frmMain mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;
        }

        private void frmPlot_Load(object sender, EventArgs e)
        {
            InitializePlot();

            StopwatchTimeElapsed = new Stopwatch();
            StopwatchTimeElapsed.Start();

            this.tmrPlotUpdate.Enabled = true;
            this.tmrPlotUpdate.Start();
        }

        private void InitializePlot()
        {
            LoggerMotorSteps = Plot.Plot.Add.DataLogger();
            LoggerMotorCalibrationMicrons = Plot.Plot.Add.DataLogger();
            LoggerIndicatorMicrons = Plot.Plot.Add.DataLogger();
            LoggerIndenterForce_mg = Plot.Plot.Add.DataLogger();
        }

        private void tmrPlotUpdate_Tick(object sender, EventArgs e)
        {
            float currentTime = StopwatchTimeElapsed.ElapsedMilliseconds / 1000.0f;

            if (MainForm.Motor != null)
            {
                LoggerMotorSteps.Add(currentTime, MainForm.Motor.Position_step);
                LoggerMotorCalibrationMicrons.Add(currentTime, MainForm.Motor.PositionFromCalibration_um);
            }
            else
            {
                LoggerMotorSteps.Add(currentTime, 0);
                LoggerMotorCalibrationMicrons.Add(currentTime, 0);
            }
            if (MainForm.Indicator != null)
            {
                LoggerIndicatorMicrons.Add(currentTime, (float)MainForm.Indicator.Position);
            }
            else
            {
                LoggerIndicatorMicrons.Add(currentTime, 0);
            }
            if (MainForm.IndenterController != null)
            {
                LoggerIndenterForce_mg.Add(currentTime, MainForm.IndenterController.IndenterForce_mg);
            }
            else
            {
                LoggerIndenterForce_mg.Add(currentTime, 0);
            }

            Plot.Refresh();
        }

        private void btnPlotClear_Click(object sender, EventArgs e)
        {
            LoggerMotorSteps.Clear();
            LoggerMotorCalibrationMicrons.Clear();
            LoggerIndicatorMicrons.Clear();
            LoggerIndenterForce_mg.Clear();
        }

        private void numPlotInterval_ValueChanged(object sender, EventArgs e)
        {
            tmrPlotUpdate.Interval = (int)numPlotInterval.Value;
        }

        private void chkPlotViewMotorSteps_CheckedChanged(object sender, EventArgs e)
        {
            LoggerMotorSteps.IsVisible = chkPlotViewMotorSteps.Checked;
        }

        private void chkPlotViewMotorCalibration_CheckedChanged(object sender, EventArgs e)
        {
            LoggerMotorCalibrationMicrons.IsVisible = chkPlotViewMotorCalibration.Checked;
        }

        private void chkPlotViewIndicator_CheckedChanged(object sender, EventArgs e)
        {
            LoggerIndicatorMicrons.IsVisible = chkPlotViewIndicator.Checked;
        }

        private void chkPlotViewIndenterForce_CheckedChanged(object sender, EventArgs e)
        {
            LoggerIndenterForce_mg.IsVisible = chkPlotViewIndenterForce.Checked;
        }
    }
}
