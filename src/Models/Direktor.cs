using csOOPproject.Services;
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
            if (Ucenici.Count == 0)
            {
                Console.WriteLine("nema ucenika!");
            }
            foreach (KeyValuePair<int, Ucenik> ucenik in Ucenici)
            {
                Console.WriteLine($"ucenik sa id {ucenik.Key}:");
                ucenik.Value.PrikaziInformacije();
            }
            Console.WriteLine("nastavnici:");
            if (Nastavnici.Count == 0)
            {
                Console.WriteLine("nema nastavnika!");
            }
            foreach (KeyValuePair<int, Nastavnik> nastavnik in Nastavnici)
            {
                Console.WriteLine($"nastavnik sa id {nastavnik.Key}:");
                nastavnik.Value.PrikaziInformacije();
            }
        }

        public void DodajUcenika()
        {
            int id;
            while (true)
            {
                Console.WriteLine("unesite id novog ucenika:");
                if (!int.TryParse(Console.ReadLine(), out int odgovor))
                {
                    Console.WriteLine("unesite ispravan id!");
                    continue;
                }
                id = odgovor;
                break;
            }

            Console.WriteLine("unesite ime novog ucenika:");
            string ime = Console.ReadLine();

            Console.WriteLine("unesite prezime:");
            string prezime = Console.ReadLine();

            int uzrast;
            while (true)
            {
                Console.WriteLine("unesite uzrast (0-120):");
                if (!int.TryParse(Console.ReadLine(), out int odgovor)
                    || odgovor < 0
                    || odgovor > 120)
                {
                    Console.WriteLine("unesite ispravan uzrast!");
                    continue;
                }
                uzrast = odgovor;
                break;
            }

            DateTime datum_rodjenja;
            while (true)
            {
                Console.WriteLine("unesite datum rodjenja (npr. 25.02.2009):");
                if (!DateTime.TryParse(Console.ReadLine(),
                    out DateTime odgovor))
                {
                    Console.WriteLine("unesite ispravan datum!");
                    continue;
                }
                datum_rodjenja = odgovor;
                break;
            }

            Odeljenje odeljenje;
            List<string> sva_odeljenja = new List<string>();

            foreach (KeyValuePair<int, Odeljenje> od in
                SchoolManagementService.sva_odeljenja)
            {
                sva_odeljenja.Add($"{od.Key} = {od.Value.VratiOdeljenje()}");
            }
            while (true)
            {
                Console.WriteLine("izaberite odeljenje:");
                Console.WriteLine(string.Join(", ", sva_odeljenja));
                if (!int.TryParse(Console.ReadLine(), out int odgovor)
                    || !SchoolManagementService.sva_odeljenja.ContainsKey(odgovor))
                {
                    Console.WriteLine("unesite ispravan broj!");
                    continue;
                }
                odeljenje = SchoolManagementService.sva_odeljenja[odgovor];
                break;
            }

            Console.WriteLine("unesite sifru za tog novog ucenika:");
            string sifra = Console.ReadLine();

            Ucenik ucenik = new Ucenik(ime, prezime, uzrast, datum_rodjenja, odeljenje);

            SchoolManagementService.sifre.Add(ucenik, sifra);
            Ucenici.Add(id, ucenik);
            Console.WriteLine($"ucenik je uspesno dodat!");
        }

        public void DodajNastavnika()
        {
            int id;
            while (true)
            {
                Console.WriteLine("unesite id novog nastavnika:");
                if (!int.TryParse(Console.ReadLine(), out int odgovor))
                {
                    Console.WriteLine("unesite ispravan id!");
                    continue;
                }
                id = odgovor;
                break;
            }

            Console.WriteLine("unesite ime novog nastavnika:");
            string ime = Console.ReadLine();

            Console.WriteLine("unesite prezime:");
            string prezime = Console.ReadLine();

            int uzrast;
            while (true)
            {
                Console.WriteLine("unesite uzrast (0-120):");
                if (!int.TryParse(Console.ReadLine(), out int odgovor)
                    || odgovor < 0
                    || odgovor > 120)
                {
                    Console.WriteLine("unesite ispravan uzrast!");
                    continue;
                }
                uzrast = odgovor;
                break;
            }

            DateTime datum_rodjenja;
            while (true)
            {
                Console.WriteLine("unesite datum rodjenja (npr. 25.02.2009):");
                if (!DateTime.TryParse(Console.ReadLine(),
                    out DateTime odgovor))
                {
                    Console.WriteLine("unesite ispravan datum!");
                    continue;
                }
                datum_rodjenja = odgovor;
                break;
            }

            Predmet predmet;
            List<string> svi_predmeti = new List<string>();

            foreach (KeyValuePair<int, Predmet> pr in
                SchoolManagementService.svi_predmeti)
            {
                svi_predmeti.Add($"{pr.Key} = {pr.Value.Naziv}");
            }
            while (true)
            {
                Console.WriteLine("izaberite predmet:");
                Console.WriteLine(string.Join(", ", svi_predmeti));
                if (!int.TryParse(Console.ReadLine(), out int odgovor)
                    || !SchoolManagementService.svi_predmeti.ContainsKey(odgovor))
                {
                    Console.WriteLine("unesite ispravan broj!");
                    continue;
                }
                predmet = SchoolManagementService.svi_predmeti[odgovor];
                break;
            }

            Odeljenje odeljenje;
            List<string> sva_odeljenja = new List<string>();

            foreach (KeyValuePair<int, Odeljenje> od in
                SchoolManagementService.sva_odeljenja)
            {
                sva_odeljenja.Add($"{od.Key} = {od.Value.VratiOdeljenje()}");
            }
            while (true)
            {
                Console.WriteLine("izaberite odeljenje:");
                Console.WriteLine(string.Join(", ", sva_odeljenja));
                if (!int.TryParse(Console.ReadLine(), out int odgovor)
                    || !SchoolManagementService.sva_odeljenja.ContainsKey(odgovor))
                {
                    Console.WriteLine("unesite ispravan broj!");
                    continue;
                }
                odeljenje = SchoolManagementService.sva_odeljenja[odgovor];
                break;
            }

            Console.WriteLine("unesite sifru za tog novog nastavnika:");
            string sifra = Console.ReadLine();

            Nastavnik nastavnik = new Nastavnik(ime, prezime, uzrast,
                datum_rodjenja, predmet, odeljenje);

            SchoolManagementService.sifre.Add(nastavnik, sifra);
            Nastavnici.Add(id, nastavnik);
            Console.WriteLine($"nastavnik je uspesno dodat!");
        }

        public void ObrisiUcenika()
        {
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
            if (!Ucenici.ContainsKey(id))
            {
                Console.WriteLine($"ucenik ne postoji!");
                return;
            }
            _ = SchoolManagementService.sifre.Remove(Ucenici[id]);
            _ = Ucenici.Remove(id);
            Console.WriteLine("ucenik je uspesno obrisan!");
        }

        public void ObrisiNastavnika()
        {
            int id;
            while (true)
            {
                Console.WriteLine("unesite id nastavnika:");
                if (!int.TryParse(Console.ReadLine(), out int odgovor))
                {
                    Console.WriteLine("unesite ispravan id!");
                    continue;
                }
                id = odgovor;
                break;
            }
            if (!Nastavnici.ContainsKey(id))
            {
                Console.WriteLine($"nastavnik ne postoji!");
                return;
            }
            _ = SchoolManagementService.sifre.Remove(Nastavnici[id]);
            _ = Nastavnici.Remove(id);
            Console.WriteLine("nastavnik je uspesno obrisan!");
        }


    }
}
