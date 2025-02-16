using PicomotorStageControl_v2.SequenceCommands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class SetDataFileName : Command
    {
        frmMain MainForm;
        public string DataFileName { get; private set; } = "";

        public SetDataFileName(frmMain mainForm, string dataFileName) : base()
        {
            this.MainForm = mainForm;
            this.DataFileName = dataFileName;
            this.Type = CommandTypes.SetDataFileName;
            this.DisplayText = "Set Data File Name To " + DataFileName;
            this.LogMessage = "Set Data File Name To " + DataFileName;
        }

        public override void Execute()
        {
            this.MainForm.SetDataFileName(this.DataFileName);
        }
    }
}
