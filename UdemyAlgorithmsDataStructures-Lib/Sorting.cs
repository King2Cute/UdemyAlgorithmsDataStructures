namespace UdemyAlgorithmsDataStructures_Lib
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
					if (array[i] > array[i + 1])
					{
						Swap(array, i, i + 1);
					}
				}
			}
		}

		public static void SelectionSort(int[] array)
		{
			// Selection sort is similar to Bubble sort however instead of swapping two elements next to each other 
			// We swap the largest element with the wall and then deincrement the wall

			// Quadratic O(n^2)

			for (int wallIndex = array.Length - 1; wallIndex > 0; wallIndex--)
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

		public static void ShellSort(int[] array)
		{
			// Shell sort uses a gap to pre sort most of the array and then switches to insertion sort to finish.
			// To calculate the gap for a shell sort we can rely on the "universal" sequence of max gap < N/3 where N is the length of the array.
			// Alternatively we can use max gap = N/2 at each step and then reduce the gap with gap /= 2

			// Shell sort will then take the element at the start and gap and switch if the higher is lower, both forwards and backwards.
			// When the gap becomes 1 it becomes the insertion sort.

			//Best: O(nlogn): Loglinear complexity.
			//Worst: 

			int gap = 1;
			while (gap < array.Length / 3)
				gap = 3 * gap + 1;

			while (gap >= 1)
			{
				for (int i = gap; i < array.Length; i++)
				{
					for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
					{
						Swap(array, j, j - gap);
					}
				}

				gap /= 3;
			}
		}

		public static void MergeSort(int[] array)
		{
			// merge sort is split into two different phase: splitting and then merging.

			// the splitting is essentially taking the array and halfing it, in cases of a none even half you will end up just splitting it where 
			// one half is bigger then the other. You keep splitting till your left with a sub arrays and sibling arrays
			// 38 27 43 3 9 82 10 
			// splits to 
			// 38 27 43 3 | 9 82 10
			// splits to 
			// 38 27 | 43 3 | 9 82 | 10
			// splits to 
			// 38 | 27 | 43 | 3 | 9 | 82 | 10
			// 2 merged sibling arrays on the left, 1 on the right.

			// we then merge these arrays back again sorting them in the process 
			// 27 38 | 3 43 | 9 82 | 10
			// finally we can go through the arrays and compare sorting into the correct order. we do this by first using the 2 sibling arrays 
			// on the left hand side and it goes something like 
			// 3 is less then 27, 27 is less then 43, 38 is less then 43 finally 43
			// 3, 27, 38, 43
			// then we move onto the right side - 9 is less then 10, 10 is less then 82 
			// 9, 10, 82
			// finally we take both out 3, 27, 38, 43 and 9, 10, 82 and do the same
			// 3 is less then 9, 9 is less then 27, 10 is less then 27, 27 is les then 82, 38 is less then 82, 43 is less then 82
			// 3, 9, 10, 27, 38, 43, 82

			// Linearithmic O(n log n)


			int[] aux = new int[array.Length];
			Sort(0, array.Length - 1);

			void Sort(int low, int high)
			{
				if (high <= low)
					return;

				int mid = (high + low) / 2;
				Sort(low, mid);
				Sort(mid + 1, high);

				Merge(low, mid, high);
			}

			void Merge(int low, int mid, int high)
			{
				if (array[mid] <= array[mid + 1])
					return;

				int i = low;
				int j = mid + 1;

				Array.Copy(array, low, aux, low, high - low + 1);

				for (int k = low; k <= high; k++)
				{
					if (i > mid) array[k] = aux[j++];
					else if (j > high) array[k] = aux[i++];
					else if (aux[j] < aux[i])
						array[k] = aux[j++];
					else
						array[k] = aux[i++];
				}
			}
		}

		public static void QuickSort(int[] array)
		{
			// Divide and conquer comparison based
			// Choose a pivot array usually first or last 
			// Reorder so all elements that are smaller are before and larger are after
			// Recursively repeats until the array is sorted

			// Ranging from Logarithmic O(n log n) to Quadratic O(n^2)

			Sort(0, array.Length - 1);

			void Sort(int low, int high)
			{
				if (high <= low)
					return;

				int j = Partition(low, high);
				Console.WriteLine($"Partition is set to: {j}");
				Sort(low, j - 1);
				Sort(j + 1, high);
			}

			int Partition(int low, int high)
			{
				int i = low;
				int j = high + 1;

				//pivot is the first one in the partition
				Console.WriteLine($"pivot is {array[low]}");
				int pivot = array[low];

				while (true)
				{
					while (array[++i] < pivot)
					{
						if (i == high) break;
					}

					while (pivot < array[--j])
					{
						if (j == low) break;
					}

					if (i >= j) break;

					Swap(array, i, j);
				}

				Swap(array, low, j);
				return j;
			}
		}

		private static void Swap(int[] array, int i, int j)
		{
			if (i == j)
				return;

			// Swap array j and array i
			(array[j], array[i]) = (array[i], array[j]);

			Console.WriteLine($"Swapping j and i with i and j: {array[i]}, {array[j]}");
			array.ToList().ForEach(i => Console.WriteLine(i.ToString()));
		}
	}
}
