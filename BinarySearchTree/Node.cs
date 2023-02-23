using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
        public class Node<T> where T:IComparable
        {
           //properties
            public T nodedata { get; set; }
            public Node<T> left { get; set; }
            public Node<T> right { get; set; }

            //constructor
            public Node(T data)
            {
                this.nodedata = data;
                this.left = null;
                this.right = null;

            }
       
        }
    
}
