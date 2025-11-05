using csOOPproject.Interfaces;

namespace csOOPproject.Models.Entities
{
    public class Enemy : Entity, IHealable, IExperienceGiver
    {

        public Enemy(string name, double base_hp, double base_mp,
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
        public void GiveExperience(Entity entity)
        {
            //@TODO
        }
    }
}
