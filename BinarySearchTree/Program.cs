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
            

            Console.WriteLine("\n1.Insertion \n2:Insert More Elements \n3:searching element");
           

            Console.WriteLine("Enter the option!!!");
            int num = Convert.ToInt32(Console.ReadLine());
            BinaryTree<int> binarySearch = new BinaryTree<int>();
            switch (num)
            {
                case 1:
                    binarySearch.insert(56);
                    binarySearch.insert(30);
                    binarySearch.insert(70);
                    binarySearch.Display(binarySearch.root);
                    break;
                case 2:
                    binarySearch.insert(56);
                    binarySearch.insert(30);
                    binarySearch.insert(70);
                    binarySearch.insert(22);
                    binarySearch.insert(40);
                    binarySearch.insert(60);
                    binarySearch.insert(95);
                    binarySearch.insert(11);
                    binarySearch.insert(3);
                    binarySearch.insert(16);
                    binarySearch.insert(65);
                    binarySearch.insert(63);
                    binarySearch.insert(67);
                    // Check if all the numbers are added using the size method
                    int expectedSize = 13;
                    int actualSize = binarySearch.Size(binarySearch.root);
                    if (expectedSize == actualSize)
                    {
                        Console.WriteLine("All numbers were successfully added to the binary tree.");
                    }
                    else
                    {
                        Console.WriteLine("Some numbers were not added to the binary tree.");
                    }
                    // Display the binary tree
                    Console.WriteLine("Binary Tree:");
                    binarySearch.Display(binarySearch.root);
                    break;
                case 3:
                    int valueToSearch = 7;
                    binarySearch.IsExists(valueToSearch, binarySearch.root);
                    break;
                default:
                    Console.WriteLine("Enter above option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
