﻿namespace Diner2
{
    public interface IFoodItem
    {
         string Name { get; set; }
         double Price { get; set; }
         Sizes Portion { get; set; }
    }
}