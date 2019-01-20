using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Plane : Unit
    {
        public int CountEngines {get;}
        public Plane(int generalCountDetails,string name):base(generalCountDetails, name)
        {
        }
    }
}
