using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class Osa2_funktsioonid
    {
        
        public static string Juku(string nimi="Juku")
        {
            string otsus = "";
            string vastus = "";
            int vanus = 0;
            string pilet = "";
            Console.WriteLine(nimi);
            if (nimi.ToLower() == "juku")
            {
                Console.Write("Kui vana sa oled?: ");
                try
                {
                    vanus = int.Parse(Console.ReadLine());
                    if (vanus > 0 && vanus<100)
                    {
                        if (vanus < 6)
                        {
                            pilet="Sulle on kinopilet tasuta!";
                        }
                        else if (vanus >= 6 && vanus < 14)
                        {
                            pilet="Sulle on kinopilet on lastepilet!";
                        }
                        else if (vanus >= 14 && vanus < 65)
                        {
                            pilet="Sulle on kinopilet täispilet!";
                        }
                        else if (vanus >= 65)
                        {
                            pilet="Sulle on kinopilet sooduspilet!";
                        }
                    }
                    else 
                    { 
                        pilet="Tundmatupilet. Vanus peab olema >0 arv ja <100!";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                otsus= $"Lähme kinno! {pilet}";
            }
            else
            {
                otsus = "Ma olen hõivatud" ;
            } 
            vastus=$"Tere {nimi}, {otsus}";
            return vastus; 
        }
        // 2. Pinginaabrid
        public static string Pinginaabrid()
        {
            Console.Write("Esimene nimi: ");
            string nimi1 = Console.ReadLine();
            Console.Write("Teine nimi: ");
            string nimi2 = Console.ReadLine();

            return $"{nimi1} ja {nimi2} on täna pinginaabrid.";
        }

        // 3. Ristkülik + remont
        public static void RistkylikJaRemont()
        {
            Console.Write("Seina pikkus: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Seina laius: ");
            float b = float.Parse(Console.ReadLine());

            float pindala = a * b;
            Console.WriteLine($"Põranda pindala on {pindala}");

            Console.Write("Kas soovid remonti teha? (jah/ei): ");
            string vastus = Console.ReadLine();

            if (vastus.ToLower() == "jah")
            {
                Console.Write("Ruutmeetri hind: ");
                float hind = float.Parse(Console.ReadLine());
                float summa = pindala * hind;
                Console.WriteLine($"Põranda vahetamise hind on {summa}");
            }
        }

        // 4. 30% soodustus → alghind
        public static void Alghind()
        {
            Console.Write("Sisesta hind 30% soodustusega: ");
            float soodushind = float.Parse(Console.ReadLine());

            float alghind = soodushind / 0.7f;
            Console.WriteLine($"Alghind oli {alghind}");
        }

        // 5. Temperatuur
        public static void Temperatuur()
        {
            Console.Write("Sisesta temperatuur: ");
            float t = float.Parse(Console.ReadLine());

            if (t > 18)
                Console.WriteLine("Temperatuur on üle 18 kraadi");
            else
                Console.WriteLine("Temperatuur on alla 18 kraadi");
        }

        // 6. Pikkus
        public static void Pikkus()
        {
            Console.Write("Sisesta pikkus (cm): ");
            int p = int.Parse(Console.ReadLine());

            if (p < 160)
                Console.WriteLine("Sa oled lühike");
            else if (p <= 180)
                Console.WriteLine("Sa oled keskmine");
            else
                Console.WriteLine("Sa oled pikk");
        }

        // 7. Pikkus + sugu
        public static void PikkusJaSugu()
        {
            Console.Write("Sisesta pikkus (cm): ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Sisesta sugu (m/n): ");
            string sugu = Console.ReadLine();

            if (sugu.ToLower() == "m")
            {
                if (p < 170)
                    Console.WriteLine("Mees: lühike");
                else if (p <= 185)
                    Console.WriteLine("Mees: keskmine");
                else
                    Console.WriteLine("Mees: pikk");
            }
            else
            {
                if (p < 160)
                    Console.WriteLine("Naine: lühike");
                else if (p <= 175)
                    Console.WriteLine("Naine: keskmine");
                else
                    Console.WriteLine("Naine: pikk");
            }
        }

        // 8. Pood
        public static void Pood()
        {
            float summa = 0;

            Console.Write("Kas soovid piima? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
                summa += 1.2f;

            Console.Write("Kas soovid saia? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
                summa += 0.8f;

            Console.Write("Kas soovid leiba? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
                summa += 1.5f;

            Console.WriteLine($"Ostude kogusumma on {summa}");
        }
    }
}
    
