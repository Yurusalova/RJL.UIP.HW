using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop Laptop1 = new Laptop("Asus","20W","8Gb", "2kg");
            Laptop Laptop2 = new Laptop("Acer", "35W", "16Gb", "5kg");
            string descriptionLaptop1=Laptop1.GetDesciptionLaptop(Laptop1.LaptopModel, Laptop1.LaptopPower, Laptop1.LaptopRAM, Laptop1.LaptopWeight);
            string descriptionLaptop2 = Laptop2.GetDesciptionLaptop(Laptop2.LaptopModel, Laptop2.LaptopPower, Laptop2.LaptopRAM, Laptop2.LaptopWeight);
            Console.WriteLine("Laptop 1: " + descriptionLaptop1);
            Console.WriteLine("Laptop 2: " + descriptionLaptop2);
            Console.WriteLine("------------------------------------------------------------------");
            Server Server1 = new Server("IBM", "300W", "1Tb", 10);
            Server Server2 = new Server("DELL", "250W", "2Tb", 20);
            string descriptionServer1 = Server1.GetDescriptionServer(Server1.ServerModel, Server1.ServerPower, Server1.ServerRAM, Server1.ServerProcCount);
            string descriptionServer2 = Server2.GetDescriptionServer(Server2.ServerModel, Server2.ServerPower, Server2.ServerRAM, Server2.ServerProcCount);
            Console.WriteLine("Server 1: " + descriptionServer1);
            Console.WriteLine("Server 2: " + descriptionServer2);
            Console.WriteLine("------------------------------------------------------------------");
            PlazmTV PlazmTV1 = new PlazmTV("Samsung", "100W", "50'", "4K");
            PlazmTV PlazmTV2 = new PlazmTV("LG", "150W", "30'", "4K");
            string descriptionPlazmTV1 = PlazmTV1.GetDescriptionPlazmTV(PlazmTV1.PlazmTVModel, PlazmTV1.PlazmTVPower, PlazmTV1.PlazmTVDiagonal, PlazmTV1.PlazmTVResolution);
            string descriptionPlazmTV2 = PlazmTV2.GetDescriptionPlazmTV(PlazmTV2.PlazmTVModel, PlazmTV2.PlazmTVPower, PlazmTV2.PlazmTVDiagonal, PlazmTV2.PlazmTVResolution);
            Console.WriteLine("PlazmTV 1: " + descriptionPlazmTV1);
            Console.WriteLine("PlazmTV 2: " + descriptionPlazmTV2);
            Console.WriteLine("------------------------------------------------------------------");
            CRTTV CRTTV1 = new CRTTV("Saturn", "100W", "25'", "50Hz");
            CRTTV CRTTV2 = new CRTTV("Orion", "150W", "30'", "30Hz");
            string descriptionCRTTV1 = CRTTV1.GetDescriptionCRTTV(CRTTV1.CRTTVModel, CRTTV1.CRTTVPower, CRTTV1.CRTTVDiagonal, CRTTV1.CRTTVFrequency);
            string descriptionCRTTV2 = CRTTV2.GetDescriptionCRTTV(CRTTV2.CRTTVModel, CRTTV2.CRTTVPower, CRTTV2.CRTTVDiagonal, CRTTV2.CRTTVFrequency);
            Console.WriteLine("CRTTV 1: " + descriptionCRTTV1);
            Console.WriteLine("CRTTV 2: " + descriptionCRTTV2);
            Console.WriteLine("------------------------------------------------------------------");
            Player Player1 = new Player("Google Chromecast", "20W", "all");
            Player Player2 = new Player("Xiaomi Mi", "15W", "all");
            string descriptionPlayer1 = Player1.GetDescriptionPlayer(Player1.PlayerModel, Player1.PlayerPower, Player1.PlayerFormats);
            string descriptionPlayer2 = Player2.GetDescriptionPlayer(Player2.PlayerModel, Player2.PlayerPower, Player2.PlayerFormats);
            Console.WriteLine("Player 1: " + descriptionPlayer1);
            Console.WriteLine("Player 2: " + descriptionPlayer2);
            Console.ReadLine();
        }
    }
    public class Laptop
    {
        public string LaptopModel;
        public string LaptopPower;
        public string LaptopRAM;
        public string LaptopWeight;
        public Laptop(string laptopModel, string laptopPower, string laptopRAM, string laptopWeight)
        {
            this.LaptopModel = laptopModel;
            this.LaptopPower = laptopPower;
            this.LaptopRAM = laptopRAM;
            this.LaptopWeight = laptopWeight;

        }
        public string GetDesciptionLaptop(string laptopModel, string laptopPower, string laptopRAM, string laptopWeight)
        {
            string laptopDescription = $"model  {laptopModel}, power {laptopPower}, RAM {laptopRAM}, weight {laptopWeight}";
            return laptopDescription;
        }
    }
    public class Server
    {
        public string ServerModel;
        public string ServerPower;
        public string ServerRAM;
        public int ServerProcCount;
        public Server(string serverModel, string serverPower, string serverRAM, int serverProcCount)
        {
            this.ServerModel = serverModel;
            this.ServerPower = serverPower;
            this.ServerProcCount = serverProcCount;
            this.ServerRAM = serverRAM;
        }
        public string GetDescriptionServer(string serverModel, string serverPower, string serverRAM, int serverProcCount)
        {
            string serverDescription = $"model {serverModel}, power {serverPower}, RAM {serverRAM}, the count of proccessors {serverProcCount}";
            return serverDescription;
        }
    }
    public class PlazmTV
    {
        public string PlazmTVModel;
        public string PlazmTVPower;
        public string PlazmTVDiagonal;
        public string PlazmTVResolution;
        public PlazmTV(string plazmTVModel, string plazmTVPower, string plazmTVDiagonal, string plazmTVResolution)
        {
            this.PlazmTVModel = plazmTVModel;
            this.PlazmTVPower = plazmTVPower;
            this.PlazmTVResolution = plazmTVResolution;
            this.PlazmTVDiagonal = plazmTVDiagonal;
        }
        public string GetDescriptionPlazmTV(string plazmTVModel, string plazmTVPower, string plazmTVDiagonal, string plazmTVResolution)
        {
            string plazmTVDescription = $"model {plazmTVModel}, power {plazmTVPower}, diagonal {plazmTVDiagonal}, screen resolution {plazmTVResolution}";
            return plazmTVDescription;
        }
    }
    public class CRTTV
    {
        public string CRTTVModel;
        public string CRTTVPower;
        public string CRTTVDiagonal;
        public string CRTTVFrequency;
        public CRTTV(string CRTTVModel, string CRTTVPower, string CRTTVDiagonal, string CRTTVFrequency)
        {
            this.CRTTVModel = CRTTVModel;
            this.CRTTVPower = CRTTVPower;
            this.CRTTVFrequency = CRTTVFrequency;
            this.CRTTVDiagonal = CRTTVDiagonal;
        }
        public string GetDescriptionCRTTV(string CRTTVModel, string CRTTVPower, string CRTTVDiagonal, string CRTTVFrequency)
        {
            string CRTTVDescription = $"model {CRTTVModel}, power {CRTTVPower}, diagonal {CRTTVDiagonal}, scanning frequency {CRTTVFrequency}";
            return CRTTVDescription;
        }
    }
    public class Player
    {
        public string PlayerModel;
        public string PlayerPower;
        public string PlayerFormats;
        public Player(string playerModel, string playerPower, string playerFormats)
        {
            this.PlayerModel = playerModel;
            this.PlayerPower = playerPower;
            this.PlayerFormats = playerFormats;
        }
        public string GetDescriptionPlayer(string playerModel, string playerPower, string playerFormats)
        {
            string playerDescription = $"model {playerModel}, power {playerPower}, playback formats {playerFormats}";
            return playerDescription;
        }
    }
}
