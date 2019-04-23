using System;
using System.Collections.Generic;
using Engine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{


    public static class _World
    {
        private static Player Player { get; set; }
        public static void SetPlayer(Player player)
        {
            Player = player;
        }

        //Game list initialisation
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        //Item Grouping
        //Spare IDs (0-30)
        public const int UNSELLABLE_ITEM = 0;
        public const int ITEM_ID_BEASTCOIN = 1;

        //Weapon IDs (50-79)
        //Swords
        public const int ITEM_ID_ONION_SWORD = 50;
        public const int ITEM_ID_BRONZE_SWORD = 51;
        public const int ITEM_ID_SAPARA = 52;
        public const int ITEM_ID_XIPHOS = 53;
        public const int ITEM_ID_SPATHA = 54;
        public const int ITEM_ID_ROYAL_ARCHERS_SWORD = 55;
        public const int ITEM_ID_BILBO = 56;
        public const int ITEM_ID_KINGDOM_SWORD = 57;
        public const int ITEM_ID_SANDORIAN_SIGNET_SWORD = 58;
        public const int ITEM_ID_MYTHRIL_SWORD = 59;
        public const int ITEM_ID_ANCIENT_SWORD = 60;
        public const int ITEM_ID_SAVE_THE_QUEEN = 61;

        //Great Swords
        public const int ITEM_ID_RUSTY_GREATSWORD = 62;
        public const int ITEM_ID_CLAYMORE = 63;
        public const int ITEM_ID_VULCAN_CLAYMORE = 64;
        public const int ITEM_ID_ROYAL_SWORDSMAN_CLAYMORE = 65;
        public const int ITEM_ID_COBRA_UNIT_CLAYMORE = 66;
        public const int ITEM_ID_DARKSTEEL_CLAYMORE = 67;
        public const int ITEM_ID_MYTHRIL_CLAYMORE = 68;
        public const int ITEM_ID_FLAME_CLAYMORE = 69;
        public const int ITEM_ID_RAGNAROK = 70;

        //Bows
        public const int ITEM_ID_SHORTBOW = 71;
        public const int ITEM_ID_FREESWORD_BOW = 72;
        public const int ITEM_ID_POWER_BOW = 73;
        public const int ITEM_ID_PLATOON_BOW = 74;
        public const int ITEM_ID_KINGDOM_BOW = 75;
        public const int ITEM_ID_GREAT_BOW = 76;
        public const int ITEM_ID_BATTLE_BOW = 77;
        public const int ITEM_ID_LIGHTNING_BOW = 78;


        //Potion IDs (90-99)
        public const int ITEM_ID_POTION = 90;
        public const int ITEM_ID_HI_POTION = 91;
        public const int ITEM_ID_HI_POTION_PLUS = 92;
        public const int ITEM_ID_MEGA_POTION = 93;
        public const int ITEM_ID_MEGA_POTION_PLUS = 94;
        public const int ITEM_ID_X_POTION = 95;

        //Key Item IDs (100-149)
        public const int ITEM_ID_ADVENTURER_PASS = 100;

        public const int ITEM_ID_BLACKDRAGONHEAD = 199;

        //Armour IDs (150-159)
        public const int ITEM_ID_COMMON_CLOTHES = 150;

        //Accessory IDs (160-169)
        public const int ITEM_ID_SANDORIAN_RING = 160;

        //Item ID's (170+)
        public const int ITEM_ID_RABBIT_MEAT = 170;
        public const int ITEM_ID_COPPER_ORE = 171;
        public const int ITEM_ID_RABBIT_HIDE = 172;
        public const int ITEM_ID_SLEEPSHROOM = 173;
        public const int ITEM_ID_WOOZYSHROOM = 174;
        public const int ITEM_ID_FLINT_STONE = 175;
        public const int ITEM_ID_ZINC_ORE = 176;
        public const int ITEM_ID_BEETLE_JAW = 177;
        public const int ITEM_ID_INSECT_WING = 178;
        public const int ITEM_ID_BEETLE_SHELL = 179;
        public const int ITEM_ID_GRASS_THREAD = 180;
        public const int ITEM_ID_GRASS_CLOTH = 181;
        public const int ITEM_ID_COTTON_THREAD = 182;
        public const int ITEM_ID_COTTON_CLOTH = 183;
        public const int ITEM_ID_BAT_WING = 184;
        public const int ITEM_ID_FIEND_BLOOD = 185;
        public const int ITEM_ID_ROCK_SALT = 186;
        public const int ITEM_ID_ORCISH_AXE = 187;
        public const int ITEM_ID_BOMB_ASH = 188;
        public const int ITEM_ID_BONE_CHIP = 189;
        public const int ITEM_ID_REVIVAL_TREE_ROOT = 190;
        public const int ITEM_ID_WOLF_HIDE = 191;


        //Monster IDs
        //Ronfaure
        public const int MONSTER_ID_TUNNEL_WORM = 1;
        public const int MONSTER_ID_FOREST_RABBIT = 2;
        public const int MONSTER_ID_FOREST_FUNGUAR = 3;
        public const int MONSTER_ID_SCARAB_BEETLE = 4;
        public const int MONSTER_ID_GOBLIN_WEAVER = 5;
        public const int MONSTER_ID_DING_BAT_05 = 6;
        public const int MONSTER_ID_ORCISH_MESMERIZER = 7;
        public const int MONSTER_ID_MOUSE_BAT = 8;
        public const int MONSTER_ID_RIVER_CRAB = 9;
        public const int MONSTER_ID_ORCISH_FODDER = 10;
        public const int MONSTER_ID_ORCISH_GRAPPLER = 11;
        public const int MONSTER_ID_BOMB_08 = 12;
        public const int MONSTER_ID_ENCHANTED_BONES = 13;
        public const int MONSTER_ID_TAINTED_HOUND = 14;

        //Quest IDs
        /*
        public const int QUEST_BECOME_CHAMPION = 1;
        public const int QUEST_LORDS_REQUEST = 2;
        */

        //Zone : Sandoria
        public const int QUEST_001_EXPLOSIVE_REQUEST = 1;

        //Location IDs
        //Zone : San d'Oria
        public const int LOCATION_ID_MOG_HOUSE_MH = 1;

        public const int LOCATION_ID_SANDORIA_STREETS_1 = 2;
        public const int LOCATION_ID_SANDORIA_STREETS_2 = 3;
        public const int LOCATION_ID_SANDORIA_STREETS_3 = 4;
        public const int LOCATION_ID_SANDORIA_LIONSPRINGSTAVERN_4 = 5;
        public const int LOCATION_ID_SANDORIA_STREETS_5 = 6;
        public const int LOCATION_ID_SANDORIA_STREETS_6 = 7;
        public const int LOCATION_ID_SANDORIA_STREETS_7 = 8;
        public const int LOCATION_ID_SANDORIA_STREETS_8 = 9;
        public const int LOCATION_ID_SANDORIA_STREETS_9 = 10;
        public const int LOCATION_ID_SANDORIA_EASTGATE_10 = 11;
        public const int LOCATION_ID_SANDORIA_STREETS_11 = 12;
        public const int LOCATION_ID_SANDORIA_AUCTION_HOUSE_12 = 13;
        public const int LOCATION_ID_SANDORIA_STREETS_13 = 14;
        public const int LOCATION_ID_SANDORIA_STREETS_14 = 15;
        public const int LOCATION_ID_SANDORIA_STREETS_15 = 16;
        public const int LOCATION_ID_SANDORIA_STREETS_16 = 17;
        public const int LOCATION_ID_SANDORIA_STREETS_17 = 18;
        public const int LOCATION_ID_SANDORIA_WESTGATE_18 = 19;
        public const int LOCATION_ID_SANDORIA_STREETS_19 = 20;
        public const int LOCATION_ID_SANDORIA_STREETS_20 = 21;
        public const int LOCATION_ID_SANDORIA_TAUMILAS_SUNDRIES_21 = 22;
        public const int LOCATION_ID_SANDORIA_TANNERS_GUILD_22 = 23;
        public const int LOCATION_ID_SANDORIA_STREETS_23 = 24;
        public const int LOCATION_ID_SANDORIA_STREETS_24 = 25;
        public const int LOCATION_ID_SANDORIA_STREETS_25 = 26;
        public const int LOCATION_ID_SANDORIA_STREETS_26 = 27;
        public const int LOCATION_ID_SANDORIA_COUNT_CAFFAULES_MANOR_27 = 28;
        public const int LOCATION_ID_SANDORIA_PALACE_28 = 29;

        //Zone: Ronfaure

        public const int LOCATION_ID_RONFAURE_1_ENTRANCE_TO_GHELSBA_OUTPOST_31 = 31;
        public const int LOCATION_ID_RONFAURE_2_32 = 32;
        public const int LOCATION_ID_RONFAURE_3_33 = 33;
        public const int LOCATION_ID_RONFAURE_4_34 = 34;
        public const int LOCATION_ID_RONFAURE_5_35 = 35;
        public const int LOCATION_ID_RONFAURE_6_36 = 36;
        public const int LOCATION_ID_RONFAURE_7_37 = 37;
        public const int LOCATION_ID_RONFAURE_8_38 = 38;
        public const int LOCATION_ID_RONFAURE_9_SANDORIA_WESTGATE_39 = 39;
        public const int LOCATION_ID_RONFAURE_10_40 = 40;
        public const int LOCATION_ID_RONFAURE_11_41 = 41;
        public const int LOCATION_ID_RONFAURE_12_42 = 42;
        public const int LOCATION_ID_RONFAURE_13_43 = 43;
        public const int LOCATION_ID_RONFAURE_14_TO_EAST_RONFAURE_N_44 = 44;
        public const int LOCATION_ID_RONFAURE_15_45 = 45;
        public const int LOCATION_ID_RONFAURE_16_46 = 46;
        public const int LOCATION_ID_RONFAURE_17_47 = 47;
        public const int LOCATION_ID_RONFAURE_18_48 = 48;
        public const int LOCATION_ID_RONFAURE_19_49 = 49;
        public const int LOCATION_ID_RONFAURE_20_50 = 50;
        public const int LOCATION_ID_RONFAURE_21_51 = 51;
        public const int LOCATION_ID_RONFAURE_22_52 = 52;
        public const int LOCATION_ID_RONFAURE_23_TO_EAST_RONFAURE_S_53 = 53;
        public const int LOCATION_ID_RONFAURE_24_54 = 54;
        public const int LOCATION_ID_RONFAURE_25_55 = 55;
        public const int LOCATION_ID_RONFAURE_26_56 = 56;
        public const int LOCATION_ID_RONFAURE_27_57 = 57;
        public const int LOCATION_ID_RONFAURE_28_58 = 58;
        public const int LOCATION_ID_RONFAURE_29_59 = 59;
        public const int LOCATION_ID_RONFAURE_30_60 = 60;
        public const int LOCATION_ID_RONFAURE_31_61 = 61;
        public const int LOCATION_ID_RONFAURE_32_62 = 62;
        public const int LOCATION_ID_RONFAURE_33_TO_LA_THEINE_PLATEAU_63 = 63;

        public const int LOCATION_ID_RONFAURE_34_TO_RANGUEMONT_PASS_64 = 64;
        public const int LOCATION_ID_RONFAURE_35_65 = 65;
        public const int LOCATION_ID_RONFAURE_36_66 = 66;
        public const int LOCATION_ID_RONFAURE_37_67 = 67;
        public const int LOCATION_ID_RONFAURE_38_68 = 68;
        public const int LOCATION_ID_RONFAURE_39_69 = 69;
        public const int LOCATION_ID_RONFAURE_40_SANDORIA_EASTGATE_70 = 70;
        public const int LOCATION_ID_RONFAURE_41_71 = 71;
        public const int LOCATION_ID_RONFAURE_42_72 = 72;
        public const int LOCATION_ID_RONFAURE_43_73 = 73;
        public const int LOCATION_ID_RONFAURE_44_TO_WEST_RONFAURE_N_74 = 74;
        public const int LOCATION_ID_RONFAURE_45_75 = 75;
        public const int LOCATION_ID_RONFAURE_46_76 = 76;
        public const int LOCATION_ID_RONFAURE_47_77 = 77;
        public const int LOCATION_ID_RONFAURE_48_78 = 78;
        public const int LOCATION_ID_RONFAURE_49_79 = 79;
        public const int LOCATION_ID_RONFAURE_50_80 = 80;
        public const int LOCATION_ID_RONFAURE_51_81 = 81;
        public const int LOCATION_ID_RONFAURE_52_TO_WEST_RONFAURE_S_82 = 82;
        public const int LOCATION_ID_RONFAURE_53_83 = 83;
        public const int LOCATION_ID_RONFAURE_54_84 = 84;
        public const int LOCATION_ID_RONFAURE_55_85 = 85;
        public const int LOCATION_ID_RONFAURE_56_86 = 86;
        public const int LOCATION_ID_RONFAURE_57_87 = 87;
        public const int LOCATION_ID_RONFAURE_58_88 = 88;
        public const int LOCATION_ID_RONFAURE_59_89 = 89;
        public const int LOCATION_ID_RONFAURE_60_90 = 90;
        public const int LOCATION_ID_RONFAURE_61_91 = 91;
        public const int LOCATION_ID_RONFAURE_62_92 = 92;
        public const int LOCATION_ID_RONFAURE_63_93 = 93;
        public const int LOCATION_ID_RONFAURE_64_ENTRANCE_TO_KING_RANPERRES_TOMB_94 = 94;


        //Setting the fields within the Items, Weapons, Monsters and Locations Lists
        static _World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();

        }



        private static void PopulateItems()
        {
            //Populate items
            // 0 Price = Unsellable

            Items.Add(new Item(ITEM_ID_BEASTCOIN, "Beastcoin", "Beastcoins", 25));

            Items.Add(new Item(ITEM_ID_COPPER_ORE, "Copper Ore", "Copper Ore", 2));
            Items.Add(new Item(ITEM_ID_RABBIT_MEAT, "Rabbit Meat", "Rabbit Meat", 2));
            Items.Add(new Item(ITEM_ID_RABBIT_HIDE, "Rabbit Hide", "Rabbit Hides", 4));
            Items.Add(new Item(ITEM_ID_SLEEPSHROOM, "Sleepshroom", "Sleepshrooms", 4));
            Items.Add(new Item(ITEM_ID_WOOZYSHROOM, "Woozyshroom", "Woozyshrooms", 4));
            Items.Add(new Item(ITEM_ID_FLINT_STONE, "Flint Stone", "Flint Stones", 2));
            Items.Add(new Item(ITEM_ID_ZINC_ORE, "Zinc Ore", "Zinc Ore", 6));
            Items.Add(new Item(ITEM_ID_BEETLE_JAW, "Beetle Jaw", "Beetle Jaws", 4));
            Items.Add(new Item(ITEM_ID_INSECT_WING, "Insect Wing", "Insect Wings", 2));
            Items.Add(new Item(ITEM_ID_BEETLE_SHELL, "Beetle Shell", "Beetle Shells", 10));
            Items.Add(new Item(ITEM_ID_GRASS_THREAD, "Grass Thread", "Grass Thread", 20));
            Items.Add(new Item(ITEM_ID_GRASS_CLOTH, "Grass Cloth", "Pieces of Grass Cloth", 60));
            Items.Add(new Item(ITEM_ID_COTTON_THREAD, "Cotton Thread", "Cotton Thread", 40));
            Items.Add(new Item(ITEM_ID_COTTON_CLOTH, "Cotton Cloth", "Pieces of Cotton Cloth", 110));
            Items.Add(new Item(ITEM_ID_BAT_WING, "Bat Wing", "Bat Wings", 2));
            Items.Add(new Item(ITEM_ID_FIEND_BLOOD, "Vial of Fiend Blood", "Vials of Fiend Blood", 30));
            Items.Add(new Item(ITEM_ID_ROCK_SALT, "Rock Salt", "Chunks of Rock Salt", 2));
            Items.Add(new Item(ITEM_ID_ORCISH_AXE, "Orcish Axe", "Orcish Axes", 36));
            Items.Add(new Item(ITEM_ID_BOMB_ASH, "Bomb Ash", "Bomb Ashes", 120));
            Items.Add(new Item(ITEM_ID_BONE_CHIP, "Bone Chip", "Bone Chips", 2));
            Items.Add(new Item(ITEM_ID_REVIVAL_TREE_ROOT, "Revival Tree Root", "Revival Tree Roots", 60));
            Items.Add(new Item(ITEM_ID_WOLF_HIDE, "Wolf Hide", "Wolf Hides", 40));



            //Populate weapons
            //Swords
            Items.Add(new Weapon(ITEM_ID_ONION_SWORD, "Onion Sword", "Onion Swords", 1, 0, 5, UNSELLABLE_ITEM));
            Items.Add(new Weapon(ITEM_ID_BRONZE_SWORD, "Bronze Sword", "Bronze Swords", 5, 1, 6, 50));
            Items.Add(new Weapon(ITEM_ID_SAPARA, "Sapara", "Saparas", 5, 4, 7, 400));
            Items.Add(new Weapon(ITEM_ID_XIPHOS, "Xiphos", "Xiphos", 5, 5, 8, 520));
            Items.Add(new Weapon(ITEM_ID_SPATHA, "Spatha", "Spathas", 5, 8, 14, 1000));
            Items.Add(new Weapon(ITEM_ID_ROYAL_ARCHERS_SWORD, "Royal Archer's Sword", "Royal Archer's Swords", 5, 10, 15, 1600));
            Items.Add(new Weapon(ITEM_ID_BILBO, "Bilbo", "Bilbos", 5, 11, 15, 1700));
            Items.Add(new Weapon(ITEM_ID_KINGDOM_SWORD, "Kingdom Sword", "Kingdom Swords", 5, 15, 24, 3600));
            Items.Add(new Weapon(ITEM_ID_SANDORIAN_SIGNET_SWORD, "San d'Orian Signet Sword", "San d'Orian Signet Swords", 5, 17, 27, 4600));
            Items.Add(new Weapon(ITEM_ID_MYTHRIL_SWORD, "Mythril Sword", "Mythril Swords", 5, 22, 33, 7800));
            Items.Add(new Weapon(ITEM_ID_ANCIENT_SWORD, "Ancient Sword", "Ancient Swords", 5, 30, 45, UNSELLABLE_ITEM));
            Items.Add(new Weapon(ITEM_ID_SAVE_THE_QUEEN, "Save The Queen", "Save The Queens", 5, 50, 100, UNSELLABLE_ITEM));

            //Great Swords
            Items.Add(new Weapon(ITEM_ID_RUSTY_GREATSWORD, "Rusty Greatsword", "Rusty Greatswords", 5, 0, 10, 120));
            Items.Add(new Weapon(ITEM_ID_CLAYMORE, "Claymore", "Claymores", 5, 1, 11, 390));
            Items.Add(new Weapon(ITEM_ID_VULCAN_CLAYMORE, "Vulcan Claymore", "Vulcan Claymores", 5, 3, 18, 700));
            Items.Add(new Weapon(ITEM_ID_ROYAL_SWORDSMAN_CLAYMORE, "Royal Swordsman's Claymore", "Royal Swordsman's Claymores", 5, 4, 22, 1800));
            Items.Add(new Weapon(ITEM_ID_COBRA_UNIT_CLAYMORE, "Cobra Unit Claymore", "Cobra Unit Claymores", 5, 6, 28, 2900));
            Items.Add(new Weapon(ITEM_ID_DARKSTEEL_CLAYMORE, "Darksteel Claymore", "Darksteel Claymores", 5, 12, 36, 6600));
            Items.Add(new Weapon(ITEM_ID_MYTHRIL_CLAYMORE, "Mythril Claymore", "Mythril Claymores", 5, 15, 60, 10800));
            Items.Add(new Weapon(ITEM_ID_FLAME_CLAYMORE, "Flame Claymore", "Flame Claymores", 5, 20, 70, UNSELLABLE_ITEM));
            Items.Add(new Weapon(ITEM_ID_RAGNAROK, "Ragnarok", "Ragnaroks", 5, 30, 150, UNSELLABLE_ITEM));

            //Bows
            Items.Add(new Weapon(ITEM_ID_SHORTBOW, "Shortbow", "Shortbows", 5, 2, 3, 30));
            Items.Add(new Weapon(ITEM_ID_FREESWORD_BOW, "Freesword Bow", "Freesword Bows", 5, 5, 6, 700));
            Items.Add(new Weapon(ITEM_ID_POWER_BOW, "Power Bow", "Power Bows", 5, 9, 10, 1100));
            Items.Add(new Weapon(ITEM_ID_PLATOON_BOW, "Platoon Bow", "Platoon Bows", 5, 14, 15, 2800));
            Items.Add(new Weapon(ITEM_ID_KINGDOM_BOW, "Kingdom Bow", "Kingdom Bows", 5, 18, 19, 4100));
            Items.Add(new Weapon(ITEM_ID_GREAT_BOW, "Great Bow", "Great Bows", 5, 25, 26, 7600));
            Items.Add(new Weapon(ITEM_ID_BATTLE_BOW, "The Battle Bow", "Battle Bows", 5, 37, 38, 30));
            Items.Add(new Weapon(ITEM_ID_LIGHTNING_BOW, "Lightning Bow", "Lightning Bows", 5, 62, 68, UNSELLABLE_ITEM));


            //Populate potions
            Items.Add(new HealingPotion(ITEM_ID_POTION, "Potion", "Potions", 5, 10, 50));
            Items.Add(new HealingPotion(ITEM_ID_HI_POTION, "Hi-Potion", "Hi-Potions", 15, 30, 250));
            Items.Add(new HealingPotion(ITEM_ID_HI_POTION_PLUS, "Hi-Potion +", "Hi-Potion Plus'", 21, 36, 450));
            Items.Add(new HealingPotion(ITEM_ID_MEGA_POTION, "Mega Potion", "Mega Potions", 45, 70, 1100));
            Items.Add(new HealingPotion(ITEM_ID_MEGA_POTION_PLUS, "Mega Potion +", "Mega Potion Plus'", 55, 80, 1600));
            Items.Add(new HealingPotion(ITEM_ID_X_POTION, "X-Potion", "X-Potions", 100, 200, 5000));



            //Populate key items
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer Pass", "Adventurer Passes", UNSELLABLE_ITEM));
            Items.Add(new Item(ITEM_ID_BLACKDRAGONHEAD, "Black Dragon head", "Black Dragon heads", UNSELLABLE_ITEM));

            //Populate Armour
            Items.Add(new Armour(ITEM_ID_COMMON_CLOTHES, "Common Clothes", "Common Clothes", 0, 0, UNSELLABLE_ITEM));

            //Populate Accessories
            Items.Add(new Accessory(ITEM_ID_SANDORIAN_RING, "San d'Orian Ring", "San d'Orian Rings", 1, 0, 0, UNSELLABLE_ITEM));

        }

        private static void PopulateMonsters()
        {
            //By Area

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

            Monster dingBat05 = new Monster(MONSTER_ID_DING_BAT_05, "Ding Bat", 15, 4, 5, 0, false, 6, 6);
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

            Monster orcishGrappler = new Monster(MONSTER_ID_ORCISH_GRAPPLER, "Orcish Grappler", 10, 8, 12, 9, false, 12, 12);
            orcishGrappler.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEASTCOIN), 35, false));

            Monster bomb08 = new Monster(MONSTER_ID_BOMB_08, "Bomb", 5, 8, 12, 0, false, 15, 15);
            bomb08.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BOMB_ASH), 20, false));

            Monster enchantedBones = new Monster(MONSTER_ID_ENCHANTED_BONES, "Enchanted Bones", 5, 10, 14, 0, false, 15, 15);
            enchantedBones.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BONE_CHIP), 60, false));

            Monster taintedHound = new Monster(MONSTER_ID_TAINTED_HOUND, "Tainted Hound", 25, 6, 15, 0, false, 12, 12);
            taintedHound.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WOLF_HIDE), 30, false));

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

        }

        private static void PopulateQuests()
        {
            /*
             //BecomeChampion <MAIN QUEST>
             Quest becomeChampion = new Quest(QUEST_BECOME_CHAMPION, "Become The Ultimate Warrior", "You have always desired to become the most revered warrior in all of the land. " +
                 "It's time to achieve that dream. Seek out the Black Dragon of Dark Mist Mountain and return its head to your home. ", 10000, 0);
             becomeChampion.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BLACKDRAGONHEAD), 1));
             //becomeChampion..RewardItem = ItemByID();

             //Lord's Request
             Quest lordsRequest = new Quest(QUEST_LORDS_REQUEST, "The Lords Request", "The Grand Lord of Kol has employed you to defeat Rats in his basement. He has agreed to issue you " +
                 "an Adventurers Pass if you bring him back proof of your deeds. Bring back 5 Rat Tails to receive your reward.", 0, 0);
             lordsRequest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 5));
             lordsRequest.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

             //Static list
             Quests.Add(becomeChampion);
             Quests.Add(lordsRequest);
             */
            
            // Sandoria
            //001 Explosive Request
            Quest explosiveRequest = new Quest(QUEST_001_EXPLOSIVE_REQUEST, "Explosive Request", "You've been asked to retrieve Bomb Ash from a Bomb and return it to the Lion Springs", 200, 90);
            explosiveRequest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BOMB_ASH), 1));
            explosiveRequest.RewardItem = ItemByID(ITEM_ID_FIEND_BLOOD);

            Quests.Add(explosiveRequest);

        }


        private static void PopulateLocations()
        {

            //
            //Generate location parameters
            //
            //home.QuestAvailableHere = QuestByID(QUEST_BECOME_CHAMPION);
            //guardPost.ItemRequiredToEnter = ItemByID(ITEM_ID_ADVENTURER_PASS);
            //alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            //Zone : San d'Oria
            Location mogHouse = new Location(LOCATION_ID_MOG_HOUSE_MH, "Mog House", "Your residence as an adventurer of San d'Oria." + Environment.NewLine + "A fire burns lightly in the corner. The room is furnished with a bed, a chest of drawers, a desk and a bookcase." + Environment.NewLine + "Your own Moogle flutters around cleaning and maintaining the fire for you...", 0);
            //home.QuestAvailableHere = QuestByID(QUEST_BECOME_CHAMPION);

            Location sandoriaStreets1 = new Location(LOCATION_ID_SANDORIA_STREETS_1, "Streets of San d'Oria - Outside Mog House", "The narrow avenue that links the residential area with San d'Oria's bustling Lion Square." + Environment.NewLine + "People come and go quickly through the cobbled archways.", 0);
            Location sandoriaStreets2 = new Location(LOCATION_ID_SANDORIA_STREETS_2, "Lion Square Eastern Steps", "The eastern steps peer across the Lion Square fountain to the Lion Springs tavern to the West. The avenue that leads to the residential area lays through cobbled archways to the North." + Environment.NewLine + "Children play around the fountain while others converse and gamble.", 0);
            Location sandoriaStreets3 = new Location(LOCATION_ID_SANDORIA_STREETS_3, "Lion Square", "A fountain fills the air with moisture as folk cast dice against a table cheering at their victories." + Environment.NewLine + "To the West stands the door to the Lion Springs tavern." + Environment.NewLine + "To the South curves Squire Alley towards the East Gate." + Environment.NewLine + "To the East the steps rise before the residential areas cobble archway.", 0);
            Location sandoriaLionSprings = new Location(LOCATION_ID_SANDORIA_LIONSPRINGSTAVERN_4, "Lion Springs Tavern", "", 0);
            sandoriaLionSprings.QuestAvailableHere = QuestByID(QUEST_001_EXPLOSIVE_REQUEST);
            Location sandoriaStreets5 = new Location(LOCATION_ID_SANDORIA_STREETS_5, "Streets of San d'Oria - Squire Alley", "Dusty, busy cobbled streets connect the Lion Square fountain to the North with Cavalry Way to the South." + Environment.NewLine + "There is very little of interest usually found in this through fare.", 0);
            Location sandoriaStreets6 = new Location(LOCATION_ID_SANDORIA_STREETS_6, "Streets of San d'Oria - Cavalry Way", "The steps here rise at a curve from the Trade Stands of Cavelry Way to the West to Squire Alley at the North." + Environment.NewLine + "Sometimes - often during festivals - sales people who are unable to acquire stall-space can be found squatting on the steps vending from boxes.", 0);
            Location sandoriaStreets7 = new Location(LOCATION_ID_SANDORIA_STREETS_7, "Streets of San d'Oria - Cavalry Way Trade Stands North Wall", "Here trade stands sell items procured from various distant lands." + Environment.NewLine + "To the South more stands line the cobbled archway towards the East Gate House.", 0);
            Vendor sandoriaNorthWallTradeStands = new Vendor("North Trade Stands");
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_COPPER_ORE), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_RABBIT_MEAT), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_RABBIT_HIDE), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_SLEEPSHROOM), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_WOOZYSHROOM), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_FLINT_STONE), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_ZINC_ORE), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_BEETLE_JAW), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_BEETLE_SHELL), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_BAT_WING), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_FIEND_BLOOD), 10);
            sandoriaNorthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_ROCK_SALT), 10);
            sandoriaStreets7.VendorWorkingHere = sandoriaNorthWallTradeStands;

            Location sandoriaStreets8 = new Location(LOCATION_ID_SANDORIA_STREETS_8, "Streets of San d'Oria - Cavalry Way Trade Stands South Wall", "Here trade stands sell items procured from various local and distant lands." + Environment.NewLine + "The cobbled archway to the South leads to the East Gate House." + Environment.NewLine + "To the North more traders reside." + Environment.NewLine + "To the West, Victory Square and the local auction house draw folks and adventurers alike to unimaginable treasures and revelry.", 0);
            Vendor sandoriaSouthWallTradeStands = new Vendor("South Trade Stands");
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_COPPER_ORE), 10);
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_BONE_CHIP), 10);
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_RABBIT_HIDE), 10);
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_ZINC_ORE), 10);
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_GRASS_THREAD), 10);
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_COTTON_THREAD), 10);
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_GRASS_CLOTH), 10);
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_COTTON_CLOTH), 10);
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_REVIVAL_TREE_ROOT), 10);
            sandoriaSouthWallTradeStands.AddItemToInventory(ItemByID(ITEM_ID_WOLF_HIDE), 10);
            sandoriaStreets8.VendorWorkingHere = sandoriaSouthWallTradeStands;

            Location sandoriaStreets9 = new Location(LOCATION_ID_SANDORIA_STREETS_9, "Streets of San d'Oria - East Gate Rendevous Point", "The archway of the East Gate lays to the South. Two San d'Orian guards stand with spears keeping watch. " + Environment.NewLine + "To the North lays the cobbled archway to the trade stands of Cavalry Way.", 0);
            //Initial Ranked Missions Available Here

            Location sandoriaEastGate = new Location(LOCATION_ID_SANDORIA_EASTGATE_10, "San d'Oria East Gate", "Tall, mossy stone walls protect the city of San d'Oria. The city it tucked on the outskirts of a mountain range and in turn is a well defended capital." + Environment.NewLine + "To the South the forest of Ronfaure crawls with an ever constant flow of deadly beasts and occassionally a stray Orcish Scout hoping to waylay an unprepared adventurer." + Environment.NewLine + "(Recommended Level: 1-4)", 0);
            Location sandoriaStreets11 = new Location(LOCATION_ID_SANDORIA_STREETS_11, "Streets if San d'Oria - Victory Square SE", "Victory Square is a place of trade. The auction house lays at the Central South of this large open area.", 0);
            Location sandoriaAuctionHouse = new Location(LOCATION_ID_SANDORIA_AUCTION_HOUSE_12, "Streets of San d'Oria - Victory Square Auction House", "Trade windows line the front of the huge stone building, open all day and all night - all of the time." + Environment.NewLine + "Surrounding the auction house is the expanse of Victory Square.", 0);
            Vendor sandoriaAuctionHouseSales = new Vendor("San d'Oria Auction House");
            sandoriaAuctionHouseSales.AddItemToInventory(ItemByID(ITEM_ID_POTION), 10);
            sandoriaAuctionHouseSales.AddItemToInventory(ItemByID(ITEM_ID_SHORTBOW), 10);
            sandoriaAuctionHouseSales.AddItemToInventory(ItemByID(ITEM_ID_BRONZE_SWORD), 10);
            sandoriaAuctionHouseSales.AddItemToInventory(ItemByID(ITEM_ID_RUSTY_GREATSWORD), 10);
            sandoriaAuctionHouseSales.AddItemToInventory(ItemByID(ITEM_ID_FREESWORD_BOW), 10);
            sandoriaAuctionHouseSales.AddItemToInventory(ItemByID(ITEM_ID_SAPARA), 10);
            sandoriaAuctionHouseSales.AddItemToInventory(ItemByID(ITEM_ID_CLAYMORE), 10);


            sandoriaAuctionHouse.VendorWorkingHere = sandoriaAuctionHouseSales;
            

            Location sandoriaStreets13 = new Location(LOCATION_ID_SANDORIA_STREETS_13, "Streets of San d'Oria - Victory Square SW", "Victory Square is a place of trade. The auction house lays at the Central South of this large open area.", 0);
            Location sandoriaStreets14 = new Location(LOCATION_ID_SANDORIA_STREETS_14, "Streets of San d'Oria - Victory Square NW", "Victory Square is a place of trade. The auction house lays at the Central South of this large open area.", 0);
            Location sandoriaStreets15 = new Location(LOCATION_ID_SANDORIA_STREETS_15, "Streets of San d'Oria - Victory Square N", "Victory Square is a place of trade. The auction house lays at the Central South of this large open area." + Environment.NewLine + "To the North of here is the draw bridge which leads to the San d'Orian Palace. Only renown adventurers with invitations, noble knights and royality may enter.", 0);
            Location sandoriaStreets16 = new Location(LOCATION_ID_SANDORIA_STREETS_16, "Streets of San d'Oria - Victory Square NE", "Victory Square is a place of trade. The auction house lays at the Central South of this large open area.", 0);
            Location sandoriaStreets17 = new Location(LOCATION_ID_SANDORIA_STREETS_17, "Streets of San d'Oria - West Gate Rendevous Point", "The archway of the West Gate lays to the South. A San d'Orian guard stands with a sword and shield keeping watch." + Environment.NewLine + "To the North is a large footpath which leads towards Taumila's Saundries, the Tanners Guild and further to Count Caffaule's Manor.", 0);
            Location sandoriaWestGate = new Location(LOCATION_ID_SANDORIA_WESTGATE_18, "San d'Oria West Gate", "Tall, mossy stone walls protect the city of San d'Oria. The city it tucked on the outskirts of a mountain range and in turn is a well defended capital." + Environment.NewLine + "To the South the forest of Ronfaure crawls with an ever constant flow of deadly beasts and occassionally a stray Orcish Scout hoping to waylay an unprepared adventurer." + Environment.NewLine + "(Recommended Level: 1-4)", 0);
            Location sandoriaStreets19 = new Location(LOCATION_ID_SANDORIA_STREETS_19, "Streets of San d'Oria - Guild Walk", "Curved steps connects the West Gate Rendevous Point to the South with the guild walk to the West.", 0);
            Location sandoriaStreets20 = new Location(LOCATION_ID_SANDORIA_STREETS_20, "Streets of San d'Oria - Guild Walk", "An avenue connects Taumila's Saundries to the West with curved steps leading South to the East.", 0);
            Location sandoriaTaumilaSaundries = new Location(LOCATION_ID_SANDORIA_TAUMILAS_SUNDRIES_21, "Taumila's Saundries", "Taumila was formerly an adventurer who served the San d'Orian King during the Crystal War. Now retired, he runs a store that provides key resources to adventurers." + Environment.NewLine + "Inside the shop, Taumila sits quietly reading a book awaiting customers." + Environment.NewLine + "To the North, an alley leads to the San d'Orian Knights training grounds." + Environment.NewLine + "The building connected on the West is the San d'Orian Tanners' Guild.", 0);
            Location sandoriaTannersGuild = new Location(LOCATION_ID_SANDORIA_TANNERS_GUILD_22, "Tanners' Guild", "The Tanners Guild is an ancient guild almost as old as San d'Oria itself. Since long before San d'oria was a bustling city of trade and fortune the area of Ronfaure was a prime location of hunting for animal resource that could be used by folk."  + Environment.NewLine + "Inside the ground floor is the guild merchant. Armour and Accessories line the counter which are available for purchase." + Environment.NewLine + "To the North is Pikeman's Way." + Environment.NewLine + "To the East is Taumila's Sundries.", 0);
            Location sandoriaStreets23 = new Location(LOCATION_ID_SANDORIA_STREETS_23, "Streets of San d'Oria - Knight's Grounds Training Grounds", "Here Knights of San d'Oria casually practice the finest swordsmanship in Vana'diel. Straw dummies accept blows and arrows without protest." + Environment.NewLine + "To the South a roofed alleyway leads back out onto the guild walk outside Taumila's Sundries" + Environment.NewLine + "To the West through another roofed alleyway lays a section of Pikeman's Way", 0);
            Location sandoriaStreets24 = new Location(LOCATION_ID_SANDORIA_STREETS_24, "Streets of San d'Oria - Pikeman's Way", "Pikeman's Way claimed is name as being the the road that connects the San d'Orian Knights Training Grounds and Count Caffaule's Manor. Count Caffaule, while alive was a renown Knight of the San d'Orian Army, regularly found training if not allocated missions." + Environment.NewLine + "To the North a road curves from South to West towards Count Caffaule's Manor" + Environment.NewLine + "To the East through a roofed alley lays the San d'Orian Knights Training Grounds." + Environment.NewLine + "To the South is the Tanners' Guild.", 0);
            Location sandoriaStreets25 = new Location(LOCATION_ID_SANDORIA_STREETS_25, "Streets of San d'Oria - Pikeman's Way", "Here the road connects Pikeman's Way from the South to the East." + Environment.NewLine + "This area of San d'Oria is of higher class than the Eastern Residential Area and is often quieter. Flower beds and flags line the tall stone walls of the San d'Orian streets.", 0);
            Location sandoriaStreets26 = new Location(LOCATION_ID_SANDORIA_STREETS_26, "Streets of San d'Oria - Pikeman's Way", "Here the road connects Count Caffaule's Manor to the East with the rest of Pikeman's Way." + Environment.NewLine + "A stone wall seperates the front garden of the Manor from the rest of the area with large wooden doors as the entry way.", 0);
            Location sandoriaCountCaffaulesManor27 = new Location(LOCATION_ID_SANDORIA_COUNT_CAFFAULES_MANOR_27, "Count Caffaule's Manor", "The Manor is large, with a paired staircase leading up to the communial room of the Manor." + Environment.NewLine + "Iron chandeliers hang from the rafters and the floor is topped with a soft, red rug that follows the walkways.", 0);
            Location sandoriaPalace28 = new Location(LOCATION_ID_SANDORIA_PALACE_28, "San d'Oria Palace", "The doors are closed...", 0);

            //Ronfaure
            Location ronfaureGhelsbaEntrance = new Location(LOCATION_ID_RONFAURE_1_ENTRANCE_TO_GHELSBA_OUTPOST_31, "West Ronfaure - Tunnel To Ghelsba Outpost", "<At the moment, you may travel no further...>", 0);
            Location ronfaure2 = new Location(LOCATION_ID_RONFAURE_2_32, "West Ronfaure", "", 2);
            ronfaure2.MonsterLivingHere = MonsterByID(MONSTER_ID_ORCISH_FODDER);
            Location ronfaure3 = new Location(LOCATION_ID_RONFAURE_3_33, "West Ronfaure", "", 0);
            Location ronfaure4 = new Location(LOCATION_ID_RONFAURE_4_34, "West Ronfaure", "", 1);
            ronfaure4.MonsterLivingHere = MonsterByID(MONSTER_ID_TUNNEL_WORM);
            Location ronfaure5 = new Location(LOCATION_ID_RONFAURE_5_35, "West Ronfaure", "", 1);
            ronfaure5.MonsterLivingHere = MonsterByID(MONSTER_ID_TUNNEL_WORM);
            Location ronfaure6 = new Location(LOCATION_ID_RONFAURE_6_36, "West Ronfaure", "", 1);
            ronfaure6.MonsterLivingHere = MonsterByID(MONSTER_ID_TUNNEL_WORM);
            Location ronfaure7 = new Location(LOCATION_ID_RONFAURE_7_37, "West Ronfaure", "", 1);
            ronfaure7.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure8 = new Location(LOCATION_ID_RONFAURE_8_38, "West Ronfaure", "", 2);
            ronfaure8.MonsterLivingHere = MonsterByID(MONSTER_ID_TUNNEL_WORM);
            Location ronfaureSandoriaWestgate = new Location(LOCATION_ID_RONFAURE_9_SANDORIA_WESTGATE_39, "West Ronfaure - San d'Oria West Gate", "", 0);
            Location ronfaure10 = new Location(LOCATION_ID_RONFAURE_10_40, "West Ronfaure", "", 3);
            ronfaure10.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure11 = new Location(LOCATION_ID_RONFAURE_11_41, "West Ronfaure", "", 1);
            ronfaure11.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure12 = new Location(LOCATION_ID_RONFAURE_12_42, "West Ronfaure", "", 2);
            ronfaure12.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure13 = new Location(LOCATION_ID_RONFAURE_13_43, "West Ronfaure", "", 1);
            ronfaure13.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaureToEastRonfaureN = new Location(LOCATION_ID_RONFAURE_14_TO_EAST_RONFAURE_N_44, "West Ronfaure", "", 0);
            Location ronfaure15 = new Location(LOCATION_ID_RONFAURE_15_45, "West Ronfaure", "", 3);
            ronfaure15.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_FUNGUAR);
            Location ronfaure16 = new Location(LOCATION_ID_RONFAURE_16_46, "West Ronfaure", "", 1);
            ronfaure16.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_FUNGUAR);
            Location ronfaure17 = new Location(LOCATION_ID_RONFAURE_17_47, "West Ronfaure", "", 0);
            Location ronfaure18 = new Location(LOCATION_ID_RONFAURE_18_48, "West Ronfaure", "", 2);
            ronfaure18.MonsterLivingHere = MonsterByID(MONSTER_ID_SCARAB_BEETLE);
            Location ronfaure19 = new Location(LOCATION_ID_RONFAURE_19_49, "West Ronfaure", "", 1);
            ronfaure19.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN_WEAVER);
            Location ronfaure20 = new Location(LOCATION_ID_RONFAURE_20_50, "West Ronfaure", "", 1);
            ronfaure20.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN_WEAVER);
            Location ronfaure21 = new Location(LOCATION_ID_RONFAURE_21_51, "West Ronfaure", "", 1);
            ronfaure21.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure22 = new Location(LOCATION_ID_RONFAURE_22_52, "West Ronfaure", "", 1);
            ronfaure22.MonsterLivingHere = MonsterByID(MONSTER_ID_ORCISH_MESMERIZER);
            Location ronfaureToEastRonfaureS = new Location(LOCATION_ID_RONFAURE_23_TO_EAST_RONFAURE_S_53, "West Ronfaure", "", 0);
            Location ronfaure24 = new Location(LOCATION_ID_RONFAURE_24_54, "West Ronfaure", "", 2);
            ronfaure24.MonsterLivingHere = MonsterByID(MONSTER_ID_ORCISH_GRAPPLER);
            Location ronfaure25 = new Location(LOCATION_ID_RONFAURE_25_55, "West Ronfaure", "", 1);
            ronfaure25.MonsterLivingHere = MonsterByID(MONSTER_ID_ORCISH_FODDER);
            Location ronfaure26 = new Location(LOCATION_ID_RONFAURE_26_56, "West Ronfaure", "", 2);
            ronfaure26.MonsterLivingHere = MonsterByID(MONSTER_ID_ORCISH_GRAPPLER);
            Location ronfaure27 = new Location(LOCATION_ID_RONFAURE_27_57, "West Ronfaure", "", 3);
            ronfaure27.MonsterLivingHere = MonsterByID(MONSTER_ID_ORCISH_MESMERIZER);
            Location ronfaure28 = new Location(LOCATION_ID_RONFAURE_28_58, "West Ronfaure", "", 2);
            ronfaure28.MonsterLivingHere = MonsterByID(MONSTER_ID_SCARAB_BEETLE);
            Location ronfaure29 = new Location(LOCATION_ID_RONFAURE_29_59, "West Ronfaure", "", 1);
            ronfaure29.MonsterLivingHere = MonsterByID(MONSTER_ID_ENCHANTED_BONES);
            Location ronfaure30 = new Location(LOCATION_ID_RONFAURE_30_60, "West Ronfaure", "", 2);
            ronfaure30.MonsterLivingHere = MonsterByID(MONSTER_ID_MOUSE_BAT);
            Location ronfaure31 = new Location(LOCATION_ID_RONFAURE_31_61, "West Ronfaure", "", 1);
            ronfaure31.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN_WEAVER);
            Location ronfaure32 = new Location(LOCATION_ID_RONFAURE_32_62, "West Ronfaure", "", 1);
            ronfaure32.MonsterLivingHere = MonsterByID(MONSTER_ID_MOUSE_BAT);
            Location ronfaureToLaTheinePlateau = new Location(LOCATION_ID_RONFAURE_33_TO_LA_THEINE_PLATEAU_63, "West Ronfaure - Trail to La Theine Plateau", "<At the moment, you may travel no further...>", 0);

            Location ronfaureToRanguemontPass = new Location(LOCATION_ID_RONFAURE_34_TO_RANGUEMONT_PASS_64, "East Ronfaure - Tunnel to Ranguemont Pass", "<At the moment, you may travel no further...>", 0);
            Location ronfaure35 = new Location(LOCATION_ID_RONFAURE_35_65, "East Ronfaure", "", 1);
            ronfaure35.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure36 = new Location(LOCATION_ID_RONFAURE_36_66, "East Ronfaure", "", 2);
            ronfaure36.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure37 = new Location(LOCATION_ID_RONFAURE_37_67, "East Ronfaure", "", 2);
            ronfaure37.MonsterLivingHere = MonsterByID(MONSTER_ID_TUNNEL_WORM);
            Location ronfaure38 = new Location(LOCATION_ID_RONFAURE_38_68, "East Ronfaure", "", 1);
            ronfaure38.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure39 = new Location(LOCATION_ID_RONFAURE_39_69, "East Ronfaure", "", 1);
            Location ronfaureSandoriaEastgate = new Location(LOCATION_ID_RONFAURE_40_SANDORIA_EASTGATE_70, "East Ronfaure - San d'oria East Gate", "", 0);
            Location ronfaure41 = new Location(LOCATION_ID_RONFAURE_41_71, "East Ronfaure", "", 2);
            ronfaure41.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure42 = new Location(LOCATION_ID_RONFAURE_42_72, "East Ronfaure", "", 1);
            ronfaure42.MonsterLivingHere = MonsterByID(MONSTER_ID_ORCISH_MESMERIZER);
            Location ronfaure43 = new Location(LOCATION_ID_RONFAURE_43_73, "East Ronfaure", "", 4);
            ronfaure43.MonsterLivingHere = MonsterByID(MONSTER_ID_DING_BAT_05);
            Location ronfaureToWestRonfaureN = new Location(LOCATION_ID_RONFAURE_44_TO_WEST_RONFAURE_N_74, "East Ronfaure", "", 0);
            Location ronfaure45 = new Location(LOCATION_ID_RONFAURE_45_75, "East Ronfaure", "", 2);
            ronfaure45.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure46 = new Location(LOCATION_ID_RONFAURE_46_76, "East Ronfaure", "", 2);
            ronfaure46.MonsterLivingHere = MonsterByID(MONSTER_ID_FOREST_RABBIT);
            Location ronfaure47 = new Location(LOCATION_ID_RONFAURE_47_77, "East Ronfaure", "", 2);
            ronfaure47.MonsterLivingHere = MonsterByID(MONSTER_ID_RIVER_CRAB);
            Location ronfaure48 = new Location(LOCATION_ID_RONFAURE_48_78, "East Ronfaure", "", 3);
            ronfaure48.MonsterLivingHere = MonsterByID(MONSTER_ID_DING_BAT_05);
            Location ronfaure49 = new Location(LOCATION_ID_RONFAURE_49_79, "East Ronfaure", "", 3);
            ronfaure49.MonsterLivingHere = MonsterByID(MONSTER_ID_DING_BAT_05);
            Location ronfaure50 = new Location(LOCATION_ID_RONFAURE_50_80, "East Ronfaure", "", 2);
            ronfaure50.MonsterLivingHere = MonsterByID(MONSTER_ID_ORCISH_FODDER);
            Location ronfaure51 = new Location(LOCATION_ID_RONFAURE_51_81, "East Ronfaure", "", 2);
            ronfaure51.MonsterLivingHere = MonsterByID(MONSTER_ID_RIVER_CRAB);
            Location ronfaureToWestRonfaureS = new Location(LOCATION_ID_RONFAURE_52_TO_WEST_RONFAURE_S_82, "East Ronfaure", "", 0);
            Location ronfaure53 = new Location(LOCATION_ID_RONFAURE_53_83, "East Ronfaure", "", 2);
            ronfaure53.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN_WEAVER);
            Location ronfaure54 = new Location(LOCATION_ID_RONFAURE_54_84, "East Ronfaure", "", 2);
            ronfaure54.MonsterLivingHere = MonsterByID(MONSTER_ID_MOUSE_BAT);
            Location ronfaure55 = new Location(LOCATION_ID_RONFAURE_55_85, "East Ronfaure", "", 2);
            ronfaure55.MonsterLivingHere = MonsterByID(MONSTER_ID_RIVER_CRAB);
            Location ronfaure56 = new Location(LOCATION_ID_RONFAURE_56_86, "East Ronfaure", "", 2);
            ronfaure56.MonsterLivingHere = MonsterByID(MONSTER_ID_ORCISH_GRAPPLER);
            Location ronfaure57 = new Location(LOCATION_ID_RONFAURE_57_87, "East Ronfaure", "", 2);
            ronfaure57.MonsterLivingHere = MonsterByID(MONSTER_ID_SCARAB_BEETLE);
            Location ronfaure58 = new Location(LOCATION_ID_RONFAURE_58_88, "East Ronfaure", "", 3);
            ronfaure58.MonsterLivingHere = MonsterByID(MONSTER_ID_RIVER_CRAB);
            Location ronfaure59 = new Location(LOCATION_ID_RONFAURE_59_89, "East Ronfaure", "", 5);
            ronfaure59.MonsterLivingHere = MonsterByID(MONSTER_ID_MOUSE_BAT);
            Location ronfaure60 = new Location(LOCATION_ID_RONFAURE_60_90, "East Ronfaure", "", 5);
            ronfaure60.MonsterLivingHere = MonsterByID(MONSTER_ID_ENCHANTED_BONES);
            Location ronfaure61 = new Location(LOCATION_ID_RONFAURE_61_91, "East Ronfaure", "", 5);
            ronfaure61.MonsterLivingHere = MonsterByID(MONSTER_ID_ENCHANTED_BONES);
            Location ronfaure62 = new Location(LOCATION_ID_RONFAURE_62_92, "East Ronfaure", "", 4);
            ronfaure62.MonsterLivingHere = MonsterByID(MONSTER_ID_TAINTED_HOUND);
            Location ronfaure63 = new Location(LOCATION_ID_RONFAURE_63_93, "East Ronfaure", "", 1);
            ronfaure63.MonsterLivingHere = MonsterByID(MONSTER_ID_BOMB_08);
            Location ronfaureEntranceToKingRanperresTomb = new Location(LOCATION_ID_RONFAURE_64_ENTRANCE_TO_KING_RANPERRES_TOMB_94, "East Ronfaure - Entrance to King Ranperres Tomb", "<At the moment, you may travel no further...>", 0);



            /*
            Location KolTownStore = new Location(LOCATION_ID_KOL_STORE, "Kol General Store", "The only shop in town, the place is huge and full of items, equipment, food and trinkets. Behind the counter stands a bald, bearded man.", 0);
            Vendor garyVendor = new Vendor("Gary The Vendor");
            garyVendor.AddItemToInventory(ItemByID(ITEM_ID_PIECE_OF_FUR), 5);

            Location kolTownNorthWest = new Location(LOCATION_ID_KOL_1_1, "Kol Town North West", " des ", 0);
            Location kolTownNorth = new Location(LOCATION_ID_KOL_1_2, "Kol Town North", " des ", 0);
            Location kolTownNorthEast = new Location(LOCATION_ID_KOL_1_3, "Kol Town North East", " des ", 1);
            kolTownNorthEast.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);
            Location kolTownWest = new Location(LOCATION_ID_KOL_2_1, "Kol Town West", " des ", 0);
            Location kolTownCentre = new Location(LOCATION_ID_KOL_2_2, "Kol Town Centre", " des ", 0);
            Location kolTownEast = new Location(LOCATION_ID_KOL_2_3, "Kol Town East", " des ", 0);
            Location kolTownGate = new Location(LOCATION_ID_KOL_2_4, "Kol Town Gate", " des ", 0);
            kolTownGate.ItemRequiredToEnter = ItemByID(ITEM_ID_ADVENTURER_PASS);
            Location kolTownSouthWest = new Location(LOCATION_ID_KOL_3_1, "Kol Town South West", " des ", 0);
            Location kolTownSouth = new Location(LOCATION_ID_KOL_3_2, "Kol Town South", " des ", 0);
            Location kolTownSouthEast = new Location(LOCATION_ID_KOL_3_3, "Kol Town South East", " des ", 0);

            Location kolLordsMansionHall = new Location(LOCATION_ID_KOL_LORDS_MANSION_1_3, "Kol Lords Mansion - Hall", " des ", 0);
            kolLordsMansionHall.QuestAvailableHere = QuestByID(QUEST_LORDS_REQUEST);
            Location kolLordsMansionCorridor = new Location(LOCATION_ID_KOL_LORDS_MANSION_1_2, "Kol Lords Mansion - Corridor", " des ", 0);
            Location kolLordsMansionStairway = new Location(LOCATION_ID_KOL_LORDS_MANSION_1_1, "Kol Lords Mansion - Stairway", " des ", 0);
            Location kolLordsMansionDiningHall = new Location(LOCATION_ID_KOL_LORDS_MANSION_2_2, "Kol Lords Mansion - Dining Hall", " des ", 0);
            Location kolLordsMansionBasement = new Location(LOCATION_ID_KOL_LORDS_MANSION_2_1, "Kol Lords Mansion - Basement", " des ", 2);
            kolLordsMansionBasement.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);
            */

            //
            //Location Connections
            //
            //Zone : San d'Oria
            mogHouse.LocationToSouth = sandoriaStreets1;

            sandoriaStreets1.LocationToNorth = mogHouse;
            sandoriaStreets1.LocationToSouth = sandoriaStreets2;

            sandoriaStreets2.LocationToNorth = sandoriaStreets1;
            sandoriaStreets2.LocationToWest = sandoriaStreets3;

            sandoriaStreets3.LocationToEast = sandoriaStreets2;
            sandoriaStreets3.LocationToSouth = sandoriaStreets5;
            sandoriaStreets3.LocationToWest = sandoriaLionSprings;

            sandoriaLionSprings.LocationToEast = sandoriaStreets3;

            sandoriaStreets5.LocationToNorth = sandoriaStreets3;
            sandoriaStreets5.LocationToSouth = sandoriaStreets6;

            sandoriaStreets6.LocationToNorth = sandoriaStreets5;
            sandoriaStreets6.LocationToWest = sandoriaStreets7;

            sandoriaStreets7.LocationToEast = sandoriaStreets6;
            sandoriaStreets7.LocationToSouth = sandoriaStreets8;

            sandoriaStreets8.LocationToNorth = sandoriaStreets7;
            sandoriaStreets8.LocationToSouth = sandoriaStreets9;
            sandoriaStreets8.LocationToWest = sandoriaStreets11;

            sandoriaStreets9.LocationToNorth = sandoriaStreets8;
            sandoriaStreets9.LocationToSouth = sandoriaEastGate;

            sandoriaEastGate.LocationToNorth = sandoriaStreets9;
            sandoriaEastGate.LocationToSouth = ronfaureSandoriaEastgate;

            sandoriaStreets11.LocationToEast = sandoriaStreets8;
            sandoriaStreets11.LocationToNorth = sandoriaStreets16;
            sandoriaStreets11.LocationToWest = sandoriaAuctionHouse;

            sandoriaAuctionHouse.LocationToEast = sandoriaStreets11;
            sandoriaAuctionHouse.LocationToNorth = sandoriaStreets15;
            sandoriaAuctionHouse.LocationToWest = sandoriaStreets13;

            sandoriaStreets13.LocationToEast = sandoriaAuctionHouse;
            sandoriaStreets13.LocationToNorth = sandoriaStreets14;
            sandoriaStreets13.LocationToWest = sandoriaStreets17;

            sandoriaStreets14.LocationToEast = sandoriaStreets15;
            sandoriaStreets14.LocationToSouth = sandoriaStreets13;

            sandoriaStreets15.LocationToEast = sandoriaStreets16;
            sandoriaStreets15.LocationToSouth = sandoriaAuctionHouse;
            sandoriaStreets15.LocationToWest = sandoriaStreets14;
            sandoriaStreets15.LocationToNorth = sandoriaPalace28;

            sandoriaStreets16.LocationToSouth = sandoriaStreets11;
            sandoriaStreets16.LocationToWest = sandoriaStreets15;

            sandoriaStreets17.LocationToEast = sandoriaStreets13;
            sandoriaStreets17.LocationToSouth = sandoriaWestGate;
            sandoriaStreets17.LocationToNorth = sandoriaStreets19;

            sandoriaWestGate.LocationToNorth = sandoriaStreets17;
            sandoriaWestGate.LocationToSouth = ronfaureSandoriaWestgate;

            sandoriaStreets19.LocationToSouth = sandoriaStreets17;
            sandoriaStreets19.LocationToWest = sandoriaStreets20;

            sandoriaStreets20.LocationToEast = sandoriaStreets19;
            sandoriaStreets20.LocationToWest = sandoriaTaumilaSaundries;

            sandoriaTaumilaSaundries.LocationToEast = sandoriaStreets20;
            sandoriaTaumilaSaundries.LocationToNorth = sandoriaStreets23;
            sandoriaTaumilaSaundries.LocationToWest = sandoriaTannersGuild;

            sandoriaTannersGuild.LocationToEast = sandoriaTaumilaSaundries;
            sandoriaTannersGuild.LocationToNorth = sandoriaStreets24;

            sandoriaStreets23.LocationToSouth = sandoriaTaumilaSaundries;
            sandoriaStreets23.LocationToWest = sandoriaStreets24;

            sandoriaStreets24.LocationToSouth = sandoriaTannersGuild;
            sandoriaStreets24.LocationToNorth = sandoriaStreets25;

            sandoriaStreets25.LocationToSouth = sandoriaStreets24;
            sandoriaStreets25.LocationToEast = sandoriaStreets26;

            sandoriaStreets26.LocationToEast = sandoriaStreets25;
            sandoriaStreets26.LocationToWest = sandoriaCountCaffaulesManor27;

            sandoriaPalace28.LocationToSouth = sandoriaStreets15;

            //Zone: Ronfaure
            ronfaureGhelsbaEntrance.LocationToEast = ronfaure2;

            ronfaure2.LocationToWest = ronfaureGhelsbaEntrance;
            ronfaure2.LocationToSouth = ronfaure3;

            ronfaure3.LocationToEast = ronfaure4;
            ronfaure3.LocationToSouth = ronfaure6;
            ronfaure3.LocationToNorth = ronfaure2;

            ronfaure4.LocationToEast = ronfaure5;
            ronfaure4.LocationToSouth = ronfaure7;
            ronfaure4.LocationToWest = ronfaure3;

            ronfaure5.LocationToSouth = ronfaure8;
            ronfaure5.LocationToWest = ronfaure4;

            ronfaure6.LocationToEast = ronfaure7;
            ronfaure6.LocationToSouth = ronfaure10;
            ronfaure6.LocationToNorth = ronfaure3;

            ronfaure7.LocationToEast = ronfaure8;
            ronfaure7.LocationToSouth = ronfaure11;
            ronfaure7.LocationToWest = ronfaure6;
            ronfaure7.LocationToNorth = ronfaure4;

            ronfaure8.LocationToEast = ronfaureSandoriaWestgate;
            ronfaure8.LocationToSouth = ronfaure12;
            ronfaure8.LocationToWest = ronfaure7;
            ronfaure8.LocationToNorth = ronfaure5;

            ronfaureSandoriaWestgate.LocationToEast = sandoriaWestGate;
            ronfaureSandoriaWestgate.LocationToSouth = ronfaure13;
            ronfaureSandoriaWestgate.LocationToWest = ronfaure8;

            ronfaure10.LocationToNorth = ronfaure6;
            ronfaure10.LocationToEast = ronfaure11;

            ronfaure11.LocationToEast = ronfaure12;
            ronfaure11.LocationToSouth = ronfaure16;
            ronfaure11.LocationToWest = ronfaure10;
            ronfaure11.LocationToNorth = ronfaure7;

            ronfaure12.LocationToSouth = ronfaure17;
            ronfaure12.LocationToWest = ronfaure16;
            ronfaure12.LocationToNorth = ronfaure8;

            ronfaure13.LocationToEast = ronfaureToEastRonfaureN;
            ronfaure13.LocationToNorth = ronfaureSandoriaWestgate;

            ronfaureToEastRonfaureN.LocationToEast = ronfaureToWestRonfaureN;
            ronfaureToEastRonfaureN.LocationToWest = ronfaure13;

            ronfaure15.LocationToEast = ronfaure16;
            ronfaure15.LocationToSouth = ronfaure19;

            ronfaure16.LocationToEast = ronfaure17;
            ronfaure16.LocationToSouth = ronfaure20;
            ronfaure16.LocationToWest = ronfaure15;
            ronfaure16.LocationToNorth = ronfaure11;

            ronfaure17.LocationToEast = ronfaure18;
            ronfaure17.LocationToSouth = ronfaure21;
            ronfaure17.LocationToWest = ronfaure16;
            ronfaure17.LocationToNorth = ronfaure12;

            ronfaure18.LocationToWest = ronfaure17;

            ronfaure19.LocationToEast = ronfaure20;
            ronfaure19.LocationToNorth = ronfaure15;

            ronfaure20.LocationToEast = ronfaure21;
            ronfaure20.LocationToSouth = ronfaure25;
            ronfaure20.LocationToWest = ronfaure19;
            ronfaure20.LocationToNorth = ronfaure16;

            ronfaure21.LocationToEast = ronfaure22;
            ronfaure21.LocationToSouth = ronfaure26;
            ronfaure21.LocationToWest = ronfaure20;
            ronfaure21.LocationToNorth = ronfaure17;

            ronfaure22.LocationToEast = ronfaureToEastRonfaureS;
            ronfaure22.LocationToSouth = ronfaure27;
            ronfaure22.LocationToWest = ronfaure21;

            ronfaureToEastRonfaureS.LocationToEast = ronfaureToWestRonfaureS;
            ronfaureToEastRonfaureS.LocationToWest = ronfaure22;

            ronfaure24.LocationToEast = ronfaure25;
            ronfaure24.LocationToSouth = ronfaure28;

            ronfaure25.LocationToEast = ronfaure26;
            ronfaure25.LocationToSouth = ronfaure29;
            ronfaure25.LocationToWest = ronfaure24;
            ronfaure25.LocationToNorth = ronfaure20;

            ronfaure26.LocationToEast = ronfaure27;
            ronfaure26.LocationToSouth = ronfaure30;
            ronfaure26.LocationToWest = ronfaure25;
            ronfaure26.LocationToNorth = ronfaure21;

            ronfaure27.LocationToSouth = ronfaure31;
            ronfaure27.LocationToWest = ronfaure26;
            ronfaure27.LocationToNorth = ronfaure22;

            ronfaure28.LocationToEast = ronfaure29;
            ronfaure28.LocationToSouth = ronfaureToLaTheinePlateau;
            ronfaure28.LocationToNorth = ronfaure24;

            ronfaure29.LocationToEast = ronfaure30;
            ronfaure29.LocationToWest = ronfaure28;
            ronfaure29.LocationToNorth = ronfaure25;

            ronfaure30.LocationToEast = ronfaure31;
            ronfaure30.LocationToWest = ronfaure29;
            ronfaure30.LocationToNorth = ronfaure26;

            ronfaure31.LocationToEast = ronfaure32;
            ronfaure31.LocationToWest = ronfaure30;
            ronfaure31.LocationToNorth = ronfaure27;

            ronfaure32.LocationToWest = ronfaure31;

            ronfaureToLaTheinePlateau.LocationToNorth = ronfaure28;

            ronfaureToRanguemontPass.LocationToSouth = ronfaure39;

            ronfaure35.LocationToEast = ronfaure36;
            ronfaure35.LocationToSouth = ronfaureSandoriaEastgate;

            ronfaure36.LocationToEast = ronfaure37;
            ronfaure36.LocationToSouth = ronfaure41;
            ronfaure36.LocationToWest = ronfaure35;

            ronfaure37.LocationToEast = ronfaure38;
            ronfaure37.LocationToSouth = ronfaure42;
            ronfaure37.LocationToWest = ronfaure36;

            ronfaure38.LocationToEast = ronfaure39;
            ronfaure38.LocationToSouth = ronfaure43;
            ronfaure38.LocationToWest = ronfaure37;

            ronfaure39.LocationToWest = ronfaure38;
            ronfaure39.LocationToNorth = ronfaureToRanguemontPass;

            ronfaureSandoriaEastgate.LocationToEast = ronfaure41;
            ronfaureSandoriaEastgate.LocationToSouth = ronfaure45;
            ronfaureSandoriaEastgate.LocationToWest = sandoriaEastGate;
            ronfaureSandoriaEastgate.LocationToNorth = ronfaure35;

            ronfaure41.LocationToEast = ronfaure42;
            ronfaure41.LocationToSouth = ronfaure46;
            ronfaure41.LocationToWest = ronfaureSandoriaEastgate;
            ronfaure41.LocationToNorth = ronfaure36;

            ronfaure42.LocationToEast = ronfaure43;
            ronfaure42.LocationToSouth = ronfaure47;
            ronfaure42.LocationToWest = ronfaure41;
            ronfaure42.LocationToNorth = ronfaure37;

            ronfaure43.LocationToSouth = ronfaure48;
            ronfaure43.LocationToWest = ronfaure42;
            ronfaure43.LocationToNorth = ronfaure38;

            ronfaureToWestRonfaureN.LocationToEast = ronfaure45;
            ronfaureToWestRonfaureN.LocationToWest = ronfaureToEastRonfaureN;

            ronfaure45.LocationToEast = ronfaure46;
            ronfaure45.LocationToSouth = ronfaure49;
            ronfaure45.LocationToWest = ronfaureToWestRonfaureN;
            ronfaure45.LocationToNorth = ronfaureSandoriaEastgate;

            ronfaure46.LocationToEast = ronfaure47;
            ronfaure46.LocationToSouth = ronfaure51;
            ronfaure46.LocationToWest = ronfaure45;
            ronfaure46.LocationToNorth = ronfaure41;

            ronfaure47.LocationToEast = ronfaure48;
            ronfaure47.LocationToSouth = ronfaure51;
            ronfaure47.LocationToWest = ronfaure46;
            ronfaure47.LocationToNorth = ronfaure42;

            ronfaure48.LocationToWest = ronfaure47;
            ronfaure48.LocationToNorth = ronfaure43;

            ronfaure49.LocationToEast = ronfaure50;
            ronfaure49.LocationToNorth = ronfaure45;

            ronfaure50.LocationToEast = ronfaure51;
            ronfaure50.LocationToWest = ronfaure49;
            ronfaure50.LocationToNorth = ronfaure46;

            ronfaure51.LocationToSouth = ronfaure55;
            ronfaure51.LocationToWest = ronfaure50;
            ronfaure51.LocationToNorth = ronfaure47;

            ronfaureToWestRonfaureS.LocationToEast = ronfaure53;
            ronfaureToWestRonfaureS.LocationToWest = ronfaureToEastRonfaureS;

            ronfaure53.LocationToEast = ronfaure54;
            ronfaure53.LocationToWest = ronfaureToWestRonfaureS;

            ronfaure54.LocationToEast = ronfaure55;
            ronfaure54.LocationToSouth = ronfaure57;
            ronfaure54.LocationToWest = ronfaure53;

            ronfaure55.LocationToSouth = ronfaure58;
            ronfaure55.LocationToWest = ronfaure54;
            ronfaure55.LocationToNorth = ronfaure51;

            ronfaure56.LocationToEast = ronfaure57;
            ronfaure56.LocationToSouth = ronfaure60;

            ronfaure57.LocationToEast = ronfaure58;
            ronfaure57.LocationToSouth = ronfaure61;
            ronfaure57.LocationToWest = ronfaure56;
            ronfaure57.LocationToNorth = ronfaure54;

            ronfaure58.LocationToEast = ronfaure59;
            ronfaure58.LocationToSouth = ronfaure62;
            ronfaure58.LocationToWest = ronfaure57;
            ronfaure58.LocationToNorth = ronfaure55;

            ronfaure59.LocationToSouth = ronfaure63;
            ronfaure59.LocationToWest = ronfaure58;

            ronfaure60.LocationToEast = ronfaure61;
            ronfaure60.LocationToNorth = ronfaure56;

            ronfaure61.LocationToSouth = ronfaureEntranceToKingRanperresTomb;
            ronfaure61.LocationToWest = ronfaure60;
            ronfaure61.LocationToNorth = ronfaure57;

            ronfaure62.LocationToEast = ronfaure63;
            ronfaure62.LocationToNorth = ronfaure58;

            ronfaure63.LocationToWest = ronfaure62;
            ronfaure63.LocationToNorth = ronfaure59;

            ronfaureEntranceToKingRanperresTomb.LocationToNorth = ronfaure61;

            


            //
            //Static List
            //
            //Zone : San d'Oria
            Locations.Add(mogHouse);
            Locations.Add(sandoriaStreets1);
            Locations.Add(sandoriaStreets2);
            Locations.Add(sandoriaStreets3);
            Locations.Add(sandoriaLionSprings);
            Locations.Add(sandoriaStreets5);
            Locations.Add(sandoriaStreets6);
            Locations.Add(sandoriaStreets7);
            Locations.Add(sandoriaStreets8);
            Locations.Add(sandoriaStreets9);
            Locations.Add(sandoriaEastGate);
            Locations.Add(sandoriaStreets11);
            Locations.Add(sandoriaAuctionHouse);
            Locations.Add(sandoriaStreets13);
            Locations.Add(sandoriaStreets14);
            Locations.Add(sandoriaStreets15);
            Locations.Add(sandoriaStreets16);
            Locations.Add(sandoriaStreets17);
            Locations.Add(sandoriaWestGate);
            Locations.Add(sandoriaStreets19);
            Locations.Add(sandoriaStreets20);
            Locations.Add(sandoriaTaumilaSaundries);
            Locations.Add(sandoriaTannersGuild);
            Locations.Add(sandoriaStreets23);
            Locations.Add(sandoriaStreets24);
            Locations.Add(sandoriaStreets25);
            Locations.Add(sandoriaStreets26);
            Locations.Add(sandoriaCountCaffaulesManor27);
            Locations.Add(sandoriaPalace28);

            //Zone: Ronfaure
            Locations.Add(ronfaureGhelsbaEntrance);
            Locations.Add(ronfaure2);
            Locations.Add(ronfaure3);
            Locations.Add(ronfaure4);
            Locations.Add(ronfaure5);
            Locations.Add(ronfaure6);
            Locations.Add(ronfaure7);
            Locations.Add(ronfaure8);
            Locations.Add(ronfaureSandoriaWestgate);
            Locations.Add(ronfaure10);
            Locations.Add(ronfaure11);
            Locations.Add(ronfaure12);
            Locations.Add(ronfaure13);
            Locations.Add(ronfaureToEastRonfaureN);
            Locations.Add(ronfaure15);
            Locations.Add(ronfaure16);
            Locations.Add(ronfaure17);
            Locations.Add(ronfaure18);
            Locations.Add(ronfaure19);
            Locations.Add(ronfaure20);
            Locations.Add(ronfaure21);
            Locations.Add(ronfaure22);
            Locations.Add(ronfaureToEastRonfaureS);
            Locations.Add(ronfaure24);
            Locations.Add(ronfaure25);
            Locations.Add(ronfaure26);
            Locations.Add(ronfaure27);
            Locations.Add(ronfaure28);
            Locations.Add(ronfaure29);
            Locations.Add(ronfaure30);
            Locations.Add(ronfaure31);
            Locations.Add(ronfaure32);
            Locations.Add(ronfaureToLaTheinePlateau);

            Locations.Add(ronfaureToRanguemontPass);
            Locations.Add(ronfaure35);
            Locations.Add(ronfaure36);
            Locations.Add(ronfaure37);
            Locations.Add(ronfaure38);
            Locations.Add(ronfaure39);
            Locations.Add(ronfaureSandoriaEastgate);
            Locations.Add(ronfaure41);
            Locations.Add(ronfaure42);
            Locations.Add(ronfaure43);
            Locations.Add(ronfaureToWestRonfaureN);
            Locations.Add(ronfaure45);
            Locations.Add(ronfaure46);
            Locations.Add(ronfaure47);
            Locations.Add(ronfaure48);
            Locations.Add(ronfaure49);
            Locations.Add(ronfaure50);
            Locations.Add(ronfaure51);
            Locations.Add(ronfaureToWestRonfaureS);
            Locations.Add(ronfaure53);
            Locations.Add(ronfaure54);
            Locations.Add(ronfaure55);
            Locations.Add(ronfaure56);
            Locations.Add(ronfaure57);
            Locations.Add(ronfaure58);
            Locations.Add(ronfaure59);
            Locations.Add(ronfaure60);
            Locations.Add(ronfaure61);
            Locations.Add(ronfaure62);
            Locations.Add(ronfaure63);
            Locations.Add(ronfaureEntranceToKingRanperresTomb);

        }


        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }

    }
}
