using FantasyFighter.Interfaces;

namespace FantasyFighter.Characters
{
    public class RatKing : Enemy, ICanAttack, ICanDefend
    {
        public RatKing(string name) : base(name, health: 120, attackPoints: 25, defensePoints: 10)
        {
        }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public int Defend()
        {
            throw new NotImplementedException();
        }
    }
}
