using System;

namespace Bakery.Models
{
  public class Macaron : Pastry
  {
    public static int Cost {get;set;} = 4;

    public Macaron() : base(Cost)
    {
      this.PastryType = "Macaron";
    }
  }
}