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
  }
}