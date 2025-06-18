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
            LoggerIndicatorMicrons = Plot.Plot.Add.DataLogger();
            LoggerIndicatorMicrons.Axes.YAxis = Plot.Plot.Axes.Left;

            LoggerIndenterForce_mg = Plot.Plot.Add.DataLogger();
            LoggerIndenterForce_mg.Axes.YAxis = Plot.Plot.Axes.Right;

            Plot.Plot.XLabel("Time (s)");
            Plot.Plot.Axes.Left.Label.Text = "Indicator Position (microns)";
            Plot.Plot.Axes.Right.Label.Text = "Indenter Force (mg)";
        }

        private void tmrPlotUpdate_Tick(object sender, EventArgs e)
        {
            float currentTime = StopwatchTimeElapsed.ElapsedMilliseconds / 1000.0f;


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

            try
            {
                Plot.Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Plot refresh error: " + ex.Message);
            }
        }

        private void btnPlotClear_Click(object sender, EventArgs e)
        {
            LoggerIndicatorMicrons.Clear();
            LoggerIndenterForce_mg.Clear();
        }

        private void numPlotInterval_ValueChanged(object sender, EventArgs e)
        {
            tmrPlotUpdate.Interval = (int)numPlotInterval.Value;
        }
    }
}
