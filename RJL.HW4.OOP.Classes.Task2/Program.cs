using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW4.OOP.Classes.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Agregat Agregat1 = new Agregat(10);
            Console.WriteLine($"Agregat contains {Agregat1.AgregatCountDetails} details");
            
            Worker worker1 = new Worker("experienced");
            int worker1CountDetailPerDay = worker1.GetWorkerCountDetailsPerDay(worker1.WorkerExperience);
            decimal worker1CountDaysForAssembly = Agregat1.getCountDaysForAssembly(Agregat1.AgregatCountDetails, worker1CountDetailPerDay);
            Console.WriteLine($"Worker1 is {worker1.WorkerExperience}. He will assembly aggregate for  {worker1CountDaysForAssembly} days");
            Worker worker2 = new Worker("inexperienced");
            int worker2CountDetailPerDay = worker1.GetWorkerCountDetailsPerDay(worker2.WorkerExperience);
            decimal worker2CountDaysForAssembly = Agregat1.getCountDaysForAssembly(Agregat1.AgregatCountDetails, worker2CountDetailPerDay);
            Console.WriteLine($"Worker2 is {worker2.WorkerExperience}. He will assembly aggregate for  {worker2CountDaysForAssembly} days");
            Worker worker3 = new Worker("master");
            int worker3CountDetailPerDay = worker3.GetWorkerCountDetailsPerDay(worker3.WorkerExperience);
            decimal worker3CountDaysForAssembly = Agregat1.getCountDaysForAssembly(Agregat1.AgregatCountDetails, worker3CountDetailPerDay);
            Console.WriteLine($"Worker3 is {worker3.WorkerExperience}. He will assembly aggregate for  {worker3CountDaysForAssembly} days");
            Console.ReadLine();
         }
    }
    class Worker
    {
        public string WorkerExperience;
        public Worker(string workerExperience)
        {
            this.WorkerExperience = workerExperience;
        }
        public int GetWorkerCountDetailsPerDay(string workerExperience)
        {
            int workerCountDetailsPerDay = 0;
            switch (workerExperience)
            {
                case "experienced":
                    workerCountDetailsPerDay = 3;
                break;
                case "inexperienced":
                    workerCountDetailsPerDay = 1;
                break;
                case "master":
                    workerCountDetailsPerDay = 5;
                break;
                default:
                    workerCountDetailsPerDay = 0;
                break;
        }
            return workerCountDetailsPerDay;
        }
       
    }
}
    class Agregat
{
    public int AgregatCountDetails;
    public Agregat(int agregatCountDetails)
    {
        this.AgregatCountDetails = agregatCountDetails;
    }
    public decimal getCountDaysForAssembly(int agregatCountDetails, int countDetailsPerDay)
    {
        decimal temp = agregatCountDetails/countDetailsPerDay;
        decimal countDaysForAssembly = Math.Ceiling(temp);
        return countDaysForAssembly;
    }
 }

