using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Country
    {
        public int OrderCounter { get; private set;} = 0;

        public  List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            int OrderLength=1;
            int index = 0;
            do
            {
                this.OrderCounter++;
                orders.Add(new Order(this.OrderCounter, 2, 3, 4));
                orders[index].FillOrder();
                OrderLength++;
                index++;
            }
            while (OrderLength <= 7);
            return orders;
        }
    }
}
