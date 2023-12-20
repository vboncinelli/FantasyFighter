using FantasyFighter.Characters;

namespace FantasyFighter.Engine
{
    public class GameEngine
    {
        private List<Enemy> _enemies = new();

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

            // say 'h' to the player
            this.DisplayWelcomeMessage();

            // ask the player for a name
            var playerName = this.GetPlayerName();

            // ask the player to pick a role
            var playerRole = this.GetPlayerRole();

            // build hero
            this._player = new Hero(playerName, playerRole);

            // show hero stats
            this.DisplayNewHero();
        }

        public void NextTurn()
        {
            // TODO: Implement the turn-based game engine following these guidelines:

            // check if the game is already running.
            // if not, there shouldn't be any turn, right?

            // check if the condition for ending the game have already been met

            // if the hero isn't currently facing any enemy, 
            // pick a random enemy from the remainings in the list
            if (this._currentEnemy == null)
                this.PickupNewEnemy();

            // Let the player inspect the inventory to:
            // 1. use any consumable item
            // 2. switch weapons
            // 3. something else?

            // The player attacks the enemy using the primary weapon.
            // Calculate the player's damage points based on:
            // - initial value of attack points at instance creation
            // - Any modifier coming from the role
            // - Any modifier coming from consumable item
            // - Any modifier coming from the primary weapon
            // - Something else?

            // Now you have to calculate the defense points for the enemy
            // The calculation should look similar, but in this case you have
            // to consider the modifier(s) for the enemies (both generic and specific).

            // attackPoints - defensePoints = damage inflicted to the enemy in this turn.
            // Decrease the health of the enemy until it reaches 0 or below.

            // If the enemy is still alive,
            // the next step should be to calculate the enemy attack points,
            // same as before. 
            // Once you have calculated the hero's defense points
            // (taking into account all the available modifiers),
            // you can calculate the damage points taken by the hero and adjust the hero's health.

            // if the hero's health at the end of the turn is <= 0, the hero is dead.
            // End the game properly. If the hero is still alive, the game continues.

            // if the enemy, having subtracted the damage points, is dead, 
            // it should be removed from the list of enemies and
            // the current enemy should be set to null.

            // if this was the last enemy in the list, the hero has won.
            // Handle this scenario and end the game properly.
        }

        private void PickupNewEnemy()
        {
            var rnd = new Random().Next(this._enemies.Count);
            this._currentEnemy = this._enemies[rnd];
        }

        private void DisplayNewHero()
        {
            Console.WriteLine($"\n\nWelcome {this._player?.Name}, your new adventure is about to start");
            Console.WriteLine($"As a {this._player?.Role}, you'll have to defeat all your enemies and survive. Are you up for this task?");
            Console.WriteLine($"These are your stats:\nHealth: {this._player?.Health}\nAttack points: {this._player?.AttackPoints}\nDefence points: {this._player?.DefencePoints}");
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

                var roles = "[1] Warrior\n[2] Cleric\n[3] Rogue\n[4] Mage";

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
