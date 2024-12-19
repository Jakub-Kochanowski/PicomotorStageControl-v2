using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicomotorStageControl_v2
{
    public class Indicator
    {
        public string COMPort { get; private set; } = "";
        public decimal Position { get; private set; } = 0.0M;
        public decimal Velocity { get; private set; } = 0.0M;

        public bool Connected { get { return SerialPort.IsOpen; } }

        private SerialPort SerialPort;
        private Thread SerialDataReaderThread;

        public Indicator(string comPort)
        {
            COMPort = comPort;
            SerialDataReaderThread = new Thread(SerialDataReader_DoWork);
            SerialPort = new SerialPort(COMPort, 9600, Parity.None, 8, StopBits.One)
            {
                Encoding = Encoding.ASCII,
                NewLine = "\r",
                DtrEnable = false,
                RtsEnable = false
            };
        }

        public void Connect()
        {
            SerialPort.Open();
            SerialDataReaderThread.Start();
        }

        public void Disconnect()
        {
            SerialPort.Close();
            this.Velocity = 0.0M;
        }

        private void SerialDataReader_DoWork()
        {
            // Does putting variables here actually help or does the compiler
            // take care of it? (You do not want to be initializing a new variable on every loop.
            decimal previousPosition = 0.0M;
            string msg;
            decimal num;
            DateTime now;
            DateTime previousTime = DateTime.MinValue;
            TimeSpan deltaTime;
            decimal deltaPosition;
            decimal vel;

            while (SerialPort.IsOpen)
            {
                try
                {
                    SerialPort.WriteLine("1");
                    if (SerialPort.BytesToRead != 0)
                    {
                        msg = SerialPort.ReadLine();
                        if (msg[0] != '9') {
                            msg = msg.Split('A')[1];
                            num = decimal.Parse(msg) * 1000.0M;

                            this.Position = num;

                            now = DateTime.Now;
                            deltaTime = now.Subtract(previousTime);
                            deltaPosition = num - previousPosition;

                            vel = deltaPosition / (decimal)deltaTime.TotalSeconds;

                            this.Velocity = vel;

                            previousTime = now;
                            previousPosition = num;
                        }
                    }
                    Thread.Sleep(5);
                    // TO DO: Handle disconnections
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    // TO DO: I know.
                }
            }
        }
    }
}
