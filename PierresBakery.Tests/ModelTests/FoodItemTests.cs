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
      FoodItem newFoodItem = new FoodItem(3, "Generic");
      Assert.AreEqual(typeof(FoodItem), newFoodItem.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOfFoodItem_5()
    {
      FoodItem newFoodItem = new FoodItem(5, "Generic");
      int price = newFoodItem.Price;
      Assert.AreEqual(5, price);
    }
    [TestMethod]
    public void CalculateTotal_ReturnPriceOfAllFoodItems_15()
    {
      FoodItem newFoodItem = new FoodItem(5, "Generic");
      FoodItem newFoodItem1 = new FoodItem(5, "Generic");
      FoodItem newFoodItem2 = new FoodItem(5, "Generic");
      int total = FoodItem.CalculateTotal();
      Assert.AreEqual(15, total);
    }
    [TestMethod]
    public void ApplyDiscount_ReturnPriceOfAllItemsWithDiscount_20()
    {
      FoodItem newFoodItem1 = new FoodItem(5, "Generic");
      FoodItem newFoodItem2 = new FoodItem(5, "Generic");
      FoodItem newFoodItem3 = new FoodItem(5, "Generic");
      FoodItem newFoodItem4 = new FoodItem(5, "Generic");
      FoodItem newFoodItem5 = new FoodItem(5, "Generic");
      int total = FoodItem.ApplyDiscount(5, 5); // Should reduce total by 5 for every 5 items ordered
      Assert.AreEqual(20, total);
    }
    [TestMethod]
    public void AssignId_ReturnUniqueIdForEachFoodItem_Int()
    {
      //method is private, runs in the constructor
      FoodItem newFoodItem1 = new FoodItem(5, "Generic");
      FoodItem newFoodItem2 = new FoodItem(5, "Generic");
      FoodItem newFoodItem3 = new FoodItem(5, "Generic");
      Assert.AreEqual(0, newFoodItem1.Id);
      Assert.AreEqual(1, newFoodItem1.Id);
      Assert.AreEqual(2, newFoodItem1.Id);
    }
  }
}