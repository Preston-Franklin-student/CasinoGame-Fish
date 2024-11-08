public class RobGame : Game
{
    public override string Name => "Rob";

    public override void Play()
    {
        int result;

        result = Rob.Play(gameState.drunkLevel >= 2);
        if (result == 0)
        {
            Console.WriteLine("You Lost");
            Console.Write("Press enter to continue.");
            Console.ReadLine();
            return;
        }
        else if (result == 1)
        {
            Random random = new Random();
            int stole = random.Next(150, 1000);
            Console.WriteLine("You successfully stole $" + stole + "!");
            gameState.money += stole;
            Console.Write("Press enter to continue.");
            Console.ReadLine();
            return;

        }
        else if (result == 2)
        {
            Random random = new Random();
            int stole = random.Next(500, 1500);
            Console.WriteLine("You successfully stole $" + stole + "!");
            gameState.money += stole;
            Console.Write("Press enter to continue.");
            Console.ReadLine();
            return;
        }
        else if (result == 3)
        {
            Random random = new Random();
            int stole = random.Next(1000, 2000);
            Console.WriteLine("You successfully stole $" + stole + "!");
            gameState.money += stole;
            Console.Write("Press enter to continue.");
            Console.ReadLine();
            return;
        }
    }
}