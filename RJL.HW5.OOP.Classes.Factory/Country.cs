using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Country
    {
        public static int OrderCounter=0;
        public static List<Order> GetOrders(Car car, Plane plane, Tank tank)
        {
            Order order = new Order(OrderCounter, 2, 2, 2);
            order.FillOrder(car, plane, tank);
            return new List<Order>() { order };
        }
    }
}
