using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class SourdoughTests
  {
    [TestMethod]
    public void SourdoughConstructor_CreateInstanceOfSourdough_Sourdough()
    {
      Sourdough sourdough = new Sourdough();
      Assert.AreEqual(typeof(Sourdough), sourdough.GetType());
    }
  }
}