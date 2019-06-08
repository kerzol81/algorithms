static int MaximumIndex(int[] array)
        {
            int max_index = 0;
            for ( int i = 1; i < array.Length; i++ )
            {
                if ( array[i] > array[max_index] )
                {
                    max_index = i;
                }
            }
            return max_index;
        }
