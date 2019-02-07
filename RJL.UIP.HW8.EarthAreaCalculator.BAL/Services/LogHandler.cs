using RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW8.EarthAreaCalculator.BAL.Services
{
   public class LogHandler:ILogHandler
    {
        private IFileStorage FileStorage;

        public LogHandler(IFileStorage fileStorage) {
            FileStorage = fileStorage;
        }
        public List<LogRecord> ShowAllLogs() {
            return FileStorage.LoadLogs();
        }

        public void ClearAllLogs() {
            FileStorage.CreateNewFile();
        }
    }
}
