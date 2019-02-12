using RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RJL.UIP.HW8.EarthAreaCalculator.BAL.Services
{
    public class PointsValidator : IPointsValidator
    {
        private ILogger Logger;

        public PointsValidator(ILogger logger)
        {
            Logger = logger;
        }

        public PointsValidationResult GetPointsValidationResult(List<Point> points)
        {
            bool IsPointsValid = true;
            List<PointsMistakesType> PointsMistakes = new List<PointsMistakesType>();
            for (int i = 0; i < points.Count(); i++)
            {
                for (int j = 1; j < points.Count(); j++)
                {
                    if (i == j) {
                        break;
                    }
                    if (points[i] == points[j]) {
                        IsPointsValid = false;
                        PointsMistakes.Add(PointsMistakesType.RepeatedPoints);
                        break;
                    }
                }
            }
            if (IsPointsValid)
            {
                Logger.Info($"[{this.GetType().Name}]: Points are Valid");
            }
            else
            {
                Logger.Warn($"[{this.GetType().Name}]: Points are not Valid");
            }
            return new PointsValidationResult() { IsPointsValid = IsPointsValid, PointsMistakes= PointsMistakes };
        }

    }
}
