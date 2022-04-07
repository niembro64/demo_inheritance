using System;

namespace demo_inheritance
{

  public class Sourceror : Character
  {
    public int mana; 

    public Sourceror(string n) : base(n, 7, 60, 5, 10) { 

      mana = 200; 
    }

    public override void DealDamage(Character target)
    {
      a.ss("Sourceror DealDamage");

      int amount = strength * -2;
      target.ChangeHealth(amount);

      a.ss($"{this.name} zaps {target.name} dealing {-amount}");
    }

  }
}