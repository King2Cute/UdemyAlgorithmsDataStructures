using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAlgorithmsDataStructures_Lib.BinarySearchTree
{
	public class TreeNode(int key, string value)
	{
		public int Key { get; set; } = key;
		public string Value { get; set; } = value;
		public TreeNode LeftChild { get; set; }
		public TreeNode RightChild { get; set; }
	}
}
