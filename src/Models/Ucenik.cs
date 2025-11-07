using csOOPproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace csOOPproject.Models
{
    public sealed class Ucenik : Osoba
    {

        public Odeljenje Odeljenje { get; private set; }
        public Dictionary<Predmet, List<int>> Ocene { get; private set; }

        public Ucenik(string ime, string prezime, int uzrast,
            DateTime datum_rodjenja, Odeljenje odeljenje)
            : base(ime, prezime, uzrast, datum_rodjenja)
        {
            Odeljenje = odeljenje;
            Ocene = new Dictionary<Predmet, List<int>>
            {
                { SchoolManagementService.default_predmet1, new List<int> {} },
                { SchoolManagementService.default_predmet2, new List<int> {} },
                { SchoolManagementService.default_predmet3, new List<int> {} },
            };
        }

        public override void PrikaziInformacije()
        {
            base.PrikaziInformacije();
            Odeljenje.PrikaziInformacije();
        }

        public void PrikaziOcene()
        {
            foreach (KeyValuePair<Predmet, List<int>> ocena in Ocene)
            {
                ocena.Key.PrikaziInformacije();
                string ocene = string.Join(", ", ocena.Value);
                ocene = ocena.Value.Count > 0 ? ocene : "prazan skup";
                Console.WriteLine($"ocene: {ocene}");
                double prosek = IzracunajProsek(ocena.Key);
                Console.WriteLine($"prosek: {prosek}");
            }
        }

        public void DodajOcenu(Predmet predmet, int ocena)
        {
            if (!Ocene.ContainsKey(predmet))
            {
                Console.WriteLine("predmet nije pronadjen!");
                return;
            }
            Ocene[predmet].Add(ocena);
            Console.WriteLine("ocena je uspesno dodata!");
        }

        public void ObrisiOcenu(Predmet predmet, int ocena)
        {
            if (!Ocene.ContainsKey(predmet))
            {
                Console.WriteLine("predmet nije pronadjen!");
                return;
            }
            if (!Ocene[predmet].Contains(ocena))
            {
                Console.WriteLine("ocena ne postoji!");
                return;
            }
            _ = Ocene.Remove(predmet);
            Console.WriteLine("ocena je uspesno obrisana!");
        }

        public double IzracunajProsek(Predmet predmet)
        {
            if (!Ocene.ContainsKey(predmet))
            {
                Console.WriteLine($"predmet nije pronadjen!");
                return -1;
            }
            int suma_ocena = Ocene[predmet].Sum();
            int broj_ocena = Ocene[predmet].Count;
            double prosek = suma_ocena / broj_ocena;
            return prosek;
        }

    }
}
