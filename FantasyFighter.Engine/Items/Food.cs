using FantasyFighter.Interfaces;

namespace FantasyFighter.Items
{
    public class Food : Consumable, IHeal
    {
        public int HealingPoints => 15;
    }
}
