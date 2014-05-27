using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler21
{
   public class Program
   {
      // Problem 21
      // Amicable numbers
      // Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
      // If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
      // For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. 
      // The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
      // Evaluate the sum of all the amicable numbers under 10000.

      static void Main(string[] args)
      {
         var amicableNumbers = new HashSet<int>();

         Enumerable.Range(1, 10000)
            .ToList()
            .ForEach(n => GetAmicablePair(n, amicableNumbers));

         Console.Write(amicableNumbers.Sum());
         Console.ReadKey();
      }

      public static void GetAmicablePair(int n, HashSet<int> collection)
      {
         int a = GetFactors(n).Sum();
         int b = GetFactors(a).Sum();

         if (a == GetFactors(b).Sum() && a != b)
         {
            collection.Add(a);
            collection.Add(b);
         }
      }

      public static int[] GetFactors(int n)
      {
         var factors = new HashSet<int>() { 1 };

         for (int i = 2; i <= Math.Sqrt(n); i++)
         {
            if (n % i == 0)
            {
               factors.Add(i);
               factors.Add(n / i);
            }
         }

         return factors.ToArray();
      }
   }
}
