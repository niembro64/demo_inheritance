using System;

namespace demo_inheritance
{
  public class Warrior : Character
  {
    public Warrior(string n) : base(n, 6, 80, 9, 5) { }

    public override void DealDamage(Character target)
    {
      h.p("Inside Warrior DealDamage");
      target.ChangeHealth(strength * -2);

      h.p($"{this.name} strikes {target.name} dealing {this.strength}");
    }
  }
}
