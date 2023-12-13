namespace FantasyFighter
{
    public class Troll : Character, ICanDefend, ICanAttack
    {
        public Troll(string name, int health, int attackPoints, int defensePoints) : base(name, health, attackPoints, defensePoints)
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
