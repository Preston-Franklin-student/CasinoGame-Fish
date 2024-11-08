public class Helpers {
    public static void Typing(string words, int delay = 25, bool skippable = true)
    {
        if (Program.gameState.drunkLevel > 2 || Program.gameState.loseSwitch)
            words = "?????";
        foreach (char letter in words)
        {
            if (HasPressed(ConsoleKey.Enter) && skippable)
                delay=0;

            Thread.Sleep(delay);
            Console.Write(letter);
        }
        Console.WriteLine();
    }

    public static void SkippableDelay(int ms) {
        for (int i=0; i < ms; i+=25) {
            if (HasPressed(ConsoleKey.Enter))
                break;
            Thread.Sleep(25);
        }
    }

    public static bool HasPressed(ConsoleKey key, bool intercept = true) {
        return Console.KeyAvailable && Console.ReadKey(intercept: intercept).Key == key;
    }

    public static bool AskYesNo(string prompt) {
        Console.Write(prompt);
        string? result = Console.ReadLine();
        // Console.WriteLine();

        if (result == null)
            return AskYesNo(prompt);
        
        result = result.ToLower();

        if (result == "y" || result == "yes")
            return true;
        else if (result == "n" || result == "no")
            return false;
        else
            return AskYesNo(prompt);
    }

    public static string? WeightedChoice(string[] options, Dictionary<string, int> weights)
    {
        // Calculate total weight by adding all weights for the options
        int totalWeight = options.Sum(option => weights.GetValueOrDefault(option, 1));

        Random rand = new Random();
        int randomValue = rand.Next(totalWeight);

        int cumulativeWeight = 0;
        for (int i = 0; i < options.Length; i++)
        {
            // Get the weight for the current option, defaulting to 1 if not found in dictionary
            cumulativeWeight += weights.GetValueOrDefault(options[i], 1);
            
            // If the random value falls within the current cumulative weight, return this option
            if (randomValue < cumulativeWeight)
                return options[i];
        }

        return null;
    }
}