using RJL.UIP.HW7.LoggerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.LoggerLibrary.Interfaces
{
    public interface IStorage
    {
        void AddMessage(LogRecord logRecord);
    }
}
