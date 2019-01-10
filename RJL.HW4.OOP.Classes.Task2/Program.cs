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
            Agregat Agregat1 = new Agregat(25,0);
            Console.WriteLine($"Agregat contains {Agregat1.GeneralCountDetails} details");
            Console.WriteLine("-----------------------------------------------------");
            Worker[] workers1 = GetWorkers(5, 4, 3);
            Console.WriteLine("Team consists of:");
            PrintWorkersTeam(workers1);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Assembly of agregat has been started");
            Console.WriteLine("-----------------------------------------------------");
            AssemleAgregat(Agregat1, workers1);
            Console.ReadLine();
        }
        static Worker[] GetWorkers(int countJunWorker, int countMiddleWorker, int countSeniourWorker)
        {
            int indexJunName = 1;
            int indexMidName = 1;
            int indexSenName = 1;
            int sumCountWorkers = countJunWorker + countMiddleWorker + countSeniourWorker;
            Worker[] workers = new Worker[sumCountWorkers];
            //fill part of array with JunWorkers
            for (int i = 0; i < countJunWorker; i++)
            {
                workers[i] = new Worker("JunWorkerName_" + indexJunName, "inexperienced");
                indexJunName++;
            }
            //fill part of array with MiddleWorker
            for (int i = countJunWorker; i < countMiddleWorker + countJunWorker; i++)
            {
                workers[i] = new Worker("MiddleWorkerName_" + indexMidName, "experienced");
                indexMidName++;
            }
            //fill part of array with SeniourWorkers
            for (int i = countMiddleWorker + countJunWorker; i < sumCountWorkers; i++)
            {
                workers[i] = new Worker("SeniourWorkerName_" + indexSenName, "master");
                indexSenName++;
            }
            return workers;
        }
        static void AssemleAgregat(Agregat agregate, Worker[] workersTeam)
        {
            while (agregate.CurrentAssembledDetails < agregate.GeneralCountDetails)
            {
                for (int i = 0; i < workersTeam.Length; i++)
                {
                    workersTeam[i].AgregatAssembly(agregate);
                    if (agregate.IsAgregateAssambled())
                    {
                        Console.WriteLine("General count of assembled details is " + agregate.CurrentAssembledDetails);
                        break;
                    }
                    Console.WriteLine("Current count of assembled details is " + agregate.CurrentAssembledDetails);

                }
            }
        }
        static void PrintWorkersTeam(Worker[] workersTeam)
        {
            for (int i = 0; i < workersTeam.Length; i++)
            {
                Console.WriteLine(i + 1 + ".  " + workersTeam[i].Name + "   " + workersTeam[i].Experience);
            }
        }

    }

}


