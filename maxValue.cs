static int MaximumValue( int[] array ) {
            int max_value = array[0];

            for ( int i = 1; i < array.Length; i++ )
            {
                if ( array[i] > max_value )
                {
                    max_value = array[i];
                }
            }

            return max_value;
        }
        
