using System;
using System.Collections.Generic;

namespace csOOPproject.Models
{
    public sealed class Direktor : Osoba
    {

        public string Sifra { get; private set; }

        public static Dictionary<int, Ucenik> Ucenici { get; private set; }
            = new Dictionary<int, Ucenik>();
        public static Dictionary<int, Nastavnik> Nastavnici { get; private set; }
            = new Dictionary<int, Nastavnik>();

        public Direktor(string ime, string prezime, int uzrast,
            DateTime datum_rodjenja, string sifra)
            : base(ime, prezime, uzrast, datum_rodjenja)
        {
            Sifra = sifra;
        }

        public override void PrikaziInformacije()
        {
            base.PrikaziInformacije();
        }

        public void PrikaziSveOsobe()
        {
            Console.WriteLine("ucenici:");
            foreach (KeyValuePair<int, Ucenik> ucenik in Ucenici)
            {
                if (Ucenici.Count == 0)
                {
                    Console.WriteLine("nema ucenika!");
                    break;
                }
                Console.WriteLine($"ucenik sa id {ucenik.Key}:");
                ucenik.Value.PrikaziInformacije();
            }
            Console.WriteLine("nastavnici:");
            foreach (KeyValuePair<int, Nastavnik> nastavnik in Nastavnici)
            {
                if (Nastavnici.Count == 0)
                {
                    Console.WriteLine("nema nastavnika!");
                    break;
                }
                Console.WriteLine($"nastavnik sa id {nastavnik.Key}:");
                nastavnik.Value.PrikaziInformacije();
            }
        }

        public void DodajUcenika(int id, Ucenik ucenik)
        {
            Ucenici.Add(id, ucenik);
            Console.WriteLine($"ucenik je uspesno dodat!");
        }

        public void DodajNastavnika(int id, Nastavnik nastavnik)
        {
            Nastavnici.Add(id, nastavnik);
            Console.WriteLine($"nastavnik je uspesno dodat!");
        }

        public void ObrisiUcenika(int id)
        {
            if (!Ucenici.ContainsKey(id))
            {
                Console.WriteLine($"ucenik ne postoji!");
                return;
            }
            _ = Ucenici.Remove(id);
            Console.WriteLine("ucenik je uspesno obrisan!");
        }

        public void ObrisiNastavnika(int id)
        {
            if (!Nastavnici.ContainsKey(id))
            {
                Console.WriteLine($"nastavnik ne postoji!");
                return;
            }
            _ = Nastavnici.Remove(id);
            Console.WriteLine("nastavnik je uspesno obrisan!");
        }


    }
}
