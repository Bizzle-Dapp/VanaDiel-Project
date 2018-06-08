using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int EvadeChance { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public bool IsSignature { get; set; }
        public List<LootItem> LootTable { get; set; }


        public Monster(int id, string monsterName, int evadeChance, int maximumDamage, int rewardExperiencePoints, int rewardGold, bool isSignature, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = monsterName;
            EvadeChance = EvadeChance;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            IsSignature = isSignature;
            LootTable = new List<LootItem>();

        }
    }
}
