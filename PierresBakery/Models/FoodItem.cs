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
      return 0;
    }
    public static void ClearAll()
    {
      _order.Clear();
    }

  }
}