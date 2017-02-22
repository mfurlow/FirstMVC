using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diner2
{
   public interface IMenu
    {
        List<IFoodItem> FoodItemList { get; set; }
        List<IFoodItem> GetMenu();
    }
}
