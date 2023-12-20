using FantasyFighter.Engine.Engine;
using FantasyFighter.Interfaces;
using FantasyFighter.Items;

namespace FantasyFighter.Characters
{
    public class Hero : Character
    {

        // TODO: Is this the only way to go?
        // Try to use sub classes instead of roles to define
        // different types of hero (warrior, wizard, ecc.)
        
        public Roles Role { get; private set; } = Roles.Warrior;

        public Inventory Inventory { get; private set; } = new Inventory();

        public Hero(string name, Roles role) : base(name, health: 100, attackPoints: 10, defensePoints: 10)
        {
            this.Role = role;

            // TODO: Boosters based on the role
            // Try to modify the initial stats of the hero
            // based on the role. For example, a warrior could
            // have more attack points than a cleric, but the latter
            // more health points.
            
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
                case Roles.Wizard:
                    {
                        this.Inventory.SetupForWizard();
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

        // TODO: Weapons deal different damages to different monster?
        // When calculating the damage points taken by an enemy, you could take into account the type of enemy.
        // For instance, some mosters could be weaker or more resistant against some type of weapons.
        // A dragon could take less damages from swords and knifes, and suffer more damages from magical attacks.
        // In this case, you might need to modify the method to accept an enemy as parameter. Then you need to check
        // what kind of enemy you are facing (is it a Goblin or a Dragon?) to determine the effects of the main weapon.
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
                // Check if the item implements the IHeal interface
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
