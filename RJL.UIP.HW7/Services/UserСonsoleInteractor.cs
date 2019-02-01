using RJL.UIP.HW7.LoggerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.Services
{
    public static class UserСonsoleInteractor
    {
        public static int GetPositiveIntValueFromConsoleInput(Logger logger)
        {
            int resultIntInput = 0;
            bool isValidInputInt;
            do
            {
                string resultStringInput = Console.ReadLine();
                logger.Info($"value {resultStringInput} was input from Console  ");
                bool isInputInt = int.TryParse(resultStringInput, out int resultIntFromInput);
                isValidInputInt = isInputInt && resultIntFromInput > 0;
                if (isValidInputInt)
                {
                    resultIntInput = resultIntFromInput;
                }
                else
                {
                    logger.Error("invalid value was inputed from console ");
                    Console.WriteLine($"--Invalid number. Repeat input of value");
                }
            } while (!isValidInputInt);
            return resultIntInput;
        }
    }
}
