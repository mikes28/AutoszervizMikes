using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    /*Extra property

Rakomany (int):
a rakomány súlya tonnában
0 és 20 közötti érték lehet
negatív érték esetén legyen 0
20 fölötti érték esetén legyen 20
Konstruktor

Teherauto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany)
Az első négy adatot adja át a Jarmu konstruktorának.

Metódusok felülírása

InformaciotAd():
írja ki: [Rendszám] - [Kor] éves teherautó, [KilometerOra] km-rel, rakomány: [Rakomany] tonna
Szervizel(int dij):
a teherautó sajátossága, hogy a rakományt le kell pakolni szervizelés előtt
hívja meg az ősosztály metódusát*/
    public class TeherAuto : Jarmu
    {
        private int rakomany;
        public int Rakomany
        {
            get { return rakomany; }
            set
            {
                if(value < 0)
                {
                    rakomany = 0;
                }
                else if (value > 20)
                {
                    rakomany = 20;
                }
                else
                {
                    rakomany = value;
                }
            }
        }


        public TeherAuto(string rendszam, int kor, int kilometerOra, int uzemanyagSzint, int rakomany)
            : base(rendszam, kor, kilometerOra, uzemanyagSzint)
        {
            Rakomany = rakomany;
        }



        public string InformaciotAd()
        {
            return $"{this.Rendszam} - {this.Kor} éves jármű, {this.KilometerOra} km-rel, rakomány: {this.Rakomany}";
        }

        public void Szervizel(int szervizDij)
        {
            if (rakomany==0)
            {
                //run the base class method
                base.Szervizel(szervizDij);
            }
            else
            {
                Console.WriteLine("A rakomanyt kipakoljak javitas elott");
                //unload the cargo
                rakomany = 0;
                //run the base class method
                base.Szervizel(szervizDij);

            }

        }
    }
}
