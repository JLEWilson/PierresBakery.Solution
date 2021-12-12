using System;

namespace Bakery.Models
{
  public class SourDough : Bread
  {
    public static int Cost {get;set;} = 8;
    public static string Name {get;set;} = "SourDough";

    public SourDough() : base(Cost, Name)
    {
    }
  }
}