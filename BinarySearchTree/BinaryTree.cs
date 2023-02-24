using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> root { get; set; } = null;
        public int count = 0;
        public  void insert(T data)
        {
            if (root == null)
            {
                root = new Node<T>(data);
                count++;
                
            }
            Node<T> current = root;
            while (current != null)
            {
                if (data.CompareTo(current.nodedata) > 0)
                {
                    if (current.right != null)
                    {
                        current = current.right;
                       
                    }
                    current.right = new Node<T>(data);
                    count++;
                    break;
                }

                else if (data.CompareTo(current.nodedata) < 0)
                {
                    if (current.left != null)
                    {
                        current = current.left;
                        
                    }
                    current.left = new Node<T>(data);
                    count++;
                    break;
                }

                else
                {
                    return;
                }

            }
           
        }
        public int Size()
        {
            return count;
        }
        public Node<T> Search(T value, Node<T> root)
        {
            if (root == null)
            {
                return null;
            }
            else if (value.CompareTo(root.nodedata) < 0)
            {
                return Search(value, root.left);
            }
            else if (value.CompareTo(root.nodedata) > 0)
            {
                return Search(value, root.right);
            }
            else
            {
                return root;
            }
        }
        public void isExists(T data, Node<T> root)
        {
            Node<T> node = Search(data, root);
            if (node != null)
            {

                Console.WriteLine("Element Found :" + node.nodedata);
            }
            else
                Console.WriteLine("Element {0} is not Found ", data);
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
        public int size(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftSize = size(root.left);
            int rightSize = size(root.right);
            return leftSize + rightSize + 1;
        }
    }
}

       