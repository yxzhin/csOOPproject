using System;

namespace csOOPproject.Models
{
    public sealed class Odeljenje
    {
        public short Godina { get; private set; }
        public short Razred { get; private set; }
        public Odeljenje(short godina, short razred)
        {
            Godina = godina;
            Razred = razred;
        }
        public void PrikaziInformacije()
        {
            Console.WriteLine($"godina: {Godina}");
            Console.WriteLine($"odeljenje: {Razred}");
        }
    }
}
