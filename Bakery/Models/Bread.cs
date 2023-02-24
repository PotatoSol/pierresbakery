using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  { 
    private int _id;
    public Bread(int id) 
    {
      _id = id;
    }

    public int GetId(){
      return _id;
    }
  }
}