using System;

namespace demo_inheritance
{
  public abstract class Character
  {
    // attributes
    public string name;
    public int level;
    private int health;
    public int Health { get { return health; } }
    public int strength;
    public int intelligence;

    // constructor
    public Character(string n, int l, int h, int s, int i)
    {
      name = n;
      level = l;
      health = h;
      strength = s;
      intelligence = i;
    }
    // methods
    public Character Print()
    {
      a.sss();
      a.ss($"        Name: {this.name}");
      a.ss($"       Level: {this.level}");
      a.ss($"      Health: {this.health}");
      a.ss($"    Strength: {this.strength}");
      a.ss($"Intelligence: {this.intelligence}");
      a.sss();
      return this;
    }


    public virtual void DealDamage(Character target)
    {
     a.ss("Character DealDamage");

      int amount = strength * -2;
      target.ChangeHealth(amount);

      a.ss($"{this.name} attacks {target.name} dealing {-amount}");
    }
    
    public void ChangeHealth(int amount){
      this.health += amount; 
    }

  }
}

// four pillars of OOP

// Inheritance - child extends parent class
// Polymorphism - all children are still parent type
// Encapsulation - objects can have private stuff
// Abstraction - 