using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Controller
{
    public static partial class _World //questsAndMissons
    {
        public static readonly List<Quest> Quests = new List<Quest>();

        #region Mission/QuestIDs
        //Quest IDs
        //Zone : Sandoria
        public const int QUEST_001_EXPLOSIVE_REQUEST = 1;
        public const int QUEST_002_FATHER_AND_SON = 2;
        public const int QUEST_003_A_SQUIRES_TEST = 3;

        //Mission IDs
        public const int MISSION_01_SMASH_THE_ORCISH_SCOUTS = 1001;


        #endregion

        private static void PopulateQuests()
        {
            // Sandoria Quests
            //001 Explosive Request
            Quest explosiveRequest = new Quest(QUEST_001_EXPLOSIVE_REQUEST, "Explosive Request", "You've been asked to retrieve Bomb Ash from a Bomb and return it to the Lion Springs", 200, 90);
            explosiveRequest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BOMB_ASH), 1));
            explosiveRequest.RewardItem = ItemByID(ITEM_ID_FIEND_BLOOD);
            //002 Father and Son
            Quest fatherAndSon = new Quest(QUEST_002_FATHER_AND_SON, "Father and Son", "A gentleman named Ailbeche approaches you and asks if you have seen his son. He mentions he carries a fishing rod everywhere he goes - a gift from his Grandfather in Selbina.", 100, 0);
            fatherAndSon.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(KI_ID_BAMBOO_FISHING_ROD), 1));
            //003 A Squire's Test
            Quest aSquiresTest = new Quest(QUEST_003_A_SQUIRES_TEST, "A Squire's Test", "A knight named Balasiel is openly declaring that the first adventurer to bring him a Revival Tree Root will recieve his sword as thanks.", 330, 350);
            aSquiresTest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_REVIVAL_TREE_ROOT), 1));
            aSquiresTest.RewardItem = ItemByID(SWD_ID_SPATHA);
            aSquiresTest.RequiredLevel = 4;

            // Sandoria Missions
            //M01 Smash The Orcish Scouts
            Quest smashTheOrcishScouts = new Quest(MISSION_01_SMASH_THE_ORCISH_SCOUTS, "Smash The Orcish Scouts", "The San d'orian Guard have requested you to thin the ranks of the Orcish found roaming Ronfaure. Return with an Orcish Axe as proof of your deeds.", 200, 50);
            smashTheOrcishScouts.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_ORCISH_AXE), 1));
            smashTheOrcishScouts.RankUpValue = 1;
            smashTheOrcishScouts.RequiredRank = 0;



            // Quests To List
            Quests.Add(explosiveRequest);
            Quests.Add(fatherAndSon);
            Quests.Add(aSquiresTest);

            // Missions To List
            Quests.Add(smashTheOrcishScouts);

        }
    }
}
