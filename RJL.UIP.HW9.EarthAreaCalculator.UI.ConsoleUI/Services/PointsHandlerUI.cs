using RJL.UIP.HW9.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW9.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RJL.UIP.HW9.EarthAreaCalculator.UI.ConsoleUI.Services
{
    public class PointsHandlerUI
    {
        public List<Point> CreatePointsFromInput(ILogger logger)
        {
            List<Point> Points = new List<Point>();
            int countPoints;
            do
            {
                logger.Info($"[{this.GetType().Name}]: Entering count of points");
                Console.WriteLine("--Enter count of points");
                countPoints = GetPositiveIntValueFromConsoleInput(logger);
                if (countPoints < 3) {
                    logger.Error($"[{this.GetType().Name}]:invalid count of points was inputed from console ");
                    Console.WriteLine("The count of points should be more than 2. Plese repeat input");
                }
            }
            while (countPoints < 3);
            for (int i = 0; i < countPoints; i++)
            {
                int x = GetPointCoordinateFromInput(i, "x", logger);
                int y = GetPointCoordinateFromInput(i, "y", logger);
                Point point = new Point(x, y);
                Points.Add(point);
                logger.Info($"[{this.GetType().Name}]: There was created point with coordinates ({point.X},{point.Y})");
            }
            return Points;
        }

        public int GetPointCoordinateFromInput(int pointCount, string pointType, ILogger logger)
        {
            logger.Info($"[{this.GetType().Name}]:Entering coordinate {pointType} for point number {pointCount + 1}");
            Console.WriteLine($"--Enter coordinate {pointType} for point number {pointCount + 1}");
            return GetPositiveIntValueFromConsoleInput(logger);
        }

        public void PrintPoints(List<Point> points)
        {
            Console.Clear();
            foreach (var point in points)
            {
                PrintPoint(point);
            }
        }

        public void PrintPoint(Point point)
        {
            Console.SetCursorPosition((int)point.X, (int)point.Y);
            Console.Write("*");
        }

        public void PrintPointsIfRequired(ILogger logger, List<Point> points)
        {
            Console.WriteLine("--Enter Y if you want to print points otherwise press any key");
            if (Console.ReadLine() == "Y")
            {
                PrintPoints(points);
                Console.WriteLine();
                logger.Info($"[{this.GetType().Name}]: Points were printed");
            }
        }

        public int GetPositiveIntValueFromConsoleInput(ILogger logger)
        {
            int resultIntInput = 0;
            bool isValidInputInt;
            do
            {
                string resultStringInput = Console.ReadLine();
                logger.Info($"[{this.GetType().Name}]:value {resultStringInput} was input from Console  ");
                bool isInputInt = int.TryParse(resultStringInput, out int resultIntFromInput);
                isValidInputInt = isInputInt && resultIntFromInput > 0;
                if (isValidInputInt)
                {
                    resultIntInput = resultIntFromInput;
                }
                else
                {
                    logger.Error($"[{this.GetType().Name}]:invalid value was inputed from console ");
                    Console.WriteLine($"--Invalid number. Repeat input of value");
                }
            } while (!isValidInputInt);
            return resultIntInput;
        }
    }
}
