using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string Rendszam
        {  // a jármű rendszáma
            get { return _Rendszam}; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _Rendszam = "ISMERETLEN";
                }
                else
                {
                    _Rendszam = value;
                }
            }
        }

        private int Kor
        { // a jármű életkora évben
            get { return _Kor; }
            set
            {
                if (value < 0)
                {
                    _Kor = 0;
                }
                else if (value > 50)
                {
                    _Kor = 50;
                }
                else
                {
                    _Kor = value;
                }
            }
        }
        private int KilometerOra
        { // a jármű kilométeróra állása
            get { return _KilometerOra; } 
            set
            {
                if (value < 0)
                {
                    _KilometerOra = 0;
                }
                else
                {
                    _KilometerOra = value;
                }
            }
        }
        private int UzemanyagSzint
        { // a jármű aktuális üzemanyag szintje
            get { return _UzemanyagSzint; }
            set
            {
                if (value < 0)
                {
                    _UzemanyagSzint = 0;
                }
                else if (value > 100)
                {
                    _UzemanyagSzint = 100;
                }
                else
                {
                    _UzemanyagSzint = value;
                }
            }
        }
        private bool SzervizSzukseges
        { // ha jármű kilométeróra állása eléri vagy meghaladja a 200 000 km-t
            get { return _SzervizSzukseges; }
            set
            {
                if (KilometerOra >= 200000)
                {
                    _SzervizSzukseges = true;
                }
                else
                {
                    _SzervizSzukseges = false;
                }
            }
        }
    }
