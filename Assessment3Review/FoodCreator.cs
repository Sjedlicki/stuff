using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3Review
{
    class FoodCreator
    {
        public static Food buildOrder(string input)
        {
            if(input == "slurpee")
            {
                Slurpee slurpee = new Slurpee();
                return slurpee;
            }
            else
            {
                Sliders sliders = new Sliders();
                return sliders;
            }
        }

        public static string describeOrder(Food food)
        {            
            return $"Order Name: {food.OrderName}, Order Subtotal: {food.getTotal()}, Order Total w/Tax: {food.getTotalTax() + food.getTotal()}";
        }
    }
}
