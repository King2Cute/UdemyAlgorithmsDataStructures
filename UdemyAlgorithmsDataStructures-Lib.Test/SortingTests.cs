﻿using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace UdemyAlgorithmsDataStructures_Lib.Test
{
    [TestFixture]
    public class SortingTests
    {
        private int[][] Samples()
        {
            int[][] samples =
            [
                [1],
                [2, 1],
                [2, 1, 3],
                [1, 1, 1],
                [2, -1, 3, 3],
                [4, -5, 3, 3],
                [0, -5, 3, 3],
                [0, -5, 3, 0],
                [3, 2, 5, 5, 1, 0, 7, 8],
            ];

            return samples;
        }

        private void RunTestsForSortAlgorithm(Action<int[]> sort)
        {
            foreach (var sample in Samples()) 
            {
                sort(sample);
                CollectionAssert.IsOrdered(sample);
                PrintOut(sample);
            }
        }

        private static void PrintOut(int[] sample) 
        {
            TestContext.WriteLine("-----TRACE-----\n");
            foreach(var el in sample)
            {
                TestContext.Write(el + " ");
            }

            TestContext.WriteLine("\n-------------------\n");
        }

        [Test]
        public void BubbleSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(Sorting.BubbleSort);
        }

        [Test]
        public void SelectionSort_ValidInput_SortedInput()
        {
            RunTestsForSortAlgorithm(Sorting.SelectionSort);
        }
    }
}