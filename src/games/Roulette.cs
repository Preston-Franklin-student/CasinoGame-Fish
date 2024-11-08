public class Roulette : Game
{
    public override string Name => "Roulette";

    public override void Play()
    {

        Console.Clear();
        bool yesNo = Helpers.AskYesNo("Do you want to spend $30");
        if (!(gameState.money < 30 || !yesNo))
        {
            Random random = new Random();
            int rouletteSpinner = random.Next(25, 70);
            int possibleValue = 1;
            int possibleValue2 = 0;
            int possibleValue3 = 1;
            int bottomValue = 0;
            int bottomValue2 = 1;
            int topValue = 0;
            int topValue2 = 1;
            int delay = 100;
            int topBorder = 1;
            string topBorderOutput = "";
            int bottomBorder = 1;
            string bottomBorderOutput = "";
            int middleBorder = 1;
            Console.WriteLine("Press f to Spin in Roulette");
            gameState.money -= 30;
            while (!(Console.ReadKey().Key == ConsoleKey.F)) { }
            for (possibleValue = 1; possibleValue < rouletteSpinner; possibleValue++)
            {
                if (possibleValue3 == 36)
                {
                    possibleValue3 = 1;
                }
                if (bottomValue2 == 36)
                {
                    bottomValue2 = 1;
                }
                if (topValue2 == 36)
                {
                    topValue2 = 1;
                }
                if(topBorder == 4){
                topBorder = 1;
            }
            if(bottomBorder == 4){
                bottomBorder = 1;
            }
            if(middleBorder == 4){
                middleBorder = 1;
            }
                if (possibleValue > 2) topValue = topValues(topValue, topValue2);
                if (possibleValue != 1) { possibleValue2 = possibleValues(possibleValue2, possibleValue3); }
                bottomValue = bottomValues(bottomValue, bottomValue2);
                delay = determineDelay(delay, rouletteSpinner, possibleValue);
                Thread.Sleep(delay);
                Console.Clear();
                switch(topBorder){
                case 1:
                topBorderOutput = "1 3 2 1 3 2 1";
                break;
                case 2:
                topBorderOutput = "3 2 1 3 2 1 3";
                break;
                case 3:
                topBorderOutput = "2 1 3 2 1 3 2";
                break;
            }
            Console.WriteLine(topBorderOutput);
            switch(middleBorder){
                case 1:
                Console.WriteLine("2 # # # # # 3");
            Console.Write("3 #  ");
            if(possibleValue > 2){
                if(topValue/100 >  0)
            Console.WriteLine(topValue + "  # 2");
            else if(topValue/10 > 0)
            Console.WriteLine(topValue + "   # 2");
            else
            Console.WriteLine(" " + topValue + "   # 2");
            }else{
                Console.WriteLine(" 0   # 2");
            }
            Console.Write("1 #-<");
            if(possibleValue != 1){
                if(possibleValue2/100 >  0)
            Console.WriteLine(possibleValue2 + ">-# 1");
            else if(possibleValue2/10 > 0)
            Console.WriteLine(possibleValue2 + " >-# 1");
            else
            Console.WriteLine(" " + possibleValue2 + " >-# 1");
            }else{
                Console.WriteLine(" 0 >-# 3");
            }
            Console.Write("2 #  ");
            if(bottomValue/100 >  0)
            Console.WriteLine(bottomValue + "  # 3");
            else if(bottomValue/10 > 0)
            Console.WriteLine(bottomValue + "   # 3");
            else
            Console.WriteLine(" " + bottomValue + "   # 3");
            Console.WriteLine("3 # # # # # 2");
            break;
            case 2:
            Console.WriteLine("1 # # # # # 2");
            Console.Write("2 #  ");
            if(possibleValue > 2){
                if(topValue/100 >  0)
            Console.WriteLine(topValue + "  # 1");
            else if(topValue/10 > 0)
            Console.WriteLine(topValue + "   # 1");
            else
            Console.WriteLine(" " + topValue + "   # 1");
            }else{
                Console.WriteLine(" 0   # 1");
            }
            Console.Write("3 #-<");
            if(possibleValue != 1){
                if(possibleValue2/100 >  0)
            Console.WriteLine(possibleValue2 + ">-# 3");
            else if(possibleValue2/10 > 0)
            Console.WriteLine(possibleValue2 + " >-# 3");
            else
            Console.WriteLine(" " + possibleValue2 + " >-# 3");
            }else{
                Console.WriteLine(" 0 >-#");
            }
            Console.Write("1 #  ");
            if(bottomValue/100 >  0)
            Console.WriteLine(bottomValue + "  # 2");
            else if(bottomValue/10 > 0)
            Console.WriteLine(bottomValue + "   # 2");
            else
            Console.WriteLine(" " + bottomValue + "   # 2");
            Console.WriteLine("2 # # # # # 1");
            break;
            case 3:
            Console.WriteLine("3 # # # # # 1");
            Console.Write("1 #  ");
            if(possibleValue > 2){
                if(topValue/100 >  0)
            Console.WriteLine(topValue + "  # 3");
            else if(topValue/10 > 0)
            Console.WriteLine(topValue + "   # 3");
            else
            Console.WriteLine(" " + topValue + "   # 3");
            }else{
                Console.WriteLine(" 0   # 3");
            }
            Console.Write("2 #-<");
            if(possibleValue != 1){
                if(possibleValue2/100 >  0)
            Console.WriteLine(possibleValue2 + ">-# 2");
            else if(possibleValue2/10 > 0)
            Console.WriteLine(possibleValue2 + " >-# 2");
            else
            Console.WriteLine(" " + possibleValue2 + " >-# 2");
            }else{
                Console.WriteLine(" 0 >-# 2");
            }
            Console.Write("3 #  ");
            if(bottomValue/100 >  0)
            Console.WriteLine(bottomValue + "  # 1");
            else if(bottomValue/10 > 0)
            Console.WriteLine(bottomValue + "   # 1");
            else
            Console.WriteLine("  " + bottomValue + "  # 1");
            Console.WriteLine("1 # # # # # 3");
            break;
            }
            switch(bottomBorder){
                case 1:
                bottomBorderOutput = "1 2 3 1 2 3 1";
                break;
                case 2:
                bottomBorderOutput = "3 1 2 3 1 2 3";
                break;
                case 3:
                bottomBorderOutput = "2 3 1 2 3 1 2";
                break;
            }
            Console.WriteLine(bottomBorderOutput);
            if(possibleValue > 2){
                topValue2++;
            }
            if(possibleValue != 1){
                possibleValue3++;
            }
            bottomValue2++;
            topBorder++;
            bottomBorder++;
            middleBorder++;
            }
            if (gameState.drunkLevel < 3)
            {
                gameState.money += possibleValue2;
                if(possibleValue2 == 999){
                    Console.WriteLine("!!!CONGRAGULATIONS, YOU HIT JACKPOT!!!");
                }else{
                    Console.WriteLine("Congragulations, you won $" + gameState.money + ".");
                }
            }
            else{
                gameState.money += random.Next(1, possibleValue2);
                Console.WriteLine("Congragulations, you won $???.");
            }
        
        }else
             Console.WriteLine("Alright, Leave then");
        Console.WriteLine("Press enter to leave");
        Console.ReadLine();
    }

    static int possibleValues(int possibleValue2, int possibleValue3)
    {
        switch (possibleValue3)
        {
            case 1:
            case 3:
            case 6:
            case 10:
            case 15:
            case 21:
            case 28:
                possibleValue2 = 005;
                break;
            case 2:
            case 4:
            case 7:
            case 11:
            case 16:
            case 22:
            case 29:
                possibleValue2 = 010;
                break;
            case 5:
            case 8:
            case 12:
            case 17:
            case 23:
            case 30:
                possibleValue2 = 025;
                break;
            case 9:
            case 13:
            case 18:
            case 24:
            case 31:
                possibleValue2 = 050;
                break;
            case 14:
            case 19:
            case 25:
            case 32:
                possibleValue2 = 100;
                break;
            case 20:
            case 26:
            case 33:
                possibleValue2 = 250;
                break;
            case 27:
            case 34:
                possibleValue2 = 500;
                break;
            case 35:
                possibleValue2 = 999;
                break;
        }
        return possibleValue2;
    }
    static int bottomValues(int bottomValue, int bottomValue2)
    {
        switch (bottomValue2)
        {
            case 1:
            case 3:
            case 6:
            case 10:
            case 15:
            case 21:
            case 28:
                bottomValue = 005;
                break;
            case 2:
            case 4:
            case 7:
            case 11:
            case 16:
            case 22:
            case 29:
                bottomValue = 010;
                break;
            case 5:
            case 8:
            case 12:
            case 17:
            case 23:
            case 30:
                bottomValue = 025;
                break;
            case 9:
            case 13:
            case 18:
            case 24:
            case 31:
                bottomValue = 050;
                break;
            case 14:
            case 19:
            case 25:
            case 32:
                bottomValue = 100;
                break;
            case 20:
            case 26:
            case 33:
                bottomValue = 250;
                break;
            case 27:
            case 34:
                bottomValue = 500;
                break;
            case 35:
                bottomValue = 999;
                break;
        }
        return bottomValue;
    }
    static int topValues(int topValue, int topValue2)
    {
        switch (topValue2)
        {
            case 1:
            case 3:
            case 6:
            case 10:
            case 15:
            case 21:
            case 28:
                topValue = 005;
                break;
            case 2:
            case 4:
            case 7:
            case 11:
            case 16:
            case 22:
            case 29:
                topValue = 010;
                break;
            case 5:
            case 8:
            case 12:
            case 17:
            case 23:
            case 30:
                topValue = 025;
                break;
            case 9:
            case 13:
            case 18:
            case 24:
            case 31:
                topValue = 050;
                break;
            case 14:
            case 19:
            case 25:
            case 32:
                topValue = 100;
                break;
            case 20:
            case 26:
            case 33:
                topValue = 250;
                break;
            case 27:
            case 34:
                topValue = 500;
                break;
            case 35:
                topValue = 999;
                break;
        }
        return topValue;
    }
    static int determineDelay(int delay, int rouletteSpinner, int possibleValue)
    {
        int determineDelay = rouletteSpinner - possibleValue;
        switch (determineDelay)
        {
            case 1:
                delay = 2000;
                break;
            case 2:
                delay = 1000;
                break;
            case 3:
                delay = 500;
                break;
            case 4:
                delay = 250;
                break;
        }
        return delay;
    }
}
