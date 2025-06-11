using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Timers;

namespace PicomotorStageControl_v2
{
    public class MicroscopeStageController : IDisposable
    {
        private readonly SerialPort serialPort;
        private readonly Thread pollingThread;
        private readonly object serialLock = new object();
        private volatile bool running = true;
        public bool Connected { get; private set; }

        public event Action<double, double, double>? OnPositionUpdated;
        public double[] CurrentPosition { get; private set; } = new double[3]; // X, Y, Z

        public MicroscopeStageController(string portName, int baudRate = 9600)
        {
            serialPort = new SerialPort(portName, baudRate)
            {
                NewLine = "\r",
                ReadTimeout = 1000,
                WriteTimeout = 1000,
                Encoding = Encoding.ASCII
            };

            serialPort.Open();
            Connected = true;

            pollingThread = new Thread(PollStagePosition)
            {
                IsBackground = true
            };
            pollingThread.Start();
        }

        private void PollStagePosition()
        {
            while (running)
            {
                try
                {
                    if (!Connected) continue;

                    lock (serialLock)
                    {
                        serialPort.DiscardInBuffer();
                        serialPort.Write("W X Y Z\r");

                        string? response = serialPort.ReadLine();
                        if (!string.IsNullOrWhiteSpace(response) && response.StartsWith(":A"))
                        {
                            string[] tokens = response.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            if (tokens.Length >= 4 &&
                                double.TryParse(tokens[1], out double x) &&
                                double.TryParse(tokens[2], out double y) &&
                                double.TryParse(tokens[3], out double z))
                            {
                                OnPositionUpdated?.Invoke(x, y, z);
                                this.CurrentPosition[0] = x;
                                this.CurrentPosition[1] = y;
                                this.CurrentPosition[2] = z;
                            }
                        }
                    }

                    Thread.Sleep(50); // ~20 updates/sec
                }
                catch (TimeoutException)
                {
                    // Ignore and continue polling
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Stage polling error: " + ex.Message);
                }
            }
        }

        public void HaltStage()
        {
            SendCommand("\\");
        }

        public void StageRun(int X, int Y, int Z)
        {
            int xDir = X * 9999999;
            int yDir = Y * 9999999;
            int zDir = Z * 9999999;

            SendCommand($"R X={xDir} Y={yDir} Z={zDir}");
        }

        public void SendCommand(string command)
        {
            if (!Connected) return;

            try
            {
                lock (serialLock)
                {
                    serialPort.Write(command.TrimEnd() + "\r");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stage command error: " + ex.Message);
            }
        }

        public void Dispose()
        {
            running = false;
            pollingThread.Join(500);

            if (serialPort.IsOpen)
                serialPort.Close();

            serialPort.Dispose();
        }
    }
}
