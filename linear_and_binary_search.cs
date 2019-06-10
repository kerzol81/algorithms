class Program {
        static void Main( string[] args ) {
            Console.WriteLine("Generating the list...");
            int[] numbers = new int[Int32.MaxValue / 10];

            for ( int i = 0; i < numbers.Length; i++ ) {
                numbers[i] = i;
            }

            Console.WriteLine("Which number to look for betveen 0 - {0}", numbers.Length);
            int item = Convert.ToInt32(Console.ReadLine());

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // linear search
            for ( int i = 0; i < numbers.Length; i++ ) {
                if ( numbers[i] == item ) {
                    break;
                }
            }
            stopwatch.Stop();
            Console.Write("Linear search ends");
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Restart();

            // binary search

            int left = 0;
            int right = numbers.Length - 1;

            while ( left <= right ) {
                int middle = (left + right) / 2;

                if ( numbers[middle] == item )
                    break;
                if ( item < numbers[middle] )
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            stopwatch.Stop();
            Console.Write("Binary search ends");
            Console.WriteLine(stopwatch.Elapsed);
            
            Console.ReadKey();

            
        }
    }
