using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class StopDataCollection : Command
    {
        private frmMain MainForm;
        public StopDataCollection(frmMain mainForm) : base()
        {
            this.MainForm = mainForm;
            this.Type = CommandTypes.StopDataCollection;
            this.DisplayText = "Stop Data Collection";
            this.LogMessage = "Stop Data Collection";
        }

        public override void Execute()
        {
            this.MainForm.StopDataCollection();
        }
    }
}
