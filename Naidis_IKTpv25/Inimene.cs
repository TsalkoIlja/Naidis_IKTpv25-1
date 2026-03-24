using System;
using System.Collections.Generic;
using System.Text;
namespace Naidis_IKTpv25
{
    public class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; }
        public float Pikkus { get; set; }
        public float Kaal { get; set; }
        public float Aktiivsustase { get; set; }

        public float ArvutaPaevaKalorid()
        {
            if (Sugu.ToUpper() == "M")
                return (66.5f + 13.75f * Kaal + 5.003f * Pikkus - 6.755f * Vanus) * Aktiivsustase;
            else
                return (655.1f + 9.563f * Kaal + 1.850f * Pikkus - 4.676f * Vanus) * Aktiivsustase;
        }
    }
}


