using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class Item
    {
        public string _name;
        public int _cost;
        public virtual void GetName(string newName)
        {
            
        }
        public virtual int GetCost(int newCost)
        {
            return _cost;
        }
    }
}
