namespace bubbleSorting {
    class Program {
        static void Main(string[] args) {
            int[] numbers = { 32, 1, 43, 81, 2, 17, 99, 23, 47, 431, 321, 42 };

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i ; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                    }
                }
            }

            Console.WriteLine("Bubble sorting: ");

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
