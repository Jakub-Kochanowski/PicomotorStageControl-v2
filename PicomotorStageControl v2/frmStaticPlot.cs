using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicomotorStageControl_v2
{
    public partial class frmStaticPlot : Form
    {
        public frmStaticPlot(double[] X, double[] Y, string title, string xLabel, string yLabel)
        {
            InitializeComponent();

            Plot.Plot.Add.ScatterLine(X, Y);
            Plot.Plot.Axes.Bottom.Label.Text = xLabel;
            Plot.Plot.Axes.Left.Label.Text = yLabel;
            Plot.Plot.Axes.Title.Label.Text = title;

            Plot.Refresh();
        }

        private void frmStaticPlot_Load(object sender, EventArgs e)
        {

        }
    }
}
