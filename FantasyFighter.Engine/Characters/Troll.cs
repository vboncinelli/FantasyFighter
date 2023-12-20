using FantasyFighter.Interfaces;

namespace FantasyFighter.Characters
{
    public class Troll : Enemy, ICanDefend, ICanAttack
    {
        public Troll(string name) : base(name, health: 50, attackPoints: 8, defensePoints: 10)
        {
        }
    }
}
