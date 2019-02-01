using RJL.UIP.HW7.LoggerLibrary.Services;
using RJL.UIP.HW7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.Services
{
    public static class AreaCalculator
    {
        private static long CalculateArea(List<Point> points, bool isAltAppr)
        {
            long landArea = 0;
            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i == points.Count - 1) ? 0 : i + 1;
                int prevIndex = (i == 0) ? points.Count - 1 : i - 1;
                long par1 = isAltAppr ? points[i].X : points[i].Y;
                long par2_1 = isAltAppr ? points[nextIndex].Y : points[prevIndex].X;
                long par2_2 = isAltAppr ? points[prevIndex].Y : points[nextIndex].X;
                long tempLandArea = landArea;
                landArea += par1 * (par2_1 - par2_2);
            }
            long result = (long)Math.Abs(landArea / 2);
            return result;
        }

        public static long GetValidatedArea(List<Point> points,Logger logger) {
            logger.Info("Calculating area of input points");
            long resultX = CalculateArea(points,true);
            long resultY = CalculateArea(points, false);
            if (resultX == resultY)
            {
                logger.Info("Square of area is " + resultX);
                return resultX;
            }
            else {
                logger.Error("The result of calculating area is incorrect. ");
                return 0;
            }
        }
    }
}
