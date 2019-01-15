using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Country
    {
        public static List<Order> GetOrders()
        {
            return new List<Order>() { new Order() };
        }
    }
}
