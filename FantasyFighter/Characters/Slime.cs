namespace FantasyFighter.Characters
{
    public class Slime : Enemy, ICanDefend
    {
        public Slime(string name) : base(name, health: 8, attackPoints:0, defensePoints: 2)
        {

        }

        public int Defend()
        {
            throw new NotImplementedException();
        }
    }
}
