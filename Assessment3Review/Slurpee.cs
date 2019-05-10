using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3Review
{
    class Slurpee : Food
    {
        public override double getTotal()
        {
            Price = 2.99;
            return Price * Quantity;
        }

        public override double getTotalTax()
        {
            return getTotal() * 0.06;
        }
    }
}
