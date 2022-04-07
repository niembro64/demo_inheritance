using System;
using System.Collections.Generic;

namespace demo_inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      // Character c1 = new Character("Nichole", 5, 50, 8, 5);
      Warrior cap = new Warrior("Captain America");
      Sourceror dr = new Sourceror("Dr. Strange");

      cap.Print();
      dr.Print();
      dr.DealDamage(cap);
      cap.Print();
      dr.Print();
      cap.DealDamage(dr);
      cap.Print();
      dr.Print();

      List<Warrior> allWarriors = new List<Warrior>();


    }
  }
}
