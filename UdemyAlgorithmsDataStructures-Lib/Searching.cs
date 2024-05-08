namespace UdemyAlgorithmsDataStructures_Lib
{
	public class Searching
	{
		public bool LinearSearch(int[] array, int key)
		{
			for (int i = 0; i < array.Length; i++) 
			{
				if (array[i] == key)
				{
					return true;
				}
			}

			return false;
		}

		public static int BinarySearch(int value)
		{
			// Binary search takes a mid value by adding the start end end value whilst start is less then end. 
			// if mid is the value we return it, else if mid is less then the value the start becomes mid + 1, else the end is mid

			int[] intArray = { -20, -15, 2, 7, 20, 30, 54 };

			int start = 0;
			int end = intArray.Length;

			while (start < end)
			{
				int mid = (start + end) / 2;
				if (intArray[mid] == value)
				{
					return mid;
				}
				else if (intArray[mid] < value)
				{
					start = mid + 1;
				}
				else
				{
					end = mid;
				}
			}

			return -1;
		}
	}
}
