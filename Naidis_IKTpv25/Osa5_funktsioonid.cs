using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Naidis_IKTpv25
{
    public class Osa5_funktsioonid
    {
        
        // 1. ArrayList näide
        
        public static void ArrayListNaide()
        {
            ArrayList nimed = new ArrayList();

            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            Console.WriteLine("\nKõik nimed:");
            foreach (string nimi in nimed)
                Console.WriteLine(nimi);

            nimed.Sort();

            Console.WriteLine("\nSorteeritud nimed:");
            foreach (string nimi in nimed)
                Console.WriteLine(nimi);
        }

        
        // 2. Tuple näide
        
        public static void TupleNaide()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }

        
        // 3. List<T> näide
        
        public static void ListNaide()
        {
            List<Person> people = new List<Person>()
            {
                new Person(){ Name="Kadi"},
                new Person(){ Name="Mirje"},
                new Person(){ Name="Sander"},
                new Person(){ Name="Karl"}
            };

            people.Insert(1, new Person() { Name = "Laura" });

            int index = people.FindIndex(p => p.Name == "Mirje");
            Console.WriteLine("Mirje indeks: " + index);

            people.RemoveAt(0);
            people.RemoveAt(1);

            people.Sort((a, b) => a.Name.CompareTo(b.Name));

            Console.WriteLine("\nLõplik nimekiri:");
            foreach (var p in people)
                Console.WriteLine(p.Name);
        }

        
        // 4. LinkedList näide
        
        public static void LinkedListNaide()
        {
            LinkedList<int> loetelu = new LinkedList<int>();

            loetelu.AddFirst(0);
            loetelu.AddLast(5);
            loetelu.AddLast(3);

            loetelu.AddAfter(loetelu.Find(3), 10);
            loetelu.AddBefore(loetelu.Find(5), 99);

            Console.WriteLine("Algne loetelu:");
            foreach (var arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.Remove(99);

            Console.WriteLine("\nPärast eemaldamisi:");
            foreach (var arv in loetelu)
                Console.WriteLine(arv);
        }

        
        // 5. Dictionary näide
        
        public static void DictionaryNaide()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>()
            {
                {1, "Hiina"},
                {2, "Eesti"},
                {3, "Itaalia"}
            };

            Console.WriteLine("Algne sõnastik:");
            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            riigid[2] = "Eestimaa";
            riigid.Remove(3);

            Console.WriteLine("\nPärast muudatusi:");
            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");
        }

        
        // Ülesanne 1 – Kalorite kalkulaator
        
        public static void KaloriteKalkulaator()
        {
            List<Toode> tooted = new List<Toode>()
            {
                new Toode(){ Nimi="Õun", Kalorid100g=52 },
                new Toode(){ Nimi="Kartul", Kalorid100g=77 },
                new Toode(){ Nimi="Kanafilee", Kalorid100g=165 },
                new Toode(){ Nimi="Riis", Kalorid100g=130 }
            };

            Console.Write("Nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Vanus: ");
            int vanus = int.Parse(Console.ReadLine());

            Console.Write("Sugu (M/N): ");
            string sugu = Console.ReadLine();

            Console.Write("Pikkus (cm): ");
            float pikkus = float.Parse(Console.ReadLine());

            Console.Write("Kaal (kg): ");
            float kaal = float.Parse(Console.ReadLine());

            Console.Write("Aktiivsustase (1.2–1.9): ");
            float aktiivsus = float.Parse(Console.ReadLine());

            Inimene inimene = new Inimene()
            {
                Nimi = nimi,
                Vanus = vanus,
                Sugu = sugu,
                Pikkus = pikkus,
                Kaal = kaal,
                Aktiivsustase = aktiivsus
            };

            float paevaKalorid = inimene.ArvutaPaevaKalorid();
            Console.WriteLine($"\nPäevane energiavajadus: {paevaKalorid:F0} kcal");

            Console.WriteLine("\nKui palju toitu võib süüa:");
            foreach (var t in tooted)
            {
                float kogus = (paevaKalorid / t.Kalorid100g) * 100f;
                Console.WriteLine($"{t.Nimi}: {kogus:F0} g");
            }
        }


        // Ülesanne 2 – Maakonnad ja pealinnad
        public static void MaakonnadJaPealinnad()
        {
            Dictionary<string, string> maakonnad = new Dictionary<string, string>()
            {
        {"Harjumaa", "Tallinn"},
        {"Tartumaa", "Tartu"},
        {"Pärnumaa", "Pärnu"},
        {"Ida-Virumaa", "Jõhvi"},
        {"Läänemaa", "Haapsalu"}
            };

            while (true)
            {
                Console.WriteLine("\n--- ÜLESANNE 2: Maakonnad ja pealinnad ---");
                Console.WriteLine("1 - Leia maakond pealinna järgi");
                Console.WriteLine("2 - Leia pealinn maakonna järgi");
                Console.WriteLine("3 - Lisa uus maakond ja pealinn");
                Console.WriteLine("4 - Mängurežiim");
                Console.WriteLine("0 - Välju");

                Console.Write("Valik: ");
                string valik = Console.ReadLine();

                if (valik == "0")
                    break;

                // 1. Leia maakond pealinna järgi
                if (valik == "1")
                {
                    Console.Write("Sisesta pealinn: ");
                    string linn = Console.ReadLine();

                    bool leitud = false;

                    foreach (var paar in maakonnad)
                    {
                        if (paar.Value.ToLower() == linn.ToLower())
                        {
                            Console.WriteLine($"Pealinn {linn} kuulub maakonda: {paar.Key}");
                            leitud = true;
                            break;
                        }
                    }

                    if (!leitud)
                        Console.WriteLine("Andmeid ei leitud.");
                }

                // 2. Leia pealinn maakonna järgi
                else if (valik == "2")
                {
                    Console.Write("Sisesta maakond: ");
                    string maakond = Console.ReadLine();

                    if (maakonnad.ContainsKey(maakond))
                        Console.WriteLine($"Maakonna {maakond} pealinn on: {maakonnad[maakond]}");
                    else
                        Console.WriteLine("Andmeid ei ole.");
                }

                // 3. Lisa uus maakond ja pealinn
                else if (valik == "3")
                {
                    Console.Write("Uus maakond: ");
                    string uusMaakond = Console.ReadLine();

                    Console.Write("Selle pealinn: ");
                    string uusLinn = Console.ReadLine();

                    if (!maakonnad.ContainsKey(uusMaakond))
                    {
                        maakonnad.Add(uusMaakond, uusLinn);
                        Console.WriteLine("Lisatud!");
                    }
                    else
                    {
                        Console.WriteLine("See maakond on juba olemas.");
                    }
                }

                // 4. Mängurežiim
                else if (valik == "4")
                {
                    Console.WriteLine("\n--- MÄNGUREŽIIM ---");

                    int õiged = 0;
                    int kokku = 5;

                    Random rnd = new Random();

                    for (int i = 0; i < kokku; i++)
                    {
                        var paar = maakonnad.ElementAt(rnd.Next(maakonnad.Count));

                        Console.WriteLine($"\nMis on maakonna {paar.Key} pealinn?");
                        string vastus = Console.ReadLine();

                        if (vastus.ToLower() == paar.Value.ToLower())
                        {
                            Console.WriteLine("Õige!");
                            õiged++;
                        }
                        else
                        {
                            Console.WriteLine($"Vale! Õige vastus: {paar.Value}");
                        }
                    }

                    float protsent = (float)õiged / kokku * 100f;
                    Console.WriteLine($"\nTulemus: {protsent:F0}%");
                }
            }
        }




        // Ülesanne 3 – Õpilaste analüüs

        public static void OpilasteAnalüüs()
        {
            List<Opilane> opilased = new List<Opilane>()
            {
                new Opilane(){ Nimi="Kati", Hinded=new List<int>{5,4,5}},
                new Opilane(){ Nimi="Mati", Hinded=new List<int>{3,4,4}},
                new Opilane(){ Nimi="Laura", Hinded=new List<int>{5,5,5}}
            };

            double parim = 0;
            string nimi = "";

            foreach (var o in opilased)
            {
                double keskmine = o.Hinded.Average();
                Console.WriteLine($"{o.Nimi} keskmine: {keskmine:F2}");

                if (keskmine > parim)
                {
                    parim = keskmine;
                    nimi = o.Nimi;
                }
            }

            Console.WriteLine($"\nParim õpilane: {nimi} ({parim:F2})");
        }

        
        // Ülesanne 4 – Filmide kogu
        
        public static void FilmideKogu()
        {
            List<Film> filmid = new List<Film>()
            {
                new Film(){ Pealkiri="Matrix", Aasta=1999, Zanr="Sci-Fi"},
                new Film(){ Pealkiri="Avatar", Aasta=2009, Zanr="Sci-Fi"},
                new Film(){ Pealkiri="Titanic", Aasta=1997, Zanr="Drama"},
                new Film(){ Pealkiri="Gladiator", Aasta=2000, Zanr="Action"},
                new Film(){ Pealkiri="Jurassic Park", Aasta=1993, Zanr="Adventure"}
            };

            Console.Write("Sisesta žanr: ");
            string zanr = Console.ReadLine();

            var zanriFilmid = filmid.Where(f => f.Zanr.ToLower() == zanr.ToLower());

            Console.WriteLine("\nFilmid žanris:");
            foreach (var f in zanriFilmid)
                Console.WriteLine($"{f.Pealkiri} ({f.Aasta})");

            var uusim = filmid.OrderByDescending(f => f.Aasta).First();
            Console.WriteLine($"\nUusim film: {uusim.Pealkiri} ({uusim.Aasta})");

            var grupp = filmid.GroupBy(f => f.Zanr);

            Console.WriteLine("\nFilmid žanrite kaupa:");
            foreach (var g in grupp)
            {
                Console.WriteLine($"\n{g.Key}:");
                foreach (var f in g)
                    Console.WriteLine($" - {f.Pealkiri}");
            }
        }

        
        // Ülesanne 5 – Arvude statistika
        
        public static double[] TekstistArvud(string tekst)
        {
            return tekst.Split(' ')
                        .Select(x => double.Parse(x))
                        .ToArray();
        }

        public static void ArvudeStatistika()
        {
            Console.Write("Sisesta arvud: ");
            double[] arvud = TekstistArvud(Console.ReadLine());

            Console.WriteLine($"Max: {arvud.Max()}");
            Console.WriteLine($"Min: {arvud.Min()}");
            Console.WriteLine($"Keskmine: {arvud.Average()}");
            Console.WriteLine($"Summa: {arvud.Sum()}");

            int suuremad = arvud.Count(a => a > arvud.Average());
            Console.WriteLine($"Suuremad kui keskmine: {suuremad}");

            Array.Sort(arvud);
            Console.WriteLine("Sorteeritud: " + string.Join(", ", arvud));
        }

        
        // Ülesanne 6 – Lemmikloomade register
       
        public static void LemmikloomadeRegister()
        {
            List<Lemmikloom> loomad = new List<Lemmikloom>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Liik: ");
                string liik = Console.ReadLine();

                Console.Write("Vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                loomad.Add(new Lemmikloom() { Nimi = nimi, Liik = liik, Vanus = vanus });
            }

            Console.WriteLine("\nKõik kassid:");
            foreach (var l in loomad.Where(l => l.Liik.ToLower() == "kass"))
                Console.WriteLine(l.Nimi);

            Console.WriteLine($"Keskmine vanus: {loomad.Average(l => l.Vanus):F1}");

            var vanim = loomad.OrderByDescending(l => l.Vanus).First();
            Console.WriteLine($"Vanim loom: {vanim.Nimi} ({vanim.Vanus})");

            Console.Write("\nOtsi nime järgi: ");
            string otsi = Console.ReadLine();

            var leitud = loomad.FirstOrDefault(l => l.Nimi.ToLower() == otsi.ToLower());

            Console.WriteLine(leitud != null ?
                $"Leitud: {leitud.Nimi}, {leitud.Liik}, {leitud.Vanus}" :
                "Ei leitud.");
        }

       
        // Ülesanne 7 – Valuutakalkulaator
        
        public static void Valuutakalkulaator()
        {
            List<Valuuta> valuutad = new List<Valuuta>()
            {
                new Valuuta(){ Nimetus="USD", KurssEurSuhte=0.93 },
                new Valuuta(){ Nimetus="GBP", KurssEurSuhte=1.17 },
                new Valuuta(){ Nimetus="JPY", KurssEurSuhte=0.007 }
            };

            Dictionary<string, Valuuta> map = valuutad.ToDictionary(v => v.Nimetus);

            Console.Write("Sisesta summa: ");
            double summa = double.Parse(Console.ReadLine());

            Console.Write("Sisesta valuuta: ");
            string nimetus = Console.ReadLine();

            if (!map.ContainsKey(nimetus))
            {
                Console.WriteLine("Tundmatu valuuta.");
                return;
            }

            double eur = summa * map[nimetus].KurssEurSuhte;
            Console.WriteLine($"{summa} {nimetus} = {eur:F2} EUR");

            Console.WriteLine($"EUR → USD: {(eur / map["USD"].KurssEurSuhte):F2}");
        }
    }
}


