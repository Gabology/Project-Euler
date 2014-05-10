using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    enum Direction
    {
        Left, Right, Up, Down
    }

    class Grid
    {
        public Position[,] points { get; private set; }

        public Grid(int size)
        {
            points = new Position[size + 1, size + 1];

            for (int i = 0; i < points.GetLength(0); i++)
            {
                for (int j = 0; j < points.GetLength(1); j++)
                {
                    points[i, j] = new Position(i, j);
                }
            }
        }

        public BinaryTree GetPathsTo(Position from, Position to)
        {
            var binaryTree = new BinaryTree();

            // Initially we always know that we should add two nodes starting backwards.
            var leftNode = new BinaryTreeNode(new Position(to.Column - 1, to.Row));
            var rightNode = new BinaryTreeNode(new Position(to.Column, to.Row - 1));

            // Now populate the two binary tree nodes
            binaryTree.Nodes[0] = PopulateTreeNode(leftNode, from);
            binaryTree.Nodes[1] = PopulateTreeNode(rightNode, from);

            return binaryTree;
        }

        public BinaryTreeNode PopulateTreeNode(BinaryTreeNode treeNode, Position to)
        {
            //if (treeNode.Item == to) // When we reach our from point then return
            //{
            //    return treeNode;
            //}

            if (treeNode.Item.Row > this.points.GetLowerBound(0)) // As long as we are not at the bounds of the rows we can move up
            {
                treeNode.AddChild(PopulateTreeNode(new BinaryTreeNode(new Position(treeNode.Item.Column, treeNode.Item.Row - 1)), to));
            }

            if (treeNode.Item.Column > this.points.GetLowerBound(1)) // As long as we are not at the bounds of the columns we can move to the left
            {
                treeNode.AddChild(PopulateTreeNode(new BinaryTreeNode(new Position(treeNode.Item.Column - 1, treeNode.Item.Row)), to));
            }

            return treeNode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.points.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < this.points.GetLength(1) - 1; j++)
                {
                    Console.Write(@"[ ]");
                }
                Console.WriteLine();
            }

            return sb.ToString();
        }

    }
}
