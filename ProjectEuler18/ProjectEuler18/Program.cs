using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
   class Program
   {
      // Problem 18
      // Maximum path sum I
      // By starting at the top of the triangle below and moving to adjacent numbers on the row below, 
      // the maximum total from top to bottom is 23.
      //    3
      //   7 4
      //  2 4 6
      // 8 5 9 3
      // That is, 3 + 7 + 4 + 9 = 23.
      // Find the maximum total from top to bottom of the triangle below:
      static void Main(string[] args)
      {
         var timer = new EulerTimer.Timer();
         var pyramid = new NumberTriangle();
         pyramid.AddRow(75);
         pyramid.AddRow(95, 64);
         pyramid.AddRow(17, 47, 82);
         pyramid.AddRow(18, 35, 87, 10);
         pyramid.AddRow(20, 04, 82, 47, 65);
         pyramid.AddRow(19, 01, 23, 75, 03, 34);
         pyramid.AddRow(88, 02, 77, 73, 07, 63, 67);
         pyramid.AddRow(99, 65, 04, 28, 06, 16, 70, 92);
         pyramid.AddRow(41, 41, 26, 56, 83, 40, 80, 70, 33);
         pyramid.AddRow(41, 48, 72, 33, 47, 32, 37, 16, 94, 29);
         pyramid.AddRow(53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14);
         pyramid.AddRow(70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57);
         pyramid.AddRow(91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48);
         pyramid.AddRow(63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31);
         pyramid.AddRow(04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23);
         //Console.Write(pyramid.ToString());
         Console.WriteLine(pyramid.GetMaximumPathSum());
      }
   }
}
