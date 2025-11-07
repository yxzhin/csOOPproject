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
                Console.WriteLine($"dobrodosli, {osoba.PunoIme()}!");
                _ = Console.ReadLine();
            }

        }
    }
}
