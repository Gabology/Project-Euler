using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler9
{
    struct PythagoreanTriplet
    {
        public readonly int A;
        public readonly int B;
        public readonly int C;

        public PythagoreanTriplet(int m, int n)
        {
            this.A = (2 * m) * n;
            this.B = (m * m) - (n * n);
            this.C = (m * m) + (n * n); 
        }
    }
}
