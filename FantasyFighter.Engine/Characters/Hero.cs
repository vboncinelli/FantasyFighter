using FantasyFighter.Engine.Engine;
using FantasyFighter.Interfaces;
using FantasyFighter.Items;

namespace FantasyFighter.Characters
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
            var luckyBonus = Dices.Roll();

            var protectingGears = this.Inventory.Items.OfType<IDefence>();

            int defenceBonus = 0;

            if (protectingGears.Any())
            {
                foreach(var gear in protectingGears)
                {
                    defenceBonus += gear.DefenseBonus;
                }
            }

            return this.DefencePoints + defenceBonus + luckyBonus;
        }

        public int Attack()
        {
            var luckyBonus = Dices.Roll();

            int weaponBonus = this.Inventory.MainWeapon!.AttackBonus;

            return this.AttackPoints + weaponBonus + luckyBonus;
        }

        public void Consume<T>() where T : Consumable, new()
        {
            var item = this.Inventory.Items.OfType<T>().FirstOrDefault();

            if (item is null)
                Console.WriteLine("The item you are looking for is not in the Inventory");
            else
            {
                if (item is IHeal healingItem)
                {
                    this.Health += healingItem.HealingPoints;
                    
                    Console.WriteLine($"Your health has been increased by {healingItem.HealingPoints} points. Now your health is {this.Health} points");
                }

                // remove the item from the inventory
                this.Inventory.Items.Remove(item);
            }
        }
    }
}
