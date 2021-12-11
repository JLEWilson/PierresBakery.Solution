using System;

namespace Bakery.Models
{
  public class SourDough : Bread
  {
    public static int Cost {get;set;} = 8;

    public SourDough() : base(Cost)
    {
      this.BreadType = "Sourdough";
    }
  }
}