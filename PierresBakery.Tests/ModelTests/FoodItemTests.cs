using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class FoodItemTests : IDisposable
  {
    public void Dispose()
    {
      FoodItem.ClearAll();
    }

    [TestMethod]
    public void FoodItemConstructor_CreateInstanceOfFoodItem_FoodItem()
    {
      FoodItem newFoodItem = new FoodItem(3);
      Assert.AreEqual(typeof(FoodItem), newFoodItem.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOfFoodItem_5()
    {
      FoodItem newFoodItem = new FoodItem(5);
      int price = newFoodItem.GetPrice();
      Assert.AreEqual(5, price);
    }
    [TestMethod]
    public void ApplyDiscount_ReturnPriceOfAllItemsWithDiscount_20()
    {
      FoodItem newFoodItem1 = new FoodItem(5);
      FoodItem newFoodItem2 = new FoodItem(5);
      FoodItem newFoodItem3 = new FoodItem(5);
      FoodItem newFoodItem4 = new FoodItem(5);
      FoodItem newFoodItem5 = new FoodItem(5);
      int total = FoodItem.ApplyDiscount(5, 5); // Should reduce total by 5 for every 5 items ordered
      Assert.AreEqual(20, total);
    }
  }
}