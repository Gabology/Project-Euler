using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
   public class PositionedNumber
   {
      public readonly int Value;
      public readonly int XPosition;

      public PositionedNumber(int value, int xPosition)
      {
         Value = value;
         XPosition = xPosition;
      }

      public override string ToString()
      {
         return Value.ToString();
      }
   }
}
