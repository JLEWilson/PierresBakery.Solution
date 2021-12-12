using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : FoodItem
  {
    public static string Type {get; set;} = "Bread";
    public string BreadType {get; set;}
    public Bread(int price, string itemName) : base(price, Type, itemName)
    {
      BreadType = itemName;
    }

    new public static int CalculateTotal()  //While we can't override static methods, we can hide them. The new keyword here will hide the parent objects CalculateTotal method and use this one instead.
    {
      int total = 0;
      List<FoodItem> breadOrder = FoodItem.Order.FindAll(item => item.FoodType == Type);
      foreach(FoodItem item in breadOrder)
      {
        total += item.Price;
      }
      return total;
    }
    new public static int ApplyDiscount(int itemsNeededForSale, int priceReduction) 
    {
      int total = Bread.CalculateTotal();
      List<FoodItem> breadOrder = FoodItem.Order.FindAll(item => item.FoodType == Type);
      for(int i = itemsNeededForSale; i <= breadOrder.Count; i += itemsNeededForSale)
      {
        total -= priceReduction;
      }
      return total;
    }
    public static void ClearBreadFromOrder()
    {
      Bread.Order.RemoveAll(item => item.FoodType == Type);
    }
    public static void RemoveBreadOfTypeFromOrder(string typeOfBread)
    {
      Bread.Order.RemoveAll(item => item.ItemName == typeOfBread);
    }
  }
}