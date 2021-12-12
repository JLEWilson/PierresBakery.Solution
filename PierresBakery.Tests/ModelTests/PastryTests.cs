using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearPastryFromOrder();
    }
    [TestMethod]
    public void ClearPastryFromOrder_ClearPastryItemsAndRemoveThemFromFoodItemOrder_2()
    {
      //add 4 items to FoodItem order
      Bread newBread1 = new Bread(5, "Brioche");
      Bread newBread2 = new Bread(5, "Brioche");
      Pastry newPastry1 = new Pastry(3, "Macaron");
      Pastry newPastry2 = new Pastry(3, "Macaron");
      //remove Pastry from both the FoodItem order and Pastry order
      Pastry.ClearPastryFromOrder();
      //get remaining count of foodItem _order
      int itemCount = FoodItem.Order.Count;
      Assert.AreEqual(2, itemCount);
    }
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3, "Macaron");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}
