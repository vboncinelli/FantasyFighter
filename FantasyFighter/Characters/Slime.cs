namespace FantasyFighter
{
    public class Slime : Character, ICanDefend
    {
        public Slime(string name) : base(name, health: 8, attackPoints:0, defensePoints: 2)
        {

        }

        public void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
