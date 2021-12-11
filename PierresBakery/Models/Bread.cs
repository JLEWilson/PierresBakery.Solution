using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : FoodItem
  {
    public static string Type {get; set;} = "Bread";
    public string BreadType {get; set;}
    public static List<Bread> BreadOrder {get; set;} = new List<Bread> {};
    public Bread(int price) : base(price, Type)
    {
      BreadOrder.Add(this);
    }

    new public static int CalculateTotal()  //While we can't override static methods, we can hide them. The new keyword here will hide the parent objects CalculateTotal method and use this one instead.
    {
      int total = 0;
      foreach(Bread item in BreadOrder)
      {
        total += item.Price;
      }
      return total;
    }
    new public static int ApplyDiscount(int itemsNeededForSale, int priceReduction) 
    {
      int total = Bread.CalculateTotal();
      
      for(int i = itemsNeededForSale; i <= BreadOrder.Count; i += itemsNeededForSale)
      {
        total -= priceReduction;
      }
      return total;
    }
    
    public static void ClearBreadFromOrder()
    {
      BreadOrder.Clear();
      List <FoodItem> orderList = Bread.Order;
      orderList.RemoveAll(item => item.FoodType == Type);
      Bread.Order = orderList;
    }
  }
}