using System;
public static class TrainGame
{
    public static char key;
    public static int PlayerPos;
    public static double Score;
    public static string? BarOne;
    public static string? BarTwo;
    public static string? BarThree;
    public static string? BarFour;
    public static string? BarFive;
    public static string? BarSix;
    public static string? BarSeven;
    public static string? BarEight;
    public static string? BarNine;
    public static string? BarTen;
    public static string? MovmentBar;
    public static bool result;
    public static bool playing = true;
    public static Thread thread6 = new Thread(DeathLoop);
    public static Thread thread2 = new Thread(EnemyLoop);
    public static Thread thread3 = new Thread(Display);
    public static Thread thread4 = new Thread(ScoreLoop);
    public static Thread thread5 = new Thread(EnemyCopyLoop);
    public static bool Play()
    {
        Console.Clear();
        PlayerPos = 3;
        Score = 0;
        result = true;
        thread2.Start();
        thread3.Start();
        thread4.Start();
        thread5.Start();
        thread6.Start();
        if (playing == false)
        {
            if (Score < 1) { result = false; }
            else { result = true; }
            return result;
        }
        return false;
    }
    public static void PlayerLoop()
    {
        while (true)
        {
            var keyInfo = Console.ReadKey(true);
            key = keyInfo.KeyChar;

            if (key == 'a') { PlayerPos -= 1; }
            else if (key == 'd') { PlayerPos += 1; }
            else if (key == ('x')) { break; }

            if (PlayerPos < 1) { PlayerPos = 1; }
            if (PlayerPos > 5) { PlayerPos = 5; }
            if (PlayerPos == 1) MovmentBar = ("│O│ │ │ │ │");
            else if (PlayerPos == 2) MovmentBar = ("│ │O│ │ │ │");
            else if (PlayerPos == 3) MovmentBar = ("│ │ │O│ │ │");
            else if (PlayerPos == 4) MovmentBar = ("│ │ │ │O│ │");
            else if (PlayerPos == 5) MovmentBar = ("│ │ │ │ │O│");
        }
    }
    public static void EnemyLoop()
    {
        Thread.Sleep(2000);
        while (playing)
        {
            Thread.Sleep(500);
            Random rnd = new Random();
            int result = rnd.Next(1, 6);
            if (result == 1) { BarOne = ("│█│ │ │ │ │"); Thread.Sleep(300); }
            else if (result == 2) { BarOne = ("│ │█│ │ │ │"); Thread.Sleep(300); }
            else if (result == 3) { BarOne = ("│ │ │█│ │ │"); Thread.Sleep(300); }
            else if (result == 4) { BarOne = ("│ │ │ │█│ │"); Thread.Sleep(300); }
            else if (result == 5) { BarOne = ("│ │ │ │ │█│"); Thread.Sleep(300); }
        }
    }
    public static void EnemyCopyLoop()
    {
        while (playing)
        {
            BarTwo = BarOne;
            Thread.Sleep(100);
            BarThree = BarTwo;
            Thread.Sleep(100);
            BarFour = BarThree;
            Thread.Sleep(100);
            BarFive = BarFour;
            Thread.Sleep(100);
            BarSix = BarFive;
            Thread.Sleep(100);
            BarSeven = BarSix;
            Thread.Sleep(100);
            BarEight = BarSeven;
            Thread.Sleep(100);
            BarNine = BarEight;
            Thread.Sleep(100);
            BarTen = BarNine;
        }
    }
    public static void ScoreLoop()
    {
        Thread.Sleep(2000);
        while (playing) {Thread.Sleep(100); Score += .1; Score = Math.Round(Score, 1);}
    }
    public static void DeathLoop()
    {
        while (playing)
        {
            if (BarTen == ("│█│ │ │ │ │") && PlayerPos == 1) { Quit(); }
            if (BarTen == ("│ │█│ │ │ │") && PlayerPos == 2) { Quit(); }
            if (BarTen == ("│ │ │█│ │ │") && PlayerPos == 3) { Quit(); }
            if (BarTen == ("│ │ │ │█│ │") && PlayerPos == 4) { Quit(); }
            if (BarTen == ("│ │ │ │ │█│") && PlayerPos == 5) { Quit(); }
        }
    }
    public static void Display()
    {
        MovmentBar = ("│ │ │O│ │ │");
        BarOne = ("│ │ │ │ │ │");
        BarTwo = ("│ │ │ │ │ │");
        BarThree = ("│ │ │ │ │ │");
        BarFour = ("│ │ │ │ │ │");
        BarFive = ("│ │ │ │ │ │");
        BarSix = ("│ │ │ │ │ │");
        BarSeven = ("│ │ │ │ │ │");
        BarEight = ("│ │ │ │ │ │");
        BarNine = ("│ │ │ │ │ │");
        while (playing)
        {
            Console.Clear();
            Console.WriteLine("use 'a', and 'd' to move or 'x' to stop.");
            Console.WriteLine("");
            Console.WriteLine(BarOne);
            Console.WriteLine(BarTwo);
            Console.WriteLine(BarThree);
            Console.WriteLine(BarFour);
            Console.WriteLine(BarFive);
            Console.WriteLine(BarSix);
            Console.WriteLine(BarSeven);
            Console.WriteLine(BarEight);
            Console.WriteLine(BarNine);
            Console.WriteLine(MovmentBar);
            Console.WriteLine("Score: " + Score);
            Thread.Sleep(50);
        }
    }
    public static void Quit()
    {
        Console.WriteLine("Game Over");
        playing = false;
    }
}