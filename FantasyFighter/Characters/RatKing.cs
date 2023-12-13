namespace FantasyFighter
{
    public class RatKing : Character, ICanAttack, ICanDefend
    {
        public RatKing(string name) : base(name, health: 120, attackPoints: 25, defensePoints: 10)
        {
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
