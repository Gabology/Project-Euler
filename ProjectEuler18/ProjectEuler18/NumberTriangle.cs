using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
   public class NumberTriangle
   {
      public readonly List<PositionedNumber[]> Rows = new List<PositionedNumber[]>();

      public void AddRow(params int[] numbers)
      {
         var numbersArr = new PositionedNumber[numbers.Length];

         for (int i = 0; i < numbers.Length; i++)
         {
            numbersArr[i] = new PositionedNumber(numbers[i], i);
         }

         this.Rows.Add(numbersArr);
      }

      public int GetMaximumPathSum()
      {
         var sums = new HashSet<int>();
         CalculateSumOfPath(sums, this.Rows.First().First().Value);

         return sums.Max();
      }

      private void CalculateSumOfPath(HashSet<int> finalSum, int accumulator, int index = 0, int xPosition = 0)
      {
         // When we're at the end of the triangle return the sum of the accumulator
         if (index == this.Rows.Count - 1)
         {
            finalSum.Add(accumulator);
            return;
         }

         //Check each adjacent number on the row below and add
         var rowBelow = this.Rows[index + 1];

         var adjacentNumbers = new PositionedNumber[2];
         adjacentNumbers[0] = rowBelow[xPosition];
         adjacentNumbers[1] = xPosition + 1 <= rowBelow.GetUpperBound(0) ? rowBelow[xPosition + 1] : null;

         adjacentNumbers.Where(num => num != null).ToList().ForEach(
            adjNum => CalculateSumOfPath(finalSum, accumulator + adjNum.Value, this.Rows.IndexOf(rowBelow), adjNum.XPosition));
      }

      public override string ToString()
      {
         var sb = new StringBuilder();
         int maxNumbers = this.Rows.Last().Length;

         for (int i = 0; i < this.Rows.Count; i++)
         {
            for (int j = 0; j < maxNumbers; j++)
            {
               // Add one empty space for the offset
               sb.Append(" ");
            }

            foreach (var entry in this.Rows[i])
            {
               sb.Append(entry + " ");
            }

            sb.AppendLine();
            maxNumbers--;
         }

         return sb.ToString();
      }
   }
}
