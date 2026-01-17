using System;
using System.Collections.Generic;

namespace elmakart_projesi
{
    public class Kullanici
    {
        private string _kartNo;
        public string KartNo
        {
            get => _kartNo;
            set => _kartNo = value;
        }

        public string Sifre { get; set; }

        public virtual string TipiniSoyle()
        {
            return "Standart Kart";
        }
    }

    public class OgrenciKullanici : Kullanici
    {
        public override string TipiniSoyle()
        {
            return "Öğrenci Kartı";
        }
    }

    public static class VeriDeposu
    {
        private static List<Kullanici> _kullanicilar = new List<Kullanici>()
        {
            new Kullanici { KartNo = "12345678", Sifre = "Sifre123" },
            new OgrenciKullanici { KartNo = "11223344", Sifre = "Okul123" }
        };

        public static List<Kullanici> Kullanicilar => _kullanicilar;
    }
}