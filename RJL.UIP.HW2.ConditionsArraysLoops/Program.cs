using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW2.ConditionsArraysLoops.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            if (false)
            { //task1.Дано целое число A. Проверить истинность высказывания: «Число A является положительным».
                int randomIntValueATask1 = randomizer.Next(-50, 50);
                bool resultTask1 = randomIntValueATask1 > 0;
                Console.WriteLine("Task1");
                Console.WriteLine("Number A is: " + randomIntValueATask1);
                Console.WriteLine("Number A is greater than 0: " + resultTask1);
                Console.WriteLine();
            }
            if (false)
            {//task2.Дано целое число A. Проверить истинность высказывания: «Число A является нечетным».
                int randomIntValueATask2 = randomizer.Next(-50, 50);
                bool resultTask2 = randomIntValueATask2 % 2 != 0;
                Console.WriteLine("Task2");
                Console.WriteLine("Number A is: " + randomIntValueATask2);
                Console.WriteLine("Number A is odd: " + resultTask2);
                Console.WriteLine();
            }
            if (false)
            {//task3.Даны три целых числа: A, B, C. Проверить истинность высказывания: «Справедливо двойное неравенство A < B < C».
                int randomIntValueATask3 = randomizer.Next(-50, 50);
                int randomIntValueBTask3 = randomizer.Next(-50, 50);
                int randomIntValueCTask3 = randomizer.Next(-50, 50);
                bool resultTask3 = randomIntValueATask3 < randomIntValueBTask3 && randomIntValueBTask3 < randomIntValueCTask3;
                Console.WriteLine("Task3");
                Console.WriteLine("Number A is: " + randomIntValueATask3 + ", number B is: " + randomIntValueBTask3 + ", number C is: " + randomIntValueCTask3);
                Console.WriteLine("A<B<C: " + resultTask3);
                Console.WriteLine();
            }
            if (false)
            {//task4.Даны три целых числа: A, B, C. Проверить истинность высказывания: «Хотя бы одно из чисел A, B, C положительное»..
                int randomIntValueATask4 = randomizer.Next(-50, 50);
                int randomIntValueBTask4 = randomizer.Next(-50, 50);
                int randomIntValueCTask4 = randomizer.Next(-50, 50);
                bool resultTask4 = randomIntValueATask4 > 0 || randomIntValueBTask4 > 0 || randomIntValueCTask4 > 0;
                Console.WriteLine("Task4");
                Console.WriteLine("Number A is: " + randomIntValueATask4 + ", number B is: " + randomIntValueBTask4 + ", number C is: " + randomIntValueCTask4);
                Console.WriteLine("A or B or C is greater than 0: " + resultTask4);
                Console.WriteLine();
            }
            if (false)
            {//task5.Даны три целых числа: A, B, C. Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное».
                int randomIntValueATask5 = randomizer.Next(-50, 50);
                int randomIntValueBTask5 = randomizer.Next(-50, 50);
                int randomIntValueCTask5 = randomizer.Next(-50, 50);
                bool resultTask5 = (randomIntValueATask5 > 0 && (randomIntValueBTask5 <= 0 && randomIntValueCTask5 <= 0)) ||
                                   (randomIntValueBTask5 > 0 && (randomIntValueATask5 <= 0 && randomIntValueCTask5 <= 0)) ||
                                   (randomIntValueCTask5 > 0 && (randomIntValueBTask5 <= 0 && randomIntValueATask5 <= 0));
                Console.WriteLine("Task5");
                Console.WriteLine("Number A is: " + randomIntValueATask5 + ", number B is: " + randomIntValueBTask5 + ", number C is: " + randomIntValueCTask5);
                Console.WriteLine("Exactly one of the numbers A,B,C is greater than 0: " + resultTask5);
                Console.WriteLine();
            }
            if (false)
            {//task6.Дано целое положительное число. Проверить истинность высказывания: «Данное число является нечетным трехзначным».
                int randomIntValueATask6 = randomizer.Next(0, 1000);
                bool resultTask6 = randomIntValueATask6 % 2 != 0 && randomIntValueATask6 / 100 >= 1 && randomIntValueATask6 / 100 < 10;
                Console.WriteLine("Task6");
                Console.WriteLine("Number A is: " + randomIntValueATask6);
                Console.WriteLine("Number A is odd and 3 digit: " + resultTask6);
                Console.WriteLine();
            }
            if (false)
            {/*task7.Даны числа x, y, x1, y1, x2, y2. 
            Проверить истинность высказывания:«Точка с координатами (x, y) лежит внутри прямоугольника, 
            левая верхняя вершина которого имеет координаты (x1, y1), правая нижняя — (x2, y2), а стороны параллельны координатным осям».*/
                int inputIntValueX1Task7;
                int inputIntValueY1Task7;
                int inputIntValueX2Task7;
                int inputIntValueY2Task7;
                int inputIntValueXTask7;
                int inputIntValueYTask7;
                //input values variables from the console 
                Console.WriteLine("Task7");
                Console.WriteLine("Enter value for rectangle x1: ");
                string inputResultX1 = Console.ReadLine();
                bool isSuccessX1 = int.TryParse(inputResultX1, out inputIntValueX1Task7);
                Console.WriteLine("Enter value for rectangle y1: ");
                string inputResultY1 = Console.ReadLine();
                bool isSuccessY1 = int.TryParse(inputResultY1, out inputIntValueY1Task7);
                Console.WriteLine("Enter value for rectangle x2: ");
                string inputResultX2 = Console.ReadLine();
                bool isSuccessX2 = int.TryParse(inputResultX2, out inputIntValueX2Task7);
                Console.WriteLine("Enter value for rectangle y2: ");
                string inputResultY2 = Console.ReadLine();
                bool isSuccessY2 = int.TryParse(inputResultY2, out inputIntValueY2Task7);
                Console.WriteLine("Enter value for point x: ");
                string inputResultX = Console.ReadLine();
                bool isSuccessX = int.TryParse(inputResultX, out inputIntValueXTask7);
                Console.WriteLine("Enter value for point y: ");
                string inputResultY = Console.ReadLine();
                bool isSuccessY = int.TryParse(inputResultY, out inputIntValueYTask7);
                //display of variable values
                Console.WriteLine($" Point (x,y): ({inputIntValueXTask7},{inputIntValueYTask7})");
                Console.WriteLine($" Point (x1,y1): ({inputIntValueX1Task7},{inputIntValueY1Task7})");
                Console.WriteLine($" Point (x2,y2): ({inputIntValueX2Task7},{inputIntValueY2Task7})");
                //calculate and display result
                bool resultTask7 = inputIntValueX1Task7 < inputIntValueXTask7 && inputIntValueXTask7 < inputIntValueX2Task7 && inputIntValueY1Task7 < inputIntValueYTask7 && inputIntValueYTask7 < inputIntValueY2Task7;
                Console.WriteLine("Point (x,y) within rectangle: " + resultTask7);
                Console.WriteLine();
            }
            if (false)
            {/*task8. Даны целые числа a, b, c. Проверить истинность высказывания: «Существует треугольник со сторонами a, b, c».*/
                int randomIntValueATask8 = randomizer.Next(0, 50);
                int randomIntValueBTask8 = randomizer.Next(0, 50);
                int randomIntValueCTask8 = randomizer.Next(0, 50);
                bool resultTask8 = randomIntValueATask8 + randomIntValueBTask8 > randomIntValueCTask8 && randomIntValueATask8 + randomIntValueCTask8 > randomIntValueBTask8 && randomIntValueCTask8 + randomIntValueBTask8 > randomIntValueATask8;
                Console.WriteLine("Task8");
                Console.WriteLine("Number a is: " + randomIntValueATask8 + ", number b is: " + randomIntValueBTask8 + ", number c is: " + randomIntValueCTask8);
                Console.WriteLine("Triangle with sides a,b,c, exists: " + resultTask8);
                Console.WriteLine();
            }
            if (false)
            {/*task9. Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8). 
             Учитывая, что левое нижнее поле доски(1, 1) является черным, проверить истинность высказывания: «Данное поле является белым».*/
                int randomIntValueXTask9 = randomizer.Next(1, 8);
                int randomIntValueYTask9 = randomizer.Next(1, 8);
                bool resultTask9 = ((randomIntValueXTask9 % 2 == 0 && randomIntValueYTask9 % 2 != 0) || (randomIntValueXTask9 % 2 != 0 && randomIntValueYTask9 % 2 == 0)) ? true : false;
                Console.WriteLine("Task 9");
                Console.WriteLine($"chessboard field  with coordinates ({randomIntValueXTask9},{randomIntValueYTask9}) is white: {resultTask9}");
                Console.WriteLine();
            }
            if (false)
            {/*task10. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). 
            Проверить истинность высказывания: «Ферзь за один ход может перейти с одного поля на другое».*/
                int randomIntValueX1Task10 = randomizer.Next(1, 8);
                int randomIntValueY1Task10 = randomizer.Next(1, 8);
                int randomIntValueX2Task10 = randomizer.Next(1, 8);
                int randomIntValueY2Task10 = randomizer.Next(1, 8);
                int diffValuesX1X2 = Math.Abs(randomIntValueX2Task10 - randomIntValueX1Task10);
                int diffValuesY1Y2 = Math.Abs(randomIntValueY2Task10 - randomIntValueY1Task10);
                bool resultTask10 = ((randomIntValueX1Task10 == randomIntValueX2Task10 && randomIntValueY1Task10 != randomIntValueY2Task10) ||
                    (randomIntValueX1Task10 != randomIntValueX2Task10 && randomIntValueY1Task10 == randomIntValueY2Task10) ||
                    diffValuesX1X2 == diffValuesY1Y2 || randomIntValueX2Task10 + randomIntValueX1Task10 == randomIntValueY2Task10 + randomIntValueY1Task10) ? true : false;
                Console.WriteLine("Task 10");
                Console.WriteLine($"Quenn on chessboard can pass from  ({randomIntValueX1Task10},{randomIntValueY1Task10}) to  ({randomIntValueX2Task10},{randomIntValueY2Task10}): {resultTask10}");
                Console.WriteLine();
            }
            if (false)
            {/*task11. Даны два числа А и В. Поменяйте их местами не используя дополнительную переменную*/
                int randomIntValueATask11 = randomizer.Next(0, 50);
                int randomIntValueBTask11 = randomizer.Next(0, 50);

                Console.WriteLine("Task11");
                Console.WriteLine("Before changing number A is: " + randomIntValueATask11 + ", number B is: " + randomIntValueBTask11);
                randomIntValueATask11 = randomIntValueATask11 + randomIntValueBTask11;
                randomIntValueBTask11 = randomIntValueATask11 - randomIntValueBTask11;
                randomIntValueATask11 = randomIntValueATask11 - randomIntValueBTask11;
                Console.WriteLine("After changing number A is: " + randomIntValueATask11 + ", number B is: " + randomIntValueBTask11);
                Console.WriteLine();
            }
            if (false)
            {/*task12. Дано целое число в диапазоне 1–7.Вывести строку — название дня недели, соответствующее данному числу(1 — «понедельник», 2 — «вторник» и т.д.).*/
                int randomIntValueTask12 = randomizer.Next(1, 7);
                string resultTask12;
                switch (randomIntValueTask12)
                {
                    case 1:
                        resultTask12 = "Monday";
                        break;
                    case 2:
                        resultTask12 = "Tuesday";
                        break;
                    case 3:
                        resultTask12 = "Wednesday";
                        break;
                    case 4:
                        resultTask12 = "Thursday";
                        break;
                    case 5:
                        resultTask12 = "Friday";
                        break;
                    case 6:
                        resultTask12 = "Saturday";
                        break;
                    case 7:
                        resultTask12 = "Sunday";
                        break;
                    default:
                        resultTask12 = "Unknown day";
                        break;
                }
                Console.WriteLine("Task 12");
                Console.WriteLine($"Number {randomIntValueTask12} corresponds to {resultTask12}");
                Console.WriteLine();
            }
            if (false)
            {/*task13.Дано целое число K. Вывести строку-описание оценки, соответствующей числу K(1, 2 — «неудовлетворительно», 3 — «удовлетворительно», 4 — «хорошо», 5 — «отлично»).
           Если K не лежит в диапазоне 1–5, то вывести строку «ошибка».*/
                int randomIntValueKTask13 = randomizer.Next(1, 6);
                string resultTask13;
                switch (randomIntValueKTask13)
                {
                    case 1:
                    case 2:
                        resultTask13 = "Bad";
                        break;
                    case 3:
                        resultTask13 = "So so";
                        break;
                    case 4:
                        resultTask13 = "Good";
                        break;
                    case 5:
                        resultTask13 = "Excellent";
                        break;
                    default:
                        resultTask13 = "Error";
                        break;
                }
                Console.WriteLine("Task 13");
                Console.WriteLine($"Grade {randomIntValueKTask13} corresponds to {resultTask13}");
                Console.WriteLine();
            }
            if (false)
            {/*task14. Единицы длины пронумерованы следующим образом: 1 — дециметр, 2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр.
            Дан номер единицы длины(целое число в диапазоне 1–5) и длина отрезка в этих единицах(вещественное число). Найти длину отрезка в метрах.*/
                int randomIntNumberLenTask14 = randomizer.Next(1, 5);
                int randomIntValueLenTask14 = randomizer.Next(1, 100);
                double resultLengthTask14;
                string resultMeasureTask14;
                switch (randomIntNumberLenTask14)
                {
                    case 1:
                        resultLengthTask14 = randomIntValueLenTask14 * 10;
                        resultMeasureTask14 = "decimeter";
                        break;
                    case 2:
                        resultLengthTask14 = Convert.ToDouble(randomIntValueLenTask14) / 1000;
                        resultMeasureTask14 = "kilometer";
                        break;
                    case 3:
                        resultLengthTask14 = randomIntValueLenTask14;
                        resultMeasureTask14 = "meter";
                        break;
                    case 4:
                        resultLengthTask14 = randomIntValueLenTask14 * 1000;
                        resultMeasureTask14 = "millimeter";
                        break;
                    case 5:
                        resultLengthTask14 = randomIntValueLenTask14 * 100;
                        resultMeasureTask14 = "centimeter";
                        break;
                    default:
                        resultLengthTask14 = 0;
                        resultMeasureTask14 = "Error";
                        break;
                }
                Console.WriteLine("Task 14");
                Console.WriteLine($"{randomIntValueLenTask14} meters equal to {resultLengthTask14} {resultMeasureTask14}");
                Console.WriteLine();
            }
            if (false)
            {/*task15. Дано целое число, лежащее в диапазоне 1–99.Вывести число в словесном виде(можно на любом языке Вам удобном) “десять”, “тридцать один”, т.д.*/
                int inputIntValueTask15;
                //input data from Console
                Console.WriteLine("Task15");
                Console.WriteLine("Enter number between 1 and 99: ");
                string inputResultNumber = Console.ReadLine();
                bool isSuccessNumber = int.TryParse(inputResultNumber, out inputIntValueTask15);
                int i = 0;
                int j = 0;
                string resultTask15 = "";
                //create massive for definitions of number
                string[] stringNumberArray1_9Task15 = new string[9];
                string[] stringNumberArray10_19Task15 = new string[10];
                string[] stringNumberArray20_90Task15 = new string[8];
                stringNumberArray1_9Task15[0] = "one";
                stringNumberArray1_9Task15[1] = "two";
                stringNumberArray1_9Task15[2] = "three";
                stringNumberArray1_9Task15[3] = "four";
                stringNumberArray1_9Task15[4] = "five";
                stringNumberArray1_9Task15[5] = "six";
                stringNumberArray1_9Task15[6] = "seven";
                stringNumberArray1_9Task15[7] = "eight";
                stringNumberArray1_9Task15[8] = "nine";
                stringNumberArray10_19Task15[0] = "ten";
                stringNumberArray10_19Task15[1] = "eleven";
                stringNumberArray10_19Task15[2] = "twelve";
                stringNumberArray10_19Task15[3] = "thirteen";
                stringNumberArray10_19Task15[4] = "fourteen";
                stringNumberArray10_19Task15[5] = "fifteen";
                stringNumberArray10_19Task15[6] = "sixteen";
                stringNumberArray10_19Task15[7] = "seventeen";
                stringNumberArray10_19Task15[8] = "eighteen";
                stringNumberArray10_19Task15[9] = "nineteen";
                stringNumberArray20_90Task15[0] = "twenty";
                stringNumberArray20_90Task15[1] = "thirty";
                stringNumberArray20_90Task15[2] = "fourty";
                stringNumberArray20_90Task15[3] = "fifty";
                stringNumberArray20_90Task15[4] = "sixty";
                stringNumberArray20_90Task15[5] = "seventy";
                stringNumberArray20_90Task15[6] = "eighty";
                stringNumberArray20_90Task15[7] = "ninety";
                //definition of number
                if (inputIntValueTask15 > 0 && inputIntValueTask15 < 10)
                {
                    i = inputIntValueTask15 - 1;
                    resultTask15 = stringNumberArray1_9Task15[i];
                }
                if (inputIntValueTask15 >= 10 && inputIntValueTask15 < 20)
                {
                    i = inputIntValueTask15 - 10;
                    resultTask15 = stringNumberArray10_19Task15[i];
                }
                if (inputIntValueTask15 >= 20 && inputIntValueTask15 <= 99)
                {
                    if (inputIntValueTask15 % 10 == 0)
                    {
                        i = inputIntValueTask15 / 10 - 2;
                        resultTask15 = stringNumberArray20_90Task15[i];
                    }
                    else
                    {
                        i = (inputIntValueTask15 - inputIntValueTask15 % 10) / 10 - 2;
                        j = inputIntValueTask15 % 10 - 1;
                        resultTask15 = stringNumberArray20_90Task15[i] + " " + stringNumberArray1_9Task15[j];
                    }
                }
                Console.WriteLine($"{inputIntValueTask15} is {resultTask15}");
                Console.WriteLine();
            }
            /*task16.Создать массив resultArray используя следующие шаги....*/
            int firstArrayCount = randomizer.Next(1, 20);
            int secondArrayCount = randomizer.Next(1, 20);
            int[] firstArray = new int[firstArrayCount];
            int[] secondArray = new int[secondArrayCount];
            //int resultArrayCount = Math.Max(firstArrayCount, secondArrayCount);
            int minArrayCount = Math.Min(firstArrayCount, secondArrayCount);
            //int[] resultArray = new int[resultArrayCount];
            Console.WriteLine("Task16");
            Console.Write("firstArray ");
            for (int l = 0; l < firstArray.Length; l++)
            {
                firstArray[l] = randomizer.Next(-20, 20);
                Console.Write(firstArray[l] + " ");
            }
            Console.WriteLine();
            Console.Write("secondArray ");
            for (int m = 0; m < secondArray.Length; m++)
            {
                secondArray[m] = randomizer.Next(-20, 20);
                Console.Write(secondArray[m] + " ");
            }
            int[] resultArray = ((firstArrayCount > secondArrayCount) ? firstArray : secondArray);
            Console.WriteLine();
            Console.Write("resultArray ");
            for (int k = 0; k < minArrayCount; k++)
            {
                resultArray[k] = Math.Max(firstArray[k], secondArray[k]);
            }
            foreach (int element in resultArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
