private static int BinarySearch(int[] array, int item) {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == item)
                    return middle;
                if (item < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }
