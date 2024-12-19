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
    public partial class frmNumericInputBox : Form
    {
        public decimal Value { get; private set; } = 0.0M;
        public frmNumericInputBox(string title, string label, decimal minValue, decimal maxValue, decimal numIncrement)
        {
            InitializeComponent();
            this.Text = title;
            this.lblDescription.Text = label;

            this.numValue.Minimum = minValue;
            this.numValue.Maximum = maxValue;
            this.numValue.Increment = numIncrement;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Value = numValue.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmNumericInputBox_Load(object sender, EventArgs e)
        {
            numValue.Select(0, numValue.Text.Length);
        }
    }
}
