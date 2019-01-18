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

        public string Name { get; private set; }
        public Country Country { get; private set; }

        public Factory(Country country, string name, List<Worker> workers)
        {
            this.Name = name;
            this.Country = country;
            this.Workers = workers;
        }
        private void ExecuteWorkingDay()
        {
            if (this.Orders.Count == 0)
            {
                Logger.LogWarning("There is no free orders. Generate the new ones");
                Logger.LogWithoutDate("----------------------------------------------------------");
                this.Orders.AddRange(Country.GetOrders());
                PrintOrders();
                Logger.LogWithoutDate("----------------------------------------------------------");
            }
            if (isAllOrdersCompleted())
            {
                this.Orders.Clear();
            }
            foreach (var worker in this.Workers)
            {
                foreach (var order in this.Orders)
                {
                    if (!order.isOrderCompleted)
                    {
                        if (isWorkingDayEnded())
                        {
                            break;
                        }
                        //Logger.LogInfo("Start/continue working on order number " + order.Number);
                        //Logger.CountLog += 1;
                        if (!order.isCarsInOrderAssembled())
                        {
                            CarsInOrderAssembly(order, worker);
                        }
                        if (order.isOrderCompleted)
                        {
                            Logger.LogInfo($"Order number {order.Number} is completed");
                        }
                        if (worker.isWorkDayEnded)
                        {
                            break;
                        }
                        if (!order.isPlanesInOrderAssembled())
                        {
                            PlanesInOrderAssembly(order, worker);
                        }
                        if (order.isOrderCompleted)
                        {
                            Logger.LogInfo($"Order number {order.Number} is completed");
                        }
                        if (worker.isWorkDayEnded)
                        {
                            break;
                        }
                        if (!order.isTanksInOrderAssembled())
                        {
                            TanksInOrderAssembly(order, worker);
                        }
                        if (order.isOrderCompleted)
                        {
                            Logger.LogInfo($"Order number {order.Number} is completed");
                        }
                    }
                }
            }
        }
        private void CarsInOrderAssembly(Order order, Worker worker)
        {
            int carCounter = 1;
            foreach (var car in order.Cars)
            {
                if (!car.IsReady)
                {
                    worker.CarAssembly(car, carCounter);
                    worker.isWorkDayEnded = true;
                    if (car.IsReady)
                    {
                        Logger.LogWithoutDate("----------------------------------------------------------");
                        Logger.LogInfo($"Car {carCounter} in order {order.Number} has been assembled");
                        Logger.LogInfo($"General count of assembled details in car {carCounter} is {car.CurrentAddedDetails}");
                        Logger.LogWithoutDate("----------------------------------------------------------");
                    }
                }
                carCounter++;
            }
    }
    private void PlanesInOrderAssembly(Order order, Worker worker)
    {
        int planeCounter = 1;
        foreach (var plane in order.Planes)
        {
            if (!plane.IsReady)
            {
                worker.PlaneAssembly(plane, planeCounter);
                worker.isWorkDayEnded = true;
               if (plane.IsReady)
                {
                    Logger.LogWithoutDate("----------------------------------------------------------");
                    Logger.LogInfo($"Plane {planeCounter} in order {order.Number} has been assembled");
                    Logger.LogInfo($"General count of assembled details in plane {planeCounter} is {plane.CurrentAddedDetails}");
                    Logger.LogWithoutDate("----------------------------------------------------------");
                }
            }
            planeCounter++;
        }
    }
    private void TanksInOrderAssembly(Order order, Worker worker)
    {
        int tankCounter = 1;
        foreach (var tank in order.Tanks)
        {
            if (!tank.IsReady)
            {
                worker.TankAssembly(tank, tankCounter);
                worker.isWorkDayEnded = true;
                if (tank.IsReady)
                {
                    Logger.LogWithoutDate("----------------------------------------------------------");
                    Logger.LogInfo($"Tank {tankCounter} in order {order.Number} has been assembled");
                    Logger.LogInfo($"General count of assembled details in tank {tankCounter} is {tank.CurrentAddedDetails}");
                    Logger.LogWithoutDate("----------------------------------------------------------");
                }
            }
            tankCounter++;
        }
    }
    private void ExecuteWorkingMonth()
    {
        for (int i = 0; i < 30; i++)
        {
            Date.CountDay = i + 1;
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
            Date.CountMonth = i + 1;
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
    }
}
