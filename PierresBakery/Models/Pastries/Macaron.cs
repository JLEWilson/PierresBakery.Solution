using System;

namespace Bakery.Models
{
  public class Macaron : Pastry
  {
    public static int Cost {get;set;} = 2;
    public static string Name {get;set;} = "Macaron";

    public Macaron() : base(Cost, Name)
    {
    }
  }
}