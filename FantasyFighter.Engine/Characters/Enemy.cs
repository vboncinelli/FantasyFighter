using FantasyFighter.Engine.Engine;

namespace FantasyFighter.Characters
{
    public abstract class Enemy : Character
    {
        public Enemy(string name, int health, int attackPoints, int defensePoints) : base(name, health, attackPoints, defensePoints)
        {
        }

        public virtual int Attack()
        {
            var luckyBonus = Dices.Roll();

            return this.AttackPoints + luckyBonus;
        }

        public virtual int Defend()
        {
            var luckyBonus = Dices.Roll();

            return this.DefencePoints + luckyBonus;
        }
    }
}
