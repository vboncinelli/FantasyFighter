using FantasyFighter.Engine.Engine;

namespace FantasyFighter.Characters
{
    public abstract class Enemy : Character
    {
        public Enemy(string name, int health, int attackPoints, int defensePoints) : base(name, health, attackPoints, defensePoints)
        {
        }

        // TODO: What should we do if we wanted to provide
        // different implementations for different enemies?
        public virtual int Attack()
        {
            var luckyBonus = Dices.Roll();

            return this.AttackPoints + luckyBonus;
        }

        public virtual int Defend()
        {
            // TODO: Implement the logic
            // TODO: What should we do if we wanted to provide
            // different implementations for different enemies?
            throw new NotImplementedException();
        }
    }
}
