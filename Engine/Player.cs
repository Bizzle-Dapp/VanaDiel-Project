
using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine
{
    public class Player : LivingCreature
    {

        public int _gold;
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public int _experiencePoints;
        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }

        public List<Weapon> Weapons
        {
            get { return Inventory.Where(x => x.Details is Weapon).Select(x => x.Details as Weapon).ToList(); }
        }

        public List<Armour> Armour
        {
            get { return Inventory.Where(x => x.Details is Armour).Select(x => x.Details as Armour).ToList(); }
        }

        public List<Accessory> Accessory
        {
            get { return Inventory.Where(x => x.Details is Accessory).Select(x => x.Details as Accessory).ToList(); }
        }

        public List<HealingPotion> Potions
        {
            get { return Inventory.Where(x => x.Details is HealingPotion).Select(x => x.Details as HealingPotion).ToList(); }
        }

        private void RaiseInventoryChangedEvent(Item item)
        {
            if(item is Weapon)
            {
                OnPropertyChanged("Weapons");
            }

            if(item is Armour)
            {
                OnPropertyChanged("Armour");
            }

            if(item is Accessory)
            {
                OnPropertyChanged("Accessory");
            }

            if(item is HealingPotion)
            {
                OnPropertyChanged("Potions");
            }
        }

        public void RemoveItemFromInventory(Item itemToRemove, int quantity = 1)
        {
            InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == itemToRemove.ID);

            if(item == null)
            {
                //No item in players inventory - Possible error raised?!
            }
            else
            {
                item.Quantity -= quantity;

                //Don't allow negative quantities - Possible error raised?!
                if(item.Quantity < 0)
                {
                    item.Quantity = 0;
                }

                if(item.Quantity == 0)
                {
                    Inventory.Remove(item);
                }

                RaiseInventoryChangedEvent(itemToRemove);
            }
        }

        public int Level { get; set; }
        public int NextLevel { get; set; }
        

        public Location CurrentLocation { get; set; }
        public Weapon CurrentWeapon { get; set; } // To store players currently equipped weapon
        public Armour CurrentArmour { get; set; } // To store players currently equipped armour
        public Accessory CurrentAccessory { get; set; } //To store players currently equipped accessory
        public HealingPotion CurrentPotion { get; set; } // To store players currently equipped potion

        public BindingList<InventoryItem> Inventory { get; set; }
        public BindingList<PlayerQuest> Quests { get; set; }


        private Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level, int nextLevel) : base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            NextLevel = nextLevel;
            


            Inventory = new BindingList<InventoryItem>();
            Quests = new BindingList<PlayerQuest>();
        }

        public static Player CreateDefaultPlayer()
        {
            Player player = new Player(10, 10, 20, 0, 1, 2);

            player.CurrentLocation = _World.LocationByID(_World.LOCATION_ID_MOG_HOUSE_MH);
            player.Inventory.Add(new InventoryItem(_World.ItemByID(_World.ITEM_ID_ONION_SWORD), 1));

            player.Inventory.Add(new InventoryItem(_World.ItemByID(_World.ITEM_ID_POTION), 1));

            player.Inventory.Add(new InventoryItem(_World.ItemByID(_World.ITEM_ID_COMMON_CLOTHES), 1));

            player.Inventory.Add(new InventoryItem(_World.ItemByID(_World.ITEM_ID_SANDORIAN_RING), 1));
            return player;
        }

        public static Player CreatePlayerFromXmlString(string xmlPlayerData)
        {
            try
            {
                XmlDocument playerData = new XmlDocument();

                playerData.LoadXml(xmlPlayerData);

                int currentHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentHitPoints").InnerText);
                int maximumHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumHitPoints").InnerText);
                int gold = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Gold").InnerText);
                int experiencePoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ExperiencePoints").InnerText);
                int level = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Level").InnerText);
                int nextLevel = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/NextLevel").InnerText);

                Player player = new Player(currentHitPoints, maximumHitPoints, gold, experiencePoints, level, nextLevel);

                int currentLocationID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentLocation").InnerText);
                player.CurrentLocation = _World.LocationByID(currentLocationID);

                if(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon") != null)
                {
                    int currentWeaponID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
                    player.CurrentWeapon = (Weapon)_World.ItemByID(currentWeaponID);
                }

                if(playerData.SelectSingleNode("/Player/Stats/CurrentArmour") != null)
                {
                    int currentArmourID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentArmour").InnerText);
                    player.CurrentArmour = (Armour)_World.ItemByID(currentArmourID);
                }

                if(playerData.SelectSingleNode("/Player/Stats/CurrentAccessory") != null)
                {
                    int currentAccessoryID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentAccessory").InnerText);
                    player.CurrentAccessory = (Accessory)_World.ItemByID(currentAccessoryID);
                }

                if(playerData.SelectSingleNode("/Player/Stats/CurrentPotion") != null)
                {
                    int currentPotionID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentPotion").InnerText);
                    player.CurrentPotion = (HealingPotion)_World.ItemByID(currentPotionID);
                }

                foreach(XmlNode node in playerData.SelectNodes("/Player/InventoryItems/InventoryItem"))
                {
                    int id = Convert.ToInt32(node.Attributes["ID"].Value);
                    int quantity = Convert.ToInt32(node.Attributes["Quantity"].Value);

                    for(int i = 0; i < quantity; i++)
                    {
                        player.AddItemToInventory(_World.ItemByID(id));
                    }
                }

                foreach(XmlNode node in playerData.SelectNodes("/Player/PlayerQuests/PlayerQuest"))
                {
                    int id = Convert.ToInt32(node.Attributes["ID"].Value);
                    bool isCompleted = Convert.ToBoolean(node.Attributes["IsCompleted"].Value);

                    PlayerQuest playerQuest = new PlayerQuest(_World.QuestByID(id));
                    playerQuest.IsCompleted = isCompleted;

                    player.Quests.Add(playerQuest);
                }
                return player;
            }
            catch
            {
                //If there was an error with the XML data, return a default player object
                
                return Player.CreateDefaultPlayer();
                
            }
        }




        public bool HasRequiredItemToEnterThisLocation(Location location)
        {
            
            if(location.ItemRequiredToEnter == null)
            {
                //There is no required Item for this location
                return true;
            }

            // See if the player has required items
            foreach(InventoryItem ii in Inventory)
            {
                if(ii.Details.ID == location.ItemRequiredToEnter.ID)
                {
                    //We found the required item, so return true
                    return true;
                }
            }

            // we didn't have required item in their inventory, so return "false"
            return false;
        }





        public bool HasThisQuest(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if(playerQuest.Details.ID == quest.ID)
                {
                    return true;
                }
            }
            return false;
        }





        public bool CompletedThisQuest(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if(playerQuest.Details.ID == quest.ID)
                {
                    return playerQuest.IsCompleted;
                }
            }

            return false;
        }






        public bool HasAllQuestCompletionItems(Quest quest)
        {
            //see if the player has all the items needed to compelte the quest here
            foreach(QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                bool foundItemInPlayersInventory = false;

                // Check each item in the players inventory to see if they have it, and enough of it
                foreach(InventoryItem ii in Inventory)
                {
                    //The player has the items in their inventory
                    if(ii.Details.ID == qci.Details.ID)
                    {
                        foundItemInPlayersInventory = true;
                        // Player does not have enough of this item
                        if(ii.Quantity < qci.Quantity)
                        {
                            return false;
                        }
                    }
                }

                // The player does not have any of this quest completion item in their inventory
                if(!foundItemInPlayersInventory)
                {
                    return false;
                }
            }

            //Player must have items required.
            return true;
        }






        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach(QuestCompletionItem qci in quest.QuestCompletionItems)
            {
                // Subtract the quantity form players inventory that needed to complete quest
                InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == qci.Details.ID);

                if(item != null)
                {
                    RemoveItemFromInventory(item.Details, qci.Quantity);
                }
            }
        }



        public void AddItemToInventory( Item itemToAdd, int quantity = 1)
        {
            InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == itemToAdd.ID);

            if(item == null)
            {
                // They didn't have the item, so add it to inventory
                Inventory.Add(new InventoryItem(itemToAdd, quantity));
            }
            else
            {
                //they have the item in their inventory, so increase quantity
                item.Quantity += quantity;
            }

            RaiseInventoryChangedEvent(itemToAdd);
        }




        public void MarkQuestCompleted(Quest quest)
        {
            // Find the quest in the player's quest list
            foreach(PlayerQuest pq in Quests)
            {
                if(pq.Details.ID == quest.ID)
                {
                    // Mark it as completed
                    pq.IsCompleted = true;

                    // We found the quest, and marked it complete, so get
                    //out of this function
                    return;
                }
            }
        }

        

        //
        // Saving Player Data to .xml
        //

        public string ToXmlString()
        {
            XmlDocument playerData = new XmlDocument();

            // Create the top-level XML node
            XmlNode player = playerData.CreateElement("Player");
            playerData.AppendChild(player);

            //Create the Stats child node to hold the other player statistics nodes
            XmlNode stats = playerData.CreateElement("Stats");
            player.AppendChild(stats);

            //Create the child nodes for each Stat of the players
            XmlNode currentHitPoints = playerData.CreateElement("CurrentHitPoints");
            currentHitPoints.AppendChild(playerData.CreateTextNode(this.CurrentHitPoints.ToString()));
            stats.AppendChild(currentHitPoints);

            XmlNode maximumHitPoints = playerData.CreateElement("MaximumHitPoints");
            maximumHitPoints.AppendChild(playerData.CreateTextNode(this.MaximumHitPoints.ToString()));
            stats.AppendChild(maximumHitPoints);

            XmlNode gold = playerData.CreateElement("Gold");
            gold.AppendChild(playerData.CreateTextNode(this.Gold.ToString()));
            stats.AppendChild(gold);

            XmlNode experiencePoints = playerData.CreateElement("ExperiencePoints");
            experiencePoints.AppendChild(playerData.CreateTextNode(this.ExperiencePoints.ToString()));
            stats.AppendChild(experiencePoints);

            XmlNode level = playerData.CreateElement("Level");
            level.AppendChild(playerData.CreateTextNode(this.Level.ToString()));
            stats.AppendChild(level);

            XmlNode nextLevel = playerData.CreateElement("NextLevel");
            nextLevel.AppendChild(playerData.CreateTextNode(this.NextLevel.ToString()));
            stats.AppendChild(nextLevel);

            XmlNode currentLocation = playerData.CreateElement("CurrentLocation");
            currentLocation.AppendChild(playerData.CreateTextNode(this.CurrentLocation.ID.ToString()));
            stats.AppendChild(currentLocation);

            if(CurrentWeapon != null)
            {
                XmlNode currentWeapon = playerData.CreateElement("CurrentWeapon");
                currentWeapon.AppendChild(playerData.CreateTextNode(this.CurrentWeapon.ID.ToString()));
                stats.AppendChild(currentWeapon);
            }
            
            if(CurrentArmour != null)
            {
                XmlNode currentArmour = playerData.CreateElement("CurrentArmour");
                currentArmour.AppendChild(playerData.CreateTextNode(this.CurrentArmour.ID.ToString()));
                stats.AppendChild(currentArmour);
            }
            
            if(CurrentAccessory != null)
            {
                XmlNode currentAccessory = playerData.CreateElement("CurrentAccessory");
                currentAccessory.AppendChild(playerData.CreateTextNode(this.CurrentAccessory.ID.ToString()));
                stats.AppendChild(currentAccessory);
            }

            if(CurrentPotion != null)
            {
                XmlNode currentPotion = playerData.CreateElement("CurrentPotion");
                currentPotion.AppendChild(playerData.CreateTextNode(this.CurrentPotion.ID.ToString()));
                stats.AppendChild(currentPotion);
            }
            

            //Create the Inventory Items child node to hold each InventoryItem node
            XmlNode inventoryItems = playerData.CreateElement("InventoryItems");
            player.AppendChild(inventoryItems);
            //Create the node for each InventoryItem in player inventory
            foreach(InventoryItem item in this.Inventory)
            {
                XmlNode inventoryItem = playerData.CreateElement("InventoryItem");

                XmlAttribute idAttribute = playerData.CreateAttribute("ID");
                idAttribute.Value = item.Details.ID.ToString();
                inventoryItem.Attributes.Append(idAttribute);

                XmlAttribute quantityAttribute = playerData.CreateAttribute("Quantity");
                quantityAttribute.Value = item.Quantity.ToString();
                inventoryItem.Attributes.Append(quantityAttribute);

                inventoryItems.AppendChild(inventoryItem);
            }

            //Create the player quests child node to hold the player quests
            XmlNode playerQuests = playerData.CreateElement("PlayerQuests");
            player.AppendChild(playerQuests);

            foreach(PlayerQuest quest in this.Quests)
            {
                XmlNode playerQuest = playerData.CreateElement("PlayerQuest");

                XmlAttribute idAttribute = playerData.CreateAttribute("ID");
                idAttribute.Value = quest.Details.ID.ToString();
                playerQuest.Attributes.Append(idAttribute);

                XmlAttribute isCompletedAttribute = playerData.CreateAttribute("IsCompleted");
                isCompletedAttribute.Value = quest.IsCompleted.ToString();
                playerQuest.Attributes.Append(isCompletedAttribute);

                playerQuests.AppendChild(playerQuest);
            }

            return playerData.InnerXml; //The XML document, as a string, so we can save the data to disk

        } //End of XML creation

    }
}
