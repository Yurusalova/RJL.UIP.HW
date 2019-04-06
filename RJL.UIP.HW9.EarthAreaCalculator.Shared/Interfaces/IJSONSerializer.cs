using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW9.EarthAreaCalculator.Shared.Interfaces
{
    public interface IJSONSerializer
    {
        T Deserialize<T>(string text);

        string Serialize<T>(T obj);
    }
}
