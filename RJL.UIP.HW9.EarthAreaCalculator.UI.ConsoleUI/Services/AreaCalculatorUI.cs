using RJL.UIP.HW9.EarthAreaCalculator.Core.DI;
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
    public class AreaCalculatorUI
    {
        public IAreaCalculator AreaCalculator { get; set; }

        public AreaCalculatorUI()
        {
            AreaCalculator = AppContainer.Resolve<IAreaCalculator>();
        }
        public void StartCalculation(ILogger logger)
        {
            PointsHandlerUI pointsHandlerUI = new PointsHandlerUI();
            List<Point> points = pointsHandlerUI.CreatePointsFromInput(logger);
            pointsHandlerUI.PrintPointsIfRequired(logger, points);
            ValidateAndCalculateArea(logger, points);
        }

        public void ValidateAndCalculateArea(ILogger logger, List<Point> points)
        {
            double result = AreaCalculator.GetCalculationAreaResult(points);
            if (result != 0)
            {
                Console.WriteLine("--Square of area is " + result);
            }
            else
            {
                Console.WriteLine("--Calculating of area square is incorrect.Please input valid coordinates of points");
            }
        }
    }
}
