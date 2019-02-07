using RJL.UIP.EarthAreaCalculator.Core.DI;
using RJL.UIP.HW8.EarthAreaCalculator.BAL.Services;
using RJL.UIP.HW8.EarthAreaCalculator.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RJL.UIP.HW8.EarthAreaCalculator.UI.ConsoleUI.Services
{
    public class UserСonsoleInteractor
    {
        public ILogger Logger { get; set; }

        public UserСonsoleInteractor()
        {
           Logger = AppContainer.Resolve<ILogger>();
        }

        public void StartMainMenu()
        {
            string[] menuiItems = new string[] {"start new calculation area",
                                                "view logs",
                                                "clear console",
                                                "quit"};
            int indexCommand;
            do
            {
                indexCommand = GetCommandFromOptionMenu(menuiItems);
                ChooseOptionMenu(indexCommand);
            }
            while (indexCommand != 3);
        }

        private int GetCommandFromOptionMenu(string[] menuItems)
        {
            Console.WriteLine("---------------------------NEW COMMAND----------------------------");
            Console.WriteLine("Please write the index of command from the list below. Commands:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"[{i}] = {menuItems[i]}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
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
                    new AreaCalculatorUI().StartCalculation(Logger);
                    break;
                case 1:
                    new LogHandlerUI().StartMenu();
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
