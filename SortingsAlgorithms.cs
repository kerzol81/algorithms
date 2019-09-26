using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class Sortings
    {
        public static void SimpleSort(int[] array)
        {
            if (array.Length > 1)
            {
                int t;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("the array must have at least 2 elements");
            }
        }
        public static void BubbleSort(int[] array) {
            if (array.Length > 1)
            {
                for (int i = array.Length; i > 0; i--)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int t = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = t;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("the array must have at least 2 elements");
            }
        }
    }
}
