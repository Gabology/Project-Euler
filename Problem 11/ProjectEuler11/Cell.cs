using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler11
{
    class Cell<T>
    {
        public readonly T Value;
        public readonly Position Position;

        public Cell(Position position, T value)
        {
            Value = value;
            Position = position;
        }
    }
}
