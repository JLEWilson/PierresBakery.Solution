using System;

namespace Bakery.Models
{
  public class Danish : Pastry
  {
    public static int Cost {get;set;} = 4;

    public Danish() : base(Cost)
    {
      this.PastryType = "Danish";
    }
  }
}