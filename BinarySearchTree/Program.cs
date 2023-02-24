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
                    binarySearch.insert(60);
                    binarySearch.insert(40);
                    binarySearch.insert(95);
                    binarySearch.insert(65);
                    binarySearch.insert(11);
                    binarySearch.insert(3);
                    binarySearch.insert(16);
                    binarySearch.insert(63);
                    binarySearch.insert(67);
                    binarySearch.Display(binarySearch.root);
                    Console.WriteLine("\nTotal Number of elements =" + binarySearch.Size());
                    break;
                case 3:
                    binarySearch.isExists(63, binarySearch.root);
                    break;
                default:
                    Console.WriteLine("Enter above option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
