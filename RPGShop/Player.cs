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
        Item[] item = new Item[0];
        protected string _name = "";
        public Player() 
        {
            
        }
        
        public void Print()
        {
            Console.WriteLine("You Have");
            
            for (int i = 0; i < _inventory.Length; i++)
            {
                Console.WriteLine(_inventory[i]._name);
            }
        }
       
    }
}
