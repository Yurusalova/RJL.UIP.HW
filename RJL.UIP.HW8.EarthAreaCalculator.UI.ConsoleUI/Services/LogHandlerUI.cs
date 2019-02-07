using RJL.UIP.EarthAreaCalculator.Core.DI;
using RJL.UIP.HW8.EarthAreaCalculator.BAL.Services;
using RJL.UIP.HW8.EarthAreaCalculator.DAL.Services;
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces;
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RJL.UIP.HW8.EarthAreaCalculator.UI.ConsoleUI.Services
{
    internal class LogHandlerUI
    {
        public ILogHandler LogHandler;

        public void StartMenu()
        {
            string[] menuiItems = new string[] {"show all logs",
                                                "show only info logs",
                                                "show only error logs",
                                                "show logs for today",
                                                "clear file with logs ",
                                                "back to main menu"};
            int indexCommand;
            do
            {
                indexCommand = GetCommandFromOptionMenu(menuiItems);
                ChooseOptionMenu(indexCommand);
            }
            while (indexCommand != 5);
        }

        public LogHandlerUI()
        {
            LogHandler = AppContainer.Resolve<ILogHandler>();
        }

        private int GetCommandFromOptionMenu(string[] menuItems)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Please write the index of command from the list below. Commands:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"[{i}] = {menuItems[i]}");
            }
            Console.WriteLine("-----------------------------------------------------------------");
            string inputResult = Console.ReadLine();
            int inputIntResult;
            bool isSuccessInput = int.TryParse(inputResult, out inputIntResult);
            return inputIntResult;
        }

        private void ChooseOptionMenu(int inputIntResult)
        {
            switch (inputIntResult)
            {
                case 0:
                    PrintLogs(LogHandler.ShowAllLogs());
                    break;
                case 1:
                    PrintLogsByType(LogLevel.Info);
                    break;
                case 2:
                    PrintLogsByType(LogLevel.Error);
                    break;
                case 3:
                    Console.WriteLine("this function was not provided yet");
                    break;
                case 4:
                    LogHandler.ClearAllLogs();
                    Console.WriteLine("File was cleared");
                    break;
                case 5:
                    break;
            }
        }

        private void PrintLogs(List<LogRecord> logrecords) {
            if (logrecords == null) {
                Console.WriteLine("Log file is empty");
                return;
            }
            foreach (var logrecord in logrecords)
            {
                int colorNum = logrecord.GetLogRecordColorByLogLevel(logrecord.LogLevel);
                Console.BackgroundColor = (ConsoleColor)colorNum;
                Console.WriteLine(logrecord.ToString());
            }
            Console.BackgroundColor = 0;
        }

        private void PrintLogsByType(LogLevel logLevel) {
            List<LogRecord> logrecords = LogHandler.ShowAllLogs();
            var selectedLogRecords = from t in logrecords 
                                where t.LogLevel.Equals(logLevel) 
                                select t;
             PrintLogs(selectedLogRecords.ToList());
        }
    }
}