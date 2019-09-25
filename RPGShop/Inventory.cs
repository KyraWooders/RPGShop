using System;
using System.IO;

namespace RPGShop
{
    class Inventory
    {
        
        
       
        private int _itemCost = 0;
        private float _gold = 0.00f;
        
        
        
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
        

        private Item[] _inventory;
        public Inventory()
        {
            _inventory = new Item[0];
        }

        public virtual void Add(Item value)
        {
            Item[] newList = new Item[_inventory.Length + 1];
            for (int i = 0; i < _inventory.Length; i++)
            {
                newList[i] = _inventory[i];
            }
            newList[newList.Length - 1] = value;
        }

        public void PlayerInventory()
        {
            Console.WriteLine("You have");
            Console.WriteLine("Gold: " + _gold);
        }
        //private Item[] items = new Item[12];

        //to save the player's inventory
        //public void Save(string path)
        //{
        //    //create a writer for the file at our path
        //    StreamWriter writer = File.CreateText(path);
        //    //write to it the same way we write to the console
        //    writer.WriteLine(_gold);
        //    foreach (AttackItem c in weapons)
        //    {

        //    }
        //}
    }
}
