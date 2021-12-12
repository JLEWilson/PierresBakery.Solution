using System;

namespace Bakery.Models
{
  public class Sourdough : Bread
  {
    public static int Cost {get;set;} = 8;
    public static string Name {get;set;} = "Sourdough";

    public Sourdough() : base(Cost, Name)
    {
    }
  }
}