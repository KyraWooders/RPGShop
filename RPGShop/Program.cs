using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            //add a player
            Player player = new Player();

            //add a shop
            Shop inventory = new Shop(player);

            player.Load("Psave.txt");
            inventory.Load("Ssave.txt");

            //give a chance to access superuser
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();

            //to access superuser
            if (name == "Kyra")
            {
                inventory.SuperCode();
            }

            //start the main game
            inventory.Menu();

            //last message and saves when player exits
            Console.WriteLine("Okay then. Thank you for coming by. Bye-Bye~");
            player.Save("Psave.txt");
            inventory.Save("Ssave.txt");
            Console.ReadKey();
        }
    }
}
