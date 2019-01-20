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
            RecruitmentCompany recruitmentCompany = new RecruitmentCompany() {Name="Golden Staff"};
            List<Worker> workers = recruitmentCompany.GetWorkers(2,2,2);
            WorkerManager manager = new WorkerManager("Manager_Name", "manager", 5000);
            Factory factory = new Factory(Ukraine, "Arsenal", workers, manager);
            factory.PrintWorkersTeam();
            factory.ExecuteWorkingYear();
            Console.ReadLine();
        }
    }
}

