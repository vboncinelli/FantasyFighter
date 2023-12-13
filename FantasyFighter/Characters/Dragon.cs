namespace FantasyFighter
{
    public class Dragon : Character, ICanAttack, ICanDefend
    {
        public Dragon(string name) : base(name, health: 100, attackPoints: 20, defensePoints: 15)
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
