using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class VersenyAuto : Jarmu
    {

        private int rajtsztam;
        public int Rajtszam
        {
            get { return rajtsztam; }
            set
            {
                if (value < 0)
                {
                    rajtsztam = 0;
                }
                else if (value > 99)
                {
                    rajtsztam = 99;
                }
                else
                {
                    rajtsztam = value;
                }
            }
        }

        public VersenyAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rajtszam)
           : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Rajtszam = rajtszam;
        }


        public override string InformaciotAd()
        {
            return $"{this.Rendszam} - {this.Kor} éves versenyautó, {this.KilometerOra} km-rel, Versenyauto rajtszama: {this.Rajtszam}";
        }
    }
}
