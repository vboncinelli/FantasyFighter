using FantasyFighter.Engine;
using Figgle;

namespace FantasyFighter
{
    // TODO: Experiment!
    // You can modify any element in the solution, so don't be shy.
    // If you don't know where to start, let's try to change the access modifiers
    // of classes, methods and properties... What happens? Anything breaks?
    // Remember: you should always start from the less open modifiers (such as private and internal)
    // and change to public only when required for the code to work.
    // Try also to experiment with getter and setter (and init) of the properties in the class library.
    // By default, classes, methods and props should be as closed as possible to modifications from the outside.

    // TODO: Exceptions for exceptional developers
    // Check your code: does anything can go wrong at runtime?
    // Try to use try-catch block in your code to handle exceptions at runtime
    // Do not let an exception end your app when you are playing! 

    internal class Program
    {
        static void Main(string[] args)
        {
            //http://www.jave.de/figlet/fonts/overview.html

            Console.WriteLine(FiggleFonts.Epic.Render("Fantasy Fighter"));

            //var hero = new Hero("Pollah", Roles.Warrior);
            //hero.Consume<Potion>();
            //hero.Consume<Potion>();
            //hero.Consume<Food>();
            //var damages = hero.Attack();
            //var defense = hero.Defend();

            var game = new GameEngine();

            game.StartNewGame();

            while (game.IsGameRunning)
            {
                game.NextTurn();
            }
        }
    }
}
