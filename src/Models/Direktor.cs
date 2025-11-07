using System;
using System.Collections.Generic;

namespace csOOPproject.Models
{
    public sealed class Direktor : Osoba
    {
        public List<Ucenik> Ucenici { get; private set; }
            = new List<Ucenik>();
        public List<Nastavnik> Nastavnici { get; private set; }
            = new List<Nastavnik>();

        public Direktor(string ime, string prezime, int uzrast,
            DateTime datum_rodjenja)
            : base(ime, prezime, uzrast, datum_rodjenja)
        {
            //pass
        }

        public override void PrikaziInformacije()
        {
            base.PrikaziInformacije();
            Console.WriteLine("ucenici:");
            foreach (Ucenik ucenik in Ucenici)
            {
                ucenik.PrikaziInformacije();
            }
            Console.WriteLine("nastavnici:");
            foreach (Nastavnik nastavnik in Nastavnici)
            {
                nastavnik.PrikaziInformacije();
            }
        }

        public void DodajUcenika(Ucenik ucenik)
        {
            Ucenici.Add(ucenik);
            Console.WriteLine($"ucenik je uspesno dodat!");
        }

        public void DodajNastavnika(Nastavnik nastavnik)
        {
            Nastavnici.Add(nastavnik);
            Console.WriteLine($"nastavnik je uspesno dodat!");
        }


    }
}
