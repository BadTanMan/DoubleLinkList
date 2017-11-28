using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{

    class BinaryTreeNode
    {
        public int value;
        public BinaryTreeNode left;
        public BinaryTreeNode right;

        //constructor
        public BinaryTreeNode(int initial)
        {
            value = initial;
            left = null;
            right = null;
        }
    }
}
