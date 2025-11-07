using csOOPproject.Models;

namespace csOOPproject.Services
{

    public class SchoolManagementService
    {
        public static Predmet default_predmet1 = new Predmet("predmet1");
        public static Predmet default_predmet2 = new Predmet("predmet2");
        public static Predmet default_predmet3 = new Predmet("predmet3");

        public static Nastavnik default_nastavnik1 = new Nastavnik();
        public static Nastavnik default_nastavnik2 = new Nastavnik();
        public static Nastavnik default_nastavnik3 = new Nastavnik();

        public static Odeljenje default_razred1 = new Odeljenje(1, 2, default_nastavnik1);
        public static Odeljenje default_razred2 = new Odeljenje(3, 4, default_nastavnik2);
        public static Odeljenje default_razred3 = new Odeljenje(2, 3, default_nastavnik3);
    }
}
