namespace FantasyFighter
{
    public class Slime : Character, ICanDefend
    {
        public Slime(string name, int health, int attackPoints, int defensePoints) : base(name, health, attackPoints, defensePoints)
        {
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
