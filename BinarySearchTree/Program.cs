using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Binary Search Tree....");
            BinaryTree<int> binarySearch = new BinaryTree<int>();
            binarySearch.insert(56);
            binarySearch.insert(30);
            binarySearch.insert(70);
            binarySearch.Display(binarySearch.root);
            Console.ReadLine();

       
        }
    }
}
