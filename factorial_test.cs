class Program {

        static long Factorial( int a ) {

            return (a > 1) ? a * Factorial(a - 1) : 1;
        }

        static void F( int i ) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("!{0} : {1} ",i ,Factorial(i));
            stopwatch.Stop();
            Console.WriteLine("Elapsed : {0}\n", stopwatch.Elapsed);
           }

        static void Main( string[] args ) {

            for ( int i = 2; i <= 18; i+=2 ) {
                F(i);
            }

            Console.ReadLine();
        }
    }
