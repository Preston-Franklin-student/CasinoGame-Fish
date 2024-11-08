public class HorseRace : Game
{
    public override string Name => "Horse Race";

    public override void Play()
    {
        //🐎◼️🔲
        Console.Clear();
        Console.WriteLine("Do you want to spend $150 on Horse Racing (Yes/No)");
        string play = Console.ReadLine() ?? "";
        if(gameState.money > 150 && (play.ToLower().Equals("yes") || play.ToLower().Equals("y"))){
        Console.Clear();
        Random ran = new Random();
        string h1 = Constants.nameList[ran.Next(Constants.nameList.Count)];
        string h2 = Constants.nameList[ran.Next(Constants.nameList.Count)];
        string h3 = Constants.nameList[ran.Next(Constants.nameList.Count)];
        string h4 = Constants.nameList[ran.Next(Constants.nameList.Count)];
        string h5 = Constants.nameList[ran.Next(Constants.nameList.Count)];
        int amount1;
        int amount2;
        int amount3;
        int amount4;
        int amount5;
        int speed1 = ran.Next(1, 5);
        int speed2 = ran.Next(1, 5);
        int speed3 = ran.Next(1, 5);
        int speed4 = ran.Next(1, 5);
        int speed5 = ran.Next(1, 5);
        switch (speed1)
        {
            case 1:
                amount1 = 5000;
                break;
            case 2:
                amount1 = 2500;
                break;
            case 3:
                amount1 = 1000;
                break;
            case 4:
                amount1 = 500;
                break;
            default:
                amount1 = 7192000;
                break;
        }
        switch (speed2)
        {
            case 1:
                amount2 = 5000;
                break;
            case 2:
                amount2 = 2500;
                break;
            case 3:
                amount2 = 1000;
                break;
            case 4:
                amount2 = 500;
                break;
            default:
                amount2 = 7192000;
                break;
        }
        switch (speed3)
        {
            case 1:
                amount3 = 5000;
                break;
            case 2:
                amount3 = 2500;
                break;
            case 3:
                amount3 = 1000;
                break;
            case 4:
                amount3 = 500;
                break;
            default:
                amount3 = 7192000;
                break;
        }
        switch (speed4)
        {
            case 1:
                amount4 = 5000;
                break;
            case 2:
                amount4 = 2500;
                break;
            case 3:
                amount4 = 1000;
                break;
            case 4:
                amount4 = 500;
                break;
            default:
                amount4 = 7192000;
                break;
        }
        switch (speed5)
        {
            case 1:
                amount5 = 5000;
                break;
            case 2:
                amount5 = 2500;
                break;
            case 3:
                amount5 = 1000;
                break;
            case 4:
                amount5 = 500;
                break;
            default:
                amount5 = 7192000;
                break;
        }
        int bet;
        Console.WriteLine("Welcome to the Horse Race!\nYou are just in time to see them start!\nTake Your bets");
        while (true)
        {
            if(!gameState.loseSwitch)
            Console.WriteLine($"{h1}'s Horse: Horse 1  Speed: {speed1}  Pot if win: ${amount1}\n{h2}'s Horse: Horse 2  Speed: {speed2}  Pot if win: ${amount2}\n{h3}'s Horse: Horse 3  Speed: {speed3}  Pot if win: ${amount3}\n{h4}'s Horse: Horse 4  Speed: {speed4}  Pot if win: ${amount4}\n{h5}'s Horse: Horse 5  Speed: {speed5}  Pot if win: ${amount5}");
            else
            Console.WriteLine($"{h1}'s Horse: Horse 1  Speed: ???  Pot if win: $???\n{h2}'s Horse: Horse 2  Speed: ???  Pot if win: $???\n{h3}'s Horse: Horse 3  Speed: ???  Pot if win: $???\n{h4}'s Horse: Horse 4  Speed: ???  Pot if win: $???\n{h5}'s Horse: Horse 5  Speed: ???  Pot if win: $???");
            Console.WriteLine("Enter a number:");
            try
            {
                bet = int.Parse(Console.ReadLine() ?? "");
            }
            catch (Exception)
            {
                Console.WriteLine("Not a horse number!");
                continue;
            }
            if (bet > 5 || bet < 1)
            {
                Console.WriteLine("Not a horse number!");
                continue;
            }
            Console.WriteLine($"You bet on {bet}");
            Thread.Sleep(1500);
            break;
        }
        string[] track1 = new String[30];
        string[] track2 = new String[30];
        string[] track3 = new String[30];
        string[] track4 = new String[30];
        string[] track5 = new String[30];
        for (int x = 0; x < 29; x++)
        {
            track1[x] = "~~";
            track2[x] = "~~";
            track3[x] = "~~";
            track4[x] = "~~";
            track5[x] = "~~";
        }
        int horse1 = 29;
        int horse2 = 29;
        int horse3 = 29;
        int horse4 = 29;
        int horse5 = 29;
        track1[horse1] = "🐎";
        track2[horse2] = "🐎";
        track3[horse3] = "🐎";
        track4[horse4] = "🐎";
        track5[horse5] = "🐎";
        int move1;
        int move2;
        int move3;
        int move4;
        int move5;
        int whoWins;
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"You bet on {bet}");
            move1 = 0;
            move2 = 0;
            move3 = 0;
            move4 = 0;
            move5 = 0;
            Console.Write("|_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_|\n🔲\n◼️  ");
            foreach (string y in track1)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed1 + "\n🔲\n F ");
            foreach (string y in track2)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed2 + "\n🔲\n I ");
            foreach (string y in track3)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed3 + "\n🔲\n N ");
            foreach (string y in track4)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed4 + "\n🔲\n◼️  ");
            foreach (string y in track5)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed5 + "\n🔲\n");
            Console.WriteLine("|_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_|");
            for (int x = 0; x < 3; x++)
            {
                move1 += ran.Next(-speed1, speed1 + 2);
                move2 += ran.Next(-speed2, speed2 + 2);
                move3 += ran.Next(-speed3, speed3 + 2);
                move4 += ran.Next(-speed4, speed4 + 2);
                move5 += ran.Next(-speed5, speed5 + 2);
            }
            if (move1 < 0)
                move1 = 0;
            if (move2 < 0)
                move2 = 0;
            if (move3 < 0)
                move3 = 0;
            if (move4 < 0)
                move4 = 0;
            if (move5 < 0)
                move5 = 0;
            if (horse1 - move1 - 1 <= 0)
            {
                whoWins = 1;
                break;
            }
            if (horse2 - move2 - 1 <= 0)
            {
                whoWins = 2;
                break;
            }
            if (horse3 - move3 - 1 <= 0)
            {
                whoWins = 3;
                break;
            }
            if (horse4 - move4 - 1 <= 0)
            {
                whoWins = 4;
                break;
            }
            if (horse5 - move5 - 1 <= 0)
            {
                whoWins = 5;
                break;
            }
            track1[horse1 - move1 - 1] = track1[horse1];
            track1[horse1] = "~~";
            horse1 -= move1 + 1;
            track2[horse2 - move2 - 1] = track2[horse2];
            track2[horse2] = "~~";
            horse2 -= move2 + 1;
            track3[horse3 - move3 - 1] = track3[horse3];
            track3[horse3] = "~~";
            horse3 -= move3 + 1;
            track4[horse4 - move4 - 1] = track4[horse4];
            track4[horse4] = "~~";
            horse4 -= move4 + 1;
            track5[horse5 - move5 - 1] = track5[horse5];
            track5[horse5] = "~~";
            horse5 -= move5 + 1;
            Thread.Sleep(2000);
        }
        Console.Clear();
        Console.WriteLine($"\n\n   ___🐎____\n  |    #1   |\n  | Horse {whoWins} |");
        if (bet == whoWins)
        {
            Console.Write("You win $");
            if (bet == 1)
            {
                Console.WriteLine(amount1);
                gameState.money += amount1;
            }
            if (bet == 2)
            {
                Console.WriteLine(amount2);
                gameState.money += amount2;
            }
            if (bet == 3)
            {
                Console.WriteLine(amount3);
                gameState.money += amount3;
            }
            if (bet == 4)
            {
                Console.WriteLine(amount4);
                gameState.money += amount4;
            }
            if (bet == 5)
            {
                Console.WriteLine(amount5);
                gameState.money += amount5;
            }
        }
        else{
            Console.WriteLine("You bet wrong!\nYou lose $150");
            gameState.money -= 150;
        }
    }
    else
    Console.WriteLine("You don't have $150 dollars, Really?");
    Thread.Sleep(8000);
    }
}