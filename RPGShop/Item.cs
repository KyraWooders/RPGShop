using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RPGShop
{
    class Item
    {
        public string _name;
        public int _cost;
        public string _description;
        
        public virtual void ItemPrint()
        {

        }

        public virtual void Save(StreamWriter writer)
        {

        }

    }
}
