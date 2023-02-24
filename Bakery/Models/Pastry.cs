using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  { 
    private int _id;
    public Pastry(int id) 
    {
      _id = id;
    }

    public int GetId(){
      return _id;
    }
  }
}