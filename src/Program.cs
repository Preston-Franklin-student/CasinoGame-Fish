
class Program
{
    public static GameState gameState = new GameState();
    private static Dictionary<string, Game> games = new() {
        { "boxing", new Boxing() },
        { "coin flipping", new CoinFlip() },
        { "horses", new HorseRace() },
        { "roulette", new Roulette() },
        { "slots", new Slots() },
        { "bar", new Bar() }
    };


    static void Main(string[] args)
    {
        string choice = "";
        int gamesInRow = 1;
        string choiceBefore;
        int result;
        string[] drunkChoiceList = { "rob", "rob", "boxing", "horses", "jack", "slots", "poker", "coin", "credits", "bar", "bar", "bar", "bar", "quit" };
        while (choice.ToLower() != "quit")
        {
            Random undoDrunk = new Random();
            if (undoDrunk.Next(1, 4) == 1 && gameState.drunkLevel > 0)
                gameState.drunkLevel--;
            Console.Clear();
            Console.WriteLine($"Welcome to The Casino!\nYou can bet on boxing, horse racing, blackjack, slots, poker, coin flipping, roulette, rob the casino, or quit.\nYou have ${gameState.money}.");
            Console.Write("What do you want to play (boxing, horses, jack, slots, poker, coin, spin, rob, quit)? ");
            choiceBefore = choice;
            choice = Console.ReadLine();
            if (choiceBefore.ToLower().Equals(choice.ToLower()))
                gamesInRow++;
            else
                gamesInRow -= gamesInRow - 1;
            if (gamesInRow > 5 || gameState.drunkLevel > 4)
                gameState.loseSwitch = true;
            else
                gameState.loseSwitch = false;
            if (gameState.loseSwitch)
                Console.WriteLine("Lose Switch is Activated!");
            Thread.Sleep(400);
            if (gameState.drunkLevel > 1)
            {
                Random drunkCoice = new Random();
                choice = drunkChoiceList[drunkCoice.Next(0, 14)];
            }
            switch (choice.ToLower())
            {
                case "boxing":
                    new Boxing().PlayGame();
                    break;
                case "slots":
                    new Slots().PlayGame();
                    break;
                case "rob":
                    result = Rob.Play(gameState.drunkLevel >= 2);
                    if (result == 0)
                    {
                        Console.WriteLine("You Lost");
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    else if (result == 1)
                    {
                        Random random = new Random();
                        int stole = random.Next(150, 1000);
                        Console.WriteLine("You successfully stole $" + stole + "!");
                        gameState.money += stole;
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    else if (result == 2)
                    {
                        Random random = new Random();
                        int stole = random.Next(500, 1500);
                        Console.WriteLine("You successfully stole $" + stole + "!");
                        gameState.money += stole;
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    else if (result == 3)
                    {
                        Random random = new Random();
                        int stole = random.Next(1000, 2000);
                        Console.WriteLine("You successfully stole $" + stole + "!");
                        gameState.money += stole;
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    else if (result == 4)
                    {
                        break;
                    }
                    break;
                case "coin":
                    new CoinFlip().PlayGame();
                    break;
                case "credits":
                    Credits();
                    break;
                case "bar":
                    new Bar().PlayGame();
                    break;
                case "horses":
                    new HorseRace().PlayGame();
                    break;
                case "spin":
                    new Roulette().PlayGame();
                    break;
                default:
                    break;
            }
            Random randy = new Random();
            int coinflip = randy.Next(1, 21);
            if (coinflip == 20)
            {
                new CoinFlip().PlayGame();
            }
        }
        Credits();
        Console.WriteLine($"You ended with ${gameState.money}!");
        Helpers.SkippableDelay(7000);
        Helpers.Typing("And Ur Mom!");
    }

    static void Credits()
    {
        int delay = 50;

        foreach (string key in Constants.Credits.Keys) {
            Helpers.Typing(key, delay);
            foreach (string value in Constants.Credits[key]) {
                if (Helpers.HasPressed(ConsoleKey.Enter))
                    delay = 0;

                Helpers.Typing($" - {value}", delay);
                Thread.Sleep(delay == 0 ? 0 : 100);
            }
            Thread.Sleep(delay == 0 ? 0 : 250);
        }
    }
}