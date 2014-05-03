using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler11
{
    struct Position
    {
        public readonly int Row;
        public readonly int Column;

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
