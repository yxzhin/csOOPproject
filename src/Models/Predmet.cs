using System;

namespace csOOPproject.Models
{
    public sealed class Predmet
    {
        public string Naziv { get; private set; }
        public Predmet(string naziv)
        {
            Naziv = naziv;
        }
        public void PrikaziInformacije()
        {
            Console.WriteLine($"naziv predmeta: {Naziv}");
        }

    }
}
