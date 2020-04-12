using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class ArrayHelper
    {

        private static int ReadNumber(string message, int maxAttempts, int defaultValue)
        {
            int attemptsCount = 1;
            bool isNumber = false;

            while (!isNumber)
            {
                Console.Write(message);
                string text = Console.ReadLine();

                isNumber = int.TryParse(text, out int number);

                if (isNumber)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"'{text}' is not a number, try again({maxAttempts - attemptsCount} attempts remaining)");
                }

                attemptsCount++;

                if (attemptsCount > maxAttempts)
                {
                    Console.WriteLine($"Max attempts count exceeded, assuming {defaultValue} as default value...");
                    return defaultValue;
                }
            }

            return defaultValue;
        }

        public static int[] GetArray()
        {
            int length = ReadNumber("Insert array length: ", 3, 1);

            if(length < 1)
            {
                Console.WriteLine($"Invalid value. Assuming 1 as default value...");
                length = 1;
            }

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = ReadNumber($"Element[{i}] = ", 3, 0);
            }

            return array;
        }


        // Un algoritm pentru gasirea minimului dintr-un vector
        public static int GetMinimumRecursive(int[] array)
        {
            int min = GetMinimumRecursive(array, 0, 0, true);

            return min;
        }

        private static int GetMinimumRecursive(int[] array, int index, int min, bool init)
        {
            if (init)
            {
                min = array[index];
            }

            if (index >= array.Length)
            {
                return min;
            }

            if (min > array[index])
            {
                min = array[index];
            }

            return GetMinimumRecursive(array, index + 1, min, false);
        }


        // Un algoritm pentru gasirea maximului dintr-un vector
        public static int GetMaximumRecursive(int[] array)
        {
            int min = GetMaximumRecursive(array, 0, 0, true);

            return min;
        }

        private static int GetMaximumRecursive(int[] array, int index, int max, bool init)
        {
            if (init)
            {
                max = array[index];
            }

            if (index >= array.Length)
            {
                return max;
            }

            if (max < array[index])
            {
                max = array[index];
            }
            
            return GetMaximumRecursive(array, index + 1, max, false);
        }


        // Un algoritm pentru calcularea Fibonacci(n)
        public static void FibonacciRecursive()
        {
            bool isNumber;
            string inputText = "Enter the last element of the Fibonacci series: ";
            int n = ReadNumber(inputText, 3, 2);

            if (n < 2)
            {
                Console.WriteLine($"Invalid value. Assuming 2 as default value...");
                n = 2;
            }

            Console.WriteLine($"{FibonacciRecursive(n, 2, 0, 1, true)} ");
        }

        private static int FibonacciRecursive(int number, int count, int firstElem, int secondElem, bool init)
        {
            if (init)
            {
                Console.Write($"{firstElem} ");
                Console.Write($"{secondElem} ");
            }

            count++;

            int lastElem = firstElem + secondElem;

            if (count >= number)
            {
                return lastElem;
            }

            Console.Write($"{lastElem} ");

            return FibonacciRecursive(number, count, secondElem, lastElem, false);
        }


        // Un algoritm care sa gaseasca indexulul unui element dat (citit de la tastatura) intr-un sir ordonat crescator, folosind cautare binara
        public static int FindIndexBinarySearch(int[] array)
        {
            int elemToLookFor = ReadNumber("Search for: ", 3, 0);

            return FindIndexBinarySearch(array, elemToLookFor, 0, array.Length);
        }

        private static int FindIndexBinarySearch(int[] array, int elemToLookFor, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;

                if (elemToLookFor == array[mid])
                {
                    Console.WriteLine($"The index of {elemToLookFor} is: ");
                    return mid;
                }

                if (elemToLookFor < array[mid])
                {

                    end = mid - 1;
                }

                if (elemToLookFor > array[mid])
                {
                    start = mid + 1;
                }

                return FindIndexBinarySearch(array, elemToLookFor, start, end);
            }
            else
            {
                Console.Write("Not Found. Error code: ");
                return -1;
            }
        }
    }
}
