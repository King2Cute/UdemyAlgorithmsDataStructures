using UdemyAlgorithmsDataStructures_Lib;
using UdemyAlgorithmsDataStructures_Lib.BinarySearchTree;

namespace UdemyAlgorithmsDataStructures
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

	internal class Program
	{
		static void Main(string[] args)
		{
			BinarySearchTree bst = new BinarySearchTree();
			bst.Insert(7, "Squirtle");
			bst.Insert(23, "Ekans");
			bst.Insert(151, "Mew");
			bst.Insert(4, "Charmander");
			bst.Insert(1, "Bulbasaur");

			Console.WriteLine(bst.Find(151));
		}
	}
}
