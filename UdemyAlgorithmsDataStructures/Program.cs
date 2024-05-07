using UdemyAlgorithmsDataStructures_Lib;

namespace UdemyAlgorithmsDataStructures
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Time complexity cheat sheet
			// O(1): Constant complexity. - Best
			// O(logn): Logarithmic complexity. - Good
			// O(n): Linear complexity. - Fair
			// O(nlogn): Loglinear complexity. - Bad
			// O(n^2): Quadratic complexity. - Worst
			// O(n^3): Cubic complexity. - Worst
			// O(X^n): Exponential time. - Worst
			// O(n!): Factorial complexity. - Worst

			Searching.TestStack();
			var index = Searching.BinarySearch(30);
		}
	}
}
