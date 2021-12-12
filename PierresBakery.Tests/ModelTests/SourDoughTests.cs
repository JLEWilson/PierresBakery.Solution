using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class SourdoughTests
  {
    [TestMethod]
    public void SourDoughConstructor_CreateInstanceOfSourDough_Sourdough()
    {
      SourDough sourdough = new SourDough();
      Assert.AreEqual(typeof(SourDough), sourdough.GetType());
    }
  }
}