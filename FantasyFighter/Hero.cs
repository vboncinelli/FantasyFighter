namespace FantasyFighter
{
    public class Hero : Character, ICanDefend, ICanAttack
    {
        public Roles Role { get; set; } = Roles.Warrior;
        
        public Hero(string name, int health, int attackPoints, int defensePoints) : base(name, health, attackPoints, defensePoints)
        {

        }

        public void Defend()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
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
