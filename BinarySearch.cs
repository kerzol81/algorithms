static int BinarySearch(int[] array, int key) {
            int low = 0;
            int high = array.Length;
            int middle;

            while (low <= high)
            {
                middle = (low + high) / 2;

                if (middle == key)
                {
                    return array[middle];
                }
                else if (middle < key)
                {
                    low = middle + 1;
                }
                else
                    high = middle - 1;
            }
            return 0;
