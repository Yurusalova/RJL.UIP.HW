using RJL.UIP.HW9.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW9.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RJL.UIP.HW9.EarthAreaCalculator.BAL.Services
{
    public class AreaCalculator:IAreaCalculator
    {
        private IPointsValidator PointsValidator;

        private ILogger Logger;

        public AreaCalculator(IPointsValidator pointsValidator, ILogger logger)
        {
            PointsValidator = pointsValidator;
            Logger = logger;
        }

        private  double CalculateArea(List<Point> points, bool isAltAppr)
        {
            double landArea = 0;
            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i == points.Count - 1) ? 0 : i + 1;
                int prevIndex = (i == 0) ? points.Count - 1 : i - 1;
                double par1 = isAltAppr ? points[i].X : points[i].Y;
                double par2_1 = isAltAppr ? points[nextIndex].Y : points[prevIndex].X;
                double par2_2 = isAltAppr ? points[prevIndex].Y : points[nextIndex].X;
                double tempLandArea = landArea;
                landArea += par1 * (par2_1 - par2_2);
            }
            double result = (long)Math.Abs(landArea / 2);
            return result;
        }

        public double GetCalculationAreaResult(List<Point> points)
        {
            var pointsValidationResult = new PointsValidationResult();
            pointsValidationResult = PointsValidator.GetPointsValidationResult(points);
            if (!pointsValidationResult.IsPointsValid)
            {
                return -1;
            }
            else
            {
                Logger.Info($"[{this.GetType().Name}]: Calculating area of input points");
                double resultX = CalculateArea(points, true);
                double resultY = CalculateArea(points, false);
                if (resultX == resultY)
                {
                    Logger.Info($"[{this.GetType().Name}]: Square of area is " + resultX);
                    return resultX;
                }
                else
                {
                    Logger.Error($"[{this.GetType().Name}]: The result of calculating area is incorrect. ");
                    return 0;
                }
            }
        }
    }
}
