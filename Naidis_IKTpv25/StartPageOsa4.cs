using System;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast C# programmi!");

            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("\nVali ülesanne:");
                Console.WriteLine("1 - Lemmiktoidu salvestamine faili");
                Console.WriteLine("2 - Kogu menüü kuvamine");
                Console.WriteLine("3 - Koostisosade nimekirja muutmine");
                Console.WriteLine("4 - Koostisosade otsing nimekirjast");
                Console.WriteLine("5 - Uuendatud nimekirja salvestamine");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Osa4_funktsioonid.SalvestaToit();
                        validInput = true;
                        break;

                    case "2":
                        Osa4_funktsioonid.LoeToidud();
                        validInput = true;
                        break;

                    case "3":
                        Osa4_funktsioonid.MuudaKoostisosad();
                        validInput = true;
                        break;

                    case "4":
                        Osa4_funktsioonid.OtsiKoostisosa();
                        validInput = true;
                        break;

                    case "5":
                        Osa4_funktsioonid.SalvestaKoostisosad();
                        validInput = true;
                        break;

                    default:
                        Console.WriteLine("Palun vali õige number!");
                        break;
                }
            }
        }
    }
}

