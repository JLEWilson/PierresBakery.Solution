using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : FoodItem
  {
    private static List<Bread> _breadOrder = new List<Bread> {};
    public Bread(int price) : base(price)
    {
      _breadOrder.Add(this);
    }

    new public static int ApplyDiscount(int itemsNeededForSale, int priceReduction) //While we can't override static methods, we can hide them. The new keyword here will hide the parent objects ApplyDiscount method and use this one instead.
    {
      int total = 0;
      foreach(Bread item in _breadOrder)
      {
        total += item.GetPrice();
      }
      for(int i = itemsNeededForSale; i <= _breadOrder.Count; i += itemsNeededForSale)
      {
        total -= priceReduction;
      }
      return total;
    }
    
    public static void ClearBreadFromOrder()
    {
      _breadOrder.Clear();
    }
  }
}