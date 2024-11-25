class Program
{
    public static string? printablePlayerName;
    public readonly static GameState gameState = new GameState();
    private readonly static Dictionary<string, Game?> games = new() {
        { "boxing", new Boxing() },
        { "coin flipping", new CoinFlip() },
        { "horses", new HorseRace() },
        { "roulette", new Roulette() },
        { "slots", new Slots() },
        { "close the box", new CloseTheBox()},
        { "bar", new Bar() },
        { "rob", new RobGame() },
        { "quit", null }
    };

    private readonly static Dictionary<string, int> drunkWeights = new() {
        { "rob", 2 },
        { "bar", 4 }
    };

    private readonly static Random rnd = new Random();


    static void Main(string[] args)
    {
        Console.Clear();
        string? playerName = null;
        bool isIn = false;
        while (playerName == null || playerName == ""){
            Console.Write("Enter your name: ");
            playerName = Console.ReadLine();
        }
        foreach (string i in Constants.nameList){
            if (i.ToLower() == playerName.ToLower()) isIn = true;
        }
        string? choice = null;
        string? choiceBefore;
        int gamesInRow = 1;

        while (true)
        {
            if (rnd.Next(1, 4) == 1 && gameState.drunkLevel > 0)
                gameState.drunkLevel--;
            printablePlayerName = playerName[0].ToString().ToUpper() + playerName.Remove(0,1);
            Console.Clear();
            if (isIn)Console.WriteLine($"Welcome back to The Casino, {printablePlayerName}!");
            else Console.WriteLine($"Welcome to The Casino, {printablePlayerName}!");
            Console.WriteLine($"You can bet on {string.Join(", ", games.Keys)}.");
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

            var res = games.GetValueOrDefault(choice?.ToLower() ?? "", null);

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