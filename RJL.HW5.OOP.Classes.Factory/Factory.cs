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
        public Order CurrentFreeOrder { get; private set; }
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
            foreach (var worker in this.Workers)
            {
                if (CurrentFreeOrder == null)
                {
                    Logger.LogWarning("There is no free orders. Generate the new ones");
                    this.Orders.Clear();
                    Logger.LogWithoutDate("----------------------------------------------------------");
                    this.Orders.AddRange(Country.GetOrders());
                    PrintOrders();
                    CurrentFreeOrder = Orders[0];
                    Logger.LogWithoutDate("----------------------------------------------------------");
                }
                if (isWorkingDayEnded())
                {
                    break;
                }
                Unit currentFreeUnit = Manager.GetFreeUnitfromOrder(this.CurrentFreeOrder);
                if (currentFreeUnit != null)
                {
                    worker.UnitAssembly(currentFreeUnit);
                }
                if (CurrentFreeOrder != Manager.GetFreeOrder(Orders))
                {
                    Logger.LogWithoutDate("----------------------------------------------");
                    Logger.LogInfo($"Order number {CurrentFreeOrder.Number} is completed");
                    Logger.LogWithoutDate("----------------------------------------------");

                    CurrentFreeOrder = Manager.GetFreeOrder(Orders);
                    if (CurrentFreeOrder != null)
                    {
                        Logger.LogWithoutDate("----------------------------------------------");
                        Logger.LogInfo($"Start working on order number {CurrentFreeOrder.Number}");
                        Logger.LogWithoutDate("----------------------------------------------");
                    }
                }
            }
        }
    private void ExecuteWorkingMonth()
    {
        for (int i = 0; i < 30; i++)
        {
            Date2.CountDay = i + 1;
            Logger.LogWithoutDate("-----------------------------------------------------");
            Logger.LogInfo($"New working day has been started");
            Logger.LogWithoutDate("-----------------------------------------------------");
            this.ExecuteWorkingDay();
            StartNewWorkDay();
        }
    }
    public void ExecuteWorkingYear()
    {
        Logger.LogWithoutDate("-----------------------------------------------------");
        Logger.LogInfo("New working year has been started");
        Logger.LogWithoutDate("-----------------------------------------------------");
        for (int i = 0; i < 12; i++)
        {
            Date2.CountMonth = i + 1;
            Logger.LogWithoutDate("-----------------------------------------------------");
            Logger.LogInfo($"New working month  has been started");
            Logger.LogWithoutDate("-----------------------------------------------------");
            this.ExecuteWorkingMonth();
        }
    }
    public void StartNewWorkDay()
    {
        foreach (var worker in this.Workers)
        {
            worker.isWorkDayEnded = false;
        }
    }
    public bool isWorkingDayEnded()
    {
        int workerCounter = 0;
        foreach (var worker in this.Workers)
        {
            if (worker.isWorkDayEnded)
            {
                workerCounter++;
            }
        }
        return workerCounter == Workers.Count;

    }
    public bool isAllOrdersCompleted()
    {
        foreach (var order in this.Orders)
        {
            if (order.isOrderCompleted == false)
            {
                return false;
            }
        }
        return true;
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
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Factory '{Name}' has next workers:");
            Console.WriteLine($"--Manager  {Manager.Name} with salary {Manager.Salary}");
            Console.WriteLine("--Worker's team consists of:");
            for (int i = 0; i < Workers.Count; i++)
            {
                Console.WriteLine($"  {i + 1}.{Workers[i].Name} {Workers[i].Experience} with salary {Workers[i].Salary}");
            }
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
