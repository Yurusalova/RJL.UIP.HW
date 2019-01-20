using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Car:Unit
    {
        public int CountOfDoors { get; }
        public Car(int generalCountDetails, string name):base(generalCountDetails,name)
        {
        }
    }
}
