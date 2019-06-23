/*
Bubble Sorting

The outter loop (i) runs from the end of the list until the first element.
The inner loop (j) runs from the fist element until i-1.
Then we switch elements in the inner loop if the first is bigger than the second.

*/



for (int i = numbers.Length; i > 0; i--)
{           
            for (int j = 0; j < i - 1  ; j++)
            {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                    }
             }
}
