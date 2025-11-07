using System;
using System.Collections.Generic;

namespace csOOPproject.Models
{
    public sealed class Nastavnik : Osoba
    {
        public Predmet Predmet { get; private set; }
        public Odeljenje Odeljenje { get; private set; }

        public Nastavnik(string ime, string prezime, int uzrast,
            DateTime datum_rodjenja, Predmet predmet, Odeljenje odeljenje)
            : base(ime, prezime, uzrast, datum_rodjenja)
        {
            Predmet = predmet;
            Odeljenje = odeljenje;
        }

        public override void PrikaziInformacije()
        {
            base.PrikaziInformacije();
            Predmet.PrikaziInformacije();
            Odeljenje.PrikaziInformacije();
        }

        public void PrikaziSveUcenikeOdeljenja()
        {
            if (Direktor.Ucenici.Count == 0)
            {
                Console.WriteLine("nema ucenika!");
                return;
            }
            foreach (KeyValuePair<int, Ucenik> ucenik in Direktor.Ucenici)
            {
                if (ucenik.Value.Odeljenje == Odeljenje)
                {
                    Console.WriteLine($"ucenik sa id: {ucenik.Key}");
                    ucenik.Value.PrikaziInformacije();
                }
            }
        }

        public void DodajOcenu(Ucenik ucenik, int ocena)
        {
            if (ucenik.Odeljenje != Odeljenje)
            {
                Console.WriteLine("ne mozete dodati ocenu uceniku iz drugog odeljenja!");
                return;
            }
            ucenik.DodajOcenu(Predmet, ocena);
        }

        public void ObrisiOcenu(Ucenik ucenik, int ocena)
        {
            if (ucenik.Odeljenje != Odeljenje)
            {
                Console.WriteLine("ne mozete obrisati ocenu uceniku iz drugog odeljenja!");
                return;
            }
            ucenik.ObrisiOcenu(Predmet, ocena);
        }

    }
}
