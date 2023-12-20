using FantasyFighter.Interfaces;

namespace FantasyFighter.Items
{
    public class Armour : Item, IDefence
    {
        public int DefenseBonus => 50;
    }
}
