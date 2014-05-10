using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class BinaryTreeNode
    {
        public readonly Position Item;
        public BinaryTreeNode LeftChild { get; private set; }
        public BinaryTreeNode RightChild { get; private set; }

        public BinaryTreeNode(Position item, BinaryTreeNode[] children)
        {
            this.Item = item;

            if (children.Length > 2)
            {
                throw new ArgumentOutOfRangeException("Parameter array was larger than expected");
            }

            this.LeftChild = children[0];
            this.RightChild = (children[1] != null) ? children[1] : null;
        }
        
        public BinaryTreeNode(Position item, BinaryTreeNode child)
        {
            this.Item = item;
            this.LeftChild = child;
        }

        public BinaryTreeNode(Position item)
        {
            this.Item = item;
        }

        public void AddChild(BinaryTreeNode child)
        {
            if (LeftChild == null)
            {
                LeftChild = child;
            } 
            else if (RightChild == null)
            {
                RightChild = child;
            } 
            else 
            { 
                throw new ArgumentException("TreeNode already has the maximum amount of children!");
            }
        }

    }
}
