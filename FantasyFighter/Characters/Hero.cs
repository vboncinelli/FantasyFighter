using FantasyFighter.Characters;
using FantasyFighter.Items;

namespace FantasyFighter
{
    public class Hero : Character, ICanDefend, ICanAttack
    {
        public Roles Role { get; private set; } = Roles.Warrior;

        public Inventory Inventory { get; private set; } = new Inventory();

        public Hero(string name, Roles role) : base(name, health: 100, attackPoints: 10, defensePoints: 10)
        {
            this.Role = role;

            // classic switch statement
            switch (this.Role)
            {
                case Roles.Warrior:
                    {
                        this.Inventory.SetupForWarrior();
                        break;
                    }
                case Roles.Cleric:
                    {
                        this.Inventory.SetupForCleric();
                        break;
                    }
                case Roles.Rogue:
                    {
                        this.Inventory.SetupForRogue();
                        break;
                    }
                case Roles.Mage:
                    {
                        this.Inventory.SetupForMage();
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
            return (int)(this.DefensePoints / rnd);
        }

        public int Attack()
        {
            var rnd = new Random().NextDouble();
            return (int)(this.AttackPoints / rnd);
        }
    }
}
