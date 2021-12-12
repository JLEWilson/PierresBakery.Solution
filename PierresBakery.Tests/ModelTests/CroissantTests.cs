using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class CroissantTests
  {
    [TestMethod]
    public void CroissantConstructor_CreateInstanceOfCroissant_Croissant()
    {
      Croissant croissant = new Croissant();
      Assert.AreEqual(typeof(Croissant), croissant.GetType());
    }
  }
}