using RJL.UIP.HW7.LoggerLibrary.Services;
using RJL.UIP.HW7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.Services
{
  public static  class PointsManagment
    {
        public static void PointsPrint(List<Point> points, Logger logger) {
            Console.WriteLine("Do you want to print points?");
            Console.WriteLine("Enter Y or N");
            if (InputValidator.YesNoValueInputValidate(logger) == "Y")
            {
                Console.Clear();
                foreach (var point in points)
                {
                   point.PrintPoint();
                }
                logger.Info("Points were printed");
            }
        }

        public static List<Point> PointsCreateFromInput(Logger logger) {
            List<Point> Points = new List<Point>();
            Console.WriteLine("Enter count of points");
            logger.Info("Entering count of points");
            int countPoints = InputValidator.IntegerValueInputValidate(logger);
            for (int i = 0; i < countPoints; i++)
            {
                Console.WriteLine($"Enter coordinate x for point number {i + 1}");
                logger.Info($"Entering coordinate x for point number {i + 1}");
                int x = InputValidator.IntegerValueInputValidate(logger);
                Console.WriteLine($"Enter coordinate y for point number {i + 1}");
                logger.Info($"Entering coordinate y for point number {i + 1}");
                int y = InputValidator.IntegerValueInputValidate(logger);
                Points.Add(new Point(x, y, logger));
            }
            return Points;
        }
    }
}
