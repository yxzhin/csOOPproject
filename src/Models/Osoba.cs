using System;

namespace csOOPproject.Models
{
    public abstract class Osoba
    {
        protected string Ime { get; set; }
        protected string Prezime { get; set; }
        protected int Uzrast { get; set; }
        protected DateTime Datum_rodjenja { get; set; }

        protected Osoba(string ime, string prezime, int uzrast, DateTime datum_rodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            Uzrast = uzrast;
            Datum_rodjenja = datum_rodjenja;
        }

        public virtual void PrikaziInformacije()
        {
            Console.WriteLine($"ime: {Ime}");
            Console.WriteLine($"prezime: {Prezime}");
            Console.WriteLine($"uzrast: {Uzrast:N}");
            Console.WriteLine($"datum rodjenja: {Datum_rodjenja.ToUniversalTime()}");
        }

    }
}
