using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler17
{
   public class Program
   {
      // Problem 17
      // Number letter counts
      // If the numbers 1 to 5 are written out in words: 
      // one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
      // If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
      // NOTE: Do not count spaces or hyphens. 
      // For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
      // The use of "and" when writing out numbers is in compliance with British usage.
      static void Main(string[] args)
      {
         Console.Write(GetNumberLetterCounts(1000));
         Console.ReadKey();
      }

      public static long GetNumberLetterCounts(int to)
      {
         var strNumbers = new string[to];

         for (int i = 0; i < to; i++)
         {
            strNumbers[i] = NumberReader.GetNumberToString(i + 1);
         }

         //Trim whitespace and hyphens
         var trimmedStrings = strNumbers.Select(entry => entry.Replace("-", string.Empty).Replace(" ", string.Empty));

         return trimmedStrings.Select(entry => entry.Length).Sum();
      } 
   }
}
