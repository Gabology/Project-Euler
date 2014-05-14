using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
   public class Grid
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

      public long GetPaths()
      {
         for (int i = this.points.GetUpperBound(0); i >= 0; i--)
         {
            for (int j = this.points.GetUpperBound(0); j >= 0; j--)
            {
               // If we're at the rightmost or bottom boundary then there is only one route to the point
               if (i == this.points.GetUpperBound(0) || j == this.points.GetUpperBound(0)) 
               {
                  this.points[i, j].Routes = 1;
               } 
               else // Else, we add the right neighbour routes + the bottom neighbour routes 
               {
                  this.points[i ,j].Routes = this.points[i + 1, j].Routes + this.points[i, j + 1].Routes;
               }
            }
         }
         // Return the routes of the first point
         return this.points[0,0].Routes;
      }
   }
}
