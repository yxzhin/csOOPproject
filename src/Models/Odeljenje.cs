using System;

namespace csOOPproject.Models
{
    public sealed class Odeljenje
    {
        public int Godina { get; private set; }
        public int Razred { get; private set; }
        public Odeljenje(int godina, int razred)
        {
            Godina = godina;
            Razred = razred;
        }
        public void PrikaziInformacije()
        {
            Console.WriteLine($"odeljenje: {VratiOdeljenje()}");
        }

        public string VratiOdeljenje()
        {
            return $"{Godina}-{Razred}";
        }

    }
}
