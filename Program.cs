using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static int money = 200;
    static List<string> nameList = new List<string> { "Bob", "Jeffery", "Yosgart", "Jacob", "Fish", "Will", "Mr. Luyk", "Clyde", "Evan", "Trevor", "Grank", "Justin", "Coby", "Jack", "John", "Chase", "Caleb", "Preston", "Mr. Martinez", "Alec" };
    static bool loseSwitch = false;
    static int isDrunk = 0;
    static void Main(string[] args)
    {
        string choice = "";
        int gamesInRow = 1;
        string choiceBefore;
        int result;
        string[] drunkChoiceList = {"rob","rob","rob","boxing","horses","jack","slots","poker","coin","credits","bar","bar","bar","bar","quit"};
        while (choice.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine($"Welcome to The Casino!\nYou can bet on boxing, horse racing, blackjack, slots, poker, coin flipping, rob the casino, or quit.\nYou have ${money}.");
            Console.Write("What do you want to play (boxing, horses, jack, slots, poker, coin, rob, quit)? ");
            choiceBefore = choice;
            choice = Console.ReadLine();
            if(choiceBefore.ToLower().Equals(choice.ToLower()))
            gamesInRow++;
            else
            gamesInRow -= gamesInRow - 1;
            if(gamesInRow > 5 || isDrunk > 4)
            loseSwitch = true;
            else
            loseSwitch = false;
            if(loseSwitch)
            Console.WriteLine("Lose Switch is Activated!");
            Thread.Sleep(400);
            if (isDrunk > 1){
                Random drunkCoice = new Random();
                choice = drunkChoiceList[drunkCoice.Next(0,14)];
            }
            switch (choice.ToLower())
            {
                case "boxing":
                    Boxing();
                    break;
                case "slots":
                    Slots();
                    break;
                case "rob":
                    result = Rob.Play();
                    if (result == 1){
                        Random random = new Random();
                        int stole = random.Next(150,5000);
                        Console.WriteLine("You successfully stole $" + stole + "!");
                        money += stole;
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                    }
                    break;
                case "coin":
                    CoinFlip();
                    break;
                case "credits":
                    Credits();
                    break;
                case "bar":
                    isDrunk += Bar();
                    break;
                case "horses":
                    HorceRace();
                    break;
                default:
                    break;
            }
            Random randy = new Random();
            int coinflip = randy.Next(1,21);
            if (coinflip == 20){
                CoinFlip();
            }
        }
        Credits();
        Console.WriteLine($"You ended with ${money}!");
        Thread.Sleep(7000);
        string words = "And Ur Mom!";
        Typing(words);
    }

    static void DisplayPlayerStats(string player, int damage, int defense, int health, int speed)
    {
        if (!loseSwitch){
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

    static void Boxing()
    {
        Console.Clear();
        Random random = new Random();
        List<int> critNums = new List<int> { 0, 0, 0, 1, 1, 1, 1, 1, 1, 2 };
        string p1 = nameList[random.Next(nameList.Count)];
        string p2 = nameList[random.Next(nameList.Count)];

        Console.WriteLine($"{p1} and {p2} are boxing.");
        Console.WriteLine($"You have ${money}.");

        // Player 1 stats initialization
        int p1Defense = random.Next(0, 5), p1Health = random.Next(15, 21), p1Speed = random.Next(1, 11), p1Damage = random.Next(5, 11);
        DisplayPlayerStats(p1, p1Damage, p1Defense, p1Health, p1Speed);

        // Player 2 stats initialization
        int p2Defense = random.Next(0, 5), p2Health = random.Next(15, 21), p2Speed = random.Next(1, 11), p2Damage = random.Next(5, 11);
        DisplayPlayerStats(p2, p2Damage, p2Defense, p2Health, p2Speed);
        

        // Betting and game logic
        int bet;
        while (true)
        {
            Console.Write("Bet how much? ");
            try{
            bet = int.Parse(Console.ReadLine());
            }
            catch(Exception){
                Console.WriteLine("Not a number!");
                continue;
            }
            if (bet > 0 && bet <= money)
            {
                break;
            }
            Console.WriteLine("Invalid bet!");
        }

        string guess;
        while (true)
        {
            Console.Write("On who? ");
            guess = Console.ReadLine().ToLower();
            if (guess == p1.ToLower() || guess == p2.ToLower())
            {
                break;
            }
            Console.WriteLine("You can't be indifferent!");
        }
        Console.Clear();
        while (p1Health > 0 && p2Health > 0)
        {
            Console.WriteLine($"    Health: {p1Health}");
            Console.WriteLine("|--------------|");
            Console.Write("|");
            for(int i = 0;i < 14 - p1.Length ;i++){
                Console.Write(" ");
                if(i==(14-p1.Length-1)/2)
                Console.Write(p1);
            }
            Console.WriteLine("|");
            Console.WriteLine("|              |");
            Console.WriteLine("|              |");
            Console.Write("|");
            for(int i = 0;i < 14 - p2.Length ;i++){
                Console.Write(" ");
                if(i==(14-p2.Length-1)/2)
                Console.Write(p2);
            }
            Console.WriteLine("|");
            Console.WriteLine("|--------------|");
            Console.WriteLine($"    Health: {p2Health}");
            Console.Write("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            if (p1Speed > p2Speed)
            {
                // p1 attacks first
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p1Damage - p2Defense);
                Console.WriteLine($"{p1} does {damageDealt} damage to {p2}!");
                p2Health -= damageDealt;

                if (p2Health > 0)
                {
                    crit = critNums[random.Next(critNums.Count)];
                    damageDealt = crit * (p2Damage - p1Defense);
                    Console.WriteLine($"{p2} does {damageDealt} damage to {p1}!");
                    p1Health -= damageDealt;
                }
            }
            else if (p2Speed > p1Speed)
            {
                // p2 attacks first
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p2Damage - p1Defense);
                Console.WriteLine($"{p2} does {damageDealt} damage to {p1}!");
                p1Health -= damageDealt;

                if (p1Health > 0)
                {
                    crit = critNums[random.Next(critNums.Count)];
                    damageDealt = crit * (p1Damage - p2Defense);
                    Console.WriteLine($"{p1} does {damageDealt} damage to {p2}!");
                    p2Health -= damageDealt;
                }
            } else {
                int crit = critNums[random.Next(critNums.Count)];
                int damageDealt = crit * (p1Damage - p2Defense);
                Console.WriteLine($"{p1} does {damageDealt} damage to {p2}!");
                p2Health -= damageDealt;
                crit = critNums[random.Next(critNums.Count)];
                damageDealt = crit * (p2Damage - p1Defense);
                Console.WriteLine($"{p2} does {damageDealt} damage to {p1}!");
                p1Health -= damageDealt;
            }
            
        }
        Console.WriteLine("Game!");
        if ((guess == p1.ToLower() && p2Health <= 0) || (guess == p2.ToLower() && p1Health <= 0))
        {
            money += bet;
            Console.WriteLine($"You were right! You win ${bet}!\nYou now have ${money}.");
        }
        else
        {
            money -= bet;
            Console.WriteLine($"You were wrong! You lose ${bet}!\nYou now have ${money}.");
        }

        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }

    static void Slots()
    {
        int biggest = 5;
        if(loseSwitch)
        biggest += 2;
        Console.Clear();
        Random random = new Random();
        Console.WriteLine("$25 to play!");
        Console.Write("Do you want to play (yes/no)? ");
        string yesNo = Console.ReadLine();

        if (yesNo.ToLower() == "no" || money < 25)
        {
            Console.WriteLine("Too much, huh?!?!?");
        }
        else
        {
            int num1 = random.Next(1, biggest);
            int num2 = random.Next(1, biggest);
            int num3 = random.Next(1, biggest);
            money -= 25;
            Console.WriteLine($"You have ${money}");
            int exit = 0;
            int longerAnimation = 5;
            Console.WriteLine("Press f to pull the Lever");
            while(Console.ReadKey().Key != ConsoleKey.F){
            }
            while(exit != 1 || longerAnimation > 0){
            longerAnimation--;
            exit = random.Next(1,biggest);
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
                    case 1: money += 26;Console.WriteLine("You Won $26"); break;
                    case 2: money += 100;Console.WriteLine("You Won $100"); break;
                    case 3: money += 1000;Console.WriteLine("You Won $1000"); break;
                    case 4: money += 2000;Console.WriteLine("You Won $2000! JACKPOT!"); break;
                }
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }

        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }
    static void CoinFlip(){
        Console.Clear();
        Random jimmy = new Random();
        int amount = (int)(.30 * money);
        int multiply = 2;
        if(loseSwitch)
        multiply++;
        string name = nameList[jimmy.Next(nameList.Count)];
        Console.WriteLine($"{name} challenges you to a coin flip!\nThey bet you ${amount}!");
        while(true){
            Console.Write("Do you accept? (yes or no): ");
            string purple = Console.ReadLine();
            if (purple.ToLower() == "yes"){
                Console.Write("Heads or Tails? (h or t): ");
                char picked = char.Parse(Console.ReadLine());
                while(true){
                    if (picked != 'h' && picked != 't'){
                        Console.WriteLine("That's not heads or tails!");
                        Console.Write("Heads or Tails? (h or t): ");
                        picked = char.Parse(Console.ReadLine());
                        continue;
                    } else{
                        break;
                    }
                }
                string letters = "ht";
                Console.WriteLine("Flipping Coin!!");
                for (int i=0; i<3; i++){
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("");
                int coinresult = jimmy.Next(0,2);
                if (letters[coinresult] == picked){
                    if (picked == 'h'){
                        Console.WriteLine($"You were right it was heads!\nYou win ${amount}!");
                    } else{
                        Console.WriteLine($"You were right it was tails!\nYou win ${amount}!");
                    }
                    money += amount;
                } else {
                    if (picked == 't'){
                        Console.WriteLine($"You were wrong it was heads!\nYou lose ${amount}!");
                    } else{
                        Console.WriteLine($"You were wrong it was tails!\nYou lose ${amount}!");
                    }
                    money -= amount;
                }
                Thread.Sleep(5000);
                break;
            } else if (purple.ToLower() == "no"){
                Console.WriteLine($"{name} doesn't like that! You robs you of ${amount*multiply}!");
                money -= amount*multiply;
                Thread.Sleep(5000);
                break;
            } else{
                Console.WriteLine("Hey that's not an option!");
                continue;
            }
        }
        

    }
    static int Bar()
    {
        string UserAnswer;
        Console.Clear();
        if (isDrunk <= 3){
            Console.Write("You are at the bar.\nDo you want a drink for $10? (y/n): ");
            UserAnswer = Console.ReadLine();
        } else{
            Console.WriteLine("You go back to the bar and order another dwink.");
            UserAnswer = "y";
        }
        if (UserAnswer == "y")
        {
            money-= 10;
            Random rand = new Random();
            int RandNum = rand.Next(1, 4);
            Thread.Sleep(1000);
            Console.Write("You take a drink.");
            for(int i = 0; i<4; i++){
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            if (RandNum == 1)
            {
                Console.WriteLine("You feel... drunk...");
                Thread.Sleep(4000);
                return 2;
            }
            else
            {
                Console.WriteLine("Nothing happens.");
                Thread.Sleep(4000);
                return 1;
            }
        }
        else
        {
            Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
            Thread.Sleep(4000);
            return 0;
        }
    }
            static void HorceRace()
    {
        //🐎◼️🔲
        Console.Clear();
        Console.WriteLine("Do you want to spend $150 on Horse Racing (Yes/No)");
        string play = Console.ReadLine();
        if(money > 150 && (play.ToLower().Equals("yes") || play.ToLower().Equals("y"))){
        Console.Clear();
        Random ran = new Random();
        string h1 = nameList[ran.Next(nameList.Count)];
        string h2 = nameList[ran.Next(nameList.Count)];
        string h3 = nameList[ran.Next(nameList.Count)];
        string h4 = nameList[ran.Next(nameList.Count)];
        string h5 = nameList[ran.Next(nameList.Count)];
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
            if(!loseSwitch)
            Console.WriteLine($"{h1}'s Horse: Horse 1  Speed: {speed1}  Pot if win: ${amount1}\n{h2}'s Horse: Horse 2  Speed: {speed2}  Pot if win: ${amount2}\n{h3}'s Horse: Horse 3  Speed: {speed3}  Pot if win: ${amount3}\n{h4}'s Horse: Horse 4  Speed: {speed4}  Pot if win: ${amount4}\n{h5}'s Horse: Horse 5  Speed: {speed5}  Pot if win: ${amount5}");
            else
            Console.WriteLine($"{h1}'s Horse: Horse 1  Speed: ???  Pot if win: $???\n{h2}'s Horse: Horse 2  Speed: ???  Pot if win: $???\n{h3}'s Horse: Horse 3  Speed: ???  Pot if win: $???\n{h4}'s Horse: Horse 4  Speed: ???  Pot if win: $???\n{h5}'s Horse: Horse 5  Speed: ???  Pot if win: $???");
            Console.WriteLine("Enter a number:");
            try
            {
                bet = int.Parse(Console.ReadLine());
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
                money += amount1;
            }
            if (bet == 2)
            {
                Console.WriteLine(amount2);
                money += amount2;
            }
            if (bet == 3)
            {
                Console.WriteLine(amount3);
                money += amount3;
            }
            if (bet == 4)
            {
                Console.WriteLine(amount4);
                money += amount4;
            }
            if (bet == 5)
            {
                Console.WriteLine(amount5);
                money += amount5;
            }
        }
        else{
            Console.WriteLine("You bet wrong!\nYou lose $150");
            money -= 150;
        }
    }
    else
    Console.WriteLine("You don't have $150 dollars, Really?");
    Thread.Sleep(8000);
    }
    static void Credits(){
        int sleep = 0;
        Console.Clear();
        Console.WriteLine("Credits:\n");
        Console.WriteLine("Main Producer:");
        string words = "Fish";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Main Developer:");
        words = "Fish";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Concept Creators:");
        words = "Jacob Woudwyk";
        Typing(words);
        words = "Mr. Luyk";
        Typing(words);
        words = "Yosgart Garcia";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Play Testers:");
        words = "Mr. Luyk";
        Typing(words);
        words = "Coby Johnson";
        Typing(words);
        words = "Justin Boeve";
        Typing(words);
        words = "Evan Palma";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Language conversion:");
        words = "Chat GPT";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Teachers:");
        words = "Mr. Luyk";
        Typing(words);
        words = "Mr. Martinez";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Troubleshooting:");
        words = "Yosgart Garcia";
        Typing(words);
        words = "William Newson";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Animation lead:");
        words = "Clyde Hettinga";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);
        Console.WriteLine("Animation assistants:");
        words = "Fish";
        Typing(words);
        words = "Jacob Woudwyk";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Home screen:");
        words = "Fish";
        Typing(words);
        words = "Jacob Woudwyk";
        Typing(words);
        words = "Yosgart Garcia";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);
        
        Console.WriteLine("Boxing:");
        words = "Fish";
        Typing(words);
        words = "Jacob Woudwyk";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Horse racing:");
        words = "Jacob Woudwyk";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Blackjack:");
        words = "William Newson";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Slots:");
        words = "Fish";
        Typing(words);
        words = "Jacob Woudwyk";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Poker:");
        words = "Coby Johnson";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Coin flip:");
        words = "Fish";
        Typing(words);
        words = "Jacob Woudwyk";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Robbing:");
        words = "William Newson";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Bar:");
        words = "Evan Palma";
        Typing(words);
        words = "Fish";
        Typing(words);
        words = "Jacob Woudwyk";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Special thanks:");
        words = "Mr. Luyk";
        Typing(words);
        words = "Mr. Martinez";
        Typing(words);
        words = "Anthony Flowers";
        Typing(words);
        words = "Clyde Hettinga";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);

        Console.WriteLine("Credits:");
        words = "Yosgart Garcia";
        Typing(words);
        words = "Fish";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(sleep);
    }
    static void Typing(string words){
        if(isDrunk > 2 || loseSwitch)
        words = "?????";
        foreach(char letter in words){
            Thread.Sleep(100);
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}