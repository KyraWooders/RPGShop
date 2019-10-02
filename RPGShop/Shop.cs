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
        protected int _itemCost = 0;
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
        public Shop(Player player)
        {
            _player = player;
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
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?");
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
                    //shows how much gold they have at the moment
                    Console.WriteLine("Gold: " + _gold);

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
            int choice = -1;
            while (choice != 20)
            {
                //display menu
                Console.WriteLine("");
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("20: Go Back");
                Console.WriteLine("0: " + dagger._name + " Damage: 10" + " Cost:" + dagger._cost);
                Console.WriteLine("1: " + sword._name + " Damage: 20" + " Cost:" + sword._cost);
                Console.WriteLine("2: " + bow._name + " Damage: 30" + " Cost:" + bow._cost);
                Console.WriteLine("3: " + yo._name + " Damage: 40" + " Cost:" + yo._cost);
                Console.WriteLine("4: " + hammer._name + " Damage: 50" + " Cost:" + hammer._cost);
                Console.WriteLine("5: " + warhammer._name + " Damage: 60" + " Cost:" + warhammer._cost);
                //input
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                _itemCost = _inventory[choice]._cost;
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
                    _player.Add(_inventory[choice]);
                    Remove(choice);
                }
                //when you type in 20 it will break out of the while loop
                if (choice == 20)
                {
                    break;
                }

            }

        }
        //open menu to buy armor
        public void Armor()
        {
            int choice = -1;
            while (choice != 20)
            {
                //display menu
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("20: Go Back");
                Console.WriteLine("6:" + light._name + " Defence: 10" + " Cost:" + light._cost);
                Console.WriteLine("7:" + medium._name + " Defence: 30" + " Cost:" + medium._cost);
                Console.WriteLine("8:" + heavy._name + " Defence: 100" + " Cost:" + heavy._cost);
                //input
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                _itemCost = _inventory[choice]._cost;
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
                    _player.Add(_inventory[choice]);
                    Remove(choice);
                }
                //when you type in 20 it will break out of the while loop
                if (choice == 20)
                {
                    break;
                }
            }
        }
        //open menu to buy potion
        public void Potion()
        {
            int choice = -1;
            while (choice != 20)
            {
                //display menu
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("20: Go Back");
                Console.WriteLine("9:" + small._name + " Heals: 20" + " Cost:" + small._cost);
                Console.WriteLine("10:" + mid._name + " Heals: 50" + " Cost:" + mid._cost);
                Console.WriteLine("11:" + all._name + " Heals: 100" + " Cost:" + all._cost);
                //input
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                _itemCost = _inventory[choice]._cost;
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
                     _player.Add(_inventory[choice]);
                     Remove(choice);
                }
                //when you type in 20 it will break out of the while loop
                if (choice == 20)
                {
                    break;
                }
            }
        }
        //superuser access. can pick any item they want to be in the inventory for free
        public void SuperCode()
        {
            int choice = -1;
            while(choice != 20)
            {
                //display menu
                Console.WriteLine("What item(s) do you want?");
                Console.WriteLine("20: Go Back");
                Console.WriteLine("0: " + dagger._name + " Damage: 10" + " Cost:" + dagger._cost);
                Console.WriteLine("1: " + sword._name + " Damage: 20" + " Cost:" + sword._cost);
                Console.WriteLine("2: " + bow._name + " Damage: 30" + " Cost:" + bow._cost);
                Console.WriteLine("3: " + yo._name + " Damage: 40" + " Cost:" + yo._cost);
                Console.WriteLine("4: " + hammer._name + " Damage: 50" + " Cost:" + hammer._cost);
                Console.WriteLine("5: " + warhammer._name + " Damage: 60" + " Cost:" + warhammer._cost);
                Console.WriteLine("6:" + light._name + " Defence: 10" + " Cost:" + light._cost);
                Console.WriteLine("7:" + medium._name + " Defence: 30" + " Cost:" + medium._cost);
                Console.WriteLine("8:" + heavy._name + " Defence: 100" + " Cost:" + heavy._cost);
                Console.WriteLine("9:" + small._name + " Heals: 20" + " Cost:" + small._cost);
                Console.WriteLine("10:" + mid._name + " Heals: 50" + " Cost:" + mid._cost);
                Console.WriteLine("11:" + all._name + " Heals: 100" + " Cost:" + all._cost);
                //input
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                //when you type in 20 it will break out of the superuser
                if (choice == 20)
                {
                    break;
                }
                //add chosen item to player's inven
                _player.Add(_inventory[choice]);
                Console.WriteLine("You have " + _inventory[choice]._name + " in your inventory.");
                Console.WriteLine("");
            }
        }
    }
}
