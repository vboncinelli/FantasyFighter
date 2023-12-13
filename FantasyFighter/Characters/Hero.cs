namespace FantasyFighter
{
    public class Hero : Character, ICanDefend, ICanAttack
    {
        public Roles Role { get; private set; } = Roles.Warrior;
        
        public Hero(string name, Roles role) : base(name, health: 100, attackPoints: 10, defensePoints: 10)
        {
            this.Role = role;
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
