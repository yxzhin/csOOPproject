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
                }
                else
                {
                    Console.WriteLine("");
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

                switch (opcija)
                {
                    default: Console.WriteLine("neispravna opcija!"); break;
                }

            }

        }
    }
}
