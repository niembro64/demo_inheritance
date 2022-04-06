using System;

namespace demo_inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Character c1 = new Character("Nichole", 5, 50, 8, 5);
      Warrior w1 = new Warrior("NicholeW");

      Console.Write(w1.strength);
      h.p();
      Console.Write(w1.Print());
    }
  }
}
