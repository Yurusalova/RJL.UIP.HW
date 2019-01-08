using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop Laptop1 = new Laptop("Asus","20W","8Gb", "2kg");
            Laptop Laptop2 = new Laptop("Acer", "35W", "16Gb", "5kg");
            string descriptionLaptop1=Laptop1.GetDescription();
            string descriptionLaptop2 = Laptop2.GetDescription();
            Console.WriteLine("Laptop 1: " + descriptionLaptop1);
            Console.WriteLine("Laptop 2: " + descriptionLaptop2);
            Console.WriteLine("------------------------------------------------------------------");
            Server Server1 = new Server("IBM", "300W", "1Tb", 10);
            Server Server2 = new Server("DELL", "250W", "2Tb", 20);
            string descriptionServer1 = Server1.GetDescription();
            string descriptionServer2 = Server2.GetDescription();
            Console.WriteLine("Server 1: " + descriptionServer1);
            Console.WriteLine("Server 2: " + descriptionServer2);
            Console.WriteLine("------------------------------------------------------------------");
            PlazmTV PlazmTV1 = new PlazmTV("Samsung", "100W", "50'", "4K");
            PlazmTV PlazmTV2 = new PlazmTV("LG", "150W", "30'", "4K");
            string descriptionPlazmTV1 = PlazmTV1.GetDescription();
            string descriptionPlazmTV2 = PlazmTV2.GetDescription();
            Console.WriteLine("PlazmTV 1: " + descriptionPlazmTV1);
            Console.WriteLine("PlazmTV 2: " + descriptionPlazmTV2);
            Console.WriteLine("------------------------------------------------------------------");
            CRTTV CRTTV1 = new CRTTV("Saturn", "100W", "25'", "50Hz");
            CRTTV CRTTV2 = new CRTTV("Orion", "150W", "30'", "30Hz");
            string descriptionCRTTV1 = CRTTV1.GetDescription();
            string descriptionCRTTV2 = CRTTV2.GetDescription();
            Console.WriteLine("CRTTV 1: " + descriptionCRTTV1);
            Console.WriteLine("CRTTV 2: " + descriptionCRTTV2);
            Console.WriteLine("------------------------------------------------------------------");
            Format Format1 = new Format("mp3", 128);
            Format Format2 = new Format("mp3", 256);
            Player Player1 = new Player("Google Chromecast", "20W", Format1);
            Player Player2 = new Player("Xiaomi Mi", "15W", Format2);
            string descriptionPlayer1 = Player1.GetDescription();
            string descriptionPlayer2 = Player2.GetDescription();
            Console.WriteLine("Player 1: " + descriptionPlayer1);
            Console.WriteLine("Player 2: " + descriptionPlayer2);
            Console.ReadLine();
        }
    }
    public class Laptop
    {
        public string Model { get; private set; }
        public string Power { get; private set; }
        public string RAM { get; private set; }
        public string Weight { get; private set; }
        public Laptop(string model, string power, string RAM, string weight)
        {
            this.Model = model;
            this.Power = power;
            this.RAM = RAM;
            this.Weight = weight;
        }
        public string GetDescription()
        {
            return $"model  {this.Model}, power {this.Power}, RAM {this.RAM}, weight {this.Weight}";
        }
    }
    public class Server
    {
        public string Model { get; private set; }
        public string Power { get; private set; }
        public string RAM { get; private set; }
        public int ProcCount { get; private set; }
        public Server(string model, string power, string RAM, int procCount)
        {
            this.Model = model;
            this.Power = power;
            this.ProcCount = procCount;
            this.RAM = RAM;
        }
        public string GetDescription()
        {
            return $"model {this.Model}, power {this.Power}, RAM {this.RAM}, the count of proccessors {this.ProcCount}";
        }
    }
    public class PlazmTV
    {
        public string Model { get; private set; }
        public string Power { get; private set; }
        public string Diagonal { get; private set; }
        public string Resolution { get; private set; }
        public PlazmTV(string model, string power, string diagonal, string resolution)
        {
            this.Model = model;
            this.Power = power;
            this.Resolution = resolution;
            this.Diagonal = diagonal;
        }
        public string GetDescription()
        {
            return $"model {this.Model}, power {this.Power}, diagonal {this.Diagonal}, screen resolution {this.Resolution}";
        }
    }
    public class CRTTV
    {
        public string Model { get; private set; }
        public string Power { get; private set; }
        public string Diagonal { get; private set; }
        public string Frequency { get; private set; }
        public CRTTV(string model, string power, string diagonal, string frequency)
        {
            this.Model = model;
            this.Power = power;
            this.Frequency = frequency;
            this.Diagonal = diagonal;
        }
        public string GetDescription()
        {
            return $"model {this.Model}, power {this.Power}, diagonal {this.Diagonal}, scanning frequency {this.Frequency}";
        }
    }
    public class Player
    {
        public string Model { get; private set; }
        public string Power { get; private set; }
        public Format Formats { get; private set; }
        public Player(string model, string power, Format formats)
        {
            this.Model = model;
            this.Power = power;
            this.Formats = formats;
        }
        public string GetDescription()
        {
            return $"model {this.Model}, power {this.Power}, playback formats {this.Formats.Name} {this.Formats.Bitrate} kbps";
        }
    }
    public class Format
    {
        public string Name { get; private set; }
        public int Bitrate { get; private set; }
        public Format(string name, int bitrate)
        {
            this.Name = name;
            this.Bitrate = bitrate;
        }
    }
}
