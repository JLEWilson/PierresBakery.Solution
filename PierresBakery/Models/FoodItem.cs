using System.Collections.Generic;
namespace Bakery.Models
{
  public class FoodItem
  {
    public int Price {get; set;}
    public string FoodType {get; set;}
    public static int currentId {get; set;} = 0;
    public int Id;
    public static List<FoodItem> Order {get; set;} = new List<FoodItem> {}; 
    public FoodItem(int price, string foodType)
    {
      Price = price;
      FoodType = foodType;
      Id = AssignId();
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
    private int AssignId()
    {
      return 0;
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