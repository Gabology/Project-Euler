using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler17
{
   public static class NumberReader
   {
      private static Dictionary<int, string> onesTranslationTable = new Dictionary<int, string>() 
      {
         { 1, "one" },
         { 2, "two" },
         { 3, "three" },
         { 4, "four" },
         { 5, "five" },
         { 6, "six" },
         { 7, "seven" },
         { 8, "eight" },
         { 9, "nine" },
      };

      private static Dictionary<int, string> tensTranslationTable = new Dictionary<int, string>()
      {
         { 2, "twenty" },
         { 3, "thirty" },
         { 4, "forty" },
         { 5, "fifty" },
         { 6, "sixty" },
         { 7, "seventy" },
         { 8, "eighty" },
         { 9, "ninety" },
      };

      public static string GetNumberToString(int number)
      {
         var numberString = new StringBuilder();
         GenerateStringSequence(number, numberString);

         return numberString.ToString();
      }

      private static void GenerateStringSequence(int number, StringBuilder sb)
      {
         if (number == 0)
         {
            return;
         }

         //Check for the few exception cases first
         switch (number)
         {
            case 10:
               sb.Append("ten");
               return;
            case 11:
               sb.Append("eleven");
               return;
            case 12:
               sb.Append("twelve");
               return;
            case 13:
               sb.Append("thirteen");
               return;
            case 15:
               sb.Append("fifteen");
               return;
            case 18:
               sb.Append("eighteen");
               return;
            case 1000:
               sb.Append("one thousand");
               return;
         }

         int[] numbersArray = number.ToString().ToCharArray().Select(entry => (int)char.GetNumericValue(entry)).ToArray();

         //Check the size of the number
         if (number / 100 >= 1)
         {
            if (numbersArray[1] == 0 && numbersArray[2] == 0)
            {
               sb.Append(string.Format("{0} hundred", onesTranslationTable[numbersArray[0]]));
            } 
            else
            {
               sb.Append(string.Format("{0} hundred and ", onesTranslationTable[numbersArray[0]]));
               GenerateStringSequence(number - (numbersArray[0] * 100), sb);
            }
         } 
         else if (number / 10 >= 1)
         {
            if (number < 20)
            {
               sb.Append(string.Format("{0}teen", onesTranslationTable[numbersArray[1]]));
            } 
            else
            {
               sb.Append(string.Format("{0}-", tensTranslationTable[numbersArray[0]]));
               GenerateStringSequence(number - (numbersArray[0] * 10), sb);
            }
         } 
         else
         {
            sb.Append(onesTranslationTable[number]);
         }

      }
   }
}
