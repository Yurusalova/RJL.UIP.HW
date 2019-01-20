using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Tank:Unit
    {
        public int DistanceShhoter { get; }

        public Tank(int generalCountDetails,string name):base(generalCountDetails, name)
        {
        }
    }
}
