using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class AttackItem : Item
    {
        private int _damage;
        //it returns to damage
        public int Damage
        {
            get
            {
                return _damage;
            }
        }
        //help to create a new attack item
        public AttackItem(string newName, int newDamage, int newCost)
        {
            _name = newName;
            _damage = newDamage;
            _cost = newCost;
        }
    }
}
