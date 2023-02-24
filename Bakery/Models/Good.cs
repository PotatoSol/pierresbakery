using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  abstract public class Good
  { 
    private int _id;
    private int _price;

    public Good(int id) 
    {
      this._id = id;
    }

    abstract public int GetPrice();
    abstract public void SetPrice();

    abstract public int GetId();
  }
  public class Bread : Good{
    private int _id;
    private int _price;
    public Bread(int id) : base (id){
      this._id = id;
      SetPrice();
    }

    public override void SetPrice(){
      if(_id % 3 == 0){
        _price = 0;
      } else {
        _price = 5;
      }
    }

    public override int GetId(){
      return _id;
    }
    
    public override int GetPrice(){
      return this._price;
    }
  }
    public class Pastry : Good{
    private int _id;
    private int _price;
    public Pastry(int id) : base (id){
      this._id = id;
      SetPrice();
    }
    
    public override void SetPrice(){
        if(_id % 4 == 0){
          _price = 0;
        } else {
          _price = 2;
        }
      }
    public override int GetId(){
      return _id;
    }
    public override int GetPrice(){
      return this._price;
    }
  }
}