using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopInventorySystem
{
    internal class shopItem
    {
        private int itemId;
        private string itemname;
        private int quantity;

        public int ItemID 
        { 
            get { return itemId; }
            set { itemId = value; } 
        }

        public string ItemName
        {
            get { return itemname; }
            set { itemname = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public shopItem(int itemId, string itemname, int quantity)
        {
            this.itemId = itemId;
            this.itemname = itemname;
            this.quantity = quantity;
        }
    }
}
