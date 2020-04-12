using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayHelper.GetArray();

            int min = ArrayHelper.GetMinimumRecursive(array);
            Console.WriteLine();

            Console.WriteLine($"Min Value is: {min}");
            Console.WriteLine();

            int max = ArrayHelper.GetMaximumRecursive(array);

            Console.WriteLine($"Max Value is: {max}");
            Console.WriteLine();

            int index = ArrayHelper.FindIndexBinarySearch(array);
            Console.WriteLine(index);
            Console.WriteLine();

            ArrayHelper.FibonacciRecursive();
        }
    }
}
