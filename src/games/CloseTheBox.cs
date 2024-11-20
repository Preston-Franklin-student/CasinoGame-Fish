public class CloseTheBox : Game
{
    public override string Name => "close the box";

    public override void Play()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Close the Box\nDo you want to pay $12");
        if (!(Console.ReadLine().ToLower().Equals("no") || gameState.money < 12))
        {
            Console.Clear();
            gameState.money -= 12;
            string[] roof = { "___", "___", "___", "___", "___", "___", "___", "___", "___", "____", "____", "____" };
            string[] boxes = { "|1|", "|2|", "|3|", "|4|", "|5|", "|6|", "|7|", "|8|", "|9|", "|10|", "|11|", "|12|" };
            string[] aMid = { ":-:", ":-:", ":-:", ":-:", ":-:", ":-:", ":-:", ":-:", ":-:", ":--:", ":--:", ":--:" };
            string[] empty = { "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "    ", "    ", "    " };
            string[] aFterMid = { "+_+", "+_+", "+_+", "+_+", "+_+", "+_+", "+_+", "+_+", "+_+", "+__+", "+__+", "+__+" };
            string[] closed = { "|_|", "|_|", "|_|", "|_|", "|_|", "|_|", "|_|", "|_|", "|_|", "|__|", "|__|", "|__|" };
            bool[] openOClosed = { true, true, true, true, true, true, true, true, true, true, true, true };
            int[] dice = {6, 6};
            Random randy = new Random();
            int isOnTwo = 0;
            int choice = 177;
            int leftOpen = 0;
            Console.WriteLine($"The rules, there will be 12 boxes.\nYou roll two die and can flip a box with each one of your dice or both of your die combined.\nYour goal is to flip all of the boxes over without not having a choice\nIf you finish with less than 4 you get a prize\n3 left: $25\n2 left: $100\n1 left: $250\nAll Gone: $1000\nDice = [{randy.Next(1, 6)}]\nGood luck and press enter to continue.");
            Console.ReadLine();
            while (true)
            {
                Console.Clear();
                for (int a = 0; a < 4; a++)
                {
                    if (a != 0)
                    {
                        Console.WriteLine($"\n           [{dice[0]}]\n                [{dice[1]}]");
                        Thread.Sleep(200);
                    }
                    Console.Clear();
                    for (int y = 0; y < 2; y++)
                    {
                        for (int x = 0; x < 12; x++)
                        {
                            if (!openOClosed[x] && x == choice - 1)
                            {
                                if (a == 0)
                                {
                                    if (y == 0)
                                        Console.Write(roof[x]);
                                    if (y == 1)
                                        Console.Write(boxes[x]);
                                }
                                else if (a == 1)
                                {
                                    if (y == 0)
                                        Console.Write(empty[x]);
                                    if (y == 1)
                                        Console.Write(aMid[x]);
                                }
                                else
                                    Console.Write(empty[x]);
                            }
                            else if (openOClosed[x])
                            {
                                if (y == 0)
                                    Console.Write(roof[x]);
                                if (y == 1)
                                    Console.Write(boxes[x]);
                            }
                            else
                                Console.Write(empty[x]);
                        }
                        Console.WriteLine();
                    }
                    for (int x = 0; x < 12; x++)
                    {
                        if (!openOClosed[x] && x == choice - 1)
                        {
                            if (a < 2)
                                Console.Write(empty[x]);
                            else if (a == 2)
                                Console.Write(aFterMid[x]);
                            else
                                Console.Write(closed[x]);
                        }
                        else if (!openOClosed[x])
                        {
                            Console.Write(closed[x]);
                        }
                        else
                            Console.Write(empty[x]);
                    }
                }
                if (isOnTwo % 2 == 0)
                    for (int i = 0; i < 2; i++)
                        dice[i] = randy.Next(1, 7);
                Console.WriteLine($"\n           [{dice[0]}]\n                [{dice[1]}]");
                if (!(openOClosed[dice[0]- 1] || openOClosed[dice[1]-1])){
                if (!(dice[0] + dice[1] < 12 && openOClosed[dice[0] + dice[1] - 1]))
                    break;
                else
                if (isOnTwo % 2 == 1)
                    break;
                }
                Console.WriteLine("Enter your numbers based on the die:");
                while (true)
                {
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        if (openOClosed[choice - 1] && (choice == dice[0] || choice == dice[1] || (choice == (dice[0] + dice[1]) && (isOnTwo % 2) == 0)))
                        {
                            if (choice == (dice[0] + dice[1]))
                                isOnTwo++;
                            openOClosed[choice - 1] = false;
                            break;
                        }
                        else
                            Console.WriteLine("That one is not available!");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("That is not a number!");
                    }
                }
                isOnTwo++;
            }
            for (int x = 0; x < 12; x++)
                if (openOClosed[x])
                    leftOpen++;
            switch (leftOpen)
            {
                case 3:
                    Console.WriteLine("You earned some money back\nNot $25 Bad");
                    gameState.money += 25;
                    break;
                case 2:
                    Console.WriteLine("This is a good cash back\nNicely $250 Done!");
                    gameState.money += 250;
                    break;
                case 1:
                    Console.WriteLine("Good Job You were So Close!\nGreat $500 Work!!");
                    gameState.money += 500;
                    break;
                case 0:
                    Console.WriteLine("You just... Won? Thats Crazy LUCK Amazing Job!\nJack $1000 Pot!!!");
                    gameState.money += 1000;
                    break;
                default:
                    Console.WriteLine("You win a fun experience, Come back soon");
                    break;
            }
        }
        else
            Console.WriteLine("It seems cheap to me, but to each their own");
        Thread.Sleep(300);
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }
}