﻿namespace UdemyAlgorithmsDataStructures_Lib
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            // This is a good starting point but it will most likely not be used as the performance is bad.
            // Bubble sort swaps increments through the array and swaps adjacent elements if i is greater then i+1.
            // Once we hit the wall we deincrement it.
            // Quadratic O(n^2)

            for (int wallIndex = array.Length - 1; wallIndex > 0; wallIndex--) 
            {
                for (int i = 0; i < wallIndex; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            // Selection sort is similar to Bubble sort however instead of swapping two elements next to each other 
            // we swap the largest element with the wall and then deincrement the wall
            // Quadratic O(n^2)

            for (int wallIndex = array.Length -1; wallIndex > 0; wallIndex--)
            {
                int largestAt = 0;
                for (int i = 1; i <= wallIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }

                Swap(array, largestAt, wallIndex);
            }
        }

        public static void InsertionSort(int[] array)
        {
            // Insertion sort takes the element of the wall, saves to an unsorted variable and then works backwards to shift and find 
            // the place of where the element should be inserted.
            // If the element infront of the wall is greater then the element before the wall we leave it in place and immediatly don't hit the inner for loop.
            // Quadratic O(n^2)

            for (int wallIndex = 1; wallIndex <= array.Length - 1; wallIndex++)
            {
                int unsorted = array[wallIndex];
                int i = 0;
                for (i = wallIndex; i > 0 && array[i - 1] > unsorted; i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = unsorted;
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;

            //hold the first int 
            int temp = array[i];
            //set the second int to the first place
            array[i] = array[j];
            //set the first int to the second place
            array[j] = temp;

            //alternatively use a tuple
            //(array[j], array[i]) = (array[i], array[j]);
        }
    }
}
