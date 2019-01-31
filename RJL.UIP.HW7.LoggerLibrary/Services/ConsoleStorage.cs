using RJL.UIP.HW7.LoggerLibrary.Interfaces;
using RJL.UIP.HW7.LoggerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.LoggerLibrary.Services
{

    public class ConsoleStorage : IStorage
    {
        public void AddMessage(LogRecord logRecord)
        {
            Console.WriteLine("ConsoleStorage " + logRecord.ToString());
        }
    }
}
