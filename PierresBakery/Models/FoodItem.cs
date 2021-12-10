using System.Collections.Generic;
namespace Bakery.Models
{
  public class FoodItem
  {
    private int _price;
    private string _foodType;
    private static List<FoodItem> _order = new List<FoodItem> {}; 
    public FoodItem(int price, string foodType)
    {
      _price = price;
      _foodType = foodType;
      _order.Add(this);
    }

    public int GetPrice()
    {
      return _price;
    }
    public string GetFoodType()
    {
      return _foodType;
    }
    public static List<FoodItem> GetOrder()
    {
      return _order;
    }
    public static void SetOrder(List<FoodItem> adjustedOrder)
    {
      _order = adjustedOrder;
    }
    public static int ApplyDiscount(int itemsNeededForSale, int priceReduction)
    {
      int total = 0;
      foreach(FoodItem item in _order)
      {
        total += item._price;
      }
      for(int i = itemsNeededForSale ; i<=_order.Count; i+= itemsNeededForSale)
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