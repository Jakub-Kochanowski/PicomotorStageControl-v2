using PicomotorStageControl_v2.SequenceCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class MoveTo : Command
    {
        public decimal Position_um { get; private set; }

        public MoveTo(decimal position_um) : base()
        {
            this.Type = CommandTypes.MoveTo;
            this.Position_um = position_um;
            this.DisplayText = "Move By " + position_um.ToString() + " um";
        }

        public override void Execute()
        {

        }
    }
}
