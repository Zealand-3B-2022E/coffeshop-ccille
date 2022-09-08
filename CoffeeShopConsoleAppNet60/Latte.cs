using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class Latte : Coffee
    {
        public override int pricemethod()
        {
            return 40;
        }

        public override string strength()
        {
            return "Weak";
        }
    }
}
