using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Sourdough.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void SourDoughConstructor_CreateInstanceOfSourDough_Sourdough()
    {
      SourDough sourDough = new SourDough();
      Assert.AreEqual(typeof(SourDough), sourDough.GetType());
    }
  }
}