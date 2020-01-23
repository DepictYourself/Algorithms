using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    partial class Program
    {
        static bool Eldontes(int[] x)
        {
            int i = 0;
            while(i < x.Length && !(x[i] > 5))
            {
                i = i + 1;
            }
            bool van = i < x.Length;

            return van;
        }
    }
}
