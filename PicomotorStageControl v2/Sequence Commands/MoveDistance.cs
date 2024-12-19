using PicomotorStageControl_v2.SequenceCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class MoveDistance : Command
    {
        public decimal Distance_um { get; private set; }

        public MoveDistance(decimal distance_um) : base()
        {
            this.Type = CommandTypes.MoveDistance;
            this.Distance_um = distance_um;
            this.DisplayText = "Move To " + distance_um.ToString() + " um";
        }

        public override void Execute()
        {

        }
    }
}
