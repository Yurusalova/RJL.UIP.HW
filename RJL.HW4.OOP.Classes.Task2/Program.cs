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
            Agregat Agregat1 = new Agregat(20);
            Console.WriteLine($"Agregat contains {Agregat1.AgregatCountDetails} details");
            int countJunWorker = 5;
            int countMiddleWorker = 3;
            int countSeniourWorker = 2;
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
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Team consists of:");
            for (int i = 0; i < sumCountWorkers; i++)
            {
                Console.WriteLine(i+1+".  "+workers[i].Name+"   "+ workers[i].Experience);
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Assembly of agregat has been started");
            Console.WriteLine("-----------------------------------------------------");
            int tempCountDetails = 0;
            while (tempCountDetails < Agregat1.AgregatCountDetails) 
            {
                for (int i = 0; i < sumCountWorkers; i++)
                {
                    tempCountDetails = workers[i].GetAgregatAssembly(tempCountDetails, Agregat1.AgregatCountDetails);
                    if (tempCountDetails ==sumCountWorkers)
                    {
                       break;
                    }
                   
                    Console.WriteLine("Current count of assembled details is "+tempCountDetails);
                    
                }
            } 
            Console.ReadLine();
        }

    }

}


