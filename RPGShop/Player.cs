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
        protected string _name = "";
        public Player()
        {

        }

        public void Print()
        {
            string choice = "";
            int choice2 = 0;
            Console.WriteLine("You Have");
            //shows how much gold they have at the moment
            Console.WriteLine("Gold: " + _gold);
            //shows the items they have at the moment
            for (int i = 0; i < _inventory.Length; i++)
            {
                Console.WriteLine(_inventory[i]._name);
            }
            while (choice != "No")
            {
                Console.WriteLine("Would you like to sell your items?");
                Console.WriteLine("Yes");
                Console.WriteLine("No");
                choice = Console.ReadLine();
                Console.WriteLine();
                choice = choice.ToUpper();
                if (choice == "Yes")
                {
                    Console.WriteLine("What would you like to sell");
                    for (int i = 0; i < _inventory.Length; i++)
                    {
                        Console.WriteLine(i + ": " + _inventory[i]._name + " Selling for " + _inventory[i]._cost + " Gold.");
                    }
                    Int32.TryParse(Console.ReadLine(), out choice2);
                    Console.WriteLine();
                    Console.WriteLine("You sole your " + _inventory[choice2]._name + ".");
                    Sell(choice2);
                    Console.WriteLine("Gold: " + _gold);
                }
            }
        }
        public void Sell(int index)
        {
            _itemCost = _inventory[0]._cost;
            for (int i = 0; i < _inventory.Length; i++)
            {
                Remove(i);
                _gold += _itemCost;

            }
        }
    }
}
