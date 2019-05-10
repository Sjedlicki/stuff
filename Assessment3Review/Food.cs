using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3Review
{
    abstract class Food
    {
        private string orderName;
        private double price;
        private int quantity;

        public string OrderName
        {
            get { return orderName; }
            set { orderName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Food()
        {
            orderName = "Grant Chripus";
            price = .99;
            quantity = 1;
        }

        public abstract double getTotal();
        public abstract double getTotalTax();
 
    }
}
