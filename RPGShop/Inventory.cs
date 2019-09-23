using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Inventory
    {
        private float _gold = 0.00f;
        //create a butch of items
        private AttackItem dagger = new AttackItem("Dagger", 10, 10);
        private AttackItem sword = new AttackItem("Sword", 20, 20);
        private AttackItem bow = new AttackItem("Bow", 30, 25);
        private AttackItem yo = new AttackItem("Metal Yo-Yo", 40, 15);
        private AttackItem hammer = new AttackItem("Hammer", 50, 40);
        private AttackItem warhammer = new AttackItem("War Hammer", 60, 50);

        private ArmorItem light = new ArmorItem("Light Armor", 10, 5);
        private ArmorItem medium = new ArmorItem("Medium Armor", 30, 30);
        private ArmorItem heavy = new ArmorItem("Heavy Armor", 100, 80);

        private Potion small = new Potion("Small Potion", 20, 5);
        private Potion mid = new Potion("Medium Armor", 50, 30);
        private Potion all = new Potion("Heal To Max", 100, 50);

        //the opening menu
        public void Menu()
        {
            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("Welcome to the Shop. What would you like to do?");
                //shows how much gold they have at the moment
                Console.WriteLine("Gold: " + _gold);
                //shows the items they have at the moment
                Console.WriteLine("Items:" );
                Console.WriteLine("0: End Game");
                Console.WriteLine("1: Add Gold");
                Console.WriteLine("2: Buy Item");
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    Console.Write("How much gold? ");
                    Console.WriteLine("");
                    float addedGold = Convert.ToSingle(Console.ReadLine());
                    AddGold(addedGold);
                }
                else if (choice == "2")
                {
                    BuyItem();
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
            
            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("0: Go Back");
                Console.WriteLine("1: Dagger Damage:" + dagger.Damage + " Cost:" + dagger._cost);
                Console.WriteLine("2: Sword Damage:" + sword.Damage + " Cost:" + sword._cost);
                Console.WriteLine("3: Bow Damage:" + bow.Damage + " Cost:" + bow._cost);
                Console.WriteLine("4: Metal Yo-Yo Damage:" + yo.Damage + " Cost:" + yo._cost);
                Console.WriteLine("5: Hammer Damage:" + hammer.Damage + " Cost:" + hammer._cost);
                Console.WriteLine("6: War Hammer Damage:" + warhammer.Damage + " Cost:" + warhammer._cost);
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    Console.WriteLine("You have equiped Dagger!");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You have equiped Sword!");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You have equiped Bow!");
                }
                else if (choice == "4")
                {
                    Console.WriteLine("You have equiped Metal Yo-Yo!");
                }
                else if (choice == "5")
                {
                    Console.WriteLine("You have equiped Hammer!");
                }
                else if (choice == "6")
                {
                    Console.WriteLine("You have equiped War Hammer!");
                }

            }

        }


        //open menu to buy armor
        public void Armor()
        {
            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("0: Go Back");
                Console.WriteLine("1:" + light._name + " Defence:" + light.Defence + " Cost:" + light._cost);
                Console.WriteLine("2:" + medium._name + " Defence:" + medium.Defence + " Cost:" + medium._cost);
                Console.WriteLine("3:" + heavy._name + " Defence:" + heavy.Defence + " Cost:" + heavy._cost);
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    Console.WriteLine("You have equiped !");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You have equiped !");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You have equiped !");
                }

            }
        }
        //open menu to buy potion
        public void Potion()
        {
            string choice = "";
            while (choice != "0")
            {
                //display menu
                Console.WriteLine("What weapon would you like to buy?");
                Console.WriteLine("0: Go Back");
                Console.WriteLine("1:" + small._name + " Heals:" + small.Heal + " Cost:" + small._cost);
                Console.WriteLine("2:" + mid._name + " Heals:" + mid.Heal + " Cost:" + mid._cost);
                Console.WriteLine("3:" + all._name + " Heals:" + all.Heal + " Cost:" + all._cost);
                //input
                choice = Console.ReadLine();
                Console.WriteLine();
                //check input
                if (choice == "1")
                {
                    Console.WriteLine("You have equiped " + small._name + "!");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You have equiped " + mid._name + "!");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You have equiped " + all._name + "!");
                }

            }
        }

    }
}
