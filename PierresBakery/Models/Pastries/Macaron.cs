using System;

namespace Bakery.Models
{
  public class Macaron : Pastry
  {
    public static int Cost {get;set;} = 4;
    public static string Name {get;set;} = "Croissant";

    public Macaron() : base(Cost, Name)
    {
    }
  }
}