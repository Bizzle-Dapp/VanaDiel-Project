using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {

        public int HitChanceModifier { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string itemName, string namePlural, int hitChanceModifier, int minimumDamage, int maximumDamage, int price) : base(id, itemName, namePlural, price)
        {
            HitChanceModifier = hitChanceModifier;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;

        }
    }
}
