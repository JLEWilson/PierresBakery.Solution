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
  }
}