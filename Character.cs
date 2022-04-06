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
      h.p();
      h.p($"Name          {this.name}");
      h.p();
      h.p($"Level:        {this.level}");
      h.p();
      h.p($"Health:       {this.health}");
      h.p();
      h.p($"Strength:     {this.strength}");
      h.p();
      h.p($"Intelligence: {this.intelligence}");
      h.p();
      return this;
    }


    public virtual void DealDamage(Character target)
    {
      target.health -= 20;
      if (target.health < 0)
      {
        target.health = 0;
      }

      h.p($"{this.name} attacked {target.name} dealing {this.strength}");
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