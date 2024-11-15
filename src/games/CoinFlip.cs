public class CoinFlip : Game
{
    public override string Name => "Coin Flip";

    public override void Play()
    {
        Console.Clear();
        Random rnd = new Random();
        int amount = (int)(gameState.money * 0.30);
        int multiply = 2;
        if (gameState.loseSwitch)
            multiply++;

        string name = Constants.nameList[rnd.Next(Constants.nameList.Count)];
        Console.WriteLine("     .....\n   .:::::::.\n  .::'''''::.\n  ':' o o ':'\n   '.  v  .'   ._\n   .#:...:#.  :'':\n  :#########:/*..'\n  ##########/###'");
        Console.WriteLine($"{name} challenges you to a coin flip!\nThey bet you ${amount}!");
        
        while (!Helpers.AskYesNo("Do you accept? (yes or no): ")) {
            Console.WriteLine("             .\n  ..       .:' .\n   ''=..  ' .:' :\n  :''-.      '..'\n  '...'  ...._\n       .'     '-.\n      :\n");
            Thread.Sleep(2000);
            
            Console.WriteLine($"{name} doesn't like that! {name} robs you of ${amount * multiply}!");
            gameState.money -= amount * multiply;
            Helpers.SkippableDelay(5000);
            return;
        }
        char picked = 'n';
        try{
        Console.Write("Heads or Tails? (h or t): ");
        picked = char.Parse(Console.ReadLine()!);
        }
        catch(Exception){
        Console.WriteLine("That isn't a character");
        Thread.Sleep(5000);
        }
        while (picked != 'h' && picked != 't')
        {
            try{
            Console.WriteLine("That's not heads or tails!");
            Console.Write("Heads or Tails? (h or t): ");
            picked = char.Parse(Console.ReadLine()!);
            }
            catch{
                Thread.Sleep(5000);
            }
        }

        /*Console.WriteLine("Flipping Coin!!");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }*/
        Flip();
        int tailsChance = 2;
        if (Program.printablePlayerName == "Fish") tailsChance = 3;
        Console.WriteLine();
        char result = rnd.Next(0, tailsChance) == 1 ? 'h' : 't';
        string sResult = result == 'h' ? "heads" : "tails";

        if (result == 'h')
            HeadsReveal();
        else
            TailsReveal();

        if (result == picked)
        {
            Console.WriteLine($"You win ${amount}!");

            //Console.WriteLine($"You were right it was {sResult}!\nYou win ${amount}!");
            gameState.money += amount;
        }
        else
        {
            Console.WriteLine($"You lose ${amount}!");

            //Console.WriteLine($"You were wrong it was {sResult}!\nYou lose ${amount}!");
            gameState.money -= amount;
        }
        Helpers.SkippableDelay(5000);
    }
    
    //Animations and other art - DO NOT TOUCH

    /*Approach
         .....          \n
       .:::::::.        \n
      .::'''''::.       \n
      ':' o o ':'       \n
       '.  v  .'   ._   \n
       .#:...:#.  :'':  \n
      :#########:/*..'  \n
      ##########/###'   ~

    haha get robbed >:3
                 .      \n
      ..       .:' .    \n
       ''=..  ' .:' :   \n
      :''-.      '..'   \n
      '...'  ...._      \n
           .'     '-.   \n
          :             \n
                        ~
    */

    private void Flip()
    {
        int frameRate = 50;

        Console.Clear();
        Console.WriteLine("\n\n\n.__\n'''.\n...'\n''");
        Thread.Sleep(500);

        Console.Clear();
        Console.WriteLine("\n\n\n.:-.\n'''.\n...'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n _\n:=:.\n:::.\n:::'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n  ._\n-=: '\n###.\n###'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n  '.\n-:* '\n%%%.\n%%%'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n   \\\n:*' '\n&&&.\n&&&'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n   .\n  . \\\n:*'\n@@@.\n@@@'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n     |\n  .  '\n:*'\n@@@.\n@@@'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n      /\n  .  '\n:*'\n@@@.\n@@@'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n       .\n  .   /\n:*'\n@@@.\n@@@'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n  .     .'\n:*'    '\n@@@.\n@@@'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n  .\n:*'     .-''\n@@@.\n@@@'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n  .\n:*'\n@@@.      ---\n@@@'\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n  .\n:*'\n@@@.      -._\n@@@'         '\n''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine(" .\n*'\n@@.\n@@'\n'            \\\n              \\");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("'\n@.\n@'\n            .\n             :\n              :");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine(".\n'\n             .\n             &.\n             '&\n              '");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n            ..\n            @@\n            @@\n            ''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n             .\n            %@\n           .@'\n           @%\n           '");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n            .\n           %%\n          %%\n         %%\n         *");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n            ..\n          .&&'\n        .&&'\n       '*'");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n           _..\n        _.&@*'\n      .%@&'\n      '*");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n\n      _...=##@@:\n     :@@&&&%***'");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n\n     .:::::::::.\n     '*********'");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n\n     :@@##=..._\n     '***%&&&@@:");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n     .&=._\n     '&@@@&=._\n        '=&@@@:\n            ''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n      ..\n     :@@&.\n      '&@@&.\n        '&@@&.\n          '&&'");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n       ..\n       %@%\n        %@%\n         %@%\n          %@%\n           *'");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n        ..\n        @@%\n        &@@\n         @@&\n         %@@\n          ''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n         .=.\n         @@@\n         @@@\n         @@@\n         @@@\n         '*'");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n          ..\n         %@@\n         @@&\n        &@@\n        @@%\n        ''");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n           ..\n          %@%\n         %@%\n        %@%\n       %@%\n       '*");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n             ..\n           .&@@:\n         .&@@&'\n       .&@@&'\n     .&@@&'\n    '@@&'\n____________________");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n              _.\n          _.#&@@:\n      _.#&@@@&#'\n   .#&@@@&#'\n%%:__.-'%%%%%%%%%%%%\n@@@@@@@@@@@@@@@@@@@@\n@@@@@@@@@@@@@@@@@@@@");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n%%%%%%%%%%%%%%%%%%%%\n@@@@@@@@@@@@@&&--&@@\n@@@&&=-*''    __.:@@\n@@:___....:::&@@@@@@\n@@@@@@@@@@@@@@@@@@@@\n@@@@@@@@@@@@@@@@@@@@");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@\n@@@@@@@@@@@@@@@@@@@@\n@@@@@@@@@@@@@@@@@@@@\n@@&&&&&&&&&&&&&&&&@@\n@&                &@\n@&................&@\n@@@@@@@@@@@@@@@@@@@@\n@@@@@@@@@@@@@@@@@@@@");
        Thread.Sleep(2500);
    }

    private void HeadsReveal()
    {
        Console.Clear();
        Console.WriteLine("      .-''''-.\n    .'  O  O  '.\n   .' o /\\/\\ o '.\n   :  |' '' '|  :\n   :  |.----.|  :\n   '. '.    .' .'\n    '.  ''''  .'\n      '-....-'");
        Thread.Sleep(1000);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n H  .'  O  O  '.  H\n   .' o /\\/\\ o '.\n   :  |' '' '|  :\n   :  |.----.|  :\n   '. '.    .' .'\n    '.  ''''  .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n H  .'  O  O  '.  H\n E .' o /\\/\\ o '. E\n   :  |' '' '|  :\n   :  |.----.|  :\n   '. '.    .' .'\n    '.  ''''  .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n H  .'  O  O  '.  H\n E .' o /\\/\\ o '. E\n A :  |' '' '|  : A\n   :  |.----.|  :\n   '. '.    .' .'\n    '.  ''''  .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n H  .'  O  O  '.  H\n E .' o /\\/\\ o '. E\n A :  |' '' '|  : A\n D :  |.----.|  : D\n   '. '.    .' .'\n    '.  ''''  .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n H  .'  O  O  '.  H\n E .' o /\\/\\ o '. E\n A :  |' '' '|  : A\n D :  |.----.|  : D\n S '. '.    .' .' S\n    '.  ''''  .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n H  .'  O  O  '.  H\n E .' o /\\/\\ o '. E\n A :  |' '' '|  : A\n D :  |.----.|  : D\n S '. '.    .' .' S\n !  '.  ''''  .'  !\n      '-....-'");
        Thread.Sleep(1000);
    }

    private void TailsReveal()
    {
        Console.Clear();
        Console.WriteLine("      .-''''-.\n    .'  _     '.\n   .' .' :   _ '.\n   : : o  '-' : :\n   : '.   .-._: :\n   '.  '.:     .'\n    '.        .'\n      '-....-'");
        Thread.Sleep(1000);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n T  .'  _     '.  T\n   .' .' :   _ '.\n   : : o  '-' : :\n   : '.   .-._: :\n   '.  '.:     .'\n    '.        .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n T  .'  _     '.  T\n A .' .' :   _ '. A\n   : : o  '-' : :\n   : '.   .-._: :\n   '.  '.:     .'\n    '.        .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n T  .'  _     '.  T\n A .' .' :   _ '. A\n I : : o  '-' : : I\n   : '.   .-._: :\n   '.  '.:     .'\n    '.        .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n T  .'  _     '.  T\n A .' .' :   _ '. A\n I : : o  '-' : : I\n L : '.   .-._: : L\n   '.  '.:     .'\n    '.        .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n T  .'  _     '.  T\n A .' .' :   _ '. A\n I : : o  '-' : : I\n L : '.   .-._: : L\n S '.  '.:     .' S\n    '.        .'\n      '-....-'");
        Thread.Sleep(100);

        Console.Clear();
        Console.WriteLine("      .-''''-.\n T  .'  _     '.  T\n A .' .' :   _ '. A\n I : : o  '-' : : I\n L : '.   .-._: : L\n S '.  '.:     .' S\n !  '.        .'  !\n      '-....-'");
        Thread.Sleep(1000);
    }
}