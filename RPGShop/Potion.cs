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
        public Potion(string newName, int newHeal, int newCost)
        {
            _name = newName;
            _heal = newHeal;
            _cost = newCost;
        }
        public override void GetName(string newName)
        {
            _name = newName;
        }
        public override int GetCost(int newCost)
        {
            return _cost;
        }
    }
}
