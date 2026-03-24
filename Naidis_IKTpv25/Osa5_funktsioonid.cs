using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace Naidis_IKTpv25
{
    public class Osa5_funktsioonid
    {
        // ============================
        // 1. ArrayList näide
        // ============================
        public static void ArrayListNaide()
        {
            ArrayList nimed = new ArrayList();

            // Elementide lisamine
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            // Kontroll – kas element on olemas
            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            // Elementide arv
            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            // Elemendi lisamine kindlasse kohta
            nimed.Insert(1, "Sass");

            // Indeksi leidmine
            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            // Kõigi elementide väljastamine
            Console.WriteLine("\nKõik nimed:");
            foreach (string nimi in nimed)
                Console.WriteLine(nimi);

            // Sorteerimine
            nimed.Sort();

            Console.WriteLine("\nSorteeritud nimed:");
            foreach (string nimi in nimed)
                Console.WriteLine(nimi);
        }

        // ============================
        // 2. Tuple näide
        // ============================
        public static void TupleNaide()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }

        // ============================
        // 3. List<T> näide
        // ============================
        public static void ListNaide()
        {
            List<Person> people = new List<Person>();

            // Elementide lisamine
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            // Mitme elemendi lisamine korraga
            people.AddRange(new List<Person>()
            {
                new Person() { Name = "Sander" },
                new Person() { Name = "Karl" }
            });

            // Elemendi lisamine kindlasse kohta
            people.Insert(1, new Person() { Name = "Laura" });

            // Elemendi otsimine
            int index = people.FindIndex(p => p.Name == "Mirje");
            Console.WriteLine("Mirje indeks: " + index);

            // Eemaldamine
            people.Remove(people[0]);
            people.RemoveAt(1);

            // Sorteerimine
            people.Sort((a, b) => a.Name.CompareTo(b.Name));

            // Kiire otsing
            int pos = people.BinarySearch(new Person() { Name = "Sander" },
                Comparer<Person>.Create((a, b) => a.Name.CompareTo(b.Name)));

            Console.WriteLine("Sander positsioon (BinarySearch): " + pos);

            // Lõplik nimekiri
            Console.WriteLine("\nLõplik nimekiri:");
            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        // ============================
        // 4. LinkedList näide
        // ============================
        public static void LinkedListNaide()
        {
            LinkedList<int> loetelu = new LinkedList<int>();

            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            // Elemendi leidmine ja lisamine selle järgi
            LinkedListNode<int> node3 = loetelu.Find(3);
            loetelu.AddAfter(node3, 10);

            LinkedListNode<int> node5 = loetelu.Find(5);
            loetelu.AddBefore(node5, 99);

            Console.WriteLine("Algne loetelu:");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            // Eemaldamised
            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.Remove(99);

            Console.WriteLine("\nPärast eemaldamisi:");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);
        }

        // ============================
        // 5. Dictionary näide
        // ============================
        public static void DictionaryNaide()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();

            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            Console.WriteLine("Algne sõnastik:");
            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            // Kontrollid
            Console.WriteLine("\nKas võti 2 olemas: " + riigid.ContainsKey(2));
            Console.WriteLine("Kas väärtus 'Eesti' olemas: " + riigid.ContainsValue("Eesti"));

            // Väärtuse muutmine
            riigid[2] = "Eestimaa";

            // Eemaldamine
            riigid.Remove(3);

            Console.WriteLine("\nPärast muudatusi:");
            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");
        }

        
        // Ülesanne 1 – Kalorite kalkulaator
        
        public static void KaloriteKalkulaator()
        {
            Console.WriteLine("\n--- KALORITE KALKULAATOR ---");

            // Toodete nimekiri
            List<Toode> tooted = new List<Toode>()
            {
                new Toode() { Nimi = "Õun", Kalorid100g = 52 },
                new Toode() { Nimi = "Kartul", Kalorid100g = 77 },
                new Toode() { Nimi = "Kanafilee", Kalorid100g = 165 },
                new Toode() { Nimi = "Riis", Kalorid100g = 130 }
            };

            // Kasutaja sisestused
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

            // Inimese objekt
            Inimene inimene = new Inimene()
            {
                Nimi = nimi,
                Vanus = vanus,
                Sugu = sugu,
                Pikkus = pikkus,
                Kaal = kaal,
                Aktiivsustase = aktiivsus
            };

            // Arvutus
            float paevaKalorid = inimene.ArvutaPaevaKalorid();
            Console.WriteLine($"\nPäevane energiavajadus: {paevaKalorid:F0} kcal");

            // Kontroll – kas arvutus on realistlik
            Console.WriteLine("\n[Kontroll] Päevase kaloriarvutuse kontroll:");
            if (paevaKalorid > 500 && paevaKalorid < 6000)
                Console.WriteLine("OK: Kalorite arv on realistlik.");
            else
                Console.WriteLine("VIGA: Kalorite arv ei ole realistlik!");

            // Kui palju toitu võib süüa
            Console.WriteLine("\nKui palju toitu võib süüa:");
            foreach (var t in tooted)
            {
                float kogus = (paevaKalorid / t.Kalorid100g) * 100f;
                Console.WriteLine($"{t.Nimi}: {kogus:F0} g");
            }

            // Kontroll – kas tooted olemas
            Console.WriteLine("\n[Kontroll] Toodete nimekiri:");
            Console.WriteLine(tooted.Count > 0 ? "OK: Tooted olemas." : "VIGA: Tooted puuduvad!");

            // Kontroll – valemi test
            Console.WriteLine("\n[Kontroll] Valemi kontroll:");
            float test = (1000 / 100f) * 100f;
            Console.WriteLine(test == 1000 ? "OK: Valem töötab." : "VIGA: Valem ei tööta!");
        }

        
        // Ülesanne 2 – Maakonnad ja pealinnad
        
        public static void MaakonnadJaPealinnad()
        {
            Console.WriteLine("\n--- ÜLESANNE 2: Maakonnad ja pealinnad ---");

            Dictionary<string, string> maakonnad = new Dictionary<string, string>()
            {
                { "Harjumaa", "Tallinn" },
                { "Tartumaa", "Tartu" },
                { "Pärnumaa", "Pärnu" },
                { "Ida-Virumaa", "Jõhvi" },
                { "Läänemaa", "Haapsalu" }
            };

            while (true)
            {
                Console.WriteLine("\nVali tegevus:");
                Console.WriteLine("1 - Leia maakond pealinna järgi");
                Console.WriteLine("2 - Leia pealinn maakonna järgi");
                Console.WriteLine("3 - Lisa uus maakond ja pealinn");
                Console.WriteLine("4 - Mängurežiim");
                Console.WriteLine("0 - Välju");

                Console.Write("Valik: ");
                string valik = Console.ReadLine();

                if (valik == "0")
                    break;

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
                else if (valik == "2")
                {
                    Console.Write("Sisesta maakond: ");
                    string maakond = Console.ReadLine();

                    if (maakonnad.ContainsKey(maakond))
                        Console.WriteLine($"Maakonna {maakond} pealinn on: {maakonnad[maakond]}");
                    else
                        Console.WriteLine("Andmeid ei ole.");
                }
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

            Console.WriteLine("\n--- Õpilaste analüüs ---");

            double parimKeskmine = 0;
            string parimOpilane = "";

            foreach (var o in opilased)
            {
                double keskmine = o.Hinded.Average();
                Console.WriteLine($"{o.Nimi} keskmine hinne: {keskmine:F2}");

                if (keskmine > parimKeskmine)
                {
                    parimKeskmine = keskmine;
                    parimOpilane = o.Nimi;
                }
            }

            Console.WriteLine($"\nKõrgeima keskmise sai: {parimOpilane} ({parimKeskmine:F2})");
        }
    }
}

