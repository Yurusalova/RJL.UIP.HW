using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Factory
    {

        public List<Order> Orders = new List<Order>();

        public List<Worker> Workers = new List<Worker>();

        public string Name { get; private set; }
        public Country Country { get; private set; }

        public Factory(Country country, string name)
        {
            this.Name = name;
            this.Country = country;
        }

        private void ExecuteWorkingDay()
        {
            
            if (this.Orders.Count == 0)
            {
                Logger.LogWarning("There is no free orders. Generate the new ones");
                Logger.CountLog += 1;
                this.Orders.AddRange(Country.GetOrders());
            }
            foreach (var order in this.Orders)
            {
                if (order.isOrderCompleted)
                {
                    Logger.LogInfo($"Order number {order.Number} is completed");
                    Logger.CountLog += 1;
                    ;
                 }
                else
                {
                    if (isWorkingDayEnded())
                    {
                        return;
                    }
                    Logger.LogInfo("Start/continue working on order number " + order.Number);
                    Logger.CountLog += 1;
                    if (order.isCarsInOrderAssembled()==false)
                    {
                        CarsInOrderAssembly(order);
                            }
                    if (order.isPlanesInOrderAssembled()==false)
                    {
                        PlanesInOrderAssembly(order);
                    }
                    if (order.isTanksInOrderAssembled()==false)
                    {
                        TanksInOrderAssembly(order);
                    }
               
                }

               
            }
            if (isAllOrdersCompleted()) {
                this.Orders.Clear();
            }
        }
        private void CarsInOrderAssembly( Order order) {
            int carCounter = 1;
            foreach (var car in order.Cars)
            {
                foreach (var worker in this.Workers)
                {
                    if (car.isReady)
                    {
                        Console.WriteLine("----------------------------------------------------------");
                        Logger.LogInfo($"Car {carCounter} has been assembled");
                        Logger.CountLog += 1;
                        Logger.LogInfo($"General count of assembled details in car {carCounter} is {car.CurrentAddedDetails}");
                        Console.WriteLine("----------------------------------------------------------");
                        Logger.CountLog += 1;
                        break;
                    }
                    else
                    {
                        worker.CarAssembly(car, carCounter);
                    }
                    worker.isWorkDayEnded = true;

                }
                carCounter++;
            }
        }
        private void PlanesInOrderAssembly(Order order)
        {
            int planeCounter = 1;
            foreach (var plane in order.Planes)
            {
                foreach (var worker in this.Workers)
                {

                    if (plane.isReady)
                    {
                        Console.WriteLine("----------------------------------------------------------");
                        Logger.LogInfo($"Plane {planeCounter} has been assembled");
                        Logger.CountLog += 1;

                        Logger.LogInfo($"General count of assembled details in plane {planeCounter} is {plane.CurrentAddedDetails}");

                        Console.WriteLine("----------------------------------------------------------");
                        Logger.CountLog += 1;
                        break;
                    }
                    else
                    {
                        worker.PlaneAssembly(plane, planeCounter);
                    }
                    worker.isWorkDayEnded = true;

                }
                planeCounter++;
            }
        }
        private void TanksInOrderAssembly( Order order) {
            int tankCounter = 1;
            foreach (var tank in order.Tanks)
            {
                foreach (var worker in this.Workers)
                {

                    if (tank.isReady)
                    {
                        Console.WriteLine("----------------------------------------------------------");
                        Logger.LogInfo($"Tank {tankCounter} has been assembled");
                        Logger.CountLog += 1;
                        Logger.LogInfo($"General count of assembled details in tank {tankCounter} is {tank.CurrentAddedDetails}");
                        Console.WriteLine("----------------------------------------------------------");
                        Logger.CountLog += 1;
                        break;
                    }
                    else
                    {
                        worker.TankAssembly(tank, tankCounter);
                    }
                        worker.isWorkDayEnded = true;
                    

                }
                tankCounter++;
            }
        }

        private void ExecuteWorkingMonth()
        {

            for (int i = 0; i < 30; i++)
            {
                Logger.CountDay = i + 1;
                Console.WriteLine("-----------------------------------------------------");
                Logger.LogInfo($"New working day has been started");
                Logger.CountLog += 1;
                Console.WriteLine("-----------------------------------------------------");
                this.ExecuteWorkingDay();
                StartNewWorkDay();

            }
        }

        public void ExecuteWorkingYear()
        {
            Console.WriteLine("-----------------------------------------------------");
            Logger.LogInfo("New working year has been started");
            Logger.CountLog += 1;
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < 12; i++)
            {
                Logger.CountMonth = i+1;
                Console.WriteLine("-----------------------------------------------------");
                Logger.LogInfo($"New working month  has been started");
                Logger.CountLog += 1;
                Console.WriteLine("-----------------------------------------------------");
                this.ExecuteWorkingMonth();
            }
        }
        public void PrintWorkersTeam(List<Worker> workersTeam)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Team consists of:");
            for (int i = 0; i < workersTeam.Count; i++)
            {
                Console.WriteLine(i + 1 + ".  " + workersTeam[i].Name + "   " + workersTeam[i].Experience);
            }
            Console.WriteLine("-----------------------------------------------------");
        }
        public void PrintOrders(List<Order> orders)
        {
            foreach (var order in orders)
            {
                order.PrintOrder();
            }
        }
        public List<Worker> GetWorkers(int countJunWorker, int countMiddleWorker, int countSeniourWorker)
        {
            int indexJunName = 1;
            int indexMidName = 1;
            int indexSenName = 1;
            int sumCountWorkers = countJunWorker + countMiddleWorker + countSeniourWorker;
            List<Worker> workers = new List<Worker>();
            //fill part of collection with JunWorkers
            for (int i = 0; i < countJunWorker; i++)
            {
                workers.Add(new Worker("JunWorkerName_" + indexJunName, "inexperienced", 1000));
                indexJunName++;
            }
            //fill part of collection with MiddleWorker
            for (int i = countJunWorker; i < countMiddleWorker + countJunWorker; i++)
            {
                workers.Add(new Worker("MiddleWorkerName_" + indexMidName, "experienced", 2000));
                indexMidName++;
            }
            //fill part of collection with SeniourWorkers
            for (int i = countMiddleWorker + countJunWorker; i < sumCountWorkers; i++)
            {
                workers.Add(new Worker("SeniourWorkerName_" + indexSenName, "master", 3000));
                indexSenName++;
            }
            return workers;
        }
        public void StartNewWorkDay() {
            foreach (var worker in this.Workers)
            {
                worker.isWorkDayEnded = false;
            }
        }
        public bool isWorkingDayEnded() {
            int workerCounter = 0;
            foreach (var worker in this.Workers)
            {if (worker.isWorkDayEnded)
                {
                    workerCounter++;
                }
            }
            if (workerCounter == Workers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isAllOrdersCompleted()
        { foreach (var order in this.Orders)
            {
                if (order.isOrderCompleted == false) {
                    return false;
                }
            }
            return true;
        } 

	}
}
