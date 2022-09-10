using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount) :base(discount)
        {
        }

        public BlackCoffee() :base()
        {
        }

        public override string CoffeeType()
        {
            return "BlackCoffee";
        }

        public override string strength()
        {
            return "string";
        }
    }
}
