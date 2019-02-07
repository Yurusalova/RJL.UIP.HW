using RJL.UIP.HW8.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces
{
    public interface IPointsValidator
    {
        PointsValidationResult GetPointsValidationResult(List<Point> points);
    }
}
