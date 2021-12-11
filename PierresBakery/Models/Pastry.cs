using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Pastry : FoodItem
  {
    private static string _type = "Pastry";
    public string PastryType {get; set;}
    private static List<Pastry> _pastryOrder = new List<Pastry> {};
    public Pastry(int price) : base(price, _type)
    {
      _pastryOrder.Add(this);
    }
    new public static int CalculateTotal()  //While we can't override static methods, we can hide them. The new keyword here will hide the parent objects CalculateTotal method and use this one instead.
    {
      int total = 0;
      foreach(Pastry item in _pastryOrder)
      {
        total += item.Price;
      }
      return total;
    }
    new public static int ApplyDiscount(int itemsNeededForSale, int priceReduction)
    {
      int total = Pastry.CalculateTotal();
      for(int i = itemsNeededForSale; i <= _pastryOrder.Count; i += itemsNeededForSale)
      {
        total -= priceReduction;
      }
      return total;
    }
    public static void ClearPastryFromOrder()
    {
      _pastryOrder.Clear();
      List <FoodItem> orderList = Pastry.Order;
      orderList.RemoveAll(item => item.FoodType == _type);
      Pastry.Order = orderList;
    }
  }
}