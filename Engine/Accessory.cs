using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Accessory : Item
    {

        public int HitChanceModifier { get; set; }
        public int AccessoryClass { get; set; }
        public int AccessoryDeflectChance { get; set; }


        public Accessory(int id, string itemName, string namePlural, int hitChanceModifier, int accessoryClass, int accessoryDeflectChance, int price) : base(id, itemName, namePlural, price)
        {
            HitChanceModifier = hitChanceModifier;
            AccessoryClass = accessoryClass;
            AccessoryDeflectChance = accessoryDeflectChance;
        }
    }
}
