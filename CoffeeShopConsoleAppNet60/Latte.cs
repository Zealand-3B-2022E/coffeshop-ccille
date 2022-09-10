using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public int mlMilk(int mlMilk)
        {
            return 200;
        }

        public override int pricemethod()
        {
            return 40 - base.Discount;
        }

        public override string strength()
        {
            return "Weak";
        }

        public Latte(int discount) :base(discount)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string CoffeeType()
        {
            return "Latte";
        }
    }
}
