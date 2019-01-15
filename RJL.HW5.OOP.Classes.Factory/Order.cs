using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Order
    {
        public List<Car> Cars = new List<Car>();
        public bool isOrderCompleted
        {
            get
            {
                foreach (var car in this.Cars)
                {
                    if (car.isReady)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
