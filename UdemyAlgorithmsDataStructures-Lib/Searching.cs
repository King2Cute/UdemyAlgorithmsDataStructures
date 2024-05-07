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

		public static void TestStack()
		{
			int[] array = { 10, 12, 13, 15, 2, 3, 4, 1 };
			Stack<int> stack = new Stack<int>(array);

			while (stack.Count > 0)
			{
				var top = stack.Pop();
				Console.WriteLine(top);
			}

			List<int> list = new List<int>();
			Queue<int> queue = new Queue<int>(array);
			
		}
	}
}
