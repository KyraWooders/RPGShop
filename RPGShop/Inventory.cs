using System;
using System.IO;

namespace RPGShop
{
    class Inventory
    {
        protected float _gold = 0.00f;
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
        public float GetGold()
        {
            return _gold;
        }
        protected Item[] _inventory;
        public Inventory()
        {
            _inventory = new Item[0];
        }
        //add to array
        public virtual void Add(Item value)
        {
            Item[] newList = new Item[_inventory.Length + 1];
            for (int i = 0; i < _inventory.Length; i++)
            {
                newList[i] = _inventory[i];
            }
            newList[newList.Length - 1] = value;
            _inventory = newList;
        }
        //remove from the array
        public virtual void Remove(int index)
        {
            Item[] newList = new Item[_inventory.Length - 1];
            int newPosition = 0;
            for (int i = 0; i < _inventory.Length; i++)
            {
                if (i != index)
                {
                    newList[newPosition] = _inventory[i];
                    newPosition++;
                }
            }
            _inventory = newList;
        }


        public virtual void AddedGold()
        {
            Console.Write("How much gold?");
            Console.WriteLine("");
            float addedGold = Convert.ToSingle(Console.ReadLine());
            AddGold(addedGold);
        }
        

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
