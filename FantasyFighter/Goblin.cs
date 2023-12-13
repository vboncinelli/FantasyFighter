namespace FantasyFighter
{
    public class Goblin : Character, ICanAttack, ICanDefend
    {
        public Goblin(string name, int health, int attackPoints, int defensePoints) : base(name, health, attackPoints, defensePoints)
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
