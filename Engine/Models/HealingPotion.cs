using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        
        public int MinimumHeal { get; set; }
        public int MaximumHeal { get; set; }

        public HealingPotion(int id, string itemName, string namePlural, int minimumHeal, int maximumHeal, int price) : base(id, itemName, namePlural, price)
        {
            MinimumHeal = minimumHeal;
            MaximumHeal = maximumHeal;


        }
    }
}
