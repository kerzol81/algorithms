static void Main( string[] args ) {
            Console.Write("How many names will be?");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[n];

            for ( int i = 0; i < names.Length; i++ ) {
                Console.Write("Enter name: ");
                names[i] = Convert.ToString(Console.ReadLine());
            }

            // counting algorithm - how many M letter names are?
            int counter = 0;
            for ( int j = 0; j < names.Length; j++ ) {
                if ( names[j][0] == 'm' || names[j][0] == 'M' ) {
                    counter++;
                }
            }
            Console.WriteLine("number of names that start with 'm' or 'M' letter: {0}", counter);

            // decision algorithm - Is there Jakob?
            bool is_jakob = false;

            for ( int k = 0; k < names.Length; k++ ) {
                if ( names[k] == "jakob" || names[k] == "Jakob") {
                    is_jakob = true;
                }
            }
            Console.WriteLine("Is there Jakob? {0}", is_jakob);

            //  split into arrays - split at letter H, if there is H

            for ( int a = 0; a < names.Length; a++ ) {
                if ( names[a][0] == 'h' || names[a][0] == 'H' ) {
                    string[] beforeH = new string[names.Length];
                    string[] afterH = new string[names.Length];

                    int index_of_h = 0;
                    for ( int l = 0; l < names.Length; l++ ) {
                        if ( names[l][0] == 'h' || names[l][0] == 'H' ) {
                            index_of_h = l;
                        }
                    }

                    for ( int m = 0; m < names.Length - index_of_h; m++ ) {
                        beforeH[m] = names[m];
                    }

                    for ( int p = index_of_h; p < names.Length; p++ ) {
                        afterH[p] = names[p];
                    }

                    for ( int q = 0; q < beforeH.Length; q++ ) {
                        Console.WriteLine(beforeH[q]);
                    }
                    for ( int r = 0; r < afterH.Length; r++ ) {
                        Console.WriteLine(afterH[r]);
                    }


                }
            }
           
      
            Console.ReadKey();
