using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShop
{
    class Potion : Item
    {
        private int _heal;
        public int Heal
        {
            get
            {
                return _heal;
            }
        }
        //help to create a new potion item
        public Potion(string newName, int newHeal, int newCost, string newDescription)
        {
            _name = newName;
            _heal = newHeal;
            _cost = newCost;
            _description = newDescription;
        }
        public override void ItemPrint()
        {
            Console.WriteLine(_name + " Heals: " + _heal + "HP");
            Console.WriteLine(_description);
        }

        public override void Save(StreamWriter writer)
        {
            writer.WriteLine(_name);
            writer.WriteLine(Heal);
            writer.WriteLine(_cost);
            writer.WriteLine(_description);
        }
    }
}
