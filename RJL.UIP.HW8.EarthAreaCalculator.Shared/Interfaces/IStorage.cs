using RJL.UIP.HW8.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces
{
    public interface IStorage
    {
        void AddMessage(List<LogRecord> logRecord, int ColorNumber);
        List<LogRecord> LoadLogs();
        void CreateNewFile();
        string GetLogsByType(String type);
        string GetLogsByDate(DateTime date);
    }
}
