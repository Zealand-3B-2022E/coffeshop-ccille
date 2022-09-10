using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class FlatWhite : Coffee
    {

        public FlatWhite() :base()
        {
        }

        public FlatWhite(int discount) : base(discount)
        {
        }

        public override string CoffeeType()
        {
            return "FlatWhite";
        }

        public override string strength()
        {
            return "weak";
        }

        public override int pricemethod()
        {
            return 15 - base.Discount;
        }
    }
}
