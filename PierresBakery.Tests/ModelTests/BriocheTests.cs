using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BriocheTests
  {
    [TestMethod]
    public void BriocheConstructor_CreateInstanceOfBrioche_Brioche()
    {
      Brioche brioche = new Brioche();
      Assert.AreEqual(typeof(Brioche), brioche.GetType());
    }
  }
}