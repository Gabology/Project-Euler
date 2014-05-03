using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler6
{
    class Program
    {
        // The sum of the squares of the first ten natural numbers is,
        //    1^2 + 2^2 + ... + 10^2 = 385
        // The square of the sum of the first ten natural numbers is,
        //  (1 + 2 + ... + 10)^2 = 552 = 3025
        // Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        static void Main(string[] args)
        {
            int sumOfSquares = Enumerable.Range(1, 100).Select(n => n * n).Sum();
            int squareOfSum = (int)Math.Pow(Enumerable.Range(1, 100).Sum(), 2);
            Console.Write("The difference is: " + (sumOfSquares - squareOfSum).ToString());
            Console.ReadKey();
        }
    }
}
