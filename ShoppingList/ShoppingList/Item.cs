using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    public class Item
    {
        private string name;
        private string store;
        private decimal price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Store
        {
            get { return store; }
            set { store = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Item(string name, string store, decimal price)
        {
            Name = name;
            Store = store;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0,-15} {1,-10} {2,10:C}", Name, Store, Price);
        }
    }
}
