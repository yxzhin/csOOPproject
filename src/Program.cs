using csOOPproject.Models;
using csOOPproject.Services;
using System;

namespace csOOPproject
{
    internal class Program
    {

        public static Osoba osoba;

        private static void Main(string[] args)
        {
            while (true)
            {

                while (true)
                {
                    Console.WriteLine("dobrodosli u login sistema za upravljanje skolom!");

                    Console.WriteLine("unesite puno ime (npr. Marko Markovic):");
                    string puno_ime = Console.ReadLine();
                    Console.WriteLine("unesite sifru:");
                    string sifra = Console.ReadLine();

                    osoba = SchoolManagementService.Login(puno_ime, sifra);
                    if (osoba == null)
                    {
                        Console.WriteLine("neispravno puno ime/sifra!");
                        continue;
                    }
                    break;
                }
                while (true)
                {
                    string puno_ime = osoba is Direktor ?
                        "direktor" : osoba.PunoIme();
                    Console.WriteLine($"dobrodosli u meni, {puno_ime}!");
                    Console.WriteLine("unesite broj opcije:");
                    Console.WriteLine("1 = prikazi informacije o sebi;");

                    if (osoba is Direktor)
                    {
                        Console.WriteLine("2 = prikazi sve osobe (ucenike i nastavnike);");
                        Console.WriteLine("3 = dodaj ucenika;");
                        Console.WriteLine("4 = dodaj nastavnika;");
                        Console.WriteLine("5 = obrisi ucenika;");
                        Console.WriteLine("6 = obrisi nastavnika;");
                    }
                    else if (osoba is Nastavnik)
                    {
                        Console.WriteLine("2 = prikazi sve ucenike svog odeljenja;");
                        Console.WriteLine("3 = dodaj ocenu uceniku;");
                        Console.WriteLine("4 = obrisi ocenu uceniku;");
                    }
                    else
                    {
                        Console.WriteLine("2 = prikazi svoje ocene i prosek;");
                    }
                    Console.WriteLine("73 = izlaz.");

                    int opcija;
                    while (true)
                    {
                        if (!int.TryParse(Console.ReadLine(), out int odgovor))
                        {
                            Console.WriteLine("neispravna opcija!");
                            continue;
                        }
                        opcija = odgovor;
                        break;
                    }

                    bool br = false;

                    if (osoba is Direktor direktor)
                    {
                        switch (opcija)
                        {
                            case 1: direktor.PrikaziInformacije(); break;
                            case 2: direktor.PrikaziSveOsobe(); break;
                            case 3: direktor.DodajUcenika(); break;
                            case 4: direktor.DodajNastavnika(); break;
                            case 5: direktor.ObrisiUcenika(); break;
                            case 6: direktor.ObrisiNastavnika(); break;
                            case 73: Console.WriteLine("izlaz nazad u login..."); br = true; break;
                            default: Console.WriteLine("nepoznata opcija!"); break;
                        }
                        if (br)
                        {
                            break;
                        }
                    }
                    else if (osoba is Nastavnik nastavnik)
                    {
                        switch (opcija)
                        {
                            case 1: nastavnik.PrikaziInformacije(); break;
                            case 2: nastavnik.PrikaziSveUcenikeOdeljenja(); break;
                            case 3: nastavnik.DodajOcenu(); break;
                            case 4: nastavnik.ObrisiOcenu(); break;
                            case 73: Console.WriteLine("izlaz nazad u login..."); br = true; break;
                            default: Console.WriteLine("nepoznata opcija!"); break;
                        }
                        if (br)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Ucenik ucenik = osoba as Ucenik;
                        switch (opcija)
                        {
                            case 1: ucenik.PrikaziInformacije(); break;
                            case 2: ucenik.PrikaziOcene(); break;
                            case 73: Console.WriteLine("izlaz nazad u login..."); br = true; break;
                            default: Console.WriteLine("nepoznata opcija!"); break;
                        }
                        if (br)
                        {
                            break;
                        }
                    }

                }
            }
        }
    }
}
