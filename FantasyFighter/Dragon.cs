namespace FantasyFighter
{
    public class Dragon : Character, ICanAttack, ICanDefend
    {
        public Dragon(string name, int health, int attackPoints, int defensePoints) : base(name, health, attackPoints, defensePoints)
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
