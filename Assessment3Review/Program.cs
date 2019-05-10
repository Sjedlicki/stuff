using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Sliders slider = new Sliders();


            Console.WriteLine(FoodCreator.describeOrder(slider));
 
        }
    }
}
