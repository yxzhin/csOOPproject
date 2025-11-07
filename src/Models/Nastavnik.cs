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

        public void DodajOcenu()
        {

            if (Direktor.Ucenici.Count == 0)
            {
                Console.WriteLine("nema ucenika!");
                return;
            }

            int id;
            while (true)
            {
                Console.WriteLine("unesite id ucenika:");
                if (!int.TryParse(Console.ReadLine(), out int odgovor))
                {
                    Console.WriteLine("unesite ispravan id!");
                    continue;
                }
                id = odgovor;
                break;
            }

            if (!Direktor.Ucenici.ContainsKey(id))
            {
                Console.WriteLine("ucenik nije pronadjen!");
                return;
            }

            Ucenik ucenik = Direktor.Ucenici[id];

            if (ucenik.Odeljenje != Odeljenje)
            {
                Console.WriteLine("ne mozete dodati ocenu uceniku iz drugog odeljenja!");
                return;
            }

            int ocena;
            while (true)
            {
                Console.WriteLine("unesite ocenu (1-5):");
                if (!int.TryParse(Console.ReadLine(), out int odgovor)
                    || odgovor < 1
                    || odgovor > 5)
                {
                    Console.WriteLine("unesite ispravnu ocenu!");
                    continue;
                }
                ocena = odgovor;
                break;
            }

            ucenik.DodajOcenu(Predmet, ocena);
        }

        public void ObrisiOcenu()
        {

            if (Direktor.Ucenici.Count == 0)
            {
                Console.WriteLine("nema ucenika!");
                return;
            }

            int id;
            while (true)
            {
                Console.WriteLine("unesite id ucenika:");
                if (!int.TryParse(Console.ReadLine(), out int odgovor))
                {
                    Console.WriteLine("unesite ispravan id!");
                    continue;
                }
                id = odgovor;
                break;
            }

            if (!Direktor.Ucenici.ContainsKey(id))
            {
                Console.WriteLine("ucenik nije pronadjen!");
                return;
            }

            Ucenik ucenik = Direktor.Ucenici[id];

            if (ucenik.Odeljenje != Odeljenje)
            {
                Console.WriteLine("ne mozete obrisati ocenu uceniku iz drugog odeljenja!");
                return;
            }

            int ocena;
            while (true)
            {
                Console.WriteLine("unesite ocenu (1-5):");
                if (!int.TryParse(Console.ReadLine(), out int odgovor)
                    || odgovor < 1
                    || odgovor > 5)
                {
                    Console.WriteLine("unesite ispravnu ocenu!");
                    continue;
                }
                ocena = odgovor;
                break;
            }

            ucenik.ObrisiOcenu(Predmet, ocena);
        }

    }
}
