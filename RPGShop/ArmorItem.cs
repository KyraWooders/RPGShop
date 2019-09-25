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
        public ArmorItem(string newName, int newDefence, int newCost)
        {
            _name = newName;
            _defence = newDefence;
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
