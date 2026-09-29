using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam;
        public string Rendszam
        {
            get { return rendszam; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    rendszam = "ISMERETLEN";
                }
                else
                {
                    rendszam = value;
                }
            }
        }

        private int kor;
        public int Kor
        {
            get { return kor; }
            set
            {
                if (value < 0)
                {
                    kor = 0;
                }
                else if (value > 50)
                {
                    kor = 50;
                }
                else
                {
                    kor = value;
                }
            }
        }

        private int kilometerOra;
        public int KilometerOra
        {
            get { return kilometerOra; }
            set
            {
                if (value < 0)
                {
                    kilometerOra = 0;
                }
                else
                {
                    kilometerOra = value;
                }
            }
        }

        private int uzemanyagSzint;
        public int UzemanyagSzint
        {
            get { return uzemanyagSzint; }
            set
            {
                if (value < 0)
                {
                    uzemanyagSzint = 0;
                }
                else if (value > 100)
                {
                    uzemanyagSzint = 100;
                }
                else
                {
                    uzemanyagSzint = value;
                }
            }
        }

        public bool SzervizSzukseges
        {
            get { return KilometerOra >= 200000; }
        }

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
        }

        public string InformaciotAd()
        {
            return $"{this.Rendszam} - {this.Kor} éves jármű, {this.KilometerOra} km-rel";
        }

        public void Szervizel(int szervizDij)
        {
            if (szervizDij > 100000)
            {
                KilometerOra -= 10000;
            }
            UzemanyagSzint -= 10;
            Console.WriteLine("A jármű szervizelése megtörtént.");

        }

    }
}
