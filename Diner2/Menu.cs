using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diner2
{
   public class Menu:IMenu
    {
        public List<IFoodItem> _menulist;
        public Menu()
        {

        }
        public Menu(List<IFoodItem> food)
        {
            foodItemList = food;
        }

        public List<IFoodItem> FoodItemList
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<IFoodItem> foodItemList
        {
            get
            {
                if (_menulist == null)
                {
                    _menulist = new List<IFoodItem>(new[]
            {
            new FoodItem("Fire Ranch Mushroom Burger",10.1,Sizes.small),
            new FoodItem("Pork Ribs",25.2,Sizes.large),
            new FoodItem("Lamb",40.5,Sizes.xlarge) });
                }
                return _menulist;
            }
            set {
                _menulist = value; } }

        public List<IFoodItem> GetMenu()
        {
            return foodItemList;
        }
    }
}
