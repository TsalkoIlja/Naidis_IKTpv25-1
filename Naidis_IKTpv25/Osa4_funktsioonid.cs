using System;
using System.Collections.Generic;
using System.IO;

namespace Naidis_IKTpv25
{
    public class Osa4_funktsioonid
    {
        private static string koostisosadeFail =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");

        // Laadib koostisosad failist või loob faili, kui seda pole
        private static List<string> LaeKoostisosad()
        {
            if (!File.Exists(koostisosadeFail))
            {
                File.WriteAllLines(koostisosadeFail,
                    new string[] { "Tomat", "Juust", "Ketšup" });
            }

            return new List<string>(File.ReadAllLines(koostisosadeFail));
        }

        // Ülesanne 1: Lemmiktoidu salvestamine faili
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

        // Ülesanne 2: Kogu menüü kuvamine
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

        // Ülesanne 3: Koostisosade muutmine
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

        // Ülesanne 4: Otsing listist
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

        // Ülesanne 5: Salvestamine tagasi faili
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
