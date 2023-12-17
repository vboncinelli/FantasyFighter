namespace FantasyFighter.Characters
{
    public abstract class Enemy : Character
    {
        public Enemy(string name, int health, int attackPoints, int defensePoints) : base(name, health, attackPoints, defensePoints)
        {
        }

        //public abstract void DisplayEnemyIntroText();
    }
}
