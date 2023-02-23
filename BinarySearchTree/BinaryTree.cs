using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> root { get; set; } = null;
        public  void insert(T data)
        {
           

            if (root == null)
            {
                root = new Node<T>(data);
            }
            Node<T> current = root;
            while (current != null)
            {
                if (data.CompareTo(current.nodedata) > 0)
                {
                    if (current.right != null)
                    {
                        current = current.right;
                        break;
                    }
                    current.right = new Node<T>(data);
                }

                else if (data.CompareTo(current.nodedata) < 0)
                {
                    if (current.left != null)
                    {
                        current = current.left;
                        break;
                    }
                    current.left = new Node<T>(data);
                }

                else
                {
                    return;
                }

            }
           
        }
        public void Display(Node<T> root)
        {
            if (root == null)
            {
                return;
            }
            Display(root.left);
            System.Console.Write(root.nodedata + " ");
            Display(root.right);
        }
    }
}

       