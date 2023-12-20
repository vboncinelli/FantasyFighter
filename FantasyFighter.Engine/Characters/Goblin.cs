using FantasyFighter.Interfaces;

namespace FantasyFighter.Characters
{
    public class Goblin : Enemy, ICanAttack, ICanDefend
    {
        public Goblin(string name) : base(name, health: 30, attackPoints: 3, defensePoints: 2)
        {

        }
    }
}
