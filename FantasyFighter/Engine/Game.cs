
namespace FantasyFighter
{
    public class Game
    {
        private List<Character> _enemies;

        private Hero? _player;

        public bool IsGameRunning { get; private set; }

        public Game()
        {
            this._enemies = new List<Character>()
            {
                new Dragon("Red Dragon"),
                new Dragon("Golden Dragon"),
                new Goblin("Goblin #1"),
                new Goblin("Goblin #2"),
                new Troll("Paolo"),
                new Slime("Slime #1"),
                new Slime("Slime #2")
            };
        }

        public void StartNewGame()
        {
            if(this.IsGameRunning)
            {
                Console.WriteLine("The game is already running");
                return;
            }

            this.IsGameRunning = true;

            // messaggio di benvenuto al giocatore
            this.DisplayWelcomeMessage();

            // chiedere al giocatore di scegliere un nome
            this.GetPlayerName();

            // chiedere al giocatore di scegliere un ruolo

            // costruire il nostro hero

            // iniziano i turni
        }

        private string GetPlayerName()
        {
            Console.WriteLine("Please choose your name");
            var name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                Console.WriteLine("The name cannot be empty or white spaces");

            //TODO: richiedere il nome al giocatore

            return name!;
        }

        private void DisplayWelcomeMessage()
        {
            Console.WriteLine("Messaggio di benvuto....");
        }
    }
}
