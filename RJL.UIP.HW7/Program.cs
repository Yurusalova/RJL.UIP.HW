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
                new FileStorage(@"C:\Users\Rusalovay\Documents\My\UIP\Files\")
            };
            Logger logger = new Logger(storages);

            List<Point> points = PointsManagment.PointsCreateFromInput(logger);
            long result = AreaCalculator.CompareCalculateArea(points, logger);
            if (result != 0)
            {
                Console.WriteLine("Square of area is " + result);
                PointsManagment.PointsPrint(points, logger);
            }
            else
            {
                Console.WriteLine("Calculating of area square is incorrect.Please input valid coordinates of points");
            }
            Console.ReadLine();
        }
    }
}
