public class Helpers {
    public static void Typing(string words, int delay = 100)
    {
        if (Program.gameState.drunkLevel > 2 || Program.gameState.loseSwitch)
            words = "?????";
        foreach (char letter in words)
        {
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
}