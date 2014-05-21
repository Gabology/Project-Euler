using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler20
{
   public class Program
   {
      // Problem 20
      // Factorial digit sum
      // n! means n × (n − 1) × ... × 3 × 2 × 1
      // For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
      // and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
      // Find the sum of the digits in the number 100!
      static void Main(string[] args)
      {
         Console.Write(GetFactorial(100).ToString().ToCharArray().Select(num => char.GetNumericValue(num)).Sum());
         Console.ReadKey();
      }
      public static BigInteger GetFactorial(int n)
      {
         return GetFactorial(n - 2, n * (n - 1));
      }

      public static BigInteger GetFactorial(int n, BigInteger sum)
      {
         sum = sum * n;

         if (n == 1)
         {
            return sum;
         }

         return GetFactorial(n - 1, sum);
      }
   }
}
