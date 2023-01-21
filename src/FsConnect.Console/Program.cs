using FsConnect.Managers;
using System;

namespace FsConnect.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fsConnect = new FsConnect();
            fsConnect.ConnectionChanged += FsConnect_ConnectionChanged;
            fsConnect.AircraftLoaded += FsConnect_AircraftLoaded;
            fsConnect.Crashed += FsConnect_Crashed;
            fsConnect.FlightLoaded += FsConnect_FlightLoaded;

            fsConnect.Connect("RadioPanelConsole");

            var radioManager = new RadioManager(fsConnect);
            radioManager.RadioUpdated += RadioManager_RadioUpdated;
            radioManager.Start();

            ConsoleKeyInfo key;
            do
            {
                key = System.Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);

            radioManager.Stop();
        }

        private static void RadioManager_RadioUpdated(object sender, RadioUpdatedEventsArgs e)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"COM1:          {e.Com1ActiveFrequency}");
            System.Console.WriteLine($"COM1Stby:      {e.Com1StandbyFrequency}");
            System.Console.WriteLine($"COM2:          {e.Com2ActiveFrequency}");
            System.Console.WriteLine($"COM2Stby:      {e.Com2StandbyFrequency}");
            System.Console.WriteLine($"COM1Status:    {e.Com1Status}");
            System.Console.WriteLine($"COM1Avail:     {e.Com1Available}");
        }

        private static void FsConnect_FlightLoaded(object sender, EventArgs e)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Flight loaded .........");
        }

        private static void FsConnect_Crashed(object sender, EventArgs e)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Crashed .........");
        }

        private static void FsConnect_AircraftLoaded(object sender, EventArgs e)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Aircraft loaded .........");
        }

        private static void FsConnect_ConnectionChanged(object sender, bool e)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Connection changed ({e}) .........");
        }
    }
}
