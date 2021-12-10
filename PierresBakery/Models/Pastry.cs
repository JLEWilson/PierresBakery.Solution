using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Pastry : FoodItem
  {
    private static string _type = "Pastry";
    private static List<Pastry> _pastryOrder = new List<Pastry> {};
    public Pastry(int price) : base(price, _type)
    {
      _pastryOrder.Add(this);
    }
    new public static int CalculateTotal()  //While we can't override static methods, we can hide them. The new keyword here will hide the parent objects CalculateTotal method and use this one instead.
    {
      int total = 0;
      
      return total;
    }
  }
}