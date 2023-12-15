namespace FantasyFighter
{
    public class Troll : Character, ICanDefend, ICanAttack
    {
        public Troll(string name) : base(name, health: 50, attackPoints: 8, defensePoints: 10)
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
