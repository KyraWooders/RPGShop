using System;


namespace RPGShop
{
    class Inventory
    {
        protected Item[] _inventory;

        //makes an array
        public Inventory()
        {
            _inventory = new Item[0];
        }

        //add to array
        public virtual void Add(Item value)
        {
            Item[] newList = new Item[_inventory.Length + 1];
            for (int i = 0; i < _inventory.Length; i++)
            {
                newList[i] = _inventory[i];
            }
            newList[newList.Length - 1] = value;
            _inventory = newList;
        }

        //remove from the array
        public virtual void Remove(int index)
        {
            Item[] newList = new Item[_inventory.Length - 1];
            int newPosition = 0;
            for (int i = 0; i < _inventory.Length; i++)
            {
                if (i != index)
                {
                    newList[newPosition] = _inventory[i];
                    newPosition++;
                }
            }
            _inventory = newList;
        }
    }
}
