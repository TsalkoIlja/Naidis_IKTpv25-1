using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Naidis_IKTpv25
{
    public class Osa3_funktsioonid
    {
        // 2. Viie arvu analüüs
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(summa, keskmine, korrutis);
        }
        public static (double summa, double keskmine, double korrutis) AnalüüsiArve1(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return (summa, keskmine, korrutis);
        }
        //3. Nimed ja vanused
        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa=inimesed.Sum(i=>i.Vanus);
            double keskmine_vanus = inimesed.Average(i => i.Vanus);
            Inimene vanim = inimesed.OrderByDescending(i => i.Vanus).First();
            Inimene noorim = inimesed.OrderBy(i => i.Vanus).First();
            return Tuple.Create(summa, keskmine_vanus, noorim, vanim);
        }
        //4. Osta elevant ära
        public static void KuniMärksõnani(string märksõna, string fraas)
        {
            List<string> sisestused = new List<string>();
            string input = "";

            do
            {
                Console.WriteLine(fraas);
                input = Console.ReadLine();
                sisestused.Add(input);

            } while (input != märksõna);

            Console.WriteLine("\nKõik sisestused:");
            foreach (var s in sisestused)
            {
                Console.WriteLine(s);
            }
        }
        //5. Arvamise mäng
        public static void ArvaArv()
        {
            Random rnd = new Random();
            int salajane = rnd.Next(1, 101);
            int katsed = 5;
            bool voit = false;

            for (int i = 1; i <= katsed; i++)
            {
                Console.Write($"Katse {i}/5 - Sisesta arv: ");
                int pakkumine = int.Parse(Console.ReadLine());

                if (pakkumine > salajane)
                    Console.WriteLine("Liiga suur!");
                else if (pakkumine < salajane)
                    Console.WriteLine("Liiga väike!");
                else
                {
                    Console.WriteLine("Õige!");
                    voit = true;
                    break;
                }
            }

            if (!voit)
                Console.WriteLine($"Mäng läbi! Õige arv oli {salajane}");

            Console.WriteLine("Kas soovid uuesti mängida? (jah/ei)");
            if (Console.ReadLine().ToLower() == "jah")
                ArvaArv();
        }
        //6. Suurim neliarvuline arv
        public static int SuurimNeliarv(int[] arvud)
        {
            foreach (int a in arvud)
            {
                if (a < 0 || a > 9)
                {
                    Console.WriteLine("Viga! Ainult ühekohalised arvud (0-9)");
                    return 0;
                }
            }

            Array.Sort(arvud);
            Array.Reverse(arvud);

            int tulemus = 0;
            for (int i = 0; i < arvud.Length; i++)
            {
                tulemus = tulemus * 10 + arvud[i];
            }

            return tulemus;
        
        }
        //7. Korrutustabel
        public static int[,] Korrutustabel(int read, int veerud)
        {
            int[,] tabel = new int[read, veerud];
            for (int i = 0; i < read; i++)
            {
                for (int j = 0; j < veerud; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write($"{tabel[i, j]}\t");
                }
                Console.WriteLine();
            }
            return tabel;
        }
        //8. Õpilastega mängimine
        public static void Õpilastega_mängimine(string[] nimed)
        {
            //Asendab kolmanda ja kuuenda õpilase nime (indeksite põhjal) uue nimega "Kati" ja "Mati".
            Console.WriteLine("Uus nimi:");
            string nimi1 = Console.ReadLine();
            nimed[2] = nimi1;
            nimed[5] = "Mati";
            //Kasutab while tsüklit, et tervitada ainult õpilasi, kelle nimi algab tähega "A".
            int i = 0;
            while (i < nimed.Length)
            {
                if (nimed[i].StartsWith("A"))
                {
                    Console.WriteLine($"Tere, {nimed[i]}!");
                }
                i++;
            }
            //Kasutab for tsüklit, et väljastada kõik nimed ja nende indeksid.
            for (int j = 0; j < nimed.Length; j++)
            {
                Console.WriteLine($"Indeks: {j}, Nimi: {nimed[j]}");
            }
            //Kasutab foreach tsüklit, et väljastada kõik nimed väikeste tähtedena.
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi.ToLower());
            }
            //Kasutab do-while tsüklit, et tervitada õpilasi seni, kuni kohtab nime "Mati".
            i = 0;
            do
            {
                if (nimed[i] == "Mati")
                {
                    Console.WriteLine("Leidsin Mati!");
                    break;
                }
                Console.WriteLine($"Tere, {nimed[i]}!");
                i++;
            }
            while (i<nimed.Length);
        }
        //9. Arvude ruudud
        public static void ArvudeRuudud()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };

            Console.WriteLine("For - ruudud:");
            for (int i = 0; i < arvud.Length; i++)
                Console.WriteLine(arvud[i] * arvud[i]);

            Console.WriteLine("Foreach - kahekordsed:");
            foreach (int a in arvud)
                Console.WriteLine(a * 2);

            int count = 0;
            int j = 0;
            while (j < arvud.Length)
            {
                if (arvud[j] % 3 == 0)
                    count++;
                j++;
            }
            Console.WriteLine($"3-ga jaguvaid arve: {count}");
        }
        //10. Positiivsed ja negatiivsed
        public static void PositiivsedNegatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int pos = 0, neg = 0, zero = 0;

            foreach (int a in arvud)
            {
                if (a > 0) pos++;
                else if (a < 0) neg++;
                else zero++;
            }

            Console.WriteLine($"Positiivseid: {pos}");
            Console.WriteLine($"Negatiivseid: {neg}");
            Console.WriteLine($"Nulle: {zero}");
        }
        //11. Keskmisest suuremad
        public static void KeskmisestSuuremad()
        {
            Random rnd = new Random();
            int[] arvud = new int[15];
            int summa = 0;

            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(1, 101);
                summa += arvud[i];
            }

            double keskmine = (double)summa / arvud.Length;
            Console.WriteLine($"Keskmine: {keskmine}");

            Console.WriteLine("Suuremad kui keskmine:");
            foreach (int a in arvud)
                if (a > keskmine)
                    Console.WriteLine(a);

            int i2 = 0;
            do
            {
                Console.WriteLine(arvud[i2]);
                if (arvud[i2] < 10)
                    break;
                i2++;
            } while (i2 < arvud.Length);
        }
        //12. Kõige suurema arvu otsing
        public static void SuurimArv()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int max = numbrid[0];
            int index = 0;

            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] > max)
                {
                    max = numbrid[i];
                    index = i;
                }
            }

            Console.WriteLine($"Suurim arv: {max}");
            Console.WriteLine($"Indeks: {index}");
        }
        //13. Paaris ja paaritud
        public static void PaarisPaaritud()
        {
            Random rnd = new Random();
            List<int> arvud = new List<int>();

            for (int i = 0; i < 20; i++)
                arvud.Add(rnd.Next(1, 101));

            int paarisSumma = 0;
            int paaritudSumma = 0;
            int paaritudCount = 0;
            int suuremad50 = 0;

            foreach (int a in arvud)
            {
                if (a % 2 == 0)
                    paarisSumma += a;
                else
                {
                    paaritudSumma += a;
                    paaritudCount++;
                }
            }

            int i2 = 0;
            while (i2 < arvud.Count)
            {
                if (arvud[i2] > 50)
                    suuremad50++;
                i2++;
            }

            double paaritudKeskmine = paaritudCount > 0 ?
                (double)paaritudSumma / paaritudCount : 0;

            Console.WriteLine($"Paarisarvude summa: {paarisSumma}");
            Console.WriteLine($"Paaritute keskmine: {paaritudKeskmine}");
            Console.WriteLine($">50 arve: {suuremad50}");
        }
    }
    
}
