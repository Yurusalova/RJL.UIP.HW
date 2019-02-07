using RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW8.EarthAreaCalculator.DAL.Services
{

    public class ConsoleStorage : IConsoleStorage
    {
        public void AddMessage(List<LogRecord> logRecords, int colorNumber)
        {
            foreach (var logRecord in logRecords)
            {
                Console.BackgroundColor = (ConsoleColor)colorNumber;
                Console.WriteLine("ConsoleStorage " + logRecord.ToString());
                Console.BackgroundColor = 0;
            }
        }

        public List<LogRecord> LoadLogs()
        {
            return null;
        }

        public void CreateNewFile()
        {
        }

        public string GetLogsByType(String type)
        {
            return "";
        }

        public string GetLogsByDate(DateTime date)
        {
            return "";
        }
    }
}
