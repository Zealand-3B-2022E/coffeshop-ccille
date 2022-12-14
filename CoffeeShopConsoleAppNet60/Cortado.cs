using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {

        public Cortado(int discount) :base(discount)
        {
        }

        public Cortado() :base()
        {
        }
    
        public override string CoffeeType()
        {
            return "Cortado";
        }

        public int mlMilk(int mlMilk)
        {
            return 40;
        }

        public override int pricemethod()
        {
            return 25 - base.Discount;
        }

        public override string strength()
        {
            return "Medium";
        }
    }
}
