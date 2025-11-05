using System;

namespace csOOPproject.Models
{
    public abstract class Entity
    {
        protected string Name;
        protected double BaseHp;
        protected double BaseMp;
        protected double BaseAtk;
        protected double BaseDef;
        public double Hp { get; protected set; }
        public double Mp { get; protected set; }
        public double Atk { get; protected set; }
        public double Def { get; protected set; }
        public bool IsAlive => Hp > 0;
        protected int Lvl;

        public Entity(string name, double base_hp, double base_mp,
            double base_atk, double base_def, int lvl = 1)
        {
            Name = name;
            BaseHp = base_hp;
            BaseMp = base_mp;
            BaseAtk = base_atk;
            BaseDef = base_def;
            Lvl = lvl;
        }

        public abstract void Attack(Entity entity);
        public virtual void Info()
        {
            //@TODO
        }

        public bool TakeDamage(double damage)
        {
            double taken_damage = Math.Max(0, damage - Def);
            if (taken_damage == 0)
            {
                Console.WriteLine($"{Name} je u potpunosti ignorisao {damage} stete!");
                return false;
            }
            Hp = Math.Max(0, Hp - taken_damage);
            Console.WriteLine($"{Name} je dobio {taken_damage} od {damage} stete (ignorisano {Def} stete)!");
            return true;
        }

    }
}
