using System;

namespace Bakery.Models
{
  public class Danish : Pastry
  {
    public static int Cost {get;set;} = 3;
    public static string Name {get;set;} = "Danish";

    public Danish() : base(Cost, Name)
    {
    }
  }
}