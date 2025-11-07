using csOOPproject.Models;
using System;
using System.Collections.Generic;


namespace csOOPproject.Services
{

    public class SchoolManagementService
    {

        public static Predmet default_predmet1 = new Predmet("predmet1");
        public static Predmet default_predmet2 = new Predmet("predmet2");
        public static Predmet default_predmet3 = new Predmet("predmet3");
        public static Dictionary<int, Predmet> svi_predmeti
            = new Dictionary<int, Predmet>
            {
                {1, default_predmet1},
                {2, default_predmet2},
                {3, default_predmet3},
            };

        public static Odeljenje default_razred1 = new Odeljenje(1, 2);
        public static Odeljenje default_razred2 = new Odeljenje(3, 4);
        public static Odeljenje default_razred3 = new Odeljenje(2, 3);
        public static Dictionary<int, Odeljenje> sva_odeljenja
            = new Dictionary<int, Odeljenje>
        {
                {1, default_razred1},
                {2, default_razred2},
                {3, default_razred3},
        };

        public static Nastavnik default_nastavnik1
            = new Nastavnik("nastavnik1", "nastavnik1", 37,
                new DateTime(2037, 7, 3), default_predmet1, default_razred1);

        public static Nastavnik default_nastavnik2
            = new Nastavnik("nastavnik2", "nastavnik2", 42,
                new DateTime(1973, 3, 7), default_predmet2, default_razred3);

        public static Nastavnik default_nastavnik3
            = new Nastavnik("nastavnik3", "nastavnik3", 73,
                new DateTime(2073, 7, 3), default_predmet2, default_razred3);

        public static Direktor direktor
            = new Direktor("direktor", "direktor", 73,
                new DateTime(1937, 7, 3), "ril73");

        public static Dictionary<Osoba, string> sifre = new Dictionary<Osoba, string>
        {
            { default_nastavnik1, "ril1" },
            { default_nastavnik2, "ril2" },
            { default_nastavnik3, "ril3" },
        };

        public static Osoba Login(string puno_ime, string sifra)
        {
            if (string.IsNullOrEmpty(puno_ime)
            || string.IsNullOrEmpty(sifra))
            {
                return null;
            }
            if (puno_ime.Trim().ToLower() == "direktor"
            && sifra == direktor.Sifra)
            {
                return direktor;
            }
            else
            {
                foreach (KeyValuePair<Osoba, string> kvp in sifre)
                {
                    //Console.WriteLine(kvp.Key.PunoIme().Trim().ToLower());
                    if (kvp.Key.PunoIme().Trim().ToLower() == puno_ime.ToLower()
                    && kvp.Value == sifra)
                    {
                        return kvp.Key;
                    }
                }
                return null;
            }
        }


    }
}
