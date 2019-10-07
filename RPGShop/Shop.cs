using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShop
{
    class Shop : Inventory
    {
        private Player _player;
        protected int _itemCost = 0;

        //create a butch of items
        private Item dagger = new AttackItem("Dagger", 10, 10, "A small dagger. That's it. Just a dagger.");
        private Item sword = new AttackItem("Sword", 20, 20, "A sword that can cut a sheet on paper with one light stroke.");
        private Item bow = new AttackItem("Bow", 30, 25, "A magic bow with infinite amount of arrows. The arrows don't have any magical abilites. They're just arrows.");
        private Item yo = new AttackItem("Metal Yo-Yo", 40, 15, "I know what you're thinking 'A metal yo-yo? How am I going to ues this?' Just use it like Smoky Quartz from Steven Universe.");
        private Item hammer = new AttackItem("Hammer", 50, 40, "A hammer that looks like cartoon hammer but the real thing.");
        private Item warhammer = new AttackItem("War Hammer", 60, 50, "A war hammer with a small skull of a deer on the end of the hand, and the hammer part of the war hammer is a huge steel skull of a ram.");
        private Item light = new ArmorItem("Light Armor", 10, 5, "The light armor is made out of leather.");
        private Item medium = new ArmorItem("Medium Armor", 30, 30, "The medium armor is made out of steel.");
        private Item heavy = new ArmorItem("Heavy Armor", 100, 80, "The heavy armor is made out of dead stars.");
        private Item small = new Potion("Small Potion", 20, 5, "The small potion have a green hue and smells like watermelon.");
        private Item mid = new Potion("Medium Potion", 50, 30, "The medium potion have a pink hue and tastes like Starbucks' boba tea.");
        private Item all = new Potion("Heal To Max", 100, 50, "The Heal To Max potion have a deep purple and feels like it wants to leave out of your hands.");

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
                Console.WriteLine("1: Inspect The Shop");
                Console.WriteLine("2: Sell Items");
                Console.WriteLine("3: Buy Item");
                Console.WriteLine("4: Add Gold");
                Console.WriteLine("5: See your Inventory");
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    for (int i = 0; i < _inventory.Length; i++)
                    {
                        _inventory[i].ItemPrint();
                        Console.WriteLine();
                    }
                }
                else if (choice == "2")
                {
                    _player.Selling();
                }
                else if (choice == "3")
                {
                    BuyItem();
                }
                else if (choice == "4")
                {
                    _player.AddedGold();
                }
                else if (choice == "5")
                {
                    _player.Print();

                }
            }
        }

        //helps to check the input if it's valid
        public bool checkInput(string input,out int choice)
        {
            if(input == "")
            {
                choice = -1;
                return false;
            }
            foreach (var value in input)
            {
                if (value < 48 || value > 57)
                {
                    choice = -1;
                    return false;
                }
            }
            choice = Convert.ToInt32(input);
            return true;
        }

        //open menu to buy items
        public void BuyItem()
        {
            int choice = -1;
            //Anything that is an object can be stored here
            var input = "";
            while (choice != 20)
            {
                
                //display menu
                Console.WriteLine("");
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("20: Go Back");
                for (int i = 0; i < _inventory.Length; i++)
                {
                    Console.WriteLine(i + ":" + _inventory[i]._name + " Cost: " + _inventory[i]._cost);
                }
                //input
                input = Console.ReadLine();
                //check input
                if(!checkInput(input,out choice))
                {
                    continue;
                }
                //try convert input to choice but if not forget the input
                Console.WriteLine();
                //when you type in 20 it will break out of the while loop
                if (choice == 20)
                {
                    break;
                }
                if (choice >= _inventory.Length)
                {
                    Console.WriteLine("Please try again.");
                }
                else if (choice <= _inventory.Length)
                {
                    _itemCost = _inventory[choice]._cost;
                    //check if the player have enough gold
                    if (_player._gold < _itemCost)
                    {
                        Console.WriteLine("You can't buy this item.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("You have brought " + _inventory[choice]._name + "!");
                        _player._gold -= _itemCost;
                        Console.WriteLine("Gold: " + _player._gold);
                        //move the shop item to the player's inventory
                        _player.Add(_inventory[choice]);
                        Remove(choice);
                    }
                }
                
                
            }
        }

        //superuser access. can pick any item they want to be in the inventory for free
        public void SuperCode()
        {
            int choice = -1;
            var input = "";
            while (choice != 20)
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
                Console.WriteLine("6: " + light._name + " Defence: 10" + " Cost:" + light._cost);
                Console.WriteLine("7: " + medium._name + " Defence: 30" + " Cost:" + medium._cost);
                Console.WriteLine("8: " + heavy._name + " Defence: 100" + " Cost:" + heavy._cost);
                Console.WriteLine("9: " + small._name + " Heals: 20" + " Cost:" + small._cost);
                Console.WriteLine("10: " + mid._name + " Heals: 50" + " Cost:" + mid._cost);
                Console.WriteLine("11: " + all._name + " Heals: 100" + " Cost:" + all._cost);
                //input
                input = Console.ReadLine();
                //check input
                if (!checkInput(input, out choice))
                {
                    continue;
                }
                Console.WriteLine();
                //when you type in 20 it will break out of the superuser
                if (choice == 20)
                {
                    break;
                }
                if (choice >= _inventory.Length)
                {
                    Console.WriteLine("Please try again.");
                }
                else if (choice <= _inventory.Length)
                {
                    //add chosen item to player's inven
                    _player.Add(_inventory[choice]);
                    Console.WriteLine("You have " + _inventory[choice]._name + " in your inventory.");
                    Console.WriteLine("");
                }
            }
        }

        //to save the player's inventory
        public void Save(string path)
        {
            //create a writer for the file at our path
            StreamWriter writer = File.CreateText(path);
            writer.WriteLine(_inventory.Length);
            //print out the shops item array length
            foreach (Item c in _inventory)
            {
                if (c is AttackItem)
                {
                    ((AttackItem)c).Save(writer);
                }
                else if (c is ArmorItem)
                {
                    ((ArmorItem)c).Save(writer);
                }
                else if (c is Potion)
                {
                    ((Potion)c).Save(writer);
                }
            }
            writer.Close();
        }
        public void Load (string path)
        {
            if (File.Exists(path))
            {
                //create a reader for the file at our path
                StreamReader reader = File.OpenText(path);

                int item = Convert.ToInt32(reader.ReadLine());
                Item[] loadedItems = new Item[item];
                for (int i = 0; i < item; i++)
                {
                    string name = reader.ReadLine();
                    int DamDefHp = Convert.ToInt32(reader.ReadLine());
                    int cost = Convert.ToInt32(reader.ReadLine());
                    string description = reader.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("No previous saves.");
            }
        }
    }
}
