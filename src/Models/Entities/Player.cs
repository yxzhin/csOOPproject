using csOOPproject.Interfaces;
using System;

namespace csOOPproject.Models.Entities
{
    public sealed class Player : Entity, IHealable
    {

        public double Exp { get; private set; } = 0;

        public Player(string name, double base_hp, double base_mp,
            double base_atk, double base_def, int lvl = 1)
            : base(name, base_hp, base_mp, base_atk, base_def, lvl)
        {
            //@TODO
        }

        public override void Attack(Entity entity)
        {
            //@TODO
        }

        public override void Info()
        {
            base.Info();
            //@TODO
        }

        public void Heal(double hp)
        {
            //@TODO
        }

        public void GainExperience(double exp)
        {
            Exp += exp;
            if (Exp > Lvl * 10)
            {
                for (int i = 0; i < (int)(Lvl / Exp); i++)
                {
                    LevelUp();
                }
            }
        }

        private void LevelUp()
        {
            ++Lvl;
            BaseHp *= 1.73;
            BaseMp *= 1.37;
            BaseAtk *= 1.73;
            BaseDef *= 1.37;
            Console.WriteLine($"{Name} level up!! lvl.{Lvl - 1:N} => lvl.{Lvl:N}");
        }

    }
}
