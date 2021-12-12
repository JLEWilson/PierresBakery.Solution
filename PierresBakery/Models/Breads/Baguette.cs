using System;

namespace Bakery.Models
{
  public class Baguette : Bread
  {
    public static int Cost {get;set;} = 5;
    public static string Name {get;set;} = "Croissant";

    public Baguette() : base(Cost, Name)
    {
    }
  }
}