using Figgle;

namespace FantasyFighter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //http://www.jave.de/figlet/fonts/overview.html

            Console.WriteLine(FiggleFonts.Epic.Render("Fantasy Fighter"));

            var game = new GameEngine();

            game.StartNewGame();

            while (game.IsGameRunning)
            {
                game.NextTurn();
            }
        }
    }
}
