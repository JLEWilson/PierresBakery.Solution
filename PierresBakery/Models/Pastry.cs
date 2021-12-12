using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Pastry : FoodItem
  {
    public static string Type {get;set;} = "Pastry";
    public string PastryType {get; set;}
    public Pastry(int price) : base(price, Type)
    {

    }
    new public static int CalculateTotal()  //While we can't override static methods, we can hide them. The new keyword here will hide the parent objects CalculateTotal method and use this one instead.
    {
      int total = 0;
      List<FoodItem> pastryOrder = FoodItem.Order.FindAll(item => item.FoodType == Type);
      foreach(Pastry item in pastryOrder)
      {
        total += item.Price;
      }
      return total;
    }
    new public static int ApplyDiscount(int itemsNeededForSale, int priceReduction)
    {
      int total = Pastry.CalculateTotal();
      List<FoodItem> pastryOrder = FoodItem.Order.FindAll(item => item.FoodType == Type);
      for(int i = itemsNeededForSale; i <= pastryOrder.Count; i += itemsNeededForSale)
      {
        total -= priceReduction;
      }
      return total;
    }
    public static void ClearPastryFromOrder()
    {
      List <FoodItem> orderList = Pastry.Order;
      orderList.RemoveAll(item => item.FoodType == Type);
    }
  }
}