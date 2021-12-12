using System;

namespace Bakery.Models
{
  public class Croissant : Pastry
  {
    public static int Cost {get;set;} = 4;
    public static string Name {get;set;} = "Croissant";
    public Croissant() : base(Cost, Name)
    {
    }
  }
}