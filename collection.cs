    static class Algorithms
    {
        public static void MaxValue(int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"max value: {max}");
        }

        public static void MaxIndex(int[] array)
        {
            int max = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            Console.WriteLine($"max index: {max}");
        }
        public static void MinValue(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"min value: {min}");
        }
        public static void MinIndex(int[] array)
        {
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            Console.WriteLine($"min index: {min}");
        }

    }
