/*

Binary or Logarithmic Search

*/

static int BinarySearch(int[] array, int key) {
            int low = 0;
            int high = array.Length;
            int middle;

            do
            {
                middle = (low + high) / 2;

                if (array[middle] < key)
                {
                    low = middle + 1;
                }
                else if (array[middle] > key)
                {
                    high = middle - 1;
                }
            } while (low <= high && array[middle] != key);

            return middle;
        }
