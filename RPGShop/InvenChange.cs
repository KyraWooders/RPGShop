using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGShop
{
    class InvenChange : Inventory
    {
        private object[] _inventory;
        public InvenChange()
        {
            _inventory = new object[0];
        }

    }
}
