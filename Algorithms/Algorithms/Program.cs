using System;

namespace Algorithms
{
    partial class Program
    {
        static void Main(string[] args)
        {
            #region Sorozatszamitas teszt

            int[] tomb = new int[] { 1, 3, 4, 5, 8 };
            int osszeadasEredmenye = Sorozatszamitas(tomb);

            Console.WriteLine(osszeadasEredmenye);

            #endregion


        }
    }
}
