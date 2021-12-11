using System;

namespace Bakery.Models
{
  public class Croissant : Pastry
  {
    public static int Cost {get;set;} = 4;

    public Croissant() : base(Cost)
    {
      this.PastryType = "Croissant";
    }
  }
}