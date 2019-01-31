using RJL.UIP.HW7.LoggerLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.UIP.HW7.Services
{
   public static class InputValidator
    {
        public static int IntegerValueInputValidate(Logger logger)
        {
            int resultIntInput = 0;
            bool isValidInputInt;
            do
            {
                string resultStringInput = Console.ReadLine();
                logger.Info($"value {resultStringInput} was input from Console  ");
                bool isInputInt = int.TryParse(resultStringInput, out int resultIntFromInput);
                isValidInputInt = isInputInt && resultIntFromInput >= 0 && !string.IsNullOrWhiteSpace(resultStringInput);

                if (isValidInputInt)
                {
                    resultIntInput = resultIntFromInput;
                }
                else
                {
                    Console.WriteLine($"=> Invalid number. Repeat input of value");
                    logger.Error("invalid value was inputed from console ");
                }
            } while (!isValidInputInt);

            return resultIntInput;
        }
        public static string YesNoValueInputValidate(Logger logger)
        {
            string resultStringInput = null;
            bool isValidInputInt;
            do
            {
                resultStringInput = Console.ReadLine();
                logger.Info($"value {resultStringInput} was inputed from Console  ");
                isValidInputInt = (resultStringInput=="Y"||resultStringInput == "N") && !string.IsNullOrWhiteSpace(resultStringInput);

                if (!isValidInputInt)
                {
                    Console.WriteLine($"=> Invalid value. Repeat input");
                    logger.Error("invalid value was inputed from console ");
                }
            } while (!isValidInputInt);

            return resultStringInput;
        }
    }
}
