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
            int randomIntFactorialTask2 = randomizer.Next(1, 50);
            //int randomIntFactorialTask2 = 8;
            double resultFactorialTask2 = GetFactorial(randomIntFactorialTask2);
            Console.WriteLine("task2");
            Console.WriteLine($"Factorial of number {randomIntFactorialTask2} = {resultFactorialTask2}");
            Console.WriteLine("-------------------------------------------------------------");
            // task3
            int randomIntFibonachiTask3 = randomizer.Next(1, 10);
            int[] resultFibonachiTask3 = new int[randomIntFibonachiTask3];
            Console.WriteLine("task3");
            Console.Write($"Fibonacci sequence with length {randomIntFibonachiTask3} = ");
            resultFibonachiTask3 = GetFibonachiSequence(randomIntFibonachiTask3);
            PrintArray(resultFibonachiTask3);
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
            resultCountDaysTask4 = GetCountDaysInMonthYear(inputYearValueTask4, inputMonthValueTask4);
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
            int tempIndex;
            Console.WriteLine("Random current array is");
            PrintArray(randomArrayTask6);
            Console.WriteLine();
            int minIndexInRandomArray = GetMinMaxIndexInArray(randomArrayTask6)[0];
            int maxIndexInRandomArray = GetMinMaxIndexInArray(randomArrayTask6)[1];
            Console.WriteLine($"Min value of array is {randomArrayTask6[minIndexInRandomArray]} with index {minIndexInRandomArray}");
            Console.WriteLine($"Max value of array is {randomArrayTask6[maxIndexInRandomArray]} with index {maxIndexInRandomArray}");
            if (minIndexInRandomArray > maxIndexInRandomArray)
            {
                tempIndex = minIndexInRandomArray;
                minIndexInRandomArray = maxIndexInRandomArray;
                maxIndexInRandomArray = tempIndex;
            }
            for (int i = minIndexInRandomArray + 1; i < maxIndexInRandomArray; i++)
            {
                randomArrayTask6[i] = 0;
            }
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
            double resultFactorial = (inputIntFactorial == 1)?1:(inputIntFactorial * GetFactorial(inputIntFactorial - 1));
            return resultFactorial;
        }
        static int[] GetFibonachiSequence(int inputIntFibonachi)
        {
            int[] resultFibonachi = new int[inputIntFibonachi];
            for (int i = 0; i <inputIntFibonachi; i++)
            {
                resultFibonachi[i] = (i <= 1) ? i : (GetFibonachiSequence(inputIntFibonachi-2)[i-2] + GetFibonachiSequence(inputIntFibonachi-1)[i-1]);
            }
            return resultFibonachi;
        }
        static int GetCountDaysInMonthYear(int year, int month)
        {
            int resultcountdays = 0;
            if (month != 2&&month<13)
            {
                resultcountdays = (month % 2 != 0 && month < 8) || (month % 2 == 0 && month >= 8) ? 31 : 30;
            }
            if (month == 2)
            {
                resultcountdays = (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0)) ? 29 : 28;
            }
            return resultcountdays;
        }
        static void QuickSortArray(int[] inputArray, int firstIndexForSort, int lastIndexForSort)
        {

            int middleValue = inputArray[(firstIndexForSort + lastIndexForSort) / 2];
            int firstCurrentIndex = firstIndexForSort;
            int lastCurrentIndex = lastIndexForSort;

            while (firstCurrentIndex <= lastCurrentIndex)
            {
                while (middleValue > inputArray[firstCurrentIndex])
                {
                    firstCurrentIndex++;
                }
                while (middleValue < inputArray[lastCurrentIndex])
                {
                    lastCurrentIndex--;
                }
                if (firstCurrentIndex <= lastCurrentIndex)
                {
                    int tempItemValue = inputArray[firstCurrentIndex];
                    inputArray[firstCurrentIndex] = inputArray[lastCurrentIndex];
                    inputArray[lastCurrentIndex] = tempItemValue;
                    firstCurrentIndex++;
                    lastCurrentIndex--;
                }
            }
            if (lastCurrentIndex > firstIndexForSort)
            {
                QuickSortArray(inputArray, firstIndexForSort, lastCurrentIndex);
            }
            if (firstCurrentIndex < lastIndexForSort)
            {
                QuickSortArray(inputArray, firstCurrentIndex, lastIndexForSort);
            }
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
                randomArray[i] = randomizer.Next(0, 20);
            }
            return randomArray;
        }
        static int[] GetMinMaxIndexInArray(int[] inputArray)
        {
            int maxValueIndex = 0;
            int minValueIndex = 0;
            int[] minMaxIndexArray = new int[2];

            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                minValueIndex = (inputArray[i] >= inputArray[minValueIndex]) ? minValueIndex :i;
                maxValueIndex = (inputArray[i] > inputArray[maxValueIndex]) ? i : maxValueIndex;
            }
 
            minMaxIndexArray[0] = minValueIndex;
            minMaxIndexArray[1] = maxValueIndex;

            return minMaxIndexArray;
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
               do
                {
                    firstValueTable = randomizer.Next(1, 9);
                    secondValueTable = randomizer.Next(1, 9);
                    resultMultiply = firstValueTable * secondValueTable;
                    resultStringMultiplyArray[i] = firstValueTable + "*" + secondValueTable + "=" + resultMultiply;
                    tempStringMultiplyArray[i] = secondValueTable + "*" + firstValueTable + "=" + resultMultiply;
                }
                while (CheckEqualArray(resultStringMultiplyArray, tempStringMultiplyArray, resultStringMultiplyArray[i],i));
            }
            return resultStringMultiplyArray;
        }
        static bool CheckEqualArray(string[] FirstArrayForCheck, string[] SecondArrayforCheck, string valueForCheck, int indexOfArray)
        {
            bool isEqualArray = false;
            for (int i = 0; i < FirstArrayForCheck.Length; i++)
            {
                if (((FirstArrayForCheck[i] == valueForCheck) || (SecondArrayforCheck[i] == valueForCheck)) && i != indexOfArray)
                {
                    isEqualArray=true;
                }
               
            }
            return isEqualArray;
        }
    }
}
