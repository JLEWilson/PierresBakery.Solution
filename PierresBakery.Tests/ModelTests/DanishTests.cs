using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class DanishTests
  {
    [TestMethod]
    public void DanishConstructor_CreateInstanceOfDanish_Danish()
    {
      Danish danish = new Danish();
      Assert.AreEqual(typeof(Danish), danish.GetType());
    }
  }
}