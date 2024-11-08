public class Slots : Game
{
    public override string Name => "Slots";

    public override void PlayGame()
    {
        int biggest = 5;
        if (gameState.loseSwitch)
            biggest += 2;

        Console.Clear();
        Random random = new Random();
        
        Console.WriteLine("$25 to play!");
        bool yesNo = Helpers.AskYesNo("Do you want to play (yes/no)?");

        if (yesNo || gameState.money < 25)
        {
            Console.WriteLine("Too much, huh?!?!?");
            return;
        }


        int num1 = random.Next(1, biggest);
        int num2 = random.Next(1, biggest);
        int num3 = random.Next(1, biggest);
        gameState.money -= 25;
        Console.WriteLine($"You have ${gameState.money}");
        int exit = 0;
        int longerAnimation = 5;
        Console.WriteLine("Press f to pull the Lever");
        while (Console.ReadKey().Key != ConsoleKey.F) { Thread.Sleep(25); }

        while (exit != 1 || longerAnimation > 0)
        {
            longerAnimation--;
            exit = random.Next(1, biggest);
            num1 = random.Next(1, biggest);
            Console.Clear();
            Console.WriteLine($"[ {num1}  {num2}  {num3} ]");
            Thread.Sleep(100);
            num2 = random.Next(1, biggest);
            Console.Clear();
            Console.WriteLine($"[ {num1}  {num2}  {num3} ]");
            Thread.Sleep(100);
            num3 = random.Next(1, biggest);
            Console.Clear();
            Console.WriteLine($"[ {num1}  {num2}  {num3} ]");
            Thread.Sleep(100);
        }

        Console.Clear();
        Console.WriteLine($"[ {num1}  {num2}  {num3} ]");

        if (num1 == num2 && num2 == num3)
        {
            switch (num1)
            {
                case 1: gameState.money += 26; Console.WriteLine("You Won $26"); break;
                case 2: gameState.money += 100; Console.WriteLine("You Won $100"); break;
                case 3: gameState.money += 1000; Console.WriteLine("You Won $1000"); break;
                case 4: gameState.money += 2000; Console.WriteLine("You Won $2000! JACKPOT!"); break;
            }
        }
        else
        {
            Console.WriteLine("You lose!");
        }

        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }
}