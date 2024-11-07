public class Helpers {
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