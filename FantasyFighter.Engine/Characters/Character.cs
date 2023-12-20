using FantasyFighter.Engine.Engine;

namespace FantasyFighter.Characters
{
    // TODO: Create new classes of heros
    // Is the use of an enum for roles the only possible strategy?
    // What would happen if, instead of using an enum, you would create different sub-classes
    // for Warrior, Wizard, etc.? Does it give any advantage?
    
    // TODO: Special moves?
    // What if we wanted to implement a different special attack or ability for each class of heroes?
    // For example, the Warrior could have a LuckyStrike ability that randomly double the attack points?
 
    public abstract class Character
    {
        public string Name { get; private set; }

        public int Health { get; set; }

        public int AttackPoints { get; set; }

        public int DefencePoints { get; set; }

        public Character(string name, int health, int attackPoints, int defensePoints)
        {
            Name = name;
            Health = health;
            AttackPoints = attackPoints;
            DefencePoints = defensePoints;
        }

        public override string ToString()
        {
            return $"Name: {this.Name} - Health: {this.Health} - Attack Points: {this.AttackPoints} - Defense Points: {this.DefencePoints}";
        }
    }
}
