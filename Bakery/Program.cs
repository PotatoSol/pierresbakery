using System;
using System.Collections.Generic;
using Bakery.Models;

class Program
{
  static void Main(){
    List<int> order = WelcomeMessage();
    List<Bread> breadOrder = createBreads(order[0]);
    List<Pastry> pastryOrder = createPastries(order[1]);
  }

//==================================================================================
//                                  Business
//==================================================================================

  static List<Bread> createBreads(int amountOfBread){
    List<Bread> returnBreadList = new List<Bread>();

    for(int i = 0; i < amountOfBread; i++){
      returnBreadList.Add(new Bread(i));
    }

    return returnBreadList;
  }

  static List<Pastry> createPastries(int amountOfPastry){
    List<Pastry> returnPastryList = new List<Pastry>();

    for(int i = 0; i < amountOfPastry; i++){
      returnPastryList.Add(new Pastry(i));
    }

    return returnPastryList;
  }

//==================================================================================
//                                  User Interface
//==================================================================================
  static List<int> WelcomeMessage(){
    Console.WriteLine("Hello! \nHow many pieces of bread would you like?");
    int numberOfBread = int.Parse(Console.ReadLine());

    Console.WriteLine("Okay, " + numberOfBread + " pieces of bread coming up.");

    Console.WriteLine("How many pastries would you like?");
    int numberOfPastry = int.Parse(Console.ReadLine());

    List<int> returnAmountsList = new List<int>();
    returnAmountsList.Add(numberOfBread);
    returnAmountsList.Add(numberOfPastry);
    return returnAmountsList;
  }
}