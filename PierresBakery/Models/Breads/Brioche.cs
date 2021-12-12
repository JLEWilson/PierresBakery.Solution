using System;

namespace Bakery.Models
{
  public class Brioche : Bread
  {
    public static int Cost {get;set;} = 6;
    public static string Name {get;set;} = "Brioche";

    public Brioche() : base(Cost, Name)
    {
    }
  }
}