using csOOPproject.Interfaces;
using csOOPproject.Models.Entities;
using System;

namespace csOOPproject.Models.Items
{
    public class HealthPotion : Item, IUsable
    {

        public double Hp { get; private set; }

        public void Use(Player player)
        {
            player.Heal(Hp);
            _ = player.Inventory.Remove(this);
            Console.WriteLine($"{player.Name} je popio Health Potion i napunio {Hp} HP!!");
        }
    }
}
