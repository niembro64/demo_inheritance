using System;

namespace demo_inheritance
{

  public class Mage : Character, ICastMagic
  {

    public int mana { get; set; }
    public Mage(string n) : base(n, 7, 65, 5, 9)
    {

      mana = 200;
    }

    public void castSpell(){

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