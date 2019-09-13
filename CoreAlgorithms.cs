using System;

namespace CoreAlgorithms
{
    static internal class Algorithms
    {
        internal static void MaxIndex(int[] array)
        {
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            Console.WriteLine(max);
        }
        internal static void MaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
        internal static void MinIndex(int[] array)
        {
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            Console.WriteLine(min);
        }
        internal static void MinValue(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
        }
        internal static void Total(int[] array)
        {
            int total = 0;
            foreach (int i in array)
            {
                total += i;
            }
            Console.WriteLine(total);
        }
        internal static void Average(int[] array)
        {
            double average = 0;
            double total = 0;
            foreach (int i in array)
            {
                total += i;
            }
            average = total / array.Length;
            Console.WriteLine(average);
        }
        internal static void SearchElement(int[] array, int element)
        {
            int i = 0;
            while (i < array.Length && array[i] != element)
            {
                i++;
            }
            if (i < array.Length)
            {
                Console.WriteLine($"Element found at index: {i}");
            }
            else
            {
                Console.WriteLine("No such element in the array");
            }
        }
        internal static bool Decide(int[] array, int element) {
            bool answer = false;
            int i = 0;
            while (i < array.Length && array[i] != element)
            {
                i++;
            }
            answer = i < array.Length;
            return answer;
        }
    }
}
