using Engine;
using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace Vanadiel
{
   
    //comment 
    public partial class Vanadiel : Form
    {
        //
        //PLAYER STUFF
        //

        private Player _player;
        private Monster _currentMonster;
        private const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";
        

        
        
        public Vanadiel()
        {
            //Player initialisation
            InitializeComponent();

            if(File.Exists(PLAYER_DATA_FILE_NAME))
            {
                _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PLAYER_DATA_FILE_NAME));

            }
            else
            {
                _player = Player.CreateDefaultPlayer();
            }

            cboWeapons.DataSource = _player.Weapons;
            cboWeapons.DisplayMember = "Name";
            cboWeapons.ValueMember = "Id";
            if(_player.CurrentWeapon != null)
            {
                cboWeapons.SelectedItem = _player.CurrentWeapon;
            }

            cboWeapons.SelectedIndexChanged += cboWeapons_SelectedIndexChanged;

            cboArmour.DataSource = _player.Armour;
            cboArmour.DisplayMember = "Name";
            cboArmour.ValueMember = "Id";
            if (_player.CurrentArmour != null)
            {
                cboArmour.SelectedItem = _player.CurrentArmour;
            }

            cboAccessory.SelectedIndexChanged += cboAccessory_SelectedIndexChanged;

            cboAccessory.DataSource = _player.Accessory;
            cboAccessory.DisplayMember = "Name";
            cboAccessory.ValueMember = "Id";
            if (_player.CurrentAccessory != null)
            {
                cboAccessory.SelectedItem = _player.CurrentAccessory;
            }

            cboAccessory.SelectedIndexChanged += cboAccessory_SelectedIndexChanged;

            cboPotions.DataSource = _player.Potions;
            cboPotions.DisplayMember = "Name";
            cboPotions.ValueMember = "Id";
            if (_player.CurrentPotion != null)
            {
                cboPotions.SelectedItem = _player.CurrentPotion;
            }

            cboPotions.SelectedIndexChanged += cboPotions_SelectedIndexChanged;


            _player.PropertyChanged += PlayerOnPropertyChanged;


            MoveTo(_player.CurrentLocation);
            lblHitPoints.DataBindings.Add("Text", _player, "CurrentHitPoints");
            lblGold.DataBindings.Add("Text", _player, "Gold");
            lblExperience.DataBindings.Add("Text", _player, "ExperiencePoints");

            if (!_player.Potions.Any())
            {
                cboPotions.Visible = false;
                btnUsePotion.Visible = false;
            }



            //Inventory Data bind

            dgvInventory.RowHeadersVisible = false;
            dgvInventory.AutoGenerateColumns = false;

            dgvInventory.DataSource = _player.Inventory;

            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 197,
                DataPropertyName = "Description"
            });

            dgvInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });

            //Quest Data bind

            dgvQuests.RowHeadersVisible = false;
            dgvQuests.AutoGenerateColumns = false;

            dgvQuests.DataSource = _player.Quests;

            dgvQuests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 197,
                DataPropertyName = "Name"
            });

            dgvQuests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Done?",
                DataPropertyName = "IsCompleted"
            });

            Engine._World.SetPlayer(_player);
            //Player Level Updater run
            UpdatePlayerLevelText();

        }

        private void UpdatePlayerLevelText()
        {
            //Updates labels for each player statistic
            
            lblLevel.Text = _player.Level.ToString();
            lblRank.Text = _player.Rank.ToString();

        }

        private void UpdatePlayerLevel()
        {
            //Lvl 2
            if(_player.ExperiencePoints >= 11 && _player.Level != 2 && _player.NextLevel == 2)
            {
                rtbMessages.Text += Environment.NewLine + "YOU HAVE LEVELED UP TO LEVEL 2!" + Environment.NewLine;
                rtbMessages.Text += "Hit Points increased to: 20" + Environment.NewLine + Environment.NewLine;
                _player.MaximumHitPoints = 20;
                _player.Level = 2;
                _player.NextLevel = 3;

                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();
            }

            //Lvl 3
            if(_player.ExperiencePoints >= 45 && _player.Level != 3 && _player.NextLevel == 3)
            {
                rtbMessages.Text += Environment.NewLine + "YOU HAVE LEVELED UP TO LEVEL 3!" + Environment.NewLine;
                rtbMessages.Text += "Hit Points increased to: 32" + Environment.NewLine + Environment.NewLine;
                _player.MaximumHitPoints = 32;
                _player.Level = 3;
                _player.NextLevel = 4;

                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();
            }

            //Lvl 4
            if (_player.ExperiencePoints >= 80 && _player.Level != 4 && _player.NextLevel == 4)
            {
                rtbMessages.Text += Environment.NewLine + "YOU HAVE LEVELED UP TO LEVEL 4!" + Environment.NewLine;
                rtbMessages.Text += "Hit Points increased to: 44" + Environment.NewLine + Environment.NewLine;
                _player.MaximumHitPoints = 44;
                _player.Level = 4;
                _player.NextLevel = 5;

                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();
            }

            //Lvl 5
            if (_player.ExperiencePoints >= 150 && _player.Level != 5 && _player.NextLevel == 5)
            {
                rtbMessages.Text += Environment.NewLine + "YOU HAVE LEVELED UP TO LEVEL 5!" + Environment.NewLine;
                rtbMessages.Text += "Hit Points increased to: 58" + Environment.NewLine + Environment.NewLine;
                _player.MaximumHitPoints = 58;
                _player.Level = 5;
                _player.NextLevel = 6;

                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();
            }

            //Lvl 6
            if (_player.ExperiencePoints >= 220 && _player.Level != 6 && _player.NextLevel == 6)
            {
                rtbMessages.Text += Environment.NewLine + "YOU HAVE LEVELED UP TO LEVEL 6!" + Environment.NewLine;
                rtbMessages.Text += "Hit Points increased to: 70" + Environment.NewLine + Environment.NewLine;
                _player.MaximumHitPoints = 70;
                _player.Level = 6;
                _player.NextLevel = 7;

                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();
            }

            //Lvl 7
            if (_player.ExperiencePoints >= 350 && _player.Level != 7 && _player.NextLevel == 7)
            {
                rtbMessages.Text += Environment.NewLine + "YOU HAVE LEVELED UP TO LEVEL 7!" + Environment.NewLine;
                rtbMessages.Text += "Hit Points increased to: 90" + Environment.NewLine + Environment.NewLine;
                _player.MaximumHitPoints = 90;
                _player.Level = 7;
                _player.NextLevel = 8;

                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();
            }

            //Lvl 8
            if (_player.ExperiencePoints >= 500 && _player.Level != 8 && _player.NextLevel == 8)
            {
                rtbMessages.Text += Environment.NewLine + "YOU HAVE LEVELED UP TO LEVEL 8!" + Environment.NewLine;
                rtbMessages.Text += "Hit Points increased to: 100" + Environment.NewLine + Environment.NewLine;
                _player.MaximumHitPoints = 100;
                _player.Level = 8;
                _player.NextLevel = 9;

                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();
            }

            //Lvl 9
            if (_player.ExperiencePoints >= 700 && _player.Level != 9 && _player.NextLevel == 9)
            {
                rtbMessages.Text += Environment.NewLine + "YOU HAVE LEVELED UP TO LEVEL 9!" + Environment.NewLine;
                rtbMessages.Text += "Hit Points increased to: 113" + Environment.NewLine + Environment.NewLine;
                _player.MaximumHitPoints = 113;
                _player.Level = 9;
                _player.NextLevel = 10;

                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();
            }

            //Lvl 10
            if (_player.ExperiencePoints >= 1000 && _player.Level != 10 && _player.NextLevel == 10)
            {
                rtbMessages.Text += Environment.NewLine + "YOU HAVE LEVELED UP TO LEVEL 10!" + Environment.NewLine;
                rtbMessages.Text += "Hit Points increased to: 128" + Environment.NewLine + Environment.NewLine;
                _player.MaximumHitPoints = 128;
                _player.Level = 10;
                _player.NextLevel = 11;

                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();
            }

        }



        //
        //Move buttons parameters
        //
        private int currentAreaMonstersRemaining = 0;

        private void btnNorth_Click(object sender, EventArgs e)
        {
            rtbMessages.Text = " ";
            rtbLocation.Text = " ";
            moveButtonTimer(_player.CurrentLocation.LocationToNorth);
            
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            rtbMessages.Text = " ";
            rtbLocation.Text = " ";
            moveButtonTimer(_player.CurrentLocation.LocationToWest);
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            rtbMessages.Text = " ";
            rtbLocation.Text = " ";
            moveButtonTimer(_player.CurrentLocation.LocationToEast);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            rtbMessages.Text = " ";
            rtbLocation.Text = " ";
            moveButtonTimer(_player.CurrentLocation.LocationToSouth);
        }







        //The moveTo Function, handles what happens when move buttons call for a change of location
        //
        //
        // MOVE BUTTON CLICK!!!
        //
        //

        private void MoveTo(Location newLocation)
        {
            UpdatePlayerLevelText();

            

            // Check if respawning monsters: if so, reduces enemies available
            if (newLocation != _player.CurrentLocation)
            {
                currentAreaMonstersRemaining = newLocation.MonstersRemaining;
            }

                // Does the location have any required items?
                if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                //Item not on player - inform and reject entrance.
                rtbMessages.Text += "You must have a " + newLocation.ItemRequiredToEnter.Name + " to enter this location." + Environment.NewLine;
                Thread.Sleep(1000);
                return;
            }

             

            rtbMessages.Text += "Location: " + newLocation.Name + Environment.NewLine;

            //Update player location!
            _player.CurrentLocation = newLocation;

            if (_player.CurrentLocation.VendorWorkingHere != null)
            {
                btnTrade.Visible = true;
            }
            else
            {
                btnTrade.Visible = false;
            }


            //Show/Hide available movemetn buttons
            btnNorth.Visible = (newLocation.LocationToNorth != null);
            btnEast.Visible = (newLocation.LocationToEast != null);
            btnWest.Visible = (newLocation.LocationToWest != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);

            //Display current location name and description
            rtbLocation.Text = newLocation.Name + Environment.NewLine + Environment.NewLine;
            rtbLocation.Text += newLocation.Description + Environment.NewLine;

            

            //Update Hit Points in UI
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();

            //Quest available here?
            if (newLocation.QuestAvailableHere != null)
            {
                //See if the player already has the quest, and if they've completed it
                bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.QuestAvailableHere);
                bool playerAlreadyCompeletedQuest = _player.CompletedThisQuest(newLocation.QuestAvailableHere);

                //_player already has the quest?
                if (playerAlreadyHasQuest)
                {
                    //not yet completed
                    if (!playerAlreadyCompeletedQuest)
                    {
                        //see if player has all items needed to complete quest
                        bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItems(newLocation.QuestAvailableHere);

                        if (playerHasAllItemsToCompleteQuest)
                        {
                            //Display message
                            rtbMessages.Text += "You fulfil the quest requirements." + Environment.NewLine;
                            rtbMessages.Text += Environment.NewLine;
                            rtbMessages.Text += "You complete the " + newLocation.QuestAvailableHere.Name + " quest." + Environment.NewLine;

                            // Remove quest items from inventory
                            _player.RemoveQuestCompletionItems(newLocation.QuestAvailableHere);


                            //Give reward for quest completion
                            rtbMessages.Text += "You receive: " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;

                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gil" + Environment.NewLine;

                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            rtbMessages.Text += Environment.NewLine;

                            _player.ExperiencePoints += newLocation.QuestAvailableHere.RewardExperiencePoints;
                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;

                            // Add the reward item to the player's inventory
                            _player.AddItemToInventory(newLocation.QuestAvailableHere.RewardItem);

                            // Mark the quest as completed
                            _player.MarkQuestCompleted(newLocation.QuestAvailableHere);
                        }
                    }

                    }
                    else
                    {
                    // The player does not already have the quest! 

                    //Display the messages
                    
                        rtbMessages.Text += Environment.NewLine + "You receive the " + newLocation.QuestAvailableHere.Name + " quest." + Environment.NewLine;
                        rtbMessages.Text += Environment.NewLine + newLocation.QuestAvailableHere.Description + Environment.NewLine;

                        rtbMessages.Text += Environment.NewLine + "To complete it, return with:" + Environment.NewLine;
                        foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                        {
                            if (qci.Quantity == 1)
                            {
                                rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                            }
                            else
                            {
                                rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                            }
                        }
                        rtbMessages.Text += Environment.NewLine;

                        //Add quest to player quest tracker
                        _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere));

                    }
                
            }

                if (newLocation.MonsterLivingHere != null && newLocation.MonstersRemaining > 0)
                {
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You look around for any enemies at this location..." + Environment.NewLine;
                Thread.Sleep(1000);
                    rtbMessages.Text += "You see a " + newLocation.MonsterLivingHere.Name + Environment.NewLine;

                if(RandomNumberGenerator.NumberBetween(1, 100) >= 50 && newLocation.MonsterLivingHere.IsSignature == false)
                {
                    rtbMessages.Text += "The " + newLocation.MonsterLivingHere.Name + " leaves room for you to escape." + Environment.NewLine;
                    //Show/Hide available movemetn buttons
                    btnNorth.Visible = (newLocation.LocationToNorth != null);
                    btnEast.Visible = (newLocation.LocationToEast != null);
                    btnWest.Visible = (newLocation.LocationToWest != null);
                    btnSouth.Visible = (newLocation.LocationToSouth != null);
                }
                else
                {
                    rtbMessages.Text += "The " + newLocation.MonsterLivingHere.Name + " locks you into combat." + Environment.NewLine + "There is no option but to fight!" + Environment.NewLine;
                    btnNorth.Visible = false;
                    btnEast.Visible = false;
                    btnWest.Visible = false;
                    btnSouth.Visible = false;

                }

                    //Make a new instance of Monster using values from _World.Monster list
                    Monster standardMonster = _World.MonsterByID(newLocation.MonsterLivingHere.ID);

                    _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.EvadeChance, standardMonster.MaximumDamage, standardMonster.RewardExperiencePoints, standardMonster.RewardGold, standardMonster.IsSignature, standardMonster.CurrentHitPoints, standardMonster.MaximumHitPoints);

                    foreach (LootItem lootItem in standardMonster.LootTable)
                    {
                        _currentMonster.LootTable.Add(lootItem);
                    }

                    
                    btnUseWeapon.Visible = true;
                    
                }
                else
                {
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You feel a sense of safety at this location." + Environment.NewLine;

                    _currentMonster = null;

                    
                    btnUseWeapon.Visible = false;
                    

                //Show/Hide available movemetn buttons
                btnNorth.Visible = (newLocation.LocationToNorth != null);
                btnEast.Visible = (newLocation.LocationToEast != null);
                btnWest.Visible = (newLocation.LocationToWest != null);
                btnSouth.Visible = (newLocation.LocationToSouth != null);
            }
            
                //Full heal if newLocation is Home
                if(newLocation.ID == _World.LOCATION_ID_MOG_HOUSE_MH)
                {
                //Heal Player <Local to Home location>
                rtbMessages.Text += Environment.NewLine + "A good nights rest prepares you for what's ahead. (Hit Points Restored.)" + Environment.NewLine;
                _player.CurrentHitPoints = _player.MaximumHitPoints;
                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                }


        }

        private void PlayerOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if(propertyChangedEventArgs.PropertyName == "Weapons")
            {
                cboWeapons.DataSource = _player.Weapons;

                if(!_player.Weapons.Any())
                {
                    cboWeapons.Visible = false;
                    btnUseWeapon.Visible = true;
                }
            }

            if (propertyChangedEventArgs.PropertyName == "Armour")
            {
                cboArmour.DataSource = _player.Armour;

                if (!_player.Armour.Any())
                {
                    cboArmour.Visible = false;
                }
            }

            if (propertyChangedEventArgs.PropertyName == "Accessory")
            {
                cboAccessory.DataSource = _player.Accessory;

                if (!_player.Accessory.Any())
                {
                    cboAccessory.Visible = false;
                }
            }

            if (propertyChangedEventArgs.PropertyName == "Potions")
            {
                cboPotions.DataSource = _player.Potions;

                if (!_player.Potions.Any())
                {
                    cboPotions.Visible = false;
                    btnUsePotion.Visible = false;
                }
            }
        }















        //
        //
        // WEAPON BUTTON CLICK!!!
        //
        //


        private void btnUseWeapon_Click(object sender, EventArgs e)
        {


            // Get currently selected weapon from the cboWeapons cbo
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;
            Armour currentArmour = (Armour)cboArmour.SelectedItem;
            Accessory currentAccessory = (Accessory)cboAccessory.SelectedItem;

            //Determine statistics of combat

            int playerHitChance = RandomNumberGenerator.NumberBetween(currentWeapon.HitChanceModifier += currentAccessory.HitChanceModifier, 100);
            int playerEvadeChance = RandomNumberGenerator.NumberBetween(currentArmour.EvadeChance, 100);

            int monsterHitChance = RandomNumberGenerator.NumberBetween(20, 100);
            int monsterEvadeChance = RandomNumberGenerator.NumberBetween(1 + _currentMonster.EvadeChance, 50);

            int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);
            int playerArmour = currentArmour.ArmourClass;
            int playerAccessory = currentAccessory.AccessoryClass;
            int playerAccessoryChance = currentAccessory.AccessoryDeflectChance;

            if(playerHitChance >= monsterEvadeChance)
            {
                //Apply damage to monster currentHP
                _currentMonster.CurrentHitPoints -= damageToMonster;

                //Display Damage log
                rtbMessages.Text += Environment.NewLine + "You strike the " + _currentMonster.Name + " with your " + currentWeapon.Name + "!" + Environment.NewLine;
                rtbMessages.Text += "You hit the " + _currentMonster.Name + " for " + damageToMonster.ToString() + " points. " + Environment.NewLine + Environment.NewLine;
            }
           else
            {
                rtbMessages.Text += "You miss the " + _currentMonster.Name + " with your " + currentWeapon.Name + "!" + Environment.NewLine + Environment.NewLine;
            }

            //Check if monster is dead
            if (_currentMonster.CurrentHitPoints <= 0)
            {
                //Monster dead
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You defeated the " + _currentMonster.Name + Environment.NewLine;

                //Give EXP to player
                _player.ExperiencePoints += _currentMonster.RewardExperiencePoints;
                rtbMessages.Text += "You receive " + _currentMonster.RewardExperiencePoints.ToString() + " experience points" + Environment.NewLine;

                //Give Gold for killing monster
                _player.Gold += _currentMonster.RewardGold;
                rtbMessages.Text += "You receive " + _currentMonster.RewardGold.ToString() + " gil" + Environment.NewLine;

                //Get random loot items from the monster
                List<InventoryItem> lootedItems = new List<InventoryItem>();

                // add items to the lootedItems list, comparing a random number to the drop percentage
                foreach (LootItem lootItem in _currentMonster.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }

                // if no items were randomly selected the add the default loot items(s)
                if (lootedItems.Count == 0)
                {
                    foreach (LootItem lootItem in _currentMonster.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                }

                //Add the looted items to the player's inventory
                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    _player.AddItemToInventory(inventoryItem.Details);

                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
                    }
                }

                UpdatePlayerLevel();

                // Refresh player information and inventory controls
                lblHitPoints.Text = _player.CurrentHitPoints.ToString();
                lblGold.Text = _player.Gold.ToString();
                lblExperience.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();


                // Blank line in message box - For clarity
                rtbMessages.Text += Environment.NewLine;

                //Reduce Monsters at location by 1
                currentAreaMonstersRemaining--;


                //Move player to current location (if more enemies are available)
                if(currentAreaMonstersRemaining >= 1)
                {
                    MoveTo(_player.CurrentLocation);
                    
                }
                    else
                {
                    rtbMessages.Text += "Looking around, there are no monsters... Perhaps come back in a while..?" + Environment.NewLine + Environment.NewLine;
                    btnUseWeapon.Visible = false;
                    

                    btnNorth.Visible = (_player.CurrentLocation.LocationToNorth != null);
                    btnEast.Visible = (_player.CurrentLocation.LocationToEast != null);
                    btnWest.Visible = (_player.CurrentLocation.LocationToWest != null);
                    btnSouth.Visible = (_player.CurrentLocation.LocationToSouth != null);
                }
                
            }
            else
            {
                //Monster is still alive - resolution:

                if(monsterHitChance > playerEvadeChance)
                {

                    //Determine if accessory will proc
                    int accessoryProc = RandomNumberGenerator.NumberBetween(0, 100);
                    int accessoryReduction = 0;
                    if (accessoryProc <= playerAccessoryChance)
                    {
                        accessoryReduction = playerAccessory;
                    }
                    else
                    {
                        accessoryReduction = 0;
                    }


                    // Determine the amount of damage the monster deals to _player
                    int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                    int damageDealtToPlayer = damageToPlayer;
                    damageDealtToPlayer = damageDealtToPlayer - playerArmour;
                    damageDealtToPlayer = damageDealtToPlayer - accessoryReduction;

                    if (damageDealtToPlayer <= 0)
                    {
                        damageDealtToPlayer = 0;
                    }

                    //Display damage message
                    rtbMessages.Text += Environment.NewLine;
                    rtbMessages.Text += "The " + _currentMonster.Name + " strikes you!" + Environment.NewLine;
                    rtbMessages.Text += "The " + _currentMonster.Name + " did " + damageDealtToPlayer.ToString() + " points of damage to you!" + Environment.NewLine;
                    rtbMessages.Text += "Your " + currentArmour.Name + " protected you from " + playerArmour.ToString() + " damage." + Environment.NewLine;
                    rtbMessages.Text += "Your " + currentAccessory.Name + " protected you from " + accessoryReduction.ToString() + " damage. " + Environment.NewLine + Environment.NewLine;

                    //Subtract damage from player
                    _player.CurrentHitPoints -= damageDealtToPlayer;

                    // Refresh player data in UI
                    lblHitPoints.Text = _player.CurrentHitPoints.ToString();

                    if (_player.CurrentHitPoints <= 0)
                    {
                        //Display message
                        rtbMessages.Text += Environment.NewLine;
                        rtbMessages.Text += "The " + _currentMonster.Name + " killed you." + Environment.NewLine;
                        rtbMessages.Text += Environment.NewLine;
                        rtbMessages.Text += "When you wake, you're home... Safe, and unharmed..." + Environment.NewLine;
                        rtbMessages.Text += Environment.NewLine;
                        rtbMessages.Text += Environment.NewLine;

                        //Move player to "Home"
                        MoveTo(_World.LocationByID(_World.LOCATION_ID_MOG_HOUSE_MH));
                    }
                }
                else
                {
                    rtbMessages.Text += "The " + _currentMonster.Name + " misses you!";
                }

            }
        } //End of Use Weapon Block

        private void cboWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentWeapon = (Weapon)cboWeapons.SelectedItem;
        }
        
        private void cboArmour_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentArmour = (Armour)cboArmour.SelectedItem;
        }

        private void cboAccessory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentAccessory = (Accessory)cboAccessory.SelectedItem;
        }

        private void cboPotions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _player.CurrentPotion = (HealingPotion)cboPotions.SelectedItem;
        }



















        //
        //
        // POTION BUTTON CLICK!!!
        //
        //



        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            //Get the currently selected potion from the potion cbo
            HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;

            int amountHealed = RandomNumberGenerator.NumberBetween(potion.MinimumHeal, potion.MaximumHeal);

            // Add healing amount to the player's current hit points
            _player.CurrentHitPoints = (_player.CurrentHitPoints + amountHealed);

            if(_player.CurrentHitPoints > _player.MaximumHitPoints)
            {
                _player.CurrentHitPoints = _player.MaximumHitPoints;
            }

            //Remove potion from _player's inventory
            _player.RemoveItemFromInventory(potion, 1);

            //Display message
            rtbMessages.Text += Environment.NewLine;
            rtbMessages.Text += "You use a " + potion.Name + Environment.NewLine;
            rtbMessages.Text += "Amount Healed: " + amountHealed + Environment.NewLine;

            //MONSTERS TURN, no free item usage around here...

            if(_player.CurrentLocation.MonstersRemaining != 0)
            {
                // Get currently selected weapon from the cboWeapons cbo
                Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;
                Armour currentArmour = (Armour)cboArmour.SelectedItem;
                Accessory currentAccessory = (Accessory)cboAccessory.SelectedItem;

                //Determine statistics of combat

                int playerHitChance = RandomNumberGenerator.NumberBetween(50, 100) + currentWeapon.HitChanceModifier + currentAccessory.HitChanceModifier;
                int playerEvadeChance = RandomNumberGenerator.NumberBetween(1, 100) + currentArmour.EvadeChance;

                int monsterHitChance = RandomNumberGenerator.NumberBetween(20, 100) + 1;
                int monsterEvadeChance = RandomNumberGenerator.NumberBetween(1, 50) + _currentMonster.EvadeChance;


                int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);
                int playerArmour = currentArmour.ArmourClass;
                int playerAccessory = currentAccessory.AccessoryClass;
                int playerAccessoryChance = currentAccessory.AccessoryDeflectChance;

                if (monsterHitChance > playerEvadeChance)
                {
                    //Determine if accessory will proc
                    int accessoryProc = RandomNumberGenerator.NumberBetween(0, 100);
                    int accessoryReduction = 0;
                    if (accessoryProc <= playerAccessoryChance)
                    {
                        accessoryReduction = playerAccessory;
                    }
                    else
                    {
                        accessoryReduction = 0;
                    }


                    // Determine the amount of damage the monster deals to _player
                    int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                    int damageDealtToPlayer = damageToPlayer;
                    damageDealtToPlayer = damageDealtToPlayer - playerArmour;
                    damageDealtToPlayer = damageDealtToPlayer - accessoryReduction;

                    if (damageDealtToPlayer <= 0)
                    {
                        damageDealtToPlayer = 0;
                    }

                    //Display damage message
                    rtbMessages.Text += Environment.NewLine;
                    rtbMessages.Text += "The " + _currentMonster.Name + " strikes you!" + Environment.NewLine;
                    rtbMessages.Text += "The " + _currentMonster.Name + " did " + damageDealtToPlayer.ToString() + " points of damage to you!" + Environment.NewLine;
                    rtbMessages.Text += "Your " + currentArmour.Name + " protected you from " + playerArmour.ToString() + " damage." + Environment.NewLine;
                    rtbMessages.Text += "Your " + currentAccessory.Name + " protected you from " + accessoryReduction.ToString() + " damage. " + Environment.NewLine + Environment.NewLine;

                    //Subtract damage from player
                    _player.CurrentHitPoints -= damageDealtToPlayer;

                    // Refresh player data in UI
                    lblHitPoints.Text = _player.CurrentHitPoints.ToString();

                    if (_player.CurrentHitPoints <= 0)
                    {
                        //Display message
                        rtbMessages.Text += Environment.NewLine;
                        rtbMessages.Text += "The " + _currentMonster.Name + " killed you." + Environment.NewLine;
                        rtbMessages.Text += Environment.NewLine;
                        rtbMessages.Text += "When you wake, you're home... Safe, and unharmed..." + Environment.NewLine;
                        rtbMessages.Text += Environment.NewLine;
                        rtbMessages.Text += Environment.NewLine;

                        //Move player to "Home"
                        MoveTo(_World.LocationByID(_World.LOCATION_ID_MOG_HOUSE_MH));
                    }
                    
                }
            else
                {
                    rtbMessages.Text += "The " + _currentMonster.Name + " misses you!" + Environment.NewLine + Environment.NewLine;
                }
            }

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            UpdatePlayerLevelText();

        } //End of Use Potion Block



        //Messages window snap to bottom of text
        private void rtbMessages_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            // scroll it automatically
            rtbMessages.ScrollToCaret();
        }


        //
        // Timer Configurations
        //

        //The main TimerOn variable (Stops double click of button being recognised during 1 second click delay.)
        public bool timerOn = false;

        // The move button timer delays movement on click
        public void moveButtonTimer(Location location)
        {
            if (timerOn == false)
            {
                timerOn = true;
                System.Timers.Timer myTimer = new System.Timers.Timer(1000);
                myTimer.SynchronizingObject = this;

                myTimer.Elapsed += (eventSource, unusedArgs) =>
                {
                    MoveTo(location);
                    timerOn = false;
                };
                myTimer.AutoReset = false;
                myTimer.Start();

            }
        }

        private void Vanadiel_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            TradingScreen tradingScreen = new TradingScreen(_player);
            tradingScreen.StartPosition = FormStartPosition.CenterParent;
            tradingScreen.ShowDialog(this);
        }


    }
}
