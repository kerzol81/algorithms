static int LinearSearch(int[] array, int key) {

            int i = 0;
            while (i < array.Length && array[i] != key)
            {
                i++;
            }
            if (i < array.Length)
            {
                return i;
            }
            return 0;
        }
