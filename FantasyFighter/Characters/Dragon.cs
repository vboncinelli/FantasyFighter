﻿namespace FantasyFighter.Characters
{
    public class Dragon : Enemy, ICanAttack, ICanDefend
    {
        public Dragon(string name) : base(name, health: 100, attackPoints: 20, defensePoints: 15)
        {
        }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public int Defend()
        {
            throw new NotImplementedException();
        }
    }
}