using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Sabirzyanova.Classes
{
    public class Shop
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Shop(string name, int Price)
        {
            this.Name = name;
            this.Price = Price;
        }
    }
}
