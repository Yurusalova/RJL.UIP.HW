using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class WorkerManager:Worker
    {
        public WorkerManager(string name, string experience, int salary) : base(name, experience, salary) {
        }

        public Unit GetFreeUnitfromOrder( Order currentFreeOrder)
        {
              foreach (var unit in currentFreeOrder.Units)
                    {
                        if (!unit.IsReady)
                        {
                            return unit;
                        }
                        else
                        {
                            continue;
                        }
                    }
            return null;
        }
        public Order GetFreeOrder(List<Order> orders)
        {
            foreach (var order in orders)
            {
                if (!order.isOrderCompleted)
                {
                    return order;
                 }
                else
                {
                     {
                        continue;
                    }
                }
            }
            return null;
        }
    }
}
