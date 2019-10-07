using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShop
{
    class ArmorItem : Item
    {
        int _defence = 0;
        public int Defence
        {
            get
            {
                return _defence;
            }
        }
        //help to create a new armor item
        public ArmorItem(string newName, int newDefence, int newCost, string newDescription)
        {
            _name = newName;
            _defence = newDefence;
            _cost = newCost;
            _description = newDescription;
        }
        
        public override void ItemPrint()
        {
            Console.WriteLine(_name + " Defence: " + _defence);
            Console.WriteLine(_description);
        }

        public override void Save(StreamWriter writer)
        {
            writer.WriteLine(_name);
            writer.WriteLine(Defence);
            writer.WriteLine(_cost);
            writer.WriteLine(_description);
        }
    }
}
