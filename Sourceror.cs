using System;

namespace demo_inheritance
{

  public class Sourceror : Character, ICastMagic
  {
    public int mana { get; set; }
    public Sourceror(string n) : base(n, 7, 60, 5, 10)
    {

      mana = 300;
    }


    public void castSpell()
    {

      mana -= 10;
      a.ss($"{this.name} Cast a Spell!");
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