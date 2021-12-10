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
      Bread.ClearAll();
    }

    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_InheritPricePropertyAndGetMethodFromFoodItem_3()
    {
      Bread newBread = new Bread(3);
      int price = newBread.GetPrice();
      Assert.AreEqual(3, price);
    }
  }
}