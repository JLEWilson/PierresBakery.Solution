using System;

namespace Bakery.Models
{
  public class Brioche : Bread
  {
    public static int Cost {get;set;} = 6;

    public Brioche() : base(Cost)
    {
      this.BreadType = "Brioche";
    }
  }
}