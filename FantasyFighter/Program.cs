using FantasyFighter.Characters;
using FantasyFighter.Engine;
using FantasyFighter.Items;
using Figgle;

namespace FantasyFighter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //http://www.jave.de/figlet/fonts/overview.html

            Console.WriteLine(FiggleFonts.Epic.Render("Fantasy Fighter"));

            var hero = new Hero("Pollah", Roles.Warrior);
            hero.Consume<Potion>();
            hero.Consume<Potion>();
            hero.Consume<Food>();
            var damages = hero.Attack();
            var defense = hero.Defend();

            //var game = new GameEngine();

            //game.StartNewGame();

            //while (game.IsGameRunning)
            //{
            //    game.NextTurn();
            //}
        }
    }
}
