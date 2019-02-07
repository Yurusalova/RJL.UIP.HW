﻿using RJL.UIP.HW8.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces
{
   public interface ILogHandler
    {
        List<LogRecord> ShowAllLogs();
        void ClearAllLogs();
    }
}
