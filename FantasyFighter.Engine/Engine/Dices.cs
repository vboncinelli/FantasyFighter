using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFighter.Engine.Engine
{
    internal static class Dices
    {
        internal static int Roll()
        {
            return new Random().Next(1, 13);
        }
    }
}
