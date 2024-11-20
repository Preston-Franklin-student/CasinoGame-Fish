public class HorseRace : Game
{
    public override string Name => "Horse Race";

    public override void Play()
    {
        //🐎◼️🔲🚜🐌🐈‍⬛
        //🏇🐟🎠🐝🐅🦮
        Console.Clear();
        string animal = "Horse";
        string e = "🏇";
        Console.WriteLine("Do you want to spend $150 on Horse Racing (Yes/No)");
        string play = Console.ReadLine() ?? "";
        if(gameState.money > 150 && (play.ToLower().Equals("yes") || play.ToLower().Equals("y"))){
        Console.Clear();
        Random ran = new Random();
        string[] hName = {Constants.nameList[ran.Next(Constants.nameList.Count)],Constants.nameList[ran.Next(Constants.nameList.Count)],Constants.nameList[ran.Next(Constants.nameList.Count)],Constants.nameList[ran.Next(Constants.nameList.Count)],Constants.nameList[ran.Next(Constants.nameList.Count)]};
        int[] amount = new int[5];
        int[] speed = {ran.Next(1, 5),ran.Next(1, 5),ran.Next(1, 5),ran.Next(1, 5),ran.Next(1, 5)};
        for (int x = 0; x < 5; x++)
        switch (speed[x])
        {
            case 1:
                amount[x] = 5000;
                break;
            case 2:
                amount[x] = 2500;
                break;
            case 3:
                amount[x] = 1000;
                break;
            case 4:
                amount[x] = 500;
                break;
            default:
                amount[x] = 7192000;
                break;
        }
        int bet;
        Console.WriteLine("Welcome to the Horse Race!\nYou are just in time to see them start!\nTake Your bets");
        switch(Program.printablePlayerName){
            case "Fish":
            e = "🐟";
            animal = "Fish";
            break;
            case "Jacob":
            e = "🐅";
            animal = "Fox";
            break;
            case "Evan":
            e = "🚜";
            animal = "Tractor";
            break;
            case "Preston":
            e = "🐌";
            animal = "Snail";
            break;
            case "Clyde":
            e = "🐝";
            animal = "Bee";
            break;
            case "Will":
            e = "🎠";
            animal = "Plastic Horse";
            break;
            case "Yosgart":
            e = "🐈‍⬛";
            animal = "Cat";
            break;
            default:
            break;
        }

        while (true)
        {
            if(!gameState.loseSwitch)
            Console.WriteLine($"{hName[0]}'s {animal}: {animal} 1  Speed: {speed[0]}  Pot if win: ${amount[0]}\n{hName[1]}'s {animal}: {animal} 2  Speed: {speed[1]}  Pot if win: ${amount[1]}\n{hName[2]}'s {animal}: {animal} 3  Speed: {speed[2]}  Pot if win: ${amount[2]}\n{hName[3]}'s {animal}: {animal} 4  Speed: {speed[3]}  Pot if win: ${amount[3]}\n{hName[4]}'s {animal}: {animal} 5  Speed: {speed[4]}  Pot if win: ${amount[4]}");
            else
            Console.WriteLine($"{hName[0]}'s {animal}: {animal} 1  Speed: ???  Pot if win: $???\n{hName[1]}'s {animal}: {animal} 2  Speed: ???  Pot if win: $???\n{hName[2]}'s {animal}: {animal} 3  Speed: ???  Pot if win: $???\n{hName[3]}'s {animal}: {animal} 4  Speed: ???  Pot if win: $???\n{hName[4]}'s {animal}: {animal} 5  Speed: ???  Pot if win: $???");
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
        int[] horse = {29,29,29,29,29};
        track1[horse[0]] = e;
        track2[horse[1]] = e;
        track3[horse[2]] = e;
        track4[horse[3]] = e;
        track5[horse[4]] = e;
        int[] move = new int[5];
        int whoWins = 1331;
        bool stop = false;
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"You bet on {bet}");
            for(int x = 0; x < 5; x++)
            move[x] = 0;
            Console.Write("|_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_|\n🔲\n◼️  ");
            foreach (string y in track1)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed[0] + "\n🔲\n F ");
            foreach (string y in track2)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed[1] + "\n🔲\n I ");
            foreach (string y in track3)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed[2] + "\n🔲\n N ");
            foreach (string y in track4)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed[3] + "\n🔲\n◼️  ");
            foreach (string y in track5)
                Console.Write(" " + y);
            Console.Write("|-| Speed " + speed[4] + "\n🔲\n");
            Console.WriteLine("|_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_|");
            for (int x = 0; x < 3; x++)
            {
                for(int y = 0; y < 5;y++)
                move[y] += ran.Next(-speed[y], speed[y] + 2);
            }
            for (int x = 0; x < 5;x++)
            if (move[x] < 0)
                move[x] = 0;
            for(int x = 0; x < 5; x++)
            if (horse[x] - move[x] - 1 <= 0)
            {
                whoWins = x + 1;
                stop = true;
                break;
            }
            if(stop)
            break;
            track1[horse[0] - move[0] - 1] = track1[horse[0]];
            track1[horse[0]] = "~~";
            horse[0] -= move[0] + 1;
            track2[horse[1] - move[1] - 1] = track2[horse[1]];
            track2[horse[1]] = "~~";
            horse[1] -= move[1] + 1;
            track3[horse[2] - move[2] - 1] = track3[horse[2]];
            track3[horse[2]] = "~~";
            horse[2] -= move[2] + 1;
            track4[horse[3] - move[3] - 1] = track4[horse[3]];
            track4[horse[3]] = "~~";
            horse[3] -= move[3] + 1;
            track5[horse[4] - move[4] - 1] = track5[horse[4]];
            track5[horse[4]] = "~~";
            horse[4] -= move[4] + 1;
            Thread.Sleep(2000);
        }
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine($"\n\n   ___🐎____\n  |    #1   |\n  | Horse {whoWins} |");
        if (bet == whoWins)
        {
            Console.Write("You win $");
            switch(bet){
                case 1:
                Console.WriteLine(amount[0]);
                gameState.money += amount[0];
                break;
                case 2:
                Console.WriteLine(amount[1]);
                gameState.money += amount[1];
                break;
                case 3:
                Console.WriteLine(amount[2]);
                gameState.money += amount[2];
                break;
                case 4:
                Console.WriteLine(amount[3]);
                gameState.money += amount[3];
                break;
                case 5:
                Console.WriteLine(amount[4]);
                gameState.money += amount[4];
                break;
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