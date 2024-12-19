using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    public enum CommandTypes
    {
        WaitTime,
        WaitUserInput,
        MoveDistance,
        MoveTo,
        SetVelocity,
        SetAcceleration,
        StartDataCollection,
        StopDataCollection
    }
}
