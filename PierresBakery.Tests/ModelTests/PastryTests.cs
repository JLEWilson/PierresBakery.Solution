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
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void CalculateTotal_ReturnPriceOfAllPastrys_15()
    {
      Pastry newPastry = new Pastry(5);
      Pastry newPastry1 = new Pastry(5);
      Pastry newPastry2 = new Pastry(5);
      int total = Pastry.CalculateTotal();
      Assert.AreEqual(15, total);
    }
  }
}
