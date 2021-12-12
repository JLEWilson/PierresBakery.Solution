using System.Collections.Generic;
namespace Bakery.Models
{
  public class FoodItem
  {
    public int Price {get; set;}
    public string FoodType {get; set;}
    public string ItemName {get; set;}
    public static int currentId {get; set;} = 0;
    public static List<FoodItem> Order {get; set;} = new List<FoodItem> {}; 
    public FoodItem(int price, string foodType, string itemName)
    {
      Price = price;
      FoodType = foodType;
      ItemName = itemName;
      Order.Add(this);
    }

    public static int CalculateTotal()
    {
      int total = 0;
      foreach(FoodItem item in Order)
      {
        total += item.Price;
      }
      return total;
    }

    public static void ApplyDiscountSpecific(int itemNumberForPriceChange, int newPrice, string itemName)
    {
      int count = 0;
      foreach(FoodItem item in Order)
      {
        if(item.ItemName == itemName)
        {
          count ++;
        }
        if(count == itemNumberForPriceChange)
        {
          item.Price = newPrice;
          count = 0;
        }
      }
    }
    public static void ClearAll()
    {
      Order.Clear();
    }
    public static void ResetId()
    {
      currentId = 0;
    }
  }
}