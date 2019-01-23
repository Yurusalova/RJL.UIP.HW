using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Factory
    {
        public readonly List<Order> Orders = new List<Order>();

        public readonly List<Worker> Workers = new List<Worker>();

        public WorkerManager Manager { get; private set; }

        public string Name { get; private set; }

        public Country Country { get; private set; }

        public Factory(Country country, string name, List<Worker> workers, WorkerManager manager)
        {
            this.Name = name;
            this.Country = country;
            this.Workers = workers;
            this.Manager = manager;
        }

        private void ExecuteWorkingDay()
        {
            if (Orders.Count == 0 || Manager.IsAllOrdersCompleted(Orders)) {
                GetOrdersFromCountry();
            }

            foreach (var worker in this.Workers)
            {
                List<Unit> unitsForWorker = null;
                if(!Manager.TryGetFreeUnitsForWorkerCapacity(worker.WorkerCapacity, out unitsForWorker))
                {
                    Console.Write("Today Factory was stopped because no orders were ready. Please be on time tomorrow at job because today we plan get enough orders");
                    GetOrdersFromCountry();
                    return;
                }
                worker.DoWorkWithUnits(unitsForWorker);
            }
        }

        private void GetOrdersFromCountry() {
            Logger.LogWarning("There is no free orders. Generate the new ones");
            this.Orders.Clear();
            this.Orders.AddRange(Country.GetOrders());
        }

        private void ExecuteWorkingMonth()
        {
            for (int i = 0; i < 30; i++)
            {
                Date2.CountDay = i + 1;
                Logger.LogInfo($"New working day has been started");
                this.ExecuteWorkingDay();
            }
        }

        public void ExecuteWorkingYear()
        {
            Logger.LogInfo("New working year has been started");
            for (int i = 0; i < 12; i++)
            {
                Date2.CountMonth = i + 1;
                Logger.LogInfo($"New working month  has been started");
                this.ExecuteWorkingMonth();
            }
        }

        public void PrintOrders()
        {
            foreach (var order in this.Orders)
            {
                order.PrintOrder();
            }
        }

        public void PrintWorkersTeam()
        {
            Console.WriteLine($"Factory '{Name}' has next workers:");
            Console.WriteLine($"--Manager  {Manager.Name} with salary {Manager.Salary}");
            Console.WriteLine("--Worker's team consists of:");
            for (int i = 0; i < Workers.Count; i++)
            {
                Console.WriteLine($"  {i + 1}.{Workers[i].Name} {Workers[i].Experience} with salary {Workers[i].Salary}");
            }
        }
    }
}
