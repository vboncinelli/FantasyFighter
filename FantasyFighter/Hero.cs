namespace FantasyFighter
{
    public class Hero : Character
    {
        public Roles Role { get; set; } = Roles.Warrior;
        
        public Hero(string name, int health, int attackPoints, int defensePoints) : base(name, health, attackPoints, defensePoints)
        {
        }
    }


    public enum Roles
    {
        Warrior,
        Cleric,
        Rogue,
        Mage
    }
}
