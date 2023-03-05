using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  abstract public class Good
  { 
    public int Id {get; private set;}
    protected int _price;

    public Good(int id) 
    {
      this.Id = id; //I believe this is still auto-implemented
    }

  }

  //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
  public class Bread : Good{
    public int Price 
    {
      get 
      {
        return _price;
      }
    }

    public Bread(int id) : base (id){
      if(this.Id % 3 == 0){ //for some reason, this didn't work when i put it as part of the price getter/setter
        _price = 0;
      } else {
        _price = 5;
      }
    }
  }

  //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    public class Pastry : Good{
    public int Price 
    {
      get 
      {
        return _price;
      }
    }

    public Pastry(int id) : base (id){
      if(this.Id % 4 == 0){
        _price = 0;
      } else {
        _price = 3;
      }
    }
  }
}