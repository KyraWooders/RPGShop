﻿using System;
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
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            //add a player
            Player player = new Player();
            Shop inventory = new Shop();
            //Shop inventory = new Shop(variable);
            inventory.Menu();


            Console.WriteLine("Okay then. Thank you for coming by. Bye-Bye~");
            Console.ReadKey();
        }
    }
}
