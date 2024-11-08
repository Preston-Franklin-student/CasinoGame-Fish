class Program
{
    public readonly static GameState gameState = new GameState();
    private readonly static Dictionary<string, Game?> games = new() {
        { "boxing", new Boxing() },
        { "coin flipping", new CoinFlip() },
        { "horses", new HorseRace() },
        { "roulette", new Roulette() },
        { "slots", new Slots() },
        { "bar", new Bar() },
        { "rob", new RobGame() },
        { "credits", new Credits() },
        { "quit", null }
    };

    private readonly static Dictionary<string, int> drunkWeights = new() {
        { "rob", 2 },
        { "bar", 4 }
    };

    private readonly static Random rnd = new Random();


    static void Main(string[] args)
    {
        string? choice = "";
        string? choiceBefore;
        int gamesInRow = 1;

        while (true)
        {
            if (rnd.Next(1, 4) == 1 && gameState.drunkLevel > 0)
                gameState.drunkLevel--;

            Console.Clear();
            Console.WriteLine($"Welcome to The Casino!\nYou can bet on {string.Join(", ", games.Keys)}.");
            Console.WriteLine($"You have ${gameState.money}");
            Console.Write($"What do you want to play ({string.Join(", ", games.Keys)})? ");
            choiceBefore = choice;
            choice = Console.ReadLine();

            if (choiceBefore?.ToLower().Equals(choice?.ToLower()) ?? false)
                gamesInRow++;
            else
                gamesInRow--;


            gameState.loseSwitch = gamesInRow > 5 || gameState.drunkLevel > 4;
            if (gameState.loseSwitch)
                Console.WriteLine("Lose Switch is Activated!");


            Helpers.SkippableDelay(400);
            if (gameState.drunkLevel > 1) {
                Console.WriteLine("u drunk?");
                choice = Helpers.WeightedChoice(games.Keys.ToArray(), drunkWeights)?.ToLower();
            }

            var res = games.GetValueOrDefault(choice ?? "", null);

            if (choice == "quit")
            {
                break;
            }
            else if (res == null)
            {
                Console.WriteLine("That game doesn't exist!");
                Helpers.SkippableDelay(1000);
                continue;
            }

            res.Play();

            if (rnd.Next(1, 21) == 20)
                games["coin flipping"]!.Play();
        }

        games["credits"]!.Play();

        Console.WriteLine($"You ended with ${gameState.money}!");
        Helpers.SkippableDelay(7000);
        Helpers.Typing("And Ur Mom!");
    }
}