using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class Program
    {
        // Lattice Paths
        // Problem 15
        // Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,
        // there are exactly 6 routes to the bottom right corner.
        // How many such routes are there through a 20×20 grid?
        static void Main(string[] args)
        {
            var grid = new Grid(2);
            var binaryTree = grid.GetPathsTo(grid.points[0, 0], grid.points[2, 2]);
            Console.ReadKey();
        }
    }
}
