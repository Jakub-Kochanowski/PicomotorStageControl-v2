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
    public partial class IndenterControl : Form
    {
        frmMain MainForm;

        BackgroundWorker FindSpringConstant;

        private enum SpringConstantMeasurementMode
        {
            ByPoints,
            ByDistance,
            ByForce
        }

        public IndenterControl(frmMain mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void IndenterControl_Load(object sender, EventArgs e)
        {
            FindSpringConstant = new BackgroundWorker();
            FindSpringConstant.DoWork += FindSpringConstant_DoWork;
        }

        private void btnFindSpringConstByPoints_Click(object sender, EventArgs e)
        {
            if (FindSpringConstant.IsBusy || MainForm.Motor == null || MainForm.IndenterController == null || MainForm.IndenterController.Connected == false || MainForm.Indicator == null)
                return;

        }

        private void FindSpringConstant_DoWork(object? sender, DoWorkEventArgs e)
        {

        }
    }
}
