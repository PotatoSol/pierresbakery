using System;
class Program
{
  static void Main()
  {
    // We'll add user interface code here.
  WelcomeMessage();
  }

  static void WelcomeMessage()
  {
    Console.WriteLine("Hello! \nHow many pieces of bread would you like?");
    int numberOfBread = int.Parse(Console.ReadLine());
    Console.WriteLine("Okay, " + numberOfBread + " pieces of bread coming up.");
    Console.WriteLine("How many pastries would you like?");
    int numberOfPastry = int.Parse(Console.ReadLine());
  }
}