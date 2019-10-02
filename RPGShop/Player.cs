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
            Console.WriteLine("You Have");
            //shows the items they have at the moment
            for (int i = 0; i < _inventory.Length; i++)
            {
                Console.WriteLine(_inventory[i]._name);
            }
            while (choice != "0")
            {
                Console.WriteLine("Would you like to sell your items?");
                Console.WriteLine("0: No");
                Console.WriteLine("1: Yes");
                choice = Console.ReadLine();
                Console.WriteLine();
                if (choice == "1")
                {
                    Console.WriteLine("What would you like to sell");
                    
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
