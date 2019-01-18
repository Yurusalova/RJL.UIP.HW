using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Worker
    {
        public string Name { get; private set; }
        public string Experience { get; private set; }
        public int Salary { get; private set; }
        public bool isWorkDayEnded { get; set; }

        public Worker(string name, string experience, int salary)
        {
            this.Name = name;
            this.Experience = experience;
            this.Salary = salary;
        }
       public void CarAssembly(Car car, int carNumber)
        {
            if (this.isWorkDayEnded) { return; }
            else
            {
                int workerCapacity = GetWorkerCapacity();
                int leftAssembleDetails = car.GeneralCountDetails - car.CurrentAddedDetails;
                int countDetailsToAssemble = workerCapacity >= leftAssembleDetails ? leftAssembleDetails : workerCapacity;
                car.CurrentAddedDetails += countDetailsToAssemble;
                Logger.LogInfo($"Worker {this.Name} added {countDetailsToAssemble} detail(s) to Car {carNumber}");
            }
        }
        public void PlaneAssembly(Plane plane, int planeNumber)
        {
            if (this.isWorkDayEnded) { return; }
            else
            {
                int workerCapacity = GetWorkerCapacity();
                int leftAssembleDetails = plane.GeneralCountDetails - plane.CurrentAddedDetails;
                int countDetailsToAssemble = workerCapacity >= leftAssembleDetails ? leftAssembleDetails : workerCapacity;
                plane.CurrentAddedDetails += countDetailsToAssemble;
                Logger.LogInfo($"Worker {this.Name} added {countDetailsToAssemble} detail(s) to Plane {planeNumber}");
            }
        }
        public void TankAssembly(Tank tank, int tankNumber)
        {
            if (this.isWorkDayEnded) { return; }
            else
            {
                int workerCapacity = GetWorkerCapacity();
                int leftAssembleDetails = tank.GeneralCountDetails - tank.CurrentAddedDetails;
                int countDetailsToAssemble = workerCapacity >= leftAssembleDetails ? leftAssembleDetails : workerCapacity;
                tank.CurrentAddedDetails += countDetailsToAssemble;
                Logger.LogInfo($"Worker {this.Name} added {countDetailsToAssemble} detail(s) to Tank {tankNumber}");
            }
        }
        public int GetWorkerCapacity()
        {
            int workerCapacity;
            switch (this.Experience)
            {
                case "experienced":
                    workerCapacity = 4;
                    break;
                case "inexperienced":
                    workerCapacity = 1;
                    break;
                case "master":
                    workerCapacity = 5;
                    break;
                default:
                    workerCapacity = 0;
                    break;
            }
            return workerCapacity;
        }
    }
}
