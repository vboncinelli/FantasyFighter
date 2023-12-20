namespace FantasyFighter.Items
{
    public class Inventory
    {
        public Weapon? MainWeapon { get; private set; }

        public Weapon? SecondaryWeapon { get; private set; }

        public List<Item> Items { get; private set; } = new List<Item>();

        public void SwitchWeapons()
        {
            var tmp = this.MainWeapon;

            this.MainWeapon = this.SecondaryWeapon;

            this.SecondaryWeapon = tmp;
        }

        // TODO: Experiment with the inventory
        // Try to add new kinds of items, with different effects on
        // health, attack and defence.


        internal void SetupForWarrior()
        {
            this.MainWeapon = new Sword();
            this.SecondaryWeapon = new Knife();

            this.Items.Add(new Potion());
            this.Items.Add(new Food());
            this.Items.Add(new Food());
            this.Items.Add(new Food());
        }

        // TODO: Provide the implementations for 
        // the different classes (cleric, m

        internal void SetupForCleric()
        {
            throw new NotImplementedException();
        }

        internal void SetupForWizard()
        {
            throw new NotImplementedException();
        }

        internal void SetupForRogue()
        {
            throw new NotImplementedException();
        }
    }
}
