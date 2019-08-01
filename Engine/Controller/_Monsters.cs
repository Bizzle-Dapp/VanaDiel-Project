using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Controller
{
    public static partial class _World //monsters
    {
        public static readonly List<Monster> Monsters = new List<Monster>();

        #region Monsters
        //Monster IDs
        //Ronfaure
        public const int MONSTER_ID_TUNNEL_WORM = 1;
        public const int MONSTER_ID_FOREST_RABBIT = 2;
        public const int MONSTER_ID_FOREST_FUNGUAR = 3;
        public const int MONSTER_ID_SCARAB_BEETLE = 4;
        public const int MONSTER_ID_GOBLIN_WEAVER = 5;
        public const int MONSTER_ID_DING_BAT = 6;
        public const int MONSTER_ID_ORCISH_MESMERIZER = 7;
        public const int MONSTER_ID_MOUSE_BAT = 8;
        public const int MONSTER_ID_RIVER_CRAB = 9;
        public const int MONSTER_ID_ORCISH_FODDER = 10;
        public const int MONSTER_ID_ORCISH_GRAPPLER = 11;
        public const int MONSTER_ID_BOMB = 12;
        public const int MONSTER_ID_ENCHANTED_BONES = 13;
        public const int MONSTER_ID_TAINTED_HOUND = 14;
        public const int MONSTER_ID_GHOST = 15;

        public const int MONSTER_ID_MOUSE_BAT2 = 16;
        public const int MONSTER_ID_TAINTED_HOUND2 = 17;
        public const int MONSTER_ID_GHOST2 = 18;
        #endregion

        private static void PopulateMonsters()
        {
            /////////////////
            //// By Area ////
            /////////////////
            
            //Ronfaure

            Monster tunnelWorm = new Monster(MONSTER_ID_TUNNEL_WORM, "Tunnel Worm", 0, 5, 3, 10, false, 3, 3);
            tunnelWorm.LootTable.Add(new LootItem(ItemByID(ITEM_ID_COPPER_ORE), 60, false));
            tunnelWorm.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FLINT_STONE), 60, false));
            tunnelWorm.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ZINC_ORE), 20, false));

            Monster forestRabbit = new Monster(MONSTER_ID_FOREST_RABBIT, "Forest Rabbit", 1, 4, 3, 0, false, 4, 4);
            forestRabbit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RABBIT_MEAT), 60, false));
            forestRabbit.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RABBIT_HIDE), 40, false));

            Monster forestFunguar = new Monster(MONSTER_ID_FOREST_FUNGUAR, "Forest Funguar", 5, 5, 3, 0, false, 6, 6);
            forestFunguar.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SLEEPSHROOM), 40, false));
            forestFunguar.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WOOZYSHROOM), 40, false));

            Monster scarabBeetle = new Monster(MONSTER_ID_SCARAB_BEETLE, "Scarab Beetle", 5, 7, 5, 0, false, 10, 10);
            scarabBeetle.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEETLE_JAW), 30, false));
            scarabBeetle.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEETLE_SHELL), 20, false));
            scarabBeetle.LootTable.Add(new LootItem(ItemByID(ITEM_ID_INSECT_WING), 50, false));

            Monster goblinWeaver = new Monster(MONSTER_ID_GOBLIN_WEAVER, "Goblin Weaver", 15, 7, 10, 44, false, 12, 12);
            goblinWeaver.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GRASS_THREAD), 40, false));
            goblinWeaver.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GRASS_CLOTH), 20, false));
            goblinWeaver.LootTable.Add(new LootItem(ItemByID(ITEM_ID_COTTON_THREAD), 30, false));
            goblinWeaver.LootTable.Add(new LootItem(ItemByID(ITEM_ID_COTTON_CLOTH), 10, false));
            goblinWeaver.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEASTCOIN), 30, false));
            goblinWeaver.LootTable.Add(new LootItem(ItemByID(ARMOUR_ID_LEATHER_ARMOUR), 5, false));

            Monster dingBat05 = new Monster(MONSTER_ID_DING_BAT, "Ding Bat", 15, 4, 5, 0, false, 6, 6);
            dingBat05.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BAT_WING), 40, false));

            Monster orcishMesmerizer = new Monster(MONSTER_ID_ORCISH_MESMERIZER, "Orcish Mesmerizer", 5, 10, 10, 6, false, 10, 10);
            orcishMesmerizer.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEASTCOIN), 30, false));

            Monster mouseBat = new Monster(MONSTER_ID_MOUSE_BAT, "Mouse Bat", 15, 6, 8, 0, false, 7, 7);
            mouseBat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BAT_WING), 40, false));

            Monster riverCrab = new Monster(MONSTER_ID_RIVER_CRAB, "River Crab", 1, 6, 6, 0, false, 13, 13);
            riverCrab.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROCK_SALT), 50, false));

            Monster orcishFodder = new Monster(MONSTER_ID_ORCISH_FODDER, "Orcish Fodder", 5, 10, 10, 9, false, 12, 12);
            orcishFodder.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEASTCOIN), 30, false));
            orcishFodder.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ORCISH_AXE), 30, false));
            orcishFodder.LootTable.Add(new LootItem(ItemByID(ARMOUR_ID_SCALE_MAIL), 5, false));
            orcishFodder.LootTable.Add(new LootItem(ItemByID(POTION_ID_POTION), 12, false));

            Monster orcishGrappler = new Monster(MONSTER_ID_ORCISH_GRAPPLER, "Orcish Grappler", 10, 8, 12, 9, false, 12, 12);
            orcishGrappler.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEASTCOIN), 35, false));
            orcishGrappler.LootTable.Add(new LootItem(ItemByID(POTION_ID_POTION), 12, false));

            Monster bomb08 = new Monster(MONSTER_ID_BOMB, "Bomb", 5, 8, 12, 0, false, 15, 15);
            bomb08.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BOMB_ASH), 20, false));

            Monster enchantedBones = new Monster(MONSTER_ID_ENCHANTED_BONES, "Enchanted Bones", 5, 10, 14, 0, false, 15, 15);
            enchantedBones.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BONE_CHIP), 60, false));
            enchantedBones.LootTable.Add(new LootItem(ItemByID(GSWD_ID_RUSTY_GREATSWORD), 6, false));
            enchantedBones.LootTable.Add(new LootItem(ItemByID(POTION_ID_POTION), 10, false));

            Monster taintedHound = new Monster(MONSTER_ID_TAINTED_HOUND, "Tainted Hound", 25, 6, 15, 0, false, 12, 12);
            taintedHound.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WOLF_HIDE), 30, false));

            Monster ghost = new Monster(MONSTER_ID_GHOST, "Ghost", 25, 6, 22, 0, false, 10, 10);
            ghost.LootTable.Add(new LootItem(ItemByID(ITEM_ID_REVIVAL_TREE_ROOT), 60, false));

            // King Ranperre's Tomb

            Monster mouseBat2 = new Monster(MONSTER_ID_MOUSE_BAT2, "Mouse Bat", 16, 7, 9, 0, false, 9, 9);
            mouseBat2.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BAT_WING), 50, false));

            Monster taintedHound2 = new Monster(MONSTER_ID_TAINTED_HOUND2, "Tainted Hound", 25, 6, 15, 0, false, 12, 12);
            taintedHound2.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WOLF_HIDE), 30, false));

            Monster ghost2 = new Monster(MONSTER_ID_GHOST2, "Ghost", 25, 8, 31, 0, false, 14, 14);
            ghost2.LootTable.Add(new LootItem(ItemByID(ITEM_ID_REVIVAL_TREE_ROOT), 60, false));
            ghost2.LootTable.Add(new LootItem(ItemByID(POTION_ID_HI_POTION), 9, false));

            //static list
            Monsters.Add(tunnelWorm);
            Monsters.Add(forestRabbit);
            Monsters.Add(forestFunguar);
            Monsters.Add(scarabBeetle);
            Monsters.Add(dingBat05);
            Monsters.Add(orcishMesmerizer);
            Monsters.Add(mouseBat);
            Monsters.Add(riverCrab);
            Monsters.Add(orcishFodder);
            Monsters.Add(orcishGrappler);
            Monsters.Add(bomb08);
            Monsters.Add(enchantedBones);
            Monsters.Add(taintedHound);
            Monsters.Add(ghost);

            Monsters.Add(mouseBat2);
            Monsters.Add(taintedHound2);
            Monsters.Add(ghost2);

        }
    }
}
