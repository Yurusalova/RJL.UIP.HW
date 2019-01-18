using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Country Ukraine = new Country();
            List<Worker> workers = GetWorkers(4, 3, 3);
            Factory factory = new Factory(Ukraine, "Arsenal", workers);
            PrintWorkersTeam(factory.Workers);
            factory.ExecuteWorkingYear();
            Console.ReadLine();
        }
        static void PrintWorkersTeam(List<Worker> workersTeam)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Team consists of:");
            for (int i = 0; i < workersTeam.Count; i++)
            {
                Console.WriteLine(i + 1 + ".  " + workersTeam[i].Name + "   " + workersTeam[i].Experience);
            }
            Console.WriteLine("-----------------------------------------------------");
        }
        static List<Worker> GetWorkers(int countJunWorker, int countMiddleWorker, int countSeniourWorker)
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
        
    }
}

