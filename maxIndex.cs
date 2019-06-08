int[] array = new int[9] { 3, 11, 32, 47, 21, 19, 103, 20, 7};

            int max_index = 0;

            for ( int i = 1; i < array.Length; i++ )
            {
                if ( array[i] > array[max_index] )
                {
                    max_index = i;
                }
            }
            
