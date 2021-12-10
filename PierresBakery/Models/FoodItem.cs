using System.Collections.Generic;
namespace Bakery.Models
{
  public class FoodItem
  {
    public int Price {get; set;}
    public string FoodType {get; set;}
    public static List<FoodItem> Order {get; set;} = new List<FoodItem> {}; 
    public FoodItem(int price, string foodType)
    {
      Price = price;
      FoodType = foodType;
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
    public static int ApplyDiscount(int itemsNeededForSale, int priceReduction)
    {
      int total = FoodItem.CalculateTotal();
      for(int i = itemsNeededForSale ; i<=Order.Count; i+= itemsNeededForSale)
      {
        total -= priceReduction;
      }
      return total;
    }
    
    public static void ClearAll()
    {
      Order.Clear();
    }

  }
}