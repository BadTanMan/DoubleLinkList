using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    class Tree
    {
        //Methods will use references in order to modify values (ref)

        BinaryTreeNode top;

        #region tree
        /// <summary>
        /// method <c>Tree</c>
        /// </summary>
        public Tree()
        {
            top = null;
        }
        #endregion

        #region tree override
        /// <summary>
        /// method <c>Tree</c>
        /// </summary>
        /// <param name="initial"></param>
        public Tree(int initial)
        {
            top = new BinaryTreeNode(initial);
        }
        #endregion

        #region add
        /// <summary>
        /// method <c>Add</c>
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            RecursiveAdd(ref top, value);
        }
        #endregion

        #region recursive add
        /// <summary>
        /// method <c>RecursiveAdd</c>
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        private void RecursiveAdd(ref BinaryTreeNode node, int value)
        {
            //if node is null add to tree
            if (node == null)
            {
                BinaryTreeNode newNode = new BinaryTreeNode(value);
                node = newNode; // set old node to new node and attach to tree
                return;
            }
            //add left
            if (value < node.value)
            {
                RecursiveAdd(ref node.left, value);
                return;
            }
            //add right
            if (value >= node.value)
            {
                RecursiveAdd(ref node.right, value);
                return;
            }
        }
        #endregion

        #region print
        /// <summary>
        /// method <c>Print</c>
        /// </summary>
        /// <param name="node"></param>
        /// <param name="outString"></param>
        public void Print(BinaryTreeNode node, ref string outString)
        {
            //write out tree in ascending order
            if (node == null)
            {
                node = top;
            }
            //if node is not null print out left node
            if (node.left != null)
            {
                Print(node.left, ref outString);
                outString = outString + node.value.ToString().PadLeft(3);
            }
            else
            {
                outString = outString + node.value.ToString().PadLeft(3);
            }
            //if node is not null print right
            if (node.right != null)
            {
                Print(node.right, ref outString);
            }
        }
        #endregion

        #region search
        /// <summary>
        /// method <c>Search</c>
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool Search(long num)
        {
            return Search(this.top, num);
        }
        #endregion

        #region search override
        /// <summary>
        /// method <c>Search</c>
        /// </summary>
        /// <param name="top"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        private bool Search(BinaryTreeNode top, long num) // recursive worker
        {
            if (top == null) // if node does not exist return false
            {
                return false;
            }
            else if (top.value == num) // if node exists return true
            {
                return true;
            }
            else if (num < top.value) // if node is less than parent run recursion and search left
            {
                return Search(top.left, num);
            }

            else
            {
                return Search(top.right, num); //if node is more than parent run recursion and search right
            }              
        }
        #endregion

        #region delete
        /// <summary>
        /// method <c>Delete</c>
        /// </summary>
        /// <param name="num"></param>
        public void Delete(int num)
        {
            if (Search(num) == true) //if node exist delete it!
            {
                Delete(ref this.top, num);
                Console.WriteLine("Node deleted!");
            }
            else
            {
                Console.WriteLine("Node doesn't exist!");
            }
        }
        #endregion

        #region delete override
        /// <summary>
        /// method <c> Delete</c>
        /// </summary>
        /// <param name="top"></param>
        /// <param name="num"></param>
        private void Delete(ref BinaryTreeNode top, int num)
        {
            if (top != null)
            {
                if (num < top.value) //if search node is less than parent node run recursion and traverse left
                    Delete(ref top.left, num);
                else if (num > top.value) //if search node is greater than parent node run recursion and traverse right
                    Delete(ref top.right, num);
                else
                {
                    if (top.left == null && top.right == null)
                    {
                        top = null;
                    }
                    else if (top.left != null && top.right == null)
                    {
                        top = top.left;
                    }
                    else if (top.left == null && top.right != null)
                    {
                        top = top.right;
                    }
                    else
                    {
                        if (top.right.left == null)
                        {
                            top.right.left = top.left;
                            top = top.right;
                        }
                        else
                        {
                            BinaryTreeNode q = top.right;
                            BinaryTreeNode p = top.right;
                            while (p.left.left != null)
                                p = p.left;
                            q = p.left;
                            p.left = q.right;
                            q.left = top.left;
                            q.right = top.right;
                            top = q;
                        }
                    }
                }
            }
        }
        #endregion
    }
}
