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
    public partial class frmTextInputBox : Form
    {
        public string TextInput { get; private set; } = "";
        public frmTextInputBox(string title, string label)
        {
            InitializeComponent();
            this.Text = title;
            this.lblDescription.Text = label;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.TextInput = txtTextInput.Text;

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
        }
    }
}
