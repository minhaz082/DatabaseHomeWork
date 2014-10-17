using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Shop
    {
        public string Name { set; get; }
        public string Address { set; get; }

        public List<Item> Items { set; get; } 

        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
            Items = new List<Item>();
        }

        public string Add(Item aItem)
        {
            if (HasThisItem(aItem.Id))
            {
                UpdateItem(aItem);
            }
            Items.Add(aItem);
            return "Item added";                
        }

        private void UpdateItem(Item aItem)
        {
            foreach (var item in Items)
            {
                if (aItem.Id == item.Id)
                {
                    item.Quantity += aItem.Quantity;
                }
            }
        }

        public bool HasThisItem(string itemId)
        {
            foreach (var anItem in Items)
            {
                if (anItem.Id == itemId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
