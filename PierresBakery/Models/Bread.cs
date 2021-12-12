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
    public static void ClearBreadFromOrder()
    {
      Bread.Order.RemoveAll(item => item.FoodType == Type);
    }
  }
}