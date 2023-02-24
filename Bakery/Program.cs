using System;
using System.Collections.Generic;
using Bakery.Models;

class Program
{
  static void Main(){
    List<int> order = WelcomeMessage();
    List<Bread> breadOrder = createBreads(order[0]);
    List<Pastry> pastryOrder = createPastries(order[1]);
    int total = calculateTotal(breadOrder, pastryOrder);
    printOrder(total, breadOrder, pastryOrder);
  }

//==================================================================================
//                                  Business
//==================================================================================

  static List<Bread> createBreads(int amountOfBread){
    List<Bread> returnBreadList = new List<Bread>();

    for(int i = 0; i < amountOfBread; i++){
      returnBreadList.Add(new Bread(i+1)); //Need to add 1 to the id so we don't have an id of 0
    }

    return returnBreadList;
  }

  static List<Pastry> createPastries(int amountOfPastry){
    List<Pastry> returnPastryList = new List<Pastry>();

    for(int i = 0; i < amountOfPastry; i++){
      returnPastryList.Add(new Pastry(i+1)); //Need to add 1 to the id so we don't have an id of 0
    }

    return returnPastryList;
  }

  static int calculateTotal(List<Bread> breadList, List<Pastry> pastryList){
    int total = 0;
    foreach(Bread aBread in breadList){
      total += aBread.GetPrice();
    }
    foreach(Pastry aPastry in pastryList){
      total += aPastry.GetPrice();
    }
    return total;
  }

//==================================================================================
//                                  User Interface
//==================================================================================
  static List<int> WelcomeMessage(){
    Console.WriteLine("Hello! \nHow many pieces of bread would you like?");
    int numberOfBread = int.Parse(Console.ReadLine());

    Console.WriteLine("Okay, " + numberOfBread + " loaves of bread coming up.");

    Console.WriteLine("How many pastries would you like?");
    int numberOfPastry = int.Parse(Console.ReadLine());

    Console.WriteLine("Okay, " + numberOfPastry + " pieces of pastry coming up.");
    List<int> returnAmountsList = new List<int>();
    returnAmountsList.Add(numberOfBread);
    returnAmountsList.Add(numberOfPastry);
    return returnAmountsList;
  }

  static void printOrder(int total, List<Bread> breadList, List<Pastry> pastryList){
    Console.WriteLine("Your total comes out to: $" + total);
    Console.WriteLine("You ordered: ");
    Console.WriteLine("BREAD: ");
    foreach(Bread aBread in breadList){
      Console.WriteLine("Bread #" + aBread.GetId().ToString() + " ----- $" + aBread.GetPrice());
    }
    Console.WriteLine("PASTRIES: ");
    foreach(Pastry aPastry in pastryList){
      Console.WriteLine("Bread #" + aPastry.GetId().ToString() + " ----- $" + aPastry.GetPrice());
    }
  }
}