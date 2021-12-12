using System;
using Bakery.Models;
public class Program
{
  private static bool _firstTime = true;
  private static string[] itemNames = new string[] {Baguette.Name, Brioche.Name, Sourdough.Name, Croissant.Name, Danish.Name, Macaron.Name};
  public static void Main()
  {
    if(_firstTime)
    {
      Console.WriteLine("Welcome to Pierres Bakery!");
      Console.WriteLine("Today's specials are: buy 2 get 1 free Baguettes and buy 3 get 1 half off Macarons"); //Here at jacob's pierre's bakery our deals are just a little bit more specific
      Console.WriteLine("To see our available items enter: menu");
      Console.WriteLine("To see our deals again enter: deals");
      Console.WriteLine("To add an item enter: add, then the item name");
      Console.WriteLine("To view your order and proceed to checkout enter: view)");
      _firstTime = false;
      Console.WriteLine(Macaron.Name.ToLower());
    }

    Console.WriteLine("What would you like to do? (menu/deals/add/view)");
    string response = Console.ReadLine();
    if(response == "menu" || response == "Menu")
    {
      Console.WriteLine("Breads:");
      Console.WriteLine(Baguette.Name + ": $" + Baguette.Cost);
      Console.WriteLine(Brioche.Name + ": $" + Brioche.Cost);
      Console.WriteLine(Sourdough.Name + ": $" + Sourdough.Cost);
      Console.WriteLine("Pastries:");
      Console.WriteLine(Croissant.Name + ": $" + Croissant.Cost);
      Console.WriteLine(Danish.Name + ": $" + Danish.Cost);
      Console.WriteLine(Macaron.Name + ": $" + Macaron.Cost);
      Main();
    } 
    else if(response == "deals" || response == "Deals")
    {
      Console.WriteLine("Today's specials are: ");
      Console.WriteLine("Buy 2 get 1 free Baguettes!");
      Console.WriteLine("Buy 3  get 1 half off Macarons!");
      Main();
    }
    else if(response == "add" || response == "Add")
    {
      Console.WriteLine("What would you like to add?");
      string addResponse = Console.ReadLine();
      if (!Array.Exists(itemNames, element => element == addResponse || element.ToLower() == addResponse))
      {
        Console.WriteLine("Invalid item, returning to main menu.");
        Main();
      }
      Console.WriteLine("How many would you like?");
      string numberOfItemString = Console.ReadLine();
      int numberOfItem = int.Parse(numberOfItemString);
      // I don't know of a way to make this next section more dry, not sure if I even could
      if(addResponse == Baguette.Name || addResponse == Baguette.Name.ToLower())
      {
        for (int i = 0; i < numberOfItem; i++)
        {
          Baguette newBaguette = new Baguette();
        }

        if(numberOfItem > 1 )
        {
          Console.WriteLine(numberOfItem + " " + Baguette.Name + "s added to order.");
        } 
        else
        {
          Console.WriteLine(numberOfItem + " " + Baguette.Name + " added to order.");
        }
      }
      else if(addResponse == Brioche.Name || addResponse == Brioche.Name.ToLower())
      {
        for (int i = 0; i < numberOfItem; i++)
        {
          Brioche newBrioche = new Brioche();
        }

        if(numberOfItem > 1 )
        {
          Console.WriteLine(numberOfItem + " " + Brioche.Name + "s added to order.");
        } 
        else
        {
          Console.WriteLine(numberOfItem + " " + Brioche.Name + " added to order.");
        }
      }
      else if(addResponse == Sourdough.Name || addResponse == Sourdough.Name.ToLower())
      {
        for (int i = 0; i < numberOfItem; i++)
        {
          Sourdough newSourdough = new Sourdough();
        }

        if(numberOfItem > 1 )
        {
          Console.WriteLine(numberOfItem + " " + Sourdough.Name + "s added to order.");
        } 
        else
        {
          Console.WriteLine(numberOfItem + " " + Sourdough.Name + " added to order.");
        }
      }
      else if(addResponse == Croissant.Name || addResponse == Croissant.Name.ToLower())
      {
        for (int i = 0; i < numberOfItem; i++)
        {
          Croissant newCroissant = new Croissant();
        }

        if(numberOfItem > 1 )
        {
          Console.WriteLine(numberOfItem + " " + Croissant.Name + "s added to order.");
        } 
        else
        {
          Console.WriteLine(numberOfItem + " " + Croissant.Name + " added to order.");
        }
      }
      else if(addResponse == Danish.Name || addResponse == Danish.Name.ToLower())
      {
        for (int i = 0; i < numberOfItem; i++)
        {
          Danish newDanish = new Danish();
        }

        if(numberOfItem > 1 )
        {
          Console.WriteLine(numberOfItem + " " + Danish.Name + "s added to order.");
        } 
        else
        {
          Console.WriteLine(numberOfItem + " " + Danish.Name + " added to order.");
        }
      }
      else if(addResponse == Macaron.Name || addResponse == Macaron.Name.ToLower())
      {
        for (int i = 0; i < numberOfItem; i++)
        {
          Macaron newMacaron = new Macaron();
        }

        if(numberOfItem > 1 )
        {
          Console.WriteLine(numberOfItem + " " + Macaron.Name + "s added to order.");
        } 
        else
        {
          Console.WriteLine(numberOfItem + " " + Macaron.Name + " added to order.");
        }
        
      }
      Main();
    }
    else if(response == "view" || response == "View")
      {
        Console.WriteLine("Applying discounts!");
        FoodItem.ApplyDiscountSpecific(3, 0, Baguette.Name);
        FoodItem.ApplyDiscountSpecific(3, 1, Macaron.Name);
        Console.WriteLine("Items:");
        foreach(FoodItem item in FoodItem.Order)
        {
          Console.WriteLine(item.ItemName + "- " + "$" + item.Price);
        }
        Console.WriteLine("Total: $" + FoodItem.CalculateTotal());
        Console.WriteLine("Would you like to checkout now?(yes/no)");
        string checkoutResponse = Console.ReadLine();
        if(checkoutResponse == "yes" || checkoutResponse == "Yes" || checkoutResponse == "YES"){
          Console.WriteLine("Send your payment to my venmo @Jacob-Wilson-77");
          Console.WriteLine("Thank you for your purchase!");
        }
        else
        {
          Main();
        }
        
      }
  }
}