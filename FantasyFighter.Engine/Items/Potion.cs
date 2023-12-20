using FantasyFighter.Interfaces;

namespace FantasyFighter.Items
{
    public class Potion : Consumable, IHeal
    {
        public int HealingPoints => 50;
    }
}
