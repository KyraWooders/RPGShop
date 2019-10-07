using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShop
{
    class AttackItem : Item
    {
        int _damage = 0;
        //it returns to damage
        public int Damage
        {
            get
            {
                return _damage;
            }
        }
        //help to create a new attack item
        public AttackItem(string newName, int newDamage, int newCost, string newDescription)
        {
            _name = newName;
            _damage = newDamage;
            _cost = newCost;
            _description = newDescription;
        }
        
        public override void ItemPrint()
        {
            Console.WriteLine(_name + " Damage: " + _damage);
            Console.WriteLine(_description);
        }

        public override void Save(StreamWriter writer)
        {
            writer.WriteLine(_name);
            writer.WriteLine(Damage);
            writer.WriteLine(_cost);
            writer.WriteLine(_description);
        }
    }
}
