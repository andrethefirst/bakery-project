using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("You have entered Pierre's Bakery! Welcome!");

      Console.WriteLine("Buy one loaf of Bread for $5");
      Console.WriteLine("BREAD DEAL: Buy 2 get 1 free!");

      Console.WriteLine("Buy one Pastry for $2");
      Console.WriteLine("PASTRY DEAL: Get $1 off every 3 Pastries!");

      Console.WriteLine("Do you want to buy anything? yes or no");

      string inputtedReply = Console.ReadLine();
      if (inputtedReply == "yes")
      {
        CreateOrder();
      }
      else
      {
        {
          Console.WriteLine("Well I hope to see you next time! Have a good day!");
          Console.ReadKey();
          Main();
        }
      }
    }
    static void CreateOrder()
    {
      Console.WriteLine("How many loaves of bread would you like to order?");
      string breadOrder = Console.ReadLine();
      try
      {
        int breadChoice = int.Parse(breadOrder);
        Bread addedBread = new Bread(breadChoice);
        addedBread.BreadPrice();

        Console.WriteLine($"The Price for the Bread is ${addedBread.Price}.");
        
        Console.WriteLine("Press anything to continue ordering.");
        Console.ReadKey();

        Console.WriteLine("How many pastries would you like to order?");
        string pastryOrder = Console.ReadLine();
        try
        {
          int pastryChoice = int.Parse(pastryOrder);
          Pastry addedPastry = new Pastry(pastryChoice);
          addedPastry.PastryPrice();

          Console.WriteLine($"The Price for the Pastries is ${addedPastry.Price}.");

          Console.WriteLine("Press anything to see your total.")
          Console.ReadKey();

          Console.WriteLine($"Your total price is ${addedBread.Price + addedPastry.Price}. Thank you for shopping at Pierres!");
        }
        catch (System.Exception)
        {
            
          throw;
        }
      }
      catch (System.Exception)
      {
          
        throw;
      }
    }
  }
}