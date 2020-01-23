using System;

namespace Algorithms
{
    partial class Program
    {
        static void Main(string[] args)
        {
            #region Sorozatszamitas teszt

            //int[] tomb = new int[] { 1, 3, 4, 5, 8 };
            //int osszeadasEredmenye = Sorozatszamitas(tomb);

            //Console.WriteLine(osszeadasEredmenye);

            #endregion

            #region Eldontes teszt

            //int[] tomb1 = new int[] { 1, 2 };
            //bool eredmeny1 = Eldontes(tomb1);

            //int[] tomb2 = new int[] { 1, 6 };
            //bool eredmeny2 = Eldontes(tomb2);

            //Console.WriteLine(eredmeny1);
            //Console.WriteLine(eredmeny2);

            #endregion

            #region Kivalasztas teszt

            int[] tomb = new int[] { 1, 2, 3, 4, 5, 6 };
            int eredmeny = Kivalasztas(tomb);

            Console.WriteLine(eredmeny);

            #endregion
        }
    }
}