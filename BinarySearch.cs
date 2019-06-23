/*

Binary or Logarithmic Search

*/

static int BinarySearch(int[] array, int key) {
            int low = 0;
            int high = array.Length - 1;
            int middle;

            while (low <= high)

            {
                middle = (low + high) / 2;

                if (array[middle] == key)
                {
                    return middle;
                }
                else if (array[middle] < key)
                {
                    low = middle + 1;
                }
                else
                    high = middle - 1;
            }
            return 0;
