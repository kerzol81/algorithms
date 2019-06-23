using System;
using System.Diagnostics;

namespace Linear_vs_Binary_Search {
    class Program {

        static int BinarySearch(int[] array, int key) {
            int low = 0;
            int high = array.Length-1;
            int middle;

            while (low <= high)
            {
                middle = (low + high) / 2;

                if (array[middle] == key)
                {
                    return middle;
                }
                else if (array[middle] < key)
                {
                    low = middle + 1;
                }
                else
                    high = middle - 1;
            }
            return 0;
        }

        static int LinearSearch(int[] array, int key) {

            int i = 0;
            while (i < array.Length && array[i] != key)
            {
                i++;
            }
            if (i < array.Length)
            {
                return i;
            }
            return 0;
        }


        static void Main(string[] args) {

            int[] numbers = new int[10000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            Stopwatch stopwatch = new Stopwatch();


            stopwatch.Start();
            LinearSearch(numbers, 9999);
            stopwatch.Stop();
            Console.WriteLine("Elapsed time after Linear Search: {0}", stopwatch.Elapsed);

            stopwatch.Restart();
            BinarySearch(numbers, 9999);
            stopwatch.Stop();
            Console.WriteLine("Elapsed time after Binary Search: {0}", stopwatch.Elapsed);

            Console.ReadKey();
        }
    }
}
