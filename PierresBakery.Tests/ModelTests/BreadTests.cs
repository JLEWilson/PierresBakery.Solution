using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearBreadFromOrder();
      Bread.ClearAll();
    }

    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_InheritPricePropertyAndGetMethodFromBread_3()
    {
      Bread newBread = new Bread(3);
      int price = newBread.GetPrice();
      Assert.AreEqual(3, price);
    }

    [TestMethod]
    public void ApplyDiscount_ReturnPriceOfAllItemsWithDiscount_20()    
    {
      Bread newBread1 = new Bread(5);
      Bread newBread2 = new Bread(5);
      Bread newBread3 = new Bread(5);
      Bread newBread4 = new Bread(5);
      Bread newBread5 = new Bread(5);
      int total = Bread.ApplyDiscount(3, 5); // Should reduce total by 5 for every 3 items ordered
      Assert.AreEqual(20, total);
    }
  }
}