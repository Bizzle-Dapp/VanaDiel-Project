using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Controller
{
    public static partial class _World //items
    {
        public static readonly List<Item> Items = new List<Item>();

        #region Items
        //Item Grouping
        //Spare IDs (0-300)
        public const int UNSELLABLE_ITEM = 0;


        //Weapon IDs (500-790)
        //Swords
        public const int SWD_ID_ONION_SWORD = 500;
        public const int SWD_ID_BRONZE_SWORD = 510;
        public const int SWD_ID_SAPARA = 520;
        public const int SWD_ID_XIPHOS = 530;
        public const int SWD_ID_SPATHA = 540;
        public const int SWD_ID_ROYAL_ARCHERS_SWORD = 550;
        public const int SWD_ID_BILBO = 560;
        public const int SWD_ID_KINGDOM_SWORD = 570;
        public const int SWD_ID_SANDORIAN_SIGNET_SWORD = 580;
        public const int SWD_ID_MYTHRIL_SWORD = 590;
        public const int SWD_ID_ANCIENT_SWORD = 600;
        public const int SWD_ID_SAVE_THE_QUEEN = 610;

        //Great Swords
        public const int GSWD_ID_RUSTY_GREATSWORD = 620;
        public const int GSWD_ID_CLAYMORE = 630;
        public const int GSWD_ID_VULCAN_CLAYMORE = 640;
        public const int GSWD_ID_ROYAL_SWORDSMAN_CLAYMORE = 650;
        public const int GSWD_ID_COBRA_UNIT_CLAYMORE = 660;
        public const int GSWD_ID_DARKSTEEL_CLAYMORE = 670;
        public const int GSWD_ID_MYTHRIL_CLAYMORE = 680;
        public const int GSWD_ID_FLAME_CLAYMORE = 690;
        public const int GSWD_ID_RAGNAROK = 700;

        //Bows
        public const int BOW_ID_SHORTBOW = 710;
        public const int BOW_ID_FREESWORD_BOW = 720;
        public const int BOW_ID_POWER_BOW = 730;
        public const int BOW_ID_PLATOON_BOW = 740;
        public const int BOW_ID_KINGDOM_BOW = 750;
        public const int BOW_ID_GREAT_BOW = 760;
        public const int BOW_ID_BATTLE_BOW = 770;
        public const int BOW_ID_LIGHTNING_BOW = 780;


        //Potion IDs (900-990)
        public const int POTION_ID_POTION = 900;
        public const int POTION_ID_HI_POTION = 910;
        public const int POTION_ID_HI_POTION_PLUS = 920;
        public const int POTION_ID_MEGA_POTION = 930;
        public const int POTION_ID_MEGA_POTION_PLUS = 940;
        public const int POTION_ID_X_POTION = 950;

        //Key Item IDs (1000-1490)
        public const int KI_ID_BAMBOO_FISHING_ROD = 1000;
        public const int KI_ID_KRT_SEAL = 1099;
        public const int KI_ID_GRAVEROBBERS_NOTES = 1001;

        //Armour IDs (1500-1590)
        public const int ARMOUR_ID_COMMON_CLOTHES = 1500;
        public const int ARMOUR_ID_LEATHER_ARMOUR = 1510;
        public const int ARMOUR_ID_SCALE_MAIL = 1520;
        public const int ARMOUR_ID_CHAIN_DOUBLET = 1530;

        //Accessory IDs (1600-1690)
        public const int ACCESSORY_ID_SANDORIAN_RING = 1600;

        //Item ID's (1700+)
        public const int ITEM_ID_RABBIT_MEAT = 1700;
        public const int ITEM_ID_BEASTCOIN = 1701;
        public const int ITEM_ID_COPPER_ORE = 1710;
        public const int ITEM_ID_RABBIT_HIDE = 1720;
        public const int ITEM_ID_SLEEPSHROOM = 1730;
        public const int ITEM_ID_WOOZYSHROOM = 1740;
        public const int ITEM_ID_FLINT_STONE = 1750;
        public const int ITEM_ID_ZINC_ORE = 1760;
        public const int ITEM_ID_BEETLE_JAW = 1770;
        public const int ITEM_ID_INSECT_WING = 1780;
        public const int ITEM_ID_BEETLE_SHELL = 1790;
        public const int ITEM_ID_GRASS_THREAD = 1800;
        public const int ITEM_ID_GRASS_CLOTH = 1810;
        public const int ITEM_ID_COTTON_THREAD = 1820;
        public const int ITEM_ID_COTTON_CLOTH = 1830;
        public const int ITEM_ID_BAT_WING = 1840;
        public const int ITEM_ID_FIEND_BLOOD = 1850;
        public const int ITEM_ID_ROCK_SALT = 1860;
        public const int ITEM_ID_ORCISH_AXE = 1870;
        public const int ITEM_ID_BOMB_ASH = 1880;
        public const int ITEM_ID_BONE_CHIP = 1890;
        public const int ITEM_ID_REVIVAL_TREE_ROOT = 1900;
        public const int ITEM_ID_WOLF_HIDE = 1910;
        #endregion

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
            Items.Add(new Weapon(SWD_ID_ONION_SWORD, "Onion Sword", "Onion Swords", 1, 0, 5, UNSELLABLE_ITEM));
            Items.Add(new Weapon(SWD_ID_BRONZE_SWORD, "Bronze Sword", "Bronze Swords", 5, 1, 6, 50));
            Items.Add(new Weapon(SWD_ID_SAPARA, "Sapara", "Saparas", 5, 4, 7, 400));
            Items.Add(new Weapon(SWD_ID_XIPHOS, "Xiphos", "Xiphos", 5, 5, 8, 520));
            Items.Add(new Weapon(SWD_ID_SPATHA, "Spatha", "Spathas", 5, 8, 14, 1000));
            Items.Add(new Weapon(SWD_ID_ROYAL_ARCHERS_SWORD, "Royal Archer's Sword", "Royal Archer's Swords", 5, 10, 15, 1600));
            Items.Add(new Weapon(SWD_ID_BILBO, "Bilbo", "Bilbos", 5, 11, 15, 1700));
            Items.Add(new Weapon(SWD_ID_KINGDOM_SWORD, "Kingdom Sword", "Kingdom Swords", 5, 15, 24, 3600));
            Items.Add(new Weapon(SWD_ID_SANDORIAN_SIGNET_SWORD, "San d'Orian Signet Sword", "San d'Orian Signet Swords", 5, 17, 27, 4600));
            Items.Add(new Weapon(SWD_ID_MYTHRIL_SWORD, "Mythril Sword", "Mythril Swords", 5, 22, 33, 7800));
            Items.Add(new Weapon(SWD_ID_ANCIENT_SWORD, "Ancient Sword", "Ancient Swords", 5, 30, 45, UNSELLABLE_ITEM));
            Items.Add(new Weapon(SWD_ID_SAVE_THE_QUEEN, "Save The Queen", "Save The Queens", 5, 50, 100, UNSELLABLE_ITEM));

            //Great Swords
            Items.Add(new Weapon(GSWD_ID_RUSTY_GREATSWORD, "Rusty Greatsword", "Rusty Greatswords", 5, 0, 10, 120));
            Items.Add(new Weapon(GSWD_ID_CLAYMORE, "Claymore", "Claymores", 5, 1, 11, 390));
            Items.Add(new Weapon(GSWD_ID_VULCAN_CLAYMORE, "Vulcan Claymore", "Vulcan Claymores", 5, 3, 18, 700));
            Items.Add(new Weapon(GSWD_ID_ROYAL_SWORDSMAN_CLAYMORE, "Royal Swordsman's Claymore", "Royal Swordsman's Claymores", 5, 4, 22, 1800));
            Items.Add(new Weapon(GSWD_ID_COBRA_UNIT_CLAYMORE, "Cobra Unit Claymore", "Cobra Unit Claymores", 5, 6, 28, 2900));
            Items.Add(new Weapon(GSWD_ID_DARKSTEEL_CLAYMORE, "Darksteel Claymore", "Darksteel Claymores", 5, 12, 36, 6600));
            Items.Add(new Weapon(GSWD_ID_MYTHRIL_CLAYMORE, "Mythril Claymore", "Mythril Claymores", 5, 15, 60, 10800));
            Items.Add(new Weapon(GSWD_ID_FLAME_CLAYMORE, "Flame Claymore", "Flame Claymores", 5, 20, 70, UNSELLABLE_ITEM));
            Items.Add(new Weapon(GSWD_ID_RAGNAROK, "Ragnarok", "Ragnaroks", 5, 30, 150, UNSELLABLE_ITEM));

            //Bows
            Items.Add(new Weapon(BOW_ID_SHORTBOW, "Shortbow", "Shortbows", 5, 2, 3, 30));
            Items.Add(new Weapon(BOW_ID_FREESWORD_BOW, "Freesword Bow", "Freesword Bows", 5, 5, 6, 700));
            Items.Add(new Weapon(BOW_ID_POWER_BOW, "Power Bow", "Power Bows", 5, 9, 10, 1100));
            Items.Add(new Weapon(BOW_ID_PLATOON_BOW, "Platoon Bow", "Platoon Bows", 5, 14, 15, 2800));
            Items.Add(new Weapon(BOW_ID_KINGDOM_BOW, "Kingdom Bow", "Kingdom Bows", 5, 18, 19, 4100));
            Items.Add(new Weapon(BOW_ID_GREAT_BOW, "Great Bow", "Great Bows", 5, 25, 26, 7600));
            Items.Add(new Weapon(BOW_ID_BATTLE_BOW, "The Battle Bow", "Battle Bows", 5, 37, 38, 30));
            Items.Add(new Weapon(BOW_ID_LIGHTNING_BOW, "Lightning Bow", "Lightning Bows", 5, 62, 68, UNSELLABLE_ITEM));


            //Populate potions
            Items.Add(new HealingPotion(POTION_ID_POTION, "Potion", "Potions", 5, 10, 50));
            Items.Add(new HealingPotion(POTION_ID_HI_POTION, "Hi-Potion", "Hi-Potions", 15, 30, 250));
            Items.Add(new HealingPotion(POTION_ID_HI_POTION_PLUS, "Hi-Potion +", "Hi-Potion Plus'", 21, 36, 450));
            Items.Add(new HealingPotion(POTION_ID_MEGA_POTION, "Mega Potion", "Mega Potions", 45, 70, 1100));
            Items.Add(new HealingPotion(POTION_ID_MEGA_POTION_PLUS, "Mega Potion +", "Mega Potion Plus'", 55, 80, 1600));
            Items.Add(new HealingPotion(POTION_ID_X_POTION, "X-Potion", "X-Potions", 100, 200, 5000));



            //Populate key items
            Items.Add(new Item(KI_ID_BAMBOO_FISHING_ROD, "Bamboo Fishing Rod", "Bamboo Fishing Rods", UNSELLABLE_ITEM));
            Items.Add(new Item(KI_ID_KRT_SEAL, "Seal of Ranperre", "Seals of Ranperre", UNSELLABLE_ITEM));
            Items.Add(new Item(KI_ID_GRAVEROBBERS_NOTES, "Graverobber's Notes", "Graverobber's Notes", UNSELLABLE_ITEM));

            //Populate Armour
            Items.Add(new Armour(ARMOUR_ID_COMMON_CLOTHES, "Common Clothes", "Common Clothes", 0, 0, UNSELLABLE_ITEM));
            Items.Add(new Armour(ARMOUR_ID_LEATHER_ARMOUR, "Leather Armour", "Leather Armour", 1, 2, 120));
            Items.Add(new Armour(ARMOUR_ID_SCALE_MAIL, "Scalemail", "Scalemail", 3, 0, 360));
            Items.Add(new Armour(ARMOUR_ID_CHAIN_DOUBLET, "Chain Doublet", "Chain Doublets", 2, 2, 400));


            //Populate Accessories
            Items.Add(new Accessory(ACCESSORY_ID_SANDORIAN_RING, "San d'Orian Ring", "San d'Orian Rings", 1, 0, 0, UNSELLABLE_ITEM));

        }

    }
}
