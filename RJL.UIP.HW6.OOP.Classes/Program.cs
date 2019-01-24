using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW6.OOP.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop Laptop1 = new Laptop("Asus", 20, 8, "2kg");
            Laptop Laptop2 = new Laptop("Acer", 35, 16, "5kg");
            Server Server1 = new Server("IBM", 300, 1000, 10);
            Server Server2 = new Server("DELL", 250, 2000, 20);
            PlazmTV PlazmTV1 = new PlazmTV("Samsung", 100, "50'", "4K");
            PlazmTV PlazmTV2 = new PlazmTV("LG", 150, "30'", "4K");
            CRTTV CRTTV1 = new CRTTV("Saturn", 100, "25'", "50Hz");
            CRTTV CRTTV2 = new CRTTV("Orion", 150, "30'", "30Hz");
            Format Format1 = new Format("mp3", 128);
            Format Format2 = new Format("mp3", 256);
            Format Format3 = new Format("mp3", 320);
            Player Player1 = new Player("Google Chromecast", 20, new Format[3] { Format1, Format2, Format3 });
            Player Player2 = new Player("Xiaomi Mi", 15, new Format[2] { Format1, Format2 });
            List<Device> devices = new List<Device>() { Laptop1, Laptop2, Server1, Server2, PlazmTV1, PlazmTV2, CRTTV1, CRTTV2, Player1, Player2 };
            DeviceManager.SetDevicesIDs(devices);
            DeviceManager.DescriptionDevicesOutput(devices);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Sum power of all devices is " + DeviceManager.GetSumPowerAllDevices(devices)+"W");
            Console.WriteLine("Sum RAM of all devices is " + DeviceManager.GetSumRAMAllDevices(devices)+ "Gb");
            Console.WriteLine("------------------------------------");
            Generator Generator = new Generator("Teksan",600);
            DeviceManager.ChainCreation(devices, Generator);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Chain of connected devices:");
            DeviceManager.PrintDevicesInGenerator(Generator);
            Console.WriteLine("------------------------------------");
            int idDeviceForDisconnect = DeviceManager.GetIdDeviceForDisconnectFromInput(devices);
            DeviceManager.DisconnectDeviceFromGenerator(Generator, idDeviceForDisconnect);
            Console.WriteLine("Current chain is");
            DeviceManager.PrintDevicesInGenerator(Generator);
            Console.ReadLine();
        }
    }
}
