using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class StopDataCollection : Command
    {
        public StopDataCollection() : base()
        {
            this.Type = CommandTypes.StopDataCollection;
            this.DisplayText = "Stop Data Collection";
            this.LogMessage = "Stop Data Collection";
        }

        public override void Execute()
        {
            int x = 1;
            for (int i = 0; i < 100000000; i++)
            {
                x += i;
            }
        }
    }
}
