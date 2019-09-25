using System;
using System.IO;

namespace RPGShop
{
    class Inventory
    {
        private Player player = new Player();
        private Shop shop = new Shop();
        private int _itemCost = 0;
        private float _gold = 0.00f;
        
        //the opening menu
        public void Menu()
        {
            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("Welcome to the Shop.");
                //shows how much gold they have at the moment
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?");
                //shows the items they have at the moment
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
                    Console.Write("How much gold? ");
                    Console.WriteLine("");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "3")
                {
                    player.PlayerInventory();
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
                    shop.Weapon();
                }
                else if (choice == "2")
                {
                    shop.Armor();
                }
                else if (choice == "3")
                {
                    shop.Potion();
                }

            }
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
