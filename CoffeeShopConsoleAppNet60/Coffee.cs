using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public int Price { get; set; }
        public string Strength { get; set; }
        public int Discount { get; set; }

        public virtual int pricemethod() { return 20; }

        public abstract string strength();
        
    }
}
