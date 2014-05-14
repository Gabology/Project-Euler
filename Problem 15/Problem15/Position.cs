using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
   public class Position
   {
      public readonly int Column;
      public readonly int Row;
      public long Routes { get; set; }


      public Position(int column, int row)
      {
         Row = row;
         Column = column;
      }

      public override string ToString()
      {
         return String.Format("({0}-{1}), Routes = {2}", Column, Row, Routes);
      }

      public override bool Equals(object obj)
      {
         return this == (Position)obj;
      }

      public static bool operator ==(Position x, Position y)
      {
         return (x.Column == y.Column && x.Row == y.Row) ? true : false;
      }
      public static bool operator !=(Position x, Position y)
      {
         return (x.Column == y.Column && x.Row == y.Row) ? false : true;
      }
   }
}
