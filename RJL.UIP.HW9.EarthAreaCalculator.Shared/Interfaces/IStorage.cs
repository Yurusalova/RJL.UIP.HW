using RJL.UIP.HW9.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW9.EarthAreaCalculator.Shared.Interfaces
{
    public interface IStorage
    {
        void AddMessageToStorage(List<LogRecord> logRecord, int ColorNumber);
        List<LogRecord> GetAllLogs();
        void ClearAllLogs();
        string GetLogsByType(String type);
        string GetLogsByDate(DateTime date);
    }
}
