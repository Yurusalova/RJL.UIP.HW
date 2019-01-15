using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW5.OOP.Classes.Factory
{
     class Logger
    {
        public static  int CountLogInfo { get; set; }
        public static int CountLogWarning { get; set; }
        public static void LogInfo(string message ) {
            Console.WriteLine($"{CountLogInfo}. Info: {DateTime.Today} {message}");
        }
        public static void LogWarning(string message)
        {
            Console.WriteLine($"{CountLogWarning}. Warning: {DateTime.Today} {message}");
        }
    }
}
