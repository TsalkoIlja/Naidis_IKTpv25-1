using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== OSA 5 – Kollektsioonid, Listid ja Sõnastikud ===");

            // 1. ArrayList näide
            Console.WriteLine("\n1) ArrayList näide");
            Osa5_funktsioonid.ArrayListNaide();

            // 2. Tuple näide
            Console.WriteLine("\n2) Tuple näide");
            Osa5_funktsioonid.TupleNaide();

            // 3. List<T> näide
            Console.WriteLine("\n3) List<T> näide");
            Osa5_funktsioonid.ListNaide();

            // 4. LinkedList näide
            Console.WriteLine("\n4) LinkedList näide");
            Osa5_funktsioonid.LinkedListNaide();

            // 5. Dictionary näide
            Console.WriteLine("\n5) Dictionary näide");
            Osa5_funktsioonid.DictionaryNaide();

            // Ülesanne 1 – Kalorite kalkulaator
            Console.WriteLine("\n6) Ülesanne 1 – Kalorite kalkulaator");
            Osa5_funktsioonid.KaloriteKalkulaator();

            // Ülesanne 2 – Maakonnad ja pealinnad
            Console.WriteLine("\n7) Ülesanne 2 – Maakonnad ja pealinnad");
            Osa5_funktsioonid.MaakonnadJaPealinnad();

            // Ülesanne 3 – Õpilaste analüüs
            Console.WriteLine("\n8) Ülesanne 3 – Õpilaste analüüs");
            Osa5_funktsioonid.OpilasteAnalüüs();

            // Ülesanne 4 – Filmide kogu
            Console.WriteLine("\n9) Ülesanne 4 – Filmide kogu");
            Osa5_funktsioonid.FilmideKogu();

            // Ülesanne 5 – Arvude massiivi statistika
            Console.WriteLine("\n10) Ülesanne 5 – Arvude massiivi statistika");
            Osa5_funktsioonid.ArvudeStatistika();

            // Ülesanne 6 – Lemmikloomade register
            Console.WriteLine("\n11) Ülesanne 6 – Lemmikloomade register");
            Osa5_funktsioonid.LemmikloomadeRegister();

            // Ülesanne 7 – Valuutakalkulaator
            Console.WriteLine("\n12) Ülesanne 7 – Valuutakalkulaator");
            Osa5_funktsioonid.Valuutakalkulaator();

            Console.WriteLine("\n=== Kõik ülesanded on lõpetatud ===");
        



            //// Osa 3
            ////8. Õpilastega mängimine
            //string[] opilased = { "Anna", "Peeter", "Laura", "Markus", "Artur", "Sofia", "Rasmus", "Alina", "Karl", "Maria" };
            //Osa3_funktsioonid.Õpilastega_mängimine(opilased);


            ////3. Nimed ja vanused
            //List<Inimene> Inimesed = new List<Inimene>();
            ////Inimene inimene1 = new Inimene("Marina",100);
            ////Inimesed.Add(inimene1);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Mis on {i+1}. inimese nimi?");
            //    string nimi = Console.ReadLine();
            //    Console.WriteLine($"Mis on {i+1}. inimese vanus?");
            //    int vanus = int.Parse(Console.ReadLine());
            //    Inimene inimene = new Inimene(nimi, vanus);
            //    Inimesed.Add(inimene);
            //}

            //var analüüs= Osa3_funktsioonid.Statistika(Inimesed);
            //Console.WriteLine($"Vanuste arv: {analüüs.Item1}");
            //Console.WriteLine($"Vanuste keskmine: {analüüs.Item2}");
            //Console.WriteLine($"Noorim inimene: {analüüs.Item3.Nimi} ({analüüs.Item3.Vanus} aastat vana)");
            //Console.WriteLine($"Vanim inimene: {analüüs.Item4.Nimi} ({analüüs.Item4.Vanus} aastat vana)");

            ////double[] arvud = { 1.5, 2.3, 3.7, 4.1, 5.6 };
            //double[] arvud1 = Naidis_funktsioonid.Täida_massiiv_double(new double[5]);
            //var tulemus=Osa3_funktsioonid.AnalüüsiArve(arvud1);
            //Console.WriteLine($"Summa: {tulemus.Item1}, Keskmine: {tulemus.Item2}, Korrutis: {tulemus.Item3}");

            //var (summa, keskmine, korrutis) = Osa3_funktsioonid.AnalüüsiArve1(arvud1);
            //Console.WriteLine($"Summa: {summa}, Keskmine: {keskmine}, Korrutis: {korrutis}");



            //Console.WriteLine("3. Osa. Kordused ja Listid, massivid");
            //Console.WriteLine("For:");
            //for (int i=0; i<10;i++)
            //{
            //    Console.WriteLine($"Tere, {i+1}!");
            //}
            //Console.WriteLine("While:");
            //int j=0;
            //while (j<10)
            //{
            //    Console.WriteLine($"Tere, {j+1}!");
            //    j++;
            //}
            //Console.WriteLine("Do:");
            //do
            //{
            //    Console.WriteLine($"Tere, {11-j}!");
            //    j--;
            //}
            //while (j!=0);
            //int[] arvud = new int[5];
            //Console.WriteLine("Täisarvude massiiv:");            
            //arvud= Naidis_funktsioonid.Täida_massiiv(arvud);
            //Naidis_funktsioonid.Massiivide_kuvamine(arvud);

            ////Küsi mis positsioonil muuda element ja mis väärtuseks, muuda element ja kuva massiiv
            //Naidis_funktsioonid.Muuda_element_massiivis(arvud);

            //List<Isik> inimesed = new List<Isik>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Sisesta nimi: ");
            //    string nimi = Console.ReadLine();

            //    Console.Write("Sisesta vanus: ");
            //    int vanus = int.Parse(Console.ReadLine());

            //    Isik uusIsik = new Isik();
            //    uusIsik.Nimi = nimi;
            //    uusIsik.Vanus = vanus;

            //    inimesed.Add(uusIsik);
            //}

            //Console.WriteLine("\nKõik inimesed tervitavad:\n");

            //foreach (Isik isik in inimesed)
            //{
            //    isik.Tervita();
            //}

            //int juhuslik_arv = new Random().Next(-5, 25);
            //string juhuslik_arv_to_tekst = juhuslik_arv.ToString();

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("1. Osa Andmetüübid, Alamfunktsioonid/meetodid");
            ////Console.BackgroundColor= ConsoleColor.Green;
            ////Console.ForegroundColor= ConsoleColor.Blue;
            //string tekst= "Tere tulemast C#-i maailma!";
            //Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
            //Console.WriteLine("Oli loodud muutuja tekst, mis võrdub: {0}", tekst);
            //Console.Write("Mis on sinu nimi?: ");
            //string nimi = Console.ReadLine();
            ///*Console.Write("Kui vana sa oled?: ");
            //try
            //{
            //    int vanus = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);              
            //}
            //try
            //{
            //    Console.Write("Arv 1: ");
            //    float a = float.Parse(Console.ReadLine());
            //    Console.Write("Arv 2: ");
            //    float b = float.Parse(Console.ReadLine());
            //    float vastus = Naidis_funktsioonid.Summa(a, b);
            //    Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}*/

            //Random rnd = new Random();
            //int juhuslik_arv = rnd.Next(-5, 25);
            ////1.
            //Console.WriteLine(Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv));
            //juhuslik_arv = rnd.Next(-5, 25);
            ////2. 
            //tekst = Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv);
            //Console.WriteLine(tekst);
            ////Juku ja kino
            //Console.Write(Osa2_funktsioonid.Juku());//vaikimisi nimi= juku
            //Console.Write(Osa2_funktsioonid.Juku(nimi));
            //Console.Write(Osa2_funktsioonid.Juku("Python"));

        }



    }
}
