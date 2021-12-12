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
      FoodItem newFoodItem = new FoodItem(3, "Generic", "Generic");
      Assert.AreEqual(typeof(FoodItem), newFoodItem.GetType());
    }
    [TestMethod]
    public void CalculateTotal_ReturnPriceOfAllFoodItems_15()
    {
      FoodItem newFoodItem = new FoodItem(5, "Generic", "Generic");
      FoodItem newFoodItem1 = new FoodItem(5, "Generic", "Generic");
      FoodItem newFoodItem2 = new FoodItem(5, "Generic", "Generic");
      int total = FoodItem.CalculateTotal();
      Assert.AreEqual(15, total);
    }
    [TestMethod]
    public void ApplyDiscountSpecific_SetPriceOfEveryXItemWithNameToY_0()
    {
      Croissant item1 = new Croissant();
      Croissant item2 = new Croissant();
      Croissant item3 = new Croissant();
      Croissant item4 = new Croissant();
      Croissant item5 = new Croissant();
      Croissant item6 = new Croissant();
      
      FoodItem.ApplyDiscountSpecific(3, 0, Croissant.Name); //should set every third items price to 0
      int discountedItemPrice = FoodItem.Order[2].Price;
      Assert.AreEqual(0, discountedItemPrice);
    }
  }
}