using System;

namespace demo_inheritance
{
  public class Warrior : Character
  {
    public Warrior(string n) : base(n, 6, 80, 9, 5) { }

    public override void DealDamage(Character target)
    {
      a.ss("Warrior DealDamage");

      int amount = strength * -2;
      target.ChangeHealth(amount);

      a.ss($"{this.name} strikes {target.name} dealing {-amount}");
    }
  }
}
