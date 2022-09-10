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
        public int Discount { get; private set; }

        public Coffee(int discount) 
        {
            if (discount > 5)
            {
                throw new ArgumentException("You can not get more than 5 kr in discount");
            }

            this.Discount = discount;

        }

        //Default
        public Coffee() : this(0)
        {
        }

        public virtual int pricemethod() { return 20 - Discount; }

        public abstract string strength();

        public abstract string CoffeeType();

        public override string ToString()
        {
            return $"I´m a {this.CoffeeType()} and my Price is {this.pricemethod()} and my strength is {this.strength()}";
        }

    }
}
