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

        internal void SetupForCleric()
        {
            throw new NotImplementedException();
        }

        internal void SetupForWarrior()
        {
            this.MainWeapon = new Sword();
            this.SecondaryWeapon = new Knife();

            this.Items.Add(this.MainWeapon);
            this.Items.Add(this.SecondaryWeapon);
            this.Items.Add(new Potion());
            this.Items.Add(new Food());
            this.Items.Add(new Food());
            this.Items.Add(new Food());

        }

        internal void SetupForMage()
        {
            throw new NotImplementedException();
        }

        internal void SetupForRogue()
        {
            throw new NotImplementedException();
        }
    }
}
