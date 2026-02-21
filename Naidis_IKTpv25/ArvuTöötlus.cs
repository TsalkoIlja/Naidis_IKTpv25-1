using System;

namespace Naidis_IKTpv25
{
    public class ArvuTöötlus
    {
        public static int[] GenereeriRuudud(int min, int max)
        {
            Random rnd = new Random();
            int n = rnd.Next(min, max + 1);
            int m = rnd.Next(min, max + 1);

            int algus = Math.Min(n, m);
            int lopp = Math.Max(n, m);

            Console.WriteLine($"Juhuslikud arvud: {n} ja {m}");

            int[] ruudud = new int[lopp - algus + 1];
            int index = 0;

            for (int i = algus; i <= lopp; i++)
            {
                ruudud[index] = i * i;
                Console.WriteLine($"{i} → {ruudud[index]}");
                index++;
            }

            return ruudud;
        }
    }
}