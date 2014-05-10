using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class Position
    {
        private static int ctr;
        public readonly int Id;
        public readonly int Column;
        public readonly int Row;

        public Position(int column, int row)
        {
            Id = ctr++;
            Row = row;
            Column = column;
        }

        public override string ToString()
        {
            return String.Format("{0} = ({1}, {2})", Id, Row, Column);
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
