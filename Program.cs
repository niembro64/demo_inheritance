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
      Mage ma = new Mage("Dr. Mage");

      cap.Print();
      dr.Print();
      dr.DealDamage(cap);
      cap.Print();
      dr.Print();
      cap.DealDamage(dr);
      cap.Print();
      dr.Print();

      List<Character> allCharacters = new List<Character>();

      allCharacters.Add(cap);
      allCharacters.Add(dr);
      allCharacters.Add(ma);

      dr.castSpell();
      dr.Print();

      List<ICastMagic> allMagicUsers = new List<ICastMagic>();
      List<Warrior> allWarriors = new List<Warrior>();
      List<Character> allNormies = new List<Character>();

      foreach (Character c in allCharacters)
      {
        if (c is ICastMagic)
        {
          allMagicUsers.Add((ICastMagic)c);
        }
        else
        {
          allNormies.Add(c);
        }
      }
      a.ss("Magic Users:");
      foreach (Character c in allMagicUsers)
      {
        c.Print();
      }
      a.ss("Normies:");
      foreach (Character c in allWarriors)
      {
        c.Print();
      }

    }
  }
}
