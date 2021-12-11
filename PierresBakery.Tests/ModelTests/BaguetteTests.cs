using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BaguetteTests
  {
    [TestMethod]
    public void BaguetteConstructor_CreateInstanceOfBaguette_Baguette()
    {
      Baguette Baguette = new Baguette();
      Assert.AreEqual(typeof(Baguette), Baguette.GetType());
    }
  }
}