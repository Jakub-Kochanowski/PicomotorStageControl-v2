using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2.SequenceCommands
{
    internal class WaitTime : Command
    {
        private decimal Time_ms;
        private BackgroundWorker waitWorker;

        public WaitTime(decimal time_ms) : base()
        {
            this.Type = CommandTypes.WaitTime;
            this.Time_ms = time_ms;

            this.DisplayText = "Wait " + time_ms.ToString() + " ms";
            waitWorker = new BackgroundWorker();
            waitWorker.DoWork += WaitWorker_DoWork;
            this.Progress = "0ms/" + time_ms.ToString() + "ms";
            this.LogMessage = "Waited " + time_ms.ToString() + " ms";
        }

        private void WaitWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            while (Running)
            {
                DateTime later = DateTime.Now.AddMilliseconds((double)Time_ms);
                while (DateTime.Now < later)
                {
                    this.Progress = (later - DateTime.Now).ToString() + "ms/" + Time_ms.ToString() + "ms";
                    Thread.Yield();
                }
                this.Running = false;
            }
        }

        public override void Execute()
        {
            waitWorker.RunWorkerAsync();
            this.Running = true;
        }

        public override void Stop()
        {
            this.Running = false;
            waitWorker.Dispose(); // Is this a good way to do it?
            waitWorker = new BackgroundWorker();
            waitWorker.DoWork += WaitWorker_DoWork;
        }
    }
}
