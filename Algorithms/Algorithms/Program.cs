using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static int Sorozatszamitas(int[] tomb)
        {
            int eredmeny = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                eredmeny = eredmeny + tomb[i];
            }

            return eredmeny;
        }

        static void Main(string[] args)
        {
            int[] tomb = new int[] { 1, 3, 4, 5, 8 };
            int osszeadasEredmenye = Sorozatszamitas(tomb);

            Console.WriteLine(osszeadasEredmenye);
        }
    }
}
