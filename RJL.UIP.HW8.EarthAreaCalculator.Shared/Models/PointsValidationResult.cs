using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW8.EarthAreaCalculator.Shared.Models
{
    public class PointsValidationResult
    {
        public bool IsPointsValid { get; set; }

        public List<PointsMistakesType> PointsMistakes { get; set; }
    }

    public enum PointsMistakesType
    {
        RepeatedPoints = 10,
        NotClosedShape = 20,
    }
}
