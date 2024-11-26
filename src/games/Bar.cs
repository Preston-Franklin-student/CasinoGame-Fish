public class Bar : Game
{
    public override string Name => "Bar";

    public override void Play()
    {
        string? userAnswer;
        Console.Clear();
        if (gameState.drunkLevel <= 3)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%%%%%%%%%%%%%%%\n%.-.%%%%%%%%%%%%%%%%\n:   :%%%%%%%%%%%_%%%\n'.::'%%%%%%%%%.|-|%%\n.:::.%%%%%%%%%=| |%%\n--------------------\n");
            Console.Write("You are at the bar.\nDo you want a drink for $10? (y/n): ");
            userAnswer = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You go back to the bar and order another dwink.");
            userAnswer = "y";
        }
        if (userAnswer == "y")
        {
            gameState.money -= 10;
            Random rand = new Random();
            int RandNum = rand.Next(1, 4);
            /*Thread.Sleep(1000);
            Console.Write("You take a drink.");
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine();
            Thread.Sleep(1000);*/

            Drinking();
            
            if (RandNum == 1)
            {
                //Console.WriteLine("You feel... drunk...");
                //Thread.Sleep(4000);

                Drunk();
                gameState.drunkLevel += 2;
            }
            else
            {
                //Console.WriteLine("Nothing happens.");
                //Thread.Sleep(4000);
                
                NotDrunk();
                gameState.drunkLevel += 1;
            }
        }
        else
        {
            //Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
            //Thread.Sleep(4000);

            No();
        }
    }

    //Animations and other art - DO NOT TOUCH

    /*Contemplate
%%%%%%%%%%%%%%%%%%%%\n
%%%%%%%%%%%%%%%%%%%%\n
%.-.%%%%%%%%%%%%%%%%\n
:   :%%%%%%%%%%%_%%%\n
'.::'%%%%%%%%%.|-|%%\n
.:::.%%%%%%%%%=| |%%\n
--------------------\n
                    ~
    */

    private void No()
    {
        int frameRate = 100;

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%%%%%%%%%%%%%%%\n%.-.%%%%%%%%%%%%%%%%\n:   :%%%%%%%%%%%_%%%\n'..:'%%%%%%%%%.|-|%%\n%:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%%%%%%%%%%%%%%%\n%.-.%%%%%%%%%%%%%%%%\n:   :%%%%%%%%%%%_%%%\n'_..'%%%%%%%%%.|-|%%\n%:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%%%%%%%%%%%%%%%\n%.-.%%%%%%%%%%%%%%%%\n:_  :%%%%%%%%%%%_%%%\n'__.'%%%%%%%%%.|-|%%\n%:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%%%%%%%%%%%%%%%\n%.-.%%%%%%%%%%%%%%%%\n: _ :%%%%%%%%%%%_%%%\n'__.'%%%%%%%%%.|-|%%\n.:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%%%%%%%%%%%%%%%\n%.-.%%%%%%%%%%%%%%%%\n'+ -:%%%%%%%%%%%_%%%\n'._.'%%%%%%%%%.|-|%%\n.:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%%%%%%%%%%%%%%%\n%.-.%% %%%%%%%%%%%%%\n'+ o:%%%%%%%%%%%_%%%\n'._.'%%%%%%%%%.|-|%%\n.:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%%%%%%%%%%%%%%%\n%.-.%%   %%%%%%%%%%%\n'+ o:%%%%%%%%%%%_%%%\n'._.'%%%%%%%%%.|-|%%\n.:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%*   *%%%%%%%%%\n%.-.%%     %%%%%%%%%\n'+ ō:%.   .%%%%%_%%%\n'._.'%%%%%%%%%.|-|%%\n.:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%*   *%%%%%%%%%\n%.-.%% ?   %%%%%%%%%\n'+ ō:%.   .%%%%%_%%%\n'._.'%%%%%%%%%.|-|%%\n.:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%*   *%%%%%%%%%\n%.-.%% ??  %%%%%%%%%\n'+ ō:%.   .%%%%%_%%%\n'._.'%%%%%%%%%.|-|%%\n.:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%\n%%%%%%*   *%%%%%%%%%\n%.-.%% ??? %%%%%%%%%\n'+ ō:%.   .%%%%%_%%%\n'._.'%%%%%%%%%.|-|%%\n.:::.%%%%%%%%%=| |%%\n--------------------\n");
        Console.WriteLine("You go to the bar yet don't even sit down.\nYou don't know what you are doing.");
        Thread.Sleep(2500);
    }

    private void Drinking()
    {
        int frameRate = 100;
        
        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@:\n           @@@@@@\n           #@@@@#\n           :&@@&:\n           &@@@@&\n           @@@@@@\n           @@@@@@");
        Thread.Sleep(700);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@.\n           @@@@@&\n           %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@.\n           @@@@@&\n           %@@@@'\n           .&@@&:\n           &@@@@&\n          .@@@@@&\n          &@@@@@@");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@:\n           @@@@@&\n           %@@@@*\n           .&@@&.\n           &@@@@&\n          :@@@@@&\n     _   #@@&@@@@");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@:\n           @@@@@&\n           %@@@@*\n           .&@@&.\n     _    .@@@@@%\n    |-| &@@@@@@@&\n    |+%@@@@&@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@:\n           @@@@@&\n           %@@@@:\n    _      .&@@&\n   |-| ..:&@@@@@#\n   |+@@@@@@@@@@@%\n   '-*=##=^&@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@:\n           @@@@@&\n      _    #@@@@:\n     |-|   .&@@&\n     |+@#.&@@@@@%\n     '-*&@@@@@@@%\n        '&*&@@@@%");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           #@@@&.\n       _   @@@@@%\n      |-|  #@@@@%\n      |+@. .&@@&'\n      '-:@&@@@@@%\n        '@@@@@@@%\n         ''&@@@@%");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("            ...\n           %@@@%.\n        .. @@@@@%\n       /-/ #@@@@:\n      /+@. .@@@&'\n      '*%@@@@@@@%\n        :@@&@@@@#\n         *'&@@@@%");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("            ...\n           #@@@&.\n         ..@@@@@%\n        /-/%@@@@:\n       /+@..@@@&'\n       ':@@@@@@@%\n        :@@&@@@@#\n         ' &@@@@%");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ...\n           .@@@@%\n         . @@@@@@\n        /-/%@@@@&\n       /+@..@@@&'\n       ':@@@@@@@%\n        '@@&@@@@#\n         ' &@@@@%");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ...\n           .@@@@%\n         . @@@@@@\n        /-/&@@@@&\n       /+@:%@@@&\n       '*@@@@@@@#\n         @@&@@@@:\n           &@@@@#");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ...\n           .@@@@%\n           @@@@@@\n       .'-.&@@@@&\n     .'+%@:%@@@&\n      *':@@@@@@@:\n         @@&@@@@:\n           &@@@@#");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ..\n            .@@@@%\n            @@@@@@\n        .'-.&@@@@&\n      .'+@:.%@@@&\n       *:@@@@@@@&\n         &@&@@@@#\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n         _  @@@@@@\n      .-'+-_@@@@@&\n     :+_.@:.&@@@@'\n      ' :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n       _.-__@@@@@@\n     .'++_.-@@@@@&\n      --@@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n      ...--_@@@@@@\n      :+++_.@@@@@&\n       '@@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n      ..---_@@@@@@\n      :=++..@@@@@&\n        @@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n      .-'''_@@@@@@\n      :==+..@@@@@&\n        @@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n      :''''_@@@@@@\n      '=+@.-@@@@@&\n        @@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n       ___  :@@@@%\n      :.....@@@@@@\n      '--@--@@@@@&\n        @@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n       ..__ :@@@@%\n      :__...@@@@@@\n       ''@#-@@@@@&\n        :@&.&@@@@'\n        '@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n      ...._ :@@@@%\n      :___..@@@@@@\n        '@#-@@@@@&\n        :@&.&@@@@'\n        '@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n      ...._ :@@@@%\n      :____.@@@@@@\n        '#&-@@@@@&\n        :@@.&@@@@'\n        '@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n      ...._ :@@@@%\n      :__  _@@@@@@\n        '#&-@@@@@&\n        :@@.&@@@@'\n        '@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n      ...._ :@@@@%\n      :__   @@@@@@\n        '#&-@@@@@&\n        :@@.&@@@@'\n        '@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(500);

        Console.Clear();
        Console.WriteLine("              ...\n       ..__ :@@@@%\n      :     @@@@@@\n       ''@#-@@@@@&\n        :@&.&@@@@'\n        '@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n       ___  :@@@@%\n      :     @@@@@@\n      '--@--@@@@@&\n        @@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n      :'''' @@@@@@\n      '..@.-@@@@@&\n        @@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n      .-''' @@@@@@\n      :__+..@@@@@&\n        @@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n      ..--- @@@@@@\n      :___..@@@@@&\n        @@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n      ...-- @@@@@@\n      :   _.@@@@@&\n       '@@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n       _.-  @@@@@@\n     .'  _.-@@@@@&\n      --@@:.&@@@@'\n        :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ...\n            :@@@@%\n         _  @@@@@@\n      .-'  _@@@@@&\n     : _.@:.&@@@@'\n      ' :@@@@@@@&\n         &@&@@@@%\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("              ..\n            .@@@@%\n            @@@@@@\n        .' .&@@@@&\n      .' @:.%@@@&\n       *:@@@@@@@&\n         &@&@@@@#\n           &@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ...\n           .@@@@%\n           @@@@@@\n        / /&@@@@&\n       / @:%@@@&\n       '*@@@@@@@#\n         @@&@@@@:\n           &@@@@#");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("            ...\n           %@@@%.\n           @@@@@%\n       / / #@@@@:\n      / @. .@@@&'\n      '*%@@@@@@@%\n        :@@&@@@@#\n         *'&@@@@%");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@:\n           @@@@@&\n           #@@@@:\n     | |   .&@@&\n     | @#.&@@@@@%\n     '-*&@@@@@@@%\n        '&*&@@@@%");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@:\n           @@@@@&\n           %@@@@*\n           .&@@&.\n          .@@@@@%\n    | | &@@@@@@@&\n    | %@@@@&@@@@&");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@.\n           @@@@@&\n           %@@@@'\n           .&@@&:\n           &@@@@&\n          .@@@@@&\n          &@@@@@@");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@.\n           @@@@@&\n           %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Thread.Sleep(1500);
    }

    private void Drunk()
    {
        int frameRate = 100;

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@.\n           @@@@@&\n         . %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@.\n           @@@@@&\n        *  %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@.\n        o  @@@@@&\n         . %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n         o :@@@@.\n           @@@@@&\n        *  %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n         O :@@@@.\n        o  @@@@@&\n         . %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("        O    ..\n         o :@@@@.\n           @@@@@&\n        *  %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n         O :@@@@.\n        o  @@@@@&\n           %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("        O    ..\n         o :@@@@.\n           @@@@@&\n           %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n         O :@@@@.\n           @@@@@&\n           %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("        O    ..\n           :@@@@.\n           @@@@@&\n           %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel...");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@.\n           @@@@@&\n           %@@@@'\n           .&@@&:\n           &@@@@&\n           @@@@@&\n          .@@@@@@");
        Console.WriteLine("You feel... drunk...");
        Thread.Sleep(2500);
    }

    private void NotDrunk()
    {
        int frameRate = 100;

        Console.Clear();
        Console.WriteLine("             ..\n           :@@@@:\n           @@@@@@\n           #@@@@#\n           :&@@&:\n           &@@@@&\n           @@@@@@\n           @@@@@@");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ..\n           .@@@@:\n           &@@@@@\n           '@@@@%\n           :&@@&.\n           &@@@@&\n           &@@@@@\n           @@@@@@.");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("             ...\n            #@@@@%\n            @@@@@&\n            &@@@@'\n            :@@@:\n           :@@@@@.\n           #@@@@@&\n           &@@@@@@.");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("               ..\n             :@@@@#\n             %@@@@@\n             '@@@@%\n              %@@&\n             #@@@@%\n            :@@@@@@@\n            #@@@@@&@");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("                ...\n               %@@@@\n               @@@@@\n               #@@@@\n               :@@@.\n              .@@@@:\n             .@@@@@@\n             &@&@@@@");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("                  ..\n                .@@@\n                %@@@\n                '@@@\n                 &@@\n                :@@@\n               :@@@@\n               @@&@@");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("                   .\n                 :@@\n                 &@@\n                 *@@\n                  @@\n                 %@@\n                #@@@\n               .@@&@");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n                  :@\n                  &@\n                  *@\n                   @\n                  %@\n                 #@@\n                .@@&");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n                   .\n                   :\n                   '\n\n                   :\n                  :@\n                  @@");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n                   .\n                   %");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(frameRate);

        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n");
        Console.WriteLine("Nothing happens.");
        Thread.Sleep(2500);
    }
}