using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShop
{
    class Player
    {
        private Inventory inventory = new Inventory();
        private float _gold = 0.00f;
        private string _name = "";

        public void PlayerInventory()
        {
            Console.WriteLine("You have");
            
            Console.WriteLine("Gold: " + _gold);
        }
    }
}
