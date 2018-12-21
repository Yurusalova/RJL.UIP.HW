using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJL.HW3.ConditionalsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            // task1 difference between while and do..while
            int intValueExample1Task1 = 10;
            int intValueExample2Task1 = 10;
            do
            {
                intValueExample1Task1++;
            } while (intValueExample1Task1 < 10);

            while (intValueExample2Task1 < 10)
            {
                intValueExample2Task1++;
            }
            Console.WriteLine("task1");
            Console.WriteLine("In case of do..while ExampleValue= " + intValueExample1Task1);
            Console.WriteLine("In case of while ExampleValue= " + intValueExample2Task1);
            Console.WriteLine("-------------------------------------------------------------");

            //task2
            int randomIntFactorialTask2 = randomizer.Next(1, 100);
            //int randomIntFactorialTask2 = 30;
            double resultFactorialTask2 = GetFactorial(randomIntFactorialTask2);
            Console.WriteLine("task2");
            Console.WriteLine($"Factorial of number {randomIntFactorialTask2} = {resultFactorialTask2}");
            Console.WriteLine("-------------------------------------------------------------");
            // task3
            int randomIntFibonachiTask3 = randomizer.Next(1, 10);
            int[] resultFibonachiTask3 = new int[randomIntFibonachiTask3];
            Console.WriteLine("task3");
            Console.Write($"Fibonacci sequence with length {randomIntFibonachiTask3} = ");
            for (int i = resultFibonachiTask3.Length - 1; i >= 0; i--)
            {
                resultFibonachiTask3[i] = GetFibonachi(randomIntFibonachiTask3 - 1 - i);
                Console.Write(" " + resultFibonachiTask3[i]);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            //task4
            int inputYearValueTask4;
            int inputMonthValueTask4;
            int resultCountDaysTask4;
            Console.WriteLine("Task4");
            Console.WriteLine("Enter value for Year");
            string inputStringYear = Console.ReadLine();
            bool isSuccessYear = int.TryParse(inputStringYear, out inputYearValueTask4);
            Console.WriteLine("Enter value for Month");
            string inputStringMonth = Console.ReadLine();
            bool isSuccessMonth = int.TryParse(inputStringMonth, out inputMonthValueTask4);
            resultCountDaysTask4 = GetCountDays(inputYearValueTask4, inputMonthValueTask4);
            Console.WriteLine($"{inputYearValueTask4} year {inputMonthValueTask4} month contains {resultCountDaysTask4} days");
            Console.WriteLine("-------------------------------------------------------------");
            // task5
            Console.WriteLine("Task5");
            int[] randomArrayTask5 = CreateRandomArray();
            Console.WriteLine("Random current array is");
            PrintArray(randomArrayTask5);
            int[] sortArrayTask5 = randomArrayTask5;
            QuickSortArray(sortArrayTask5, 0, randomArrayTask5.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Sorted array is ");
            PrintArray(sortArrayTask5);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            //task6
            Console.WriteLine("Task6");
            int[] randomArrayTask6 = CreateRandomArray();
            Console.WriteLine("Random current array is");
            PrintArray(randomArrayTask6);
            Console.WriteLine();
            SetNullMinMaxArray(randomArrayTask6);
            Console.WriteLine("Array with null value between min and max is");
            PrintArray(randomArrayTask6);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");
            //task7
            Console.WriteLine("Task7");
            int randomArrayLengthTask7 = randomizer.Next(1, 10);
            int[][] randomArrayTask7 = new int[randomArrayLengthTask7][];
            Console.WriteLine("Current random array of arrays is");
            for (int i = 0; i < randomArrayLengthTask7; i++)
            {
                randomArrayTask7[i] = CreateRandomArray();
                PrintArray(randomArrayTask7[i]);
                Console.WriteLine();
            }
            Console.WriteLine("Array after sorting");
            for (int i = 0; i < randomArrayLengthTask7; i++)
            {
                QuickSortArray(randomArrayTask7[i], 0, randomArrayTask7[i].Length - 1);
                PrintArray(randomArrayTask7[i]);
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------");
            //task8
            Console.WriteLine("Task8");
            string[] multiplyTableArrayTask8 = GetMultiplyTable(15);
            foreach (string item in multiplyTableArrayTask8)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static double GetFactorial(int inputIntFactorial)
        {
            if (inputIntFactorial == 1)
            {
                return 1;
            }
            double resultFactorial = inputIntFactorial * GetFactorial(inputIntFactorial - 1);
            return resultFactorial;
        }
        static int GetFibonachi(int inputIntFibonachi)
        {
            if (inputIntFibonachi <= 1)
            {
                return inputIntFibonachi;
            }
            int resultFibonachi = GetFibonachi(inputIntFibonachi - 2) + GetFibonachi(inputIntFibonachi - 1);
            return resultFibonachi;
        }
        static int GetCountDays(int year, int month)
        {
            int resultcountdays = 0;
            if (month != 2)
            {
                resultcountdays = (month % 2 != 0 && month < 8) || (month % 2 == 0 && month >= 8) ? 31 : 30;
            }
            if (month == 2)
            {
                resultcountdays = (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)) ? 29 : 28;
            }
            return resultcountdays;
        }
        static void QuickSortArray(int[] inputArray, int firstIndex, int lastIndex)
        {

            int middleValue = inputArray[(firstIndex + lastIndex) / 2];
            int i = firstIndex;
            int j = lastIndex;

            while (i <= j)
            {
                while (middleValue > inputArray[i])
                {
                    i++;
                }
                while (middleValue < inputArray[j])
                {
                    j--;
                }
                if (i <= j)
                {
                    int tempItemValue = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = tempItemValue;
                    i++;
                    j--;
                }
            }
            if (j > firstIndex) QuickSortArray(inputArray, firstIndex, j);
            if (i < lastIndex) QuickSortArray(inputArray, i, lastIndex);
        }

        static void PrintArray(int[] inputArrayPrint)
        {
            foreach (int item in inputArrayPrint)
            {
                Console.Write(" " + item);
            }
        }
        static int[] CreateRandomArray()
        {
            Random randomizer = new Random();
            int randomArrayLength = randomizer.Next(20, 50);
            int[] randomArray = new int[randomArrayLength];
            for (int i = 0; i < randomArrayLength; i++)
            {
                randomArray[i] = randomizer.Next(0, 9);
            }
            return randomArray;
        }
        static void SetNullMinMaxArray(int[] inputArray)
        {
            int maxValueIndex = 0;
            int minValueIndex = 0;
            int tempIndex;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                minValueIndex = (inputArray[i + 1] >= inputArray[minValueIndex]) ? minValueIndex : i + 1;
                maxValueIndex = (inputArray[i + 1] > inputArray[maxValueIndex]) ? i + 1 : maxValueIndex;
            }
            if (minValueIndex > maxValueIndex)
            {
                tempIndex = minValueIndex;
                minValueIndex = maxValueIndex;
                maxValueIndex = tempIndex;
            }
            for (int i = minValueIndex + 1; i < maxValueIndex; i++)
            {
                inputArray[i] = 0;
            }
        }
        static string[] GetMultiplyTable(int countPeople)
        {
            Random randomizer = new Random();
            int firstValueTable = 0;
            int secondValueTable = 0;
            int resultMultiply = 0;
            string[] resultStringMultiplyArray = new string[countPeople];
            string[] tempStringMultiplyArray = new string[countPeople];
            for (int i = 0; i < countPeople; i++)
            {
                bool compareArrayItem = false;
                do
                {
                    firstValueTable = randomizer.Next(1, 9);
                    secondValueTable = randomizer.Next(1, 9);
                    resultMultiply = firstValueTable * secondValueTable;
                    resultStringMultiplyArray[i] = firstValueTable + "*" + secondValueTable + "=" + resultMultiply;
                    tempStringMultiplyArray[i] = secondValueTable + "*" + firstValueTable + "=" + resultMultiply;

                    for (int j = 0; j < countPeople; j++)
                    {
                        compareArrayItem = ((resultStringMultiplyArray[i] == resultStringMultiplyArray[j]) || (tempStringMultiplyArray[i] == resultStringMultiplyArray[j])) && i != j;
                    }
                }
                while (compareArrayItem);
            }
            return resultStringMultiplyArray;
        }
    }
}
