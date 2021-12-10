using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [Testclass]
  public class FoodItemTests : IDisposable
  {
    public void Dispose()
    {
      FoodItem.ClearAll();
    }

  }
}