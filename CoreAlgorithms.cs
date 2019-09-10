using System;

namespace CoreAlgorithms_01
{
    static class Algorithms
    {
        internal static void MaxIndex(int[] array) {
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            Console.WriteLine($"The array's max index: {max}");
        }
        internal static void MaxValue(int[] array) {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"The array's max value: {max}");
        }
        internal static void MinIndex(int[] array) {
            int min = 0;
            for (int i = 1 ; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            Console.WriteLine($"The array's min index: {min}");
        }
        internal static void MinValue(int[] array) {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"The array's min value: {min}");
        }
        internal static void Sum(int[] array) {
            int total = 0;
            foreach (int i in array)
            {
                total += i;
            }
            Console.WriteLine($"Sum of the array is: {total}");
        }
        internal static void Average(int[] array) {
            double average;
            double total = 0;          
            foreach (int i in array)
            {
                total += i;
            }
            average = total / array.Length;
            Console.WriteLine($"The average is: {average}");
        }

    }
}
