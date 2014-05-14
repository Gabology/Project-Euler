using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem16
{
   public class Program
   {
      // Problem 16
      // Power Digit Sum
      // 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
      // What is the sum of the digits of the number 2^1000?
      static void Main(string[] args)
      {

      }

      public static double GetPowerDigitSum(int number, int power)
      {
         // This is a fairly easy problem, let's solve this with one line of code.
         return  BigInteger.Pow(number, power)
                .ToString()
                .ToCharArray()
                .Where(entry => char.IsNumber(entry) && char.GetNumericValue(entry) != 0)
                .Select(entry => char.GetNumericValue(entry))
                .Sum();
      }
   }
}
