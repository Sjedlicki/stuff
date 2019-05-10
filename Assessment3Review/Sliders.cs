using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3Review
{
    class Sliders : Food
    {
        public override double getTotal()
        {
            Quantity = 3;
            Price = 1.95;
            return Quantity * Price;
        }

        public override double getTotalTax()
        {
            return getTotal() * 0.06;
        }
    }
}
