using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class ArmorItem : Item
    {
        private int _defence;
        //help to create a new attack item
        public ArmorItem(string newName, int newDefence, int newCost)
        {
            _name = newName;
            _defence = newDefence;
            _cost = newCost;
        }
    }
}
