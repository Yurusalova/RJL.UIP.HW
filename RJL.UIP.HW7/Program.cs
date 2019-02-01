using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RJL.UIP.HW7.LoggerLibrary.Interfaces;
using RJL.UIP.HW7.LoggerLibrary.Models;
using RJL.UIP.HW7.LoggerLibrary.Services;
using RJL.UIP.HW7.Models;
using RJL.UIP.HW7.Services;

namespace RJL.UIP.HW7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IStorage> storages = new List<IStorage>() {
                new ConsoleStorage(),
                new FileStorage(@"C:\Users\Rusalovay\Documents\My\UIP\Files\log.txt")
            };
            Logger logger = new Logger(storages);
            List<Point> points = PointsHandler.CreatePointsFromInput(logger);

            Console.WriteLine("--Enter Y if you want to print points otherwise press any key");
            if (Console.ReadLine() == "Y")
            {
                PointsHandler.PrintPoints(points);
                Console.WriteLine();
                logger.Info("Points were printed");
            }
            
            long result = AreaCalculator.GetValidatedArea(points, logger);
            if (result != 0)
            {
                Console.WriteLine("--Square of area is " + result);
            }
            else
            {
                Console.WriteLine("--Calculating of area square is incorrect.Please input valid coordinates of points");
            }
            Console.ReadLine();
        }
    }
}
