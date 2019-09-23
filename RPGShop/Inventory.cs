using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Inventory
    {
        private int _itemCost = 0;
        private float _gold = 0.00f;
        //create a butch of items
        private AttackItem dagger = new AttackItem("Dagger", 10, 10);
        private AttackItem sword = new AttackItem("Sword", 20, 20);
        private AttackItem bow = new AttackItem("Bow", 30, 25);
        private AttackItem yo = new AttackItem("Metal Yo-Yo", 40, 15);
        private AttackItem hammer = new AttackItem("Hammer", 50, 40);
        private AttackItem warhammer = new AttackItem("War Hammer", 60, 50);
             //holds the array
        private AttackItem[] weapons = new AttackItem[6];
        private ArmorItem light = new ArmorItem("Light Armor", 10, 5);
        private ArmorItem medium = new ArmorItem("Medium Armor", 30, 30);
        private ArmorItem heavy = new ArmorItem("Heavy Armor", 100, 80);
             //holds the array
        private ArmorItem[] armors = new ArmorItem[3];
        private Potion small = new Potion("Small Potion", 20, 5);
        private Potion mid = new Potion("Medium Potion", 50, 30);
        private Potion all = new Potion("Heal To Max", 100, 50);
             //holds the array
        private Potion[] potions = new Potion[3];
        //keeps track item arrays
        public Inventory()
        {
            AttackItem[] weaponBag = { dagger, sword, bow, yo, hammer, warhammer };
            weapons = weaponBag;
            ArmorItem[] armorBag = { light, medium, heavy };
            armors = armorBag;
            Potion[] potionBag = { small, mid, all };
            potions = potionBag;
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
                Console.WriteLine("Gold: " + _gold);
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?");
                //shows the items they have at the moment
                Console.WriteLine("0: End Game");
                Console.WriteLine("1: Add Gold");
                Console.WriteLine("2: Buy Item");
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    Console.Write("How much gold? ");
                    Console.WriteLine("");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "2")
                {
                    BuyItem();
                }
            }
        }
        //show the amount of gold the player added
        public void AddGold(float amount)
        {
            Console.WriteLine("");
            Console.WriteLine("Got " + amount + " gold!");
            _gold += amount;
            Console.WriteLine("Gold: " + _gold);
            Console.WriteLine("");
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
                Console.WriteLine("1: " + dagger._name + " Damage:" + dagger.Damage + " Cost:" + dagger._cost);
                Console.WriteLine("2: " + sword._name + " Damage:" + sword.Damage + " Cost:" + sword._cost);
                Console.WriteLine("3: " + bow._name + " Damage:" + bow.Damage + " Cost:" + bow._cost);
                Console.WriteLine("4: " + yo._name + " Damage:" + yo.Damage + " Cost:" + yo._cost);
                Console.WriteLine("5: " + hammer._name + " Damage:" + hammer.Damage + " Cost:" + hammer._cost);
                Console.WriteLine("6: " + warhammer._name + " Damage:" + warhammer.Damage + " Cost:" + warhammer._cost);
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    _itemCost = weapons[0]._cost;
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
                    }
                }
                else if (choice == "2")
                {
                    _itemCost = weapons[1]._cost;
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
                    }
                }
                else if (choice == "3")
                {
                    _itemCost = weapons[2]._cost;
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
                    }
                    
                }
                else if (choice == "4")
                {
                    _itemCost = weapons[3]._cost;
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
                    }
                    
                }
                else if (choice == "5")
                {
                    _itemCost = weapons[4]._cost;
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
                    }
                    
                }
                else if (choice == "6")
                {
                    _itemCost = weapons[5]._cost;
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
                Console.WriteLine("1:" + light._name + " Defence:" + light.Defence + " Cost:" + light._cost);
                Console.WriteLine("2:" + medium._name + " Defence:" + medium.Defence + " Cost:" + medium._cost);
                Console.WriteLine("3:" + heavy._name + " Defence:" + heavy.Defence + " Cost:" + heavy._cost);
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    _itemCost = armors[0]._cost;
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
                    }
                    
                }
                else if (choice == "2")
                {
                    _itemCost = armors[1]._cost;
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
                    }
                    
                }
                else if (choice == "3")
                {
                    _itemCost = armors[2]._cost;
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
                Console.WriteLine("1:" + small._name + " Heals:" + small.Heal + " Cost:" + small._cost);
                Console.WriteLine("2:" + mid._name + " Heals:" + mid.Heal + " Cost:" + mid._cost);
                Console.WriteLine("3:" + all._name + " Heals:" + all.Heal + " Cost:" + all._cost);
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    _itemCost = potions[0]._cost;
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
                    }
                    
                }
                else if (choice == "2")
                {
                    _itemCost = potions[1]._cost;
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
                    }
                    
                }
                else if (choice == "3")
                {
                    _itemCost = potions[2]._cost;
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
                    }
                    
                }

            }
        }
    }
}
