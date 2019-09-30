using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Shop : Inventory
    {
        private Player _player;
        
        
        private int _itemCost = 0;
        
        //create a butch of items
        private Item dagger = new AttackItem("Dagger", 10, 10);
        private Item sword = new AttackItem("Sword", 20, 20);
        private Item bow = new AttackItem("Bow", 30, 25);
        private Item yo = new AttackItem("Metal Yo-Yo", 40, 15);
        private Item hammer = new AttackItem("Hammer", 50, 40);
        private Item warhammer = new AttackItem("War Hammer", 60, 50);
        private Item light = new ArmorItem("Light Armor", 10, 5);
        private Item medium = new ArmorItem("Medium Armor", 30, 30);
        private Item heavy = new ArmorItem("Heavy Armor", 100, 80);
        private Item small = new Potion("Small Potion", 20, 5);
        private Item mid = new Potion("Medium Potion", 50, 30);
        private Item all = new Potion("Heal To Max", 100, 50);
        
               

        //keeps track item arrays
        public Shop()
        {
            Add(dagger);
            Add(sword);
            Add(bow);
            Add(yo);
            Add(hammer);
            Add(warhammer);
            Add(light);
            Add(medium);
            Add(heavy);
            Add(small);
            Add(mid);
            Add(all);
        }
        //the opening menu
        public void Menu()
        {
            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("Welcome to the Shop.");
                //shows how much gold they have at the moment
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?");
                //shows the items they have at the moment
                Console.WriteLine("0: End Game");
                Console.WriteLine("1: Buy Item");
                Console.WriteLine("2: Add Gold");
                Console.WriteLine("3: See your Inventory");
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    BuyItem();
                }
                else if (choice == "2")
                {
                    AddedGold();
                }
                else if (choice == "3")
                {
                    _player.Print();
                    Console.WriteLine("Gold: " + _gold);
                    //while(choice != "0")
                    //{
                    //    Console.WriteLine("Would you like to sell your items?");
                    //    Console.WriteLine("0: No");
                    //    Console.WriteLine("1: Yes");
                    //    choice = Console.ReadLine();
                    //    Console.WriteLine();
                    //    if (choice == "1")
                    //    {
                    //        _player.Sell();
                    //    }
                    //}
                    

                }
            }
        }
        //open menu to buy items
        public void BuyItem()
        {
            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("What would you like to buy?");
                Console.WriteLine("0: Go Back");
                Console.WriteLine("1: Weapon");
                Console.WriteLine("2: Armor");
                Console.WriteLine("3: Potion");
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    Weapon();
                }
                else if (choice == "2")
                {
                    Armor();
                }
                else if (choice == "3")
                {
                    Potion();
                }

            }
        }
        //open menu to buy weapons
        public void Weapon()
        {

            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("");
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("0: Go Back");
                Console.WriteLine("1: " + dagger._name + " Damage: 10"  + " Cost:" + dagger._cost);
                Console.WriteLine("2: " + sword._name + " Damage: 20"  + " Cost:" + sword._cost);
                Console.WriteLine("3: " + bow._name + " Damage: 30"  + " Cost:" + bow._cost);
                Console.WriteLine("4: " + yo._name + " Damage: 40"  + " Cost:" + yo._cost);
                Console.WriteLine("5: " + hammer._name + " Damage: 50"  + " Cost:" + hammer._cost);
                Console.WriteLine("6: " + warhammer._name + " Damage: 60"  + " Cost:" + warhammer._cost);
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    
                    _itemCost = _inventory[0]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have bought " + dagger._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        Add(_inventory[0]);
                        Remove(0);
                    }
                }
                else if (choice == "2")
                {
                    _itemCost = _inventory[1]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have bought " + sword._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[1]);
                        Remove(1);
                    }
                }
                else if (choice == "3")
                {
                    _itemCost = _inventory[2]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have bought " + bow._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[2]);
                        Remove(2);
                    }

                }
                else if (choice == "4")
                {
                    _itemCost = _inventory[3]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have bought " + yo._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[3]);
                        Remove(3);
                    }

                }
                else if (choice == "5")
                {
                    _itemCost = _inventory[4]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have bought " + hammer._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[4]);
                        Remove(4);
                    }

                }
                else if (choice == "6")
                {
                    _itemCost = _inventory[5]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have bought " + warhammer._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[5]);
                        Remove(5);
                    }

                }

            }

        }
        //open menu to buy armor
        public void Armor()
        {
            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("0: Go Back");
                Console.WriteLine("1:" + light._name + " Defence: 10"  + " Cost:" + light._cost);
                Console.WriteLine("2:" + medium._name + " Defence: 30"  + " Cost:" + medium._cost);
                Console.WriteLine("3:" + heavy._name + " Defence: 100"  + " Cost:" + heavy._cost);
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    _itemCost = _inventory[6]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have equiped " + light._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[6]);
                        Remove(6);
                    }

                }
                else if (choice == "2")
                {
                    _itemCost = _inventory[7]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have equiped " + medium._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[7]);
                        Remove(7);
                    }

                }
                else if (choice == "3")
                {
                    _itemCost = _inventory[8]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have equiped " + heavy._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[8]);
                        Remove(8);
                    }

                }

            }
        }
        //open menu to buy potion
        public void Potion()
        {
            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("0: Go Back");
                Console.WriteLine("1:" + small._name + " Heals: 20"  + " Cost:" + small._cost);
                Console.WriteLine("2:" + mid._name + " Heals: 50"  + " Cost:" + mid._cost);
                Console.WriteLine("3:" + all._name + " Heals: 100"  + " Cost:" + all._cost);
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    _itemCost = _inventory[9]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have equiped " + small._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[9]);
                        Remove(9);
                    }

                }
                else if (choice == "2")
                {
                    _itemCost = _inventory[10]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have equiped " + mid._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[10]);
                        Remove(10);
                    }

                }
                else if (choice == "3")
                {
                    _itemCost = _inventory[11]._cost;
                    //check if the player have enough gold
                    if (_gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have equiped " + all._name + "!");
                        _gold -= _itemCost;
                        Console.WriteLine("Gold: " + _gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[11]);
                        Remove(11);
                    }

                }

            }
        }
    }
}
