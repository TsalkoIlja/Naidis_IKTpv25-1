using System;
using System.Collections.Generic;
using System.IO;

namespace Naidis_IKTpv25
{
    public class Osa4_funktsioonid
    {
       
        // Ülesanne 0: Kuud.txt näide
        

        private static string kuudFail =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");

        public static void KuudNaide()
        {
            try
            {
                // 1. Faili kirjutamine
                Console.Write("Sisesta mingi tekst (kuu): ");
                string lause = Console.ReadLine();

                using (StreamWriter sw = new StreamWriter(kuudFail, true))
                {
                    sw.WriteLine(lause);
                }

                // 2. Faili lugemine
                Console.WriteLine("\nFaili sisu:");
                using (StreamReader sr = new StreamReader(kuudFail))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                // 3. Ridade lugemine listi
                List<string> kuude_list = new List<string>();
                foreach (string rida in File.ReadAllLines(kuudFail))
                {
                    kuude_list.Add(rida);
                }

                // 4. Listi muutmine
                kuude_list.Remove("Juuni");
                if (kuude_list.Count > 0)
                    kuude_list[0] = "Veeel kuuu";

                Console.WriteLine("\nPärast muutmist:");
                foreach (string kuu in kuude_list)
                    Console.WriteLine(kuu);

                // 5. Otsing
                Console.Write("\nSisesta kuu otsimiseks: ");
                string otsitav = Console.ReadLine();

                if (kuude_list.Contains(otsitav))
                    Console.WriteLine("Kuu on olemas.");
                else
                    Console.WriteLine("Sellist kuud pole.");

                // 6. Salvestamine
                File.WriteAllLines(kuudFail, kuude_list);
                Console.WriteLine("\nAndmed on salvestatud!");
            }
            catch
            {
                Console.WriteLine("Viga Kuud.txt töötlemisel!");
            }
        }


        // Ülesanded 1–5 (Praktilised ülesanded)

        private static string koostisosadeFail =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");

        private static List<string> LaeKoostisosad()
        {
            if (!File.Exists(koostisosadeFail))
            {
                File.WriteAllLines(koostisosadeFail,
                    new string[] { "Tomat", "Juust", "Ketšup" });
            }

            return new List<string>(File.ReadAllLines(koostisosadeFail));
        }

        // Ülesanne 1
        public static void SalvestaToit()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");

                Console.Write("Sisesta Itaalia toidu nimi: ");
                string toit = Console.ReadLine();

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(toit);
                }

                Console.WriteLine("Toit on salvestatud!");
            }
            catch
            {
                Console.WriteLine("Viga faili kirjutamisel!");
            }
        }

        // Ülesanne 2
        public static void LoeToidud()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");

                using (StreamReader sr = new StreamReader(path))
                {
                    string sisu = sr.ReadToEnd();
                    Console.WriteLine("\nFaili sisu:");
                    Console.WriteLine(sisu);
                }
            }
            catch
            {
                Console.WriteLine("Faili lugemisel tekkis viga!");
            }
        }

        // Ülesanne 3
        public static void MuudaKoostisosad()
        {
            try
            {
                List<string> koostisosad = LaeKoostisosad();

                if (koostisosad.Count > 0)
                    koostisosad[0] = "Kvaliteetne oliiviõli";

                koostisosad.Remove("Ketšup");

                Console.WriteLine("\nUuendatud koostisosad:");
                foreach (string k in koostisosad)
                {
                    Console.WriteLine(k);
                }

                File.WriteAllLines(koostisosadeFail, koostisosad);
                Console.WriteLine("Koostisosad on muudetud ja salvestatud!");
            }
            catch
            {
                Console.WriteLine("Viga koostisosade muutmisel!");
            }
        }

        // Ülesanne 4
        public static void OtsiKoostisosa()
        {
            try
            {
                List<string> koostisosad = LaeKoostisosad();

                Console.Write("Sisesta koostisosa otsimiseks: ");
                string otsitav = Console.ReadLine();

                if (koostisosad.Contains(otsitav))
                    Console.WriteLine("Koostisosa on olemas!");
                else
                    Console.WriteLine("Seda koostisosa ei ole.");
            }
            catch
            {
                Console.WriteLine("Viga otsimisel!");
            }
        }

        // Ülesanne 5
        public static void SalvestaKoostisosad()
        {
            try
            {
                List<string> koostisosad = LaeKoostisosad();

                File.WriteAllLines(koostisosadeFail, koostisosad);
                Console.WriteLine("Uus retsept on edukalt faili salvestatud!");
            }
            catch
            {
                Console.WriteLine("Viga salvestamisel!");
            }
        }
    }
}
