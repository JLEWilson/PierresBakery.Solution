using System;

namespace Bakery.Models
{
  public class Baguette : Bread
  {
    public static int Cost {get;set;} = 5;

    public Baguette() : base(Cost)
    {
      
    }
  }
}