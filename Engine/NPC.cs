using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NPC
    {
        public string Name { get; set; }
        public Quest TriggerQuest { get; set; }
        public string Dialog { get; set; }
        public Item GivesItem { get; set; }

        public NPC(string name, Quest triggerQuest, string dialog, Item givesItem = null)
        {
            Name = name;
            TriggerQuest = triggerQuest;
            Dialog = dialog;
            GivesItem = givesItem;
        }
    }
}
