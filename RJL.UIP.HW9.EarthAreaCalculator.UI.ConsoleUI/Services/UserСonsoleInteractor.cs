using RJL.UIP.HW9.EarthAreaCalculator.Core.DI;
using RJL.UIP.HW9.EarthAreaCalculator.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RJL.UIP.HW9.EarthAreaCalculator.UI.ConsoleUI.Services
{
    public class UserСonsoleInteractor
    {
        public ILogger Logger { get; set; }

        private LogHandlerUI LogHandlerUI = new LogHandlerUI();

        public UserСonsoleInteractor()
        {
            Logger = AppContainer.Resolve<ILogger>();
        }

        public void StartMenu(string[] menuiItems, int LevelMenu)
        {
            int indexCommand;
            do
            {
                indexCommand = GetCommandFromOptionMenu(menuiItems);
                if (LevelMenu == 1)
                {
                    ChooseOptionMainMenu(indexCommand);
                }
                else if (LevelMenu == 2)
                {
                    LogHandlerUI.ChooseOptionMenu(indexCommand);
                }
            }
            while (indexCommand != menuiItems.Length - 1);
        }

        private int GetCommandFromOptionMenu(string[] menuItems)
        {
            bool isSuccessResultInput = false;
            int inputIntResult = 0;
            do
            {
                Console.WriteLine("---------------------------NEW COMMAND----------------------------");
                Console.WriteLine("Please write the index of command from the list below. Commands:");
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.WriteLine($"[{i}] = {menuItems[i]}");
                }
                Console.WriteLine("-------------------------------------------------------------------");
                string inputResult = Console.ReadLine();
                bool isSuccessInput = int.TryParse(inputResult, out inputIntResult);
                isSuccessResultInput = isSuccessInput && inputIntResult >= 0 && inputIntResult < menuItems.Length;
            } while (!isSuccessResultInput);
            return inputIntResult;
        }

        private void ChooseOptionMainMenu(int inputIntResult)
        {
            switch (inputIntResult)
            {
                case 0:
                    new AreaCalculatorUI().StartCalculation(Logger);
                    break;
                case 1:
                    string[] menuiItems = new string[] {"show all logs",
                                                "show only info logs",
                                                "show only error logs",
                                                "show logs for today",
                                                "clear file with logs ",
                                                "back to main menu"};
                    StartMenu(menuiItems, 2);
                    break;
                case 2:
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Good bye!");
                    break;
            }
        }
    }
}
