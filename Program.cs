using System;
using System.Collections.Generic;

class Program
{
    static int money = 200;
    static List<string> nameList = new List<string> { "Bob", "Jeffery", "Yosgart", "Jacob", "Fish", "Will", "Mr. Luyk", "Clyde", "Evan", "Trevor", "Grank", "Justin", "Coby", "Jack", "John", "Chase", "Caleb", "Preston", "Mr. Martinez", "Alec" };
    static bool loseSwitch = false;
    static void Main(string[] args)
    {
        string choice = "";
        int gamesInRow = 1;
        string choiceBefore;
        bool result;
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
            if(gamesInRow > 5)
            loseSwitch = true;
            else
            loseSwitch = false;
            if(loseSwitch)
            Console.WriteLine("Lose Switch is Activated!");
            Thread.Sleep(400);
            switch (choice.ToLower())
            {
                case "boxing":
                    Boxing();
                    break;
                case "slots":
                    Slots();
                    break;
                case "rob":
                    result = TrainGame.Play();
                    if (result){
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
            bet = int.Parse(Console.ReadLine());
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
            int x = (14-p1.Length)/2;
            int z;
            if (p1.Length % 2 == 0){
                z = x;
            } else {
                z = x + 1;
            }
            int y = p2.Length/2;
            int w;
            if (p2.Length % 2 == 0){
                w = y;
            } else {
                w = y + 1;
            }
            char chair = '~';
            string p1Row =  p1.PadLeft(x, chair).PadRight(z, chair);
            string p2Row = p2.PadLeft(y, chair).PadRight(w, chair);
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
    static void Credits(){
        Console.Clear();
        Console.WriteLine("Credits:\n");
        Console.WriteLine("Main Producer:");
        string words = "Fish";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(4000);
        Console.WriteLine("Main Developer:");
        words = "Fish";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(4000);
        Console.WriteLine("Concept Creators:");
        words = "Jacob Woudwyk";
        Typing(words);
        words = "Mr. Luyk";
        Typing(words);
        words = "Yosgart Garcia";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(4000);
        Console.WriteLine("Play Testers:");
        words = "Mr. Luyk";
        Typing(words);
        words = "Coby Johnson";
        Typing(words);
        words = "Justin Boeve";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(4000);
        Console.WriteLine("Language conversion:");
        words = "Chat GPT";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(4000);
        Console.WriteLine("Teachers:");
        words = "Mr. Luyk";
        Typing(words);
        words = "Mr. Martinez";
        Typing(words);
        Thread.Sleep(4000);
        Console.WriteLine();
        Console.WriteLine("Troubleshooting:");
        words = "Yosgart Garcia";
        Typing(words);
        words = "Will Newson";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(4000);

        Console.WriteLine("Home screen:");
        words = "Fish";
        Typing(words);
        words = "Jacob Woudwyk";
        Typing(words);
        words = "Yosgart Garcia";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(4000);
        
        Console.WriteLine("Boxing:");
        words = "Fish";
        Typing(words);
        words = "Jacob Woudwyk";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(4000);

        Console.WriteLine("Slots:");
        words = "Fish";
        Typing(words);
        words = "Jacob Woudwyk";
        Typing(words);
        Console.WriteLine();
        Thread.Sleep(4000);
    }
    static void Typing(string words){
        foreach(char letter in words){
            Thread.Sleep(100);
            Console.Write(letter);
        }
        Console.WriteLine();
    }
}