using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread : FoodItem
  {
    private static List<Bread> _breadOrder = new List<Bread> {};
    private int _breadOrderTotalPrice;
    public Bread(int price) : base(price)
    {
      _breadOrder.Add(this);
      _breadOrderTotalPrice += this.GetPrice();
    }

    public static int ApplyDiscount(int itemsNeededForSale, int priceReduction) //This is separate from FoodItem.ApplyDiscount because bread objects don't inherit the static fields or methods
    {
      return 0;
    }
  }
}