using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int index;
        public Node max;
        public Node min;
        public Node(int i=0)
        {
            index = i;
        }
        public void Add(int i)
        {
            if (i > index)
                max = new Node(i);
            else
                min = new Node(i);
        }
        public Node getNode(int i)
        {
            if (index == i)
                return this;
            else if (index < i)
                return max.getNode(i);
            else if (index > i)
                return min.getNode(i);
            else
                return null;
        }
    }
}
