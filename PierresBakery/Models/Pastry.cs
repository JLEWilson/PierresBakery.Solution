using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Pastry : FoodItem
  {
    public static string Type {get;set;} = "Pastry";
    public string PastryType {get; set;}
    public Pastry(int price, string itemName) : base(price, Type, itemName)
    {
      PastryType = itemName;
    }
    public static void ClearPastryFromOrder()
    {
      Pastry.Order.RemoveAll(item => item.FoodType == Type);
    }
  }
}