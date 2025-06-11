using System;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Timers;

public class IndenterController : IDisposable
{
    private readonly SerialPort serialPort;
    private readonly Thread pollingThread;
    private readonly object serialLock = new object();
    private volatile bool running = true;
    public bool Connected { get; private set; } = false;
    private static int baudRate = 11500;

    public double IndenterCalibration { get; set; }
    public double ProbeWeight_mg { get; set; } // Why overcomplicate with private, internal stuff


    private double RawIndenterValue = 0.0D;
    private double CalibratedIndenterValue { get { return RawIndenterValue - IndenterCalibration - ProbeWeight_mg; } }
    public double IndenterForce_mg { get { return CalibratedIndenterValue / 1000.0D; } }
    public double IndenterForce_N { get { return (CalibratedIndenterValue / 1000.0D) * 9.81D; } }

    
    public event Action<double, double, double>? OnForceUpdated;

    public IndenterController(string portName)
    {
        serialPort = new SerialPort(portName, baudRate)
        {
            ReadTimeout = 1000,
            WriteTimeout = 1000,
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
        List<byte> buffer = new List<byte>();

        while (running)
        {
            try
            {
                if (!Connected) continue;

                int b = serialPort.ReadByte();
                if (b == -1) continue;

                buffer.Add((byte)b);
                if (buffer.Count > 16)
                    buffer.RemoveAt(0);
                if (buffer.Count >= 4 && buffer[0] == 0x0D && buffer[1] == 0x0A)
                {
                    ushort value = (ushort)(buffer[2] | (buffer[3] << 8));
                    this.RawIndenterValue = value;
                    OnForceUpdated?.Invoke(value, IndenterForce_mg, IndenterForce_N); // TO DO: I dunno.
                }

                Thread.Sleep(10); // ~20 updates/sec
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

    public void Dispose()
    {
        running = false;
        pollingThread.Join(500);

        if (serialPort.IsOpen)
            serialPort.Close();

        serialPort.Dispose();
    }
}