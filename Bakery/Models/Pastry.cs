using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  { 
    private int _id;
    private int _price;
    public Pastry(int id) 
    {
      _id = id;
      SetPrice();
    }

    public int GetId(){
      return _id;
    }

    private void SetPrice(){
      if(_id % 4 == 0){
        _price = 0;
      } else {
        _price = 2;
      }
    }

    public int GetPrice(){
      return _price;
    }
  }
}