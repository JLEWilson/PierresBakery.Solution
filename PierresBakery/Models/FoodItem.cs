using System.Collections.Generic;
namespace Bakery.Models
{
  public class FoodItem
  {
    private int _price;
    private static List<FoodItem> _order = new List<FoodItem> {}; 
    public FoodItem(int price)
    {
      _price = price;
      _order.Add(this);
    }

    public int GetPrice()
    {
      return _price;
    }
    public static int ApplyDiscount(int itemsNeededForSale, int priceReduction)
    {
      int total = 0;
      foreach(FoodItem item in _order)
      {
        total += item._price;
      }
      for(int i=0; i<_order.Count; i+= itemsNeededForSale)
      {
        total -= priceReduction;
      }
      return total;
    }
    public static void ClearAll()
    {
      _order.Clear();
    }

  }
}