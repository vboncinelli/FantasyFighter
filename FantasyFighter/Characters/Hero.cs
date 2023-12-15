namespace FantasyFighter
{
    public class Hero : Character, ICanDefend, ICanAttack
    {
        public Roles Role { get; private set; } = Roles.Warrior;

        public Hero(string name, Roles role) : base(name, health: 100, attackPoints: 10, defensePoints: 10)
        {
            this.Role = role;

            // classic switch statement
            switch (this.Role)
            {
                // we can modify the character's stats based on the role
                case Roles.Warrior:
                    {
                        base.AttackPoints *= 3;
                        base.DefensePoints *= 2;
                        break;
                    }
                case Roles.Cleric:
                    {
                        base.DefensePoints *= 3;
                        break;
                    }
                case Roles.Rogue:
                    {
                        base.AttackPoints *= 2;
                        base.DefensePoints *= 2;
                        break;
                    }
                case Roles.Mage:
                    {
                        base.AttackPoints *= 3;
                        break;
                    }
                case Roles.Undefined:
                default:
                    Console.WriteLine("Uh oh, something went terribly wrong, at this point your hero should have a role");
                    break;
            }
        }

        public int Defend()
        {
            var rnd = new Random().NextDouble();
            return (int) (this.DefensePoints / rnd);
        }

        public int Attack()
        {
            var rnd = new Random().NextDouble();
            return (int)(this.AttackPoints / rnd);
        }
    }


    public enum Roles
    {
        Undefined,
        Warrior,
        Cleric,
        Rogue,
        Mage
    }
}
