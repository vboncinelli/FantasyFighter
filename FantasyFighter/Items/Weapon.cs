using FantasyFighter.Interfaces;

namespace FantasyFighter.Items
{
    public abstract class Weapon : Item, IWeapon
    {
        public abstract int AttackBonus { get; set; }
    }
}
