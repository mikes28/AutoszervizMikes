using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    /*Adattag

jarmuvek:
a járművek egy közös listában legyenek tárolva (List<Jarmu>)
Metódusok

JarmuFelvetele(Jarmu jarmu):
adja hozzá a járművet a listához
írja ki a konzolra, hogy a jármű megérkezett a szervizbe
InformaciokListazasa():
menjen végig a listán és minden járműről írja ki az információkat az adott leszármazott osztály metódusával
CsoportosSzerviz(int dij):
menjen végig a listán
ha egy járműnél szerviz szükséges, akkor kapjon szervizelést
ha egy járműnél szerviz nem szükséges, akkor írja ki: A [Rendszam] szervizelése jelenleg nem szükséges.
a szervizelés a jármű saját metódusával történjen*/

    public class Szerviz
    {
        public List<Jarmu> jarmuvek = new List<Jarmu>();

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine($"A {jarmu.Rendszam} rendszámú jármű megérkezett a szervizbe.");
        }

        public void InformaciokListazasa()
        {
            foreach (var jarmu in jarmuvek)
            {
                Console.WriteLine(jarmu.InformaciotAd());
            }
        }
        public void CsoportosSzerviz(int dij)
        {
            foreach (var jarmu in jarmuvek)
            {
                if (jarmu.SzervizSzukseges)
                {
                    jarmu.Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"A {jarmu.Rendszam} szervizelése jelenleg nem szükséges.");
                }
            }
        }
    }
}
