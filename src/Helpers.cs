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

    public static void DisplayPlayerStats(GameState gameState, string player, int damage, int defense, int health, int speed)
    {
        if (!gameState.loseSwitch){
            Random random = new Random();
            int unknown = random.Next(1,5);
            if (unknown == 1){
                string damageStat = "?";
                int defenseStat = defense;
                int healthStat = health;
                int speedStat = speed;
                Console.WriteLine($"{player}'s stats:");
                Console.WriteLine($"Attack: {damageStat}");
                Console.WriteLine($"Defense: {defenseStat}");
                Console.WriteLine($"Health: {healthStat}");
                Console.WriteLine($"Speed: {speedStat}");
            } else if (unknown == 2){
                int damageStat = damage;
                string defenseStat = "?";
                int healthStat = health;
                int speedStat = speed;
                Console.WriteLine($"{player}'s stats:");
                Console.WriteLine($"Attack: {damageStat}");
                Console.WriteLine($"Defense: {defenseStat}");
                Console.WriteLine($"Health: {healthStat}");
                Console.WriteLine($"Speed: {speedStat}");
            } else if (unknown == 3){
                int damageStat = damage;
                int defenseStat = defense;
                string healthStat = "?";
                int speedStat = speed;
                Console.WriteLine($"{player}'s stats:");
                Console.WriteLine($"Attack: {damageStat}");
                Console.WriteLine($"Defense: {defenseStat}");
                Console.WriteLine($"Health: {healthStat}");
                Console.WriteLine($"Speed: {speedStat}");
            } else {
                int damageStat = damage;
                int defenseStat = defense;
                int healthStat = health;
                string speedStat = "?";
                Console.WriteLine($"{player}'s stats:");
                Console.WriteLine($"Attack: {damageStat}");
                Console.WriteLine($"Defense: {defenseStat}");
                Console.WriteLine($"Health: {healthStat}");
                Console.WriteLine($"Speed: {speedStat}");
            }
        } else{
            string damageStat = "?";
            string defenseStat = "?";
            string healthStat = "?";
            string speedStat = "?";
            Console.WriteLine($"{player}'s stats:");
            Console.WriteLine($"Attack: {damageStat}");
            Console.WriteLine($"Defense: {defenseStat}");
            Console.WriteLine($"Health: {healthStat}");
            Console.WriteLine($"Speed: {speedStat}");
        }
        
    }
}