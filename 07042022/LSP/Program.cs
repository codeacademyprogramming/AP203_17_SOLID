using System;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes();
            mercedes.StartDrive();
            mercedes.StartAirConditioner();

            BMW bmw = new BMW();
            bmw.StartDrive();
            bmw.StartAirConditioner();

            Volqa volqa = new Volqa();

            volqa.StartDrive();

        }
    }
}
