using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  { 
    private int _id;
    private int _price;
    public Bread(int id) 
    {
      _id = id;
      SetPrice();
    }

    public int GetId(){
      return _id;
    }

    private void SetPrice(){
      if(_id % 3 == 0){
        _price = 0;
      } else {
        _price = 5;
      }
    }

    public int GetPrice(){
      return _price;
    }
  }
}