using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearBreadFromOrder();
    }
    [TestMethod]
    public void ClearBreadFromOrder_ClearBreadItemsAndRemoveThemFromFoodItemOrder_2()
    {
      //add 4 items to FoodItem order
      FoodItem newFoodItem1 = new FoodItem(5, "Generic", "Brioche");
      FoodItem newFoodItem2 = new FoodItem(5, "Generic", "Brioche");
      Bread newBread1 = new Bread(5, "Brioche");
      Bread newBread2 = new Bread(5, "Brioche");
      //remove bread from both the FoodItem order and bread order
      Bread.ClearBreadFromOrder();
      //get remaining count of foodItem _order
      int itemCount = FoodItem.Order.Count;
      Assert.AreEqual(2, itemCount);
    }
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3, "Brioche");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BreadConstructor_InheritPricePropertyAndGetMethodFromBread_3()
    {
      Bread newBread = new Bread(3, "Brioche");
      int price = newBread.Price;
      Assert.AreEqual(3, price);
    }
  }
}