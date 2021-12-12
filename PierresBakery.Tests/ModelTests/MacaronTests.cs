using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class MacaronTests
  {
    [TestMethod]
    public void MacaronConstructor_CreateInstanceOfMacaron_Macaron()
    {
      Macaron macaron = new Macaron();
      Assert.AreEqual(typeof(Macaron), macaron.GetType());
    }
  }
}