using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints {get; set;}
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }
        public int RankUpValue { get; set; }
        public int RequiredLevel { get; set; }
        public int RequiredRank { get; set; }

        public Quest(int id, string questName, string description, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = questName;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            QuestCompletionItems = new List<QuestCompletionItem>();
            RankUpValue = 0;
            RequiredLevel = 0;
            RequiredRank = 0;
        }
    }
}
