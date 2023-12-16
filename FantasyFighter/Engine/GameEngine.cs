using FantasyFighter.Characters;

namespace FantasyFighter
{
    public class GameEngine
    {
        private List<Enemy>? _enemies;

        private Enemy? _currentEnemy; 

        private Hero? _player;

        public bool IsGameRunning { get; private set; }

        public GameEngine()
        {
            this._enemies = new List<Enemy>()
            {
                new Dragon("Red Dragon"),
                new Dragon("Golden Dragon"),
                new Goblin("Goblin #1"),
                new Goblin("Goblin #2"),
                new Troll("Trollone"),
                new Slime("Slime viscido"),
                new Slime("Slime ruvido")
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
            var playerName = this.GetPlayerName();

            // chiedere al giocatore di scegliere un ruolo
            var playerRole = this.GetPlayerRole();

            // costruire il nostro hero
            this._player = new Hero(playerName, playerRole);

            // stampa le informazioni relative al personaggio
            this.DisplayNewHero();
        }

        public void NextTurn()
        {
            throw new NotImplementedException();
        }


        private void DisplayNewHero()
        {
            Console.WriteLine($"\n\nWelcome {this._player?.Name}, your new adventure is about to start");
            Console.WriteLine($"As a {this._player?.Role}, you'll have to defeat all your enemies and survive. Are you up for this task?");
            Console.WriteLine(@$"These are your stats: 
Health: {this._player?.Health}
Attack points: {this._player?.AttackPoints}
Defense points: {this._player?.DefensePoints}");
        }

        private string GetPlayerName()
        {
            string? name = null;

            do
            {
                Console.WriteLine("Please choose your name");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("The name cannot be empty or white spaces");


            } while (string.IsNullOrWhiteSpace(name));

            return name!;
        }

        private Roles GetPlayerRole()
        {
            var role = Roles.Undefined;

            do
            {
                Console.WriteLine("Now choose your role\n");

                // Per il simbolo @ in una stringa (verbatim string) si veda
                // https://learn.microsoft.com/it-it/dotnet/csharp/language-reference/tokens/verbatim
                var roles = @"
[1] Warrior
[2] Cleric,
[3] Rogue,
[4] Mage";

                Console.WriteLine(roles);

                var key = Console.ReadKey().KeyChar.ToString();

                role = key switch
                {
                    "1" => Roles.Warrior,
                    "2" => Roles.Cleric,
                    "3" => Roles.Rogue,
                    "4" => Roles.Mage,
                    _ => Roles.Undefined
                };

                if (role == Roles.Undefined)
                    Console.WriteLine("\nPlease select a valid role from the list");
            } while (role == Roles.Undefined);

            return role;
        }

        private void DisplayWelcomeMessage()
        {
            Console.WriteLine("Messaggio di benvuto....\n");
        }
    }
}
