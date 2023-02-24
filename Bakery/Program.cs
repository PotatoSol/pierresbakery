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
    bool addMore = addMoreToOrder();
    int totalBread = order[0];
    int totalPastry = order[1];
    while(addMore){
      List<int> reorder = ReorderMessage();
      totalBread += reorder[0];
      totalPastry += reorder[1];
      breadOrder = createBreads(totalBread);
      pastryOrder = createPastries(totalPastry);
      total = calculateTotal(breadOrder, pastryOrder);
      printOrder(total, breadOrder, pastryOrder);
      addMore = addMoreToOrder();
    }
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

  static bool addMoreToOrder(){
    Console.WriteLine("Add more to your order?");
    string userAddMore = Console.ReadLine();
    if (userAddMore == "yes" || userAddMore == "1" || userAddMore == "true"){
      return true;
    } else {
      return false;
    }
    
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

  static List<int> ReorderMessage(){
    Console.WriteLine("How many pieces of bread would you like?");
    int numberOfBread = int.Parse(Console.ReadLine());

    Console.WriteLine("Okay, " + numberOfBread + " more loaves of bread coming up.");

    Console.WriteLine("How many pastries would you like?");
    int numberOfPastry = int.Parse(Console.ReadLine());

    Console.WriteLine("Okay, " + numberOfPastry + " more pieces of pastry coming up.");
    List<int> returnAmountsList = new List<int>();
    returnAmountsList.Add(numberOfBread);
    returnAmountsList.Add(numberOfPastry);
    return returnAmountsList;
  }

  static void printOrder(int total, List<Bread> breadList, List<Pastry> pastryList){
    Console.WriteLine("Your total comes out to: $" + total);
    Console.WriteLine("You ordered: ");
    Console.WriteLine("BREAD: ");
    int dashes = breadList.Count / 100 + 15;
    for(int i = 0; i < breadList.Count; i++){
      String amountLine = "Bread #" + breadList[i].GetId().ToString();
      Console.Write(amountLine);
      for(int j = 0; j < (dashes - (amountLine.Length)); j++){
        Console.Write("-");
      }
      Console.WriteLine("$" + breadList[i].GetPrice());
    }
    Console.WriteLine("PASTRIES: ");
    dashes = pastryList.Count / 100 + 15;
    for(int i = 0; i < pastryList.Count; i++){
      String amountLine = "Pastry #" + pastryList[i].GetId().ToString();
      Console.Write(amountLine);
      for(int j = 0; j < (dashes - (amountLine.Length)); j++){
        Console.Write("-");
      }
      Console.WriteLine("$" + pastryList[i].GetPrice());
    }
    //printReceipt(pastryList, "PASTRIES"); <-- I can't figure out why this doesn't work
  }
  /* Commented out because I can't figure this out
  static void printReceipt(List<Good> inputList, String nameOfInput){
    int dashes = inputList.Count / 100 + 15;
    for(int i = 0; i < inputList.Count; i++){
    String amountLine = nameOfInput + " #" + inputList[i].GetId().ToString();
    Console.Write(amountLine);
    for(int j = 0; j < (dashes - (amountLine.Length)); j++){
      Console.Write("-");
    }
    Console.WriteLine("$" + inputList[i].GetPrice());
  }
  }
  */
}