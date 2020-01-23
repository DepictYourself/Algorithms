namespace Algorithms
{
    partial class Program
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
    }
}
