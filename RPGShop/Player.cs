using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShop
{
    class Player : Inventory
    {
        protected int _itemCost = 0;
        public float _gold = 0.00f;
        Inventory bookbag;
        //display player's inventory
        public void Print()
        {
            Console.WriteLine("You Have");
            //shows how much gold they have at the moment
            Console.WriteLine("Gold: " + _gold);
            //shows the items they have at the moment
            for (int i = 0; i < _inventory.Length; i++)
            {
                Console.WriteLine(_inventory[i]._name);
            }
        }
        
        //helps to check the input if it's valid
        public bool checkInput(string input, out int choice)
        {
            if (input == "")
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

        //to display the sell menu
        public void Selling()
        {
            int choice = -1;
            var input = "";
            while (choice != 20)
            {
                Console.WriteLine("What would you like to sell?");
                Console.WriteLine("20: Go Back");
                //Prints all the items 
                for (int i = 0; i < _inventory.Length; i++)
                {
                    Console.WriteLine(i + ": " + _inventory[i]._name + " Selling for " + _inventory[i]._cost + " Gold.");
                }
                //input
                input = Console.ReadLine();
                //check input
                if (!checkInput(input, out choice))
                {
                    continue;
                }

                Console.WriteLine();
                if (choice == 20)
                {
                    break;
                }
                if (choice >= _inventory.Length)
                {
                    Console.WriteLine("You have none.");
                    break;
                }
                else if (choice <= _inventory.Length)
                {
                    _itemCost = _inventory[0]._cost;
                    Console.WriteLine("You sole your " + _inventory[choice]._name + ".");
                    Remove(choice);
                    _gold += _itemCost;
                    Console.WriteLine("Gold: " + _gold);
                }
            }

        }

        //show the amount of gold the player added
        public void AddGold(float amount)
        {
            Console.WriteLine("");
            Console.WriteLine("Got " + amount + " gold!");
            //adds the amount you typed in
            _gold += amount;
            Console.WriteLine("Gold: " + _gold);
            Console.WriteLine("");
        }
        
        //the gold added process
        public void AddedGold()
        {
            Console.Write("How much gold?");
            Console.WriteLine("");
            float addedGold = Convert.ToSingle(Console.ReadLine());
            AddGold(addedGold);
        }

        //to save the player's inventory
        public void Save(string path)
        {
            //create a writer for the file at our path
            StreamWriter writer = File.CreateText(path);
            //write to it the same way we write to the console
            //save gold
            writer.WriteLine(_gold);
            writer.WriteLine(_inventory.Length);
            //print out the players item array length
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

        public void Load(string path)
        {
            if (File.Exists(path))
            {
                //create a reader for the file at our path
                StreamReader reader = File.OpenText(path);

                float gold = Convert.ToInt32(reader.ReadLine());
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
