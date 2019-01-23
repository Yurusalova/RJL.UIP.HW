using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
    class RecruitmentCompany
    {
        public string Name { get; set; }

        public List<Worker> GetWorkers(int countJunWorker, int countMiddleWorker, int countSeniourWorker)
        {
            int sumCountWorkers = countJunWorker + countMiddleWorker + countSeniourWorker;
            List<Worker> workers = new List<Worker>();
            for (int i = 0; i < countJunWorker; i++)
            {
                workers.Add(new Worker("JunWorkerName_" + (i + 1).ToString(), "inexperienced", 1000));
            }
            for (int i = countJunWorker; i < countMiddleWorker + countJunWorker; i++)
            {
                workers.Add(new Worker("MiddleWorkerName_" + (i + 1).ToString(), "experienced", 2000));
            }
            for (int i = countMiddleWorker + countJunWorker; i < sumCountWorkers; i++)
            {
                workers.Add(new Worker("SeniourWorkerName_" + (i + 1).ToString(), "master", 3000));
            }
            return workers;
        }
    }
}
