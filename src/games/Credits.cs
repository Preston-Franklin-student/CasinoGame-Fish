public class Credits : Game
{
    public override string Name => "Credits";

    public override void Play()
    {
        Console.Clear();
        int delay = 50;

        foreach (string key in Constants.Credits.Keys)
        {
            Helpers.Typing(key, delay);
            foreach (string value in Constants.Credits[key])
            {
                if (Helpers.HasPressed(ConsoleKey.Spacebar))
                    delay = 0;

                Helpers.Typing(value, delay);
                Thread.Sleep(delay == 0 ? 0 : 200);
            }
            Console.WriteLine();
            Thread.Sleep(delay == 0 ? 0 : 1000);
        }
    }
}