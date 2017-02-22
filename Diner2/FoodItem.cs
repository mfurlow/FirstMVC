using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diner2
{
   public class FoodItem:IFoodItem
    {
        public FoodItem(string name, double price, Sizes portion)
        {
            Name = name;
            Price = price;
            Portion = portion;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public Sizes Portion { get; set; }
    }
}
