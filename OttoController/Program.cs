using System;
using System.IO.Ports;
using System.Threading.Tasks;

namespace OttoController
{
    class Program
    {
        private static SerialPort serialPort;

        static void Main(string[] args)
        {
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM4";
            serialPort.Open();

            string cmd = string.Empty;
            int LL = 90;
            int RL = 65;
            int LF = 120;
            int RF = 90;

            PrintSerialOutput();

            while (true)
            {
                int input;
                Console.Write("Left Leg> ");
                if (Int32.TryParse(Console.ReadLine(), out input) && input != 0)
                {
                    LL = input;
                }

                Console.Write("Left Feet> ");
                if (Int32.TryParse(Console.ReadLine(), out input) && input != 0)
                {
                    LF = input;
                }

                Console.Write("Right Leg> ");
                if (Int32.TryParse(Console.ReadLine(), out input) && input != 0)
                {
                    RL = input;
                }

                Console.Write("Right Feet> ");
                if (Int32.TryParse(Console.ReadLine(), out input) && input != 0)
                {
                    RF = input;
                }

                cmd = "1:" + LF + "&2:" + LL + "&3:" + RF + "&4:" + RL;
                serialPort.WriteLine(cmd);                
            }
        }

        static async Task PrintSerialOutput()
        {
            while (true)
            {
                var serialData = serialPort.ReadExisting();
                if (!string.IsNullOrWhiteSpace(serialData))
                {
                    Console.WriteLine();
                    Console.WriteLine("Serrial> " + serialData);
                }

                await Task.Delay(200);
            }
        }
    }
}
