using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    
        public class Armour : Item
        {

            public int ArmourClass { get; set; }
            public int EvadeChance { get; set; }


        public Armour(int id, string itemName, string namePlural, int armourClass, int evadeChance, int price) : base(id, itemName, namePlural, price)
            {
                ArmourClass = armourClass;
                EvadeChance = evadeChance;
            }
        }
    
}
