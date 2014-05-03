using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.
        static void Main(string[] args)
        {
            Console.WriteLine(Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum());
            Console.ReadKey();
        }
    }
}
