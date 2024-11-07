﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static GameState gameState = new GameState();

    static bool loseSwitch = false;
    static void Main(string[] args)
    {
        string choice = "";
        int gamesInRow = 1;
        string choiceBefore;
        int result;
        string[] drunkChoiceList = { "rob", "rob", "boxing", "horses", "jack", "slots", "poker", "coin", "credits", "bar", "bar", "bar", "bar", "quit" };
        while (choice.ToLower() != "quit")
        {
            Random undoDrunk = new Random();
            if (undoDrunk.Next(1, 4) == 1 && gameState.drunkLevel > 0)
                gameState.drunkLevel--;
            Console.Clear();
            Console.WriteLine($"Welcome to The Casino!\nYou can bet on boxing, horse racing, blackjack, slots, poker, coin flipping, roulette, rob the casino, or quit.\nYou have ${gameState.money}.");
            Console.Write("What do you want to play (boxing, horses, jack, slots, poker, coin, spin, rob, quit)? ");
            choiceBefore = choice;
            choice = Console.ReadLine();
            if (choiceBefore.ToLower().Equals(choice.ToLower()))
                gamesInRow++;
            else
                gamesInRow -= gamesInRow - 1;
            if (gamesInRow > 5 || gameState.drunkLevel > 4)
                loseSwitch = true;
            else
                loseSwitch = false;
            if (loseSwitch)
                Console.WriteLine("Lose Switch is Activated!");
            Thread.Sleep(400);
            if (gameState.drunkLevel > 1)
            {
                Random drunkCoice = new Random();
                choice = drunkChoiceList[drunkCoice.Next(0, 14)];
            }
            switch (choice.ToLower())
            {
                case "boxing":
                    new Boxing().PlayGame(gameState);
                    break;
                case "slots":
                    new Slots().PlayGame(gameState);
                    break;
                case "rob":
                    result = Rob.Play((gameState.drunkLevel >= 2));
                    if (result == 0)
                    {
                        Console.WriteLine("You Lost");
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    else if (result == 1)
                    {
                        Random random = new Random();
                        int stole = random.Next(150, 1000);
                        Console.WriteLine("You successfully stole $" + stole + "!");
                        gameState.money += stole;
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    else if (result == 2)
                    {
                        Random random = new Random();
                        int stole = random.Next(500, 1500);
                        Console.WriteLine("You successfully stole $" + stole + "!");
                        gameState.money += stole;
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    else if (result == 3)
                    {
                        Random random = new Random();
                        int stole = random.Next(1000, 2000);
                        Console.WriteLine("You successfully stole $" + stole + "!");
                        gameState.money += stole;
                        Console.Write("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    else if (result == 4)
                    {
                        break;
                    }
                    break;
                case "coin":
                    new CoinFlip().PlayGame(gameState);
                    break;
                case "credits":
                    Credits();
                    break;
                case "bar":
                    gameState.drunkLevel += Bar();
                    break;
                case "horses":
                    new HorseRace().PlayGame(gameState);
                    break;
                case "spin":
                    new Roulette().PlayGame(gameState);
                    break;
                default:
                    break;
            }
            Random randy = new Random();
            int coinflip = randy.Next(1, 21);
            if (coinflip == 20)
            {
                new CoinFlip().PlayGame(gameState);
            }
        }
        Credits();
        Console.WriteLine($"You ended with ${gameState.money}!");
        Thread.Sleep(7000);
        string words = "And Ur Mom!";
        Helpers.Typing(gameState, words);
    }

    static int Bar()
    {
        string UserAnswer;
        Console.Clear();
        if (gameState.drunkLevel <= 3)
        {
            Console.Write("You are at the bar.\nDo you want a drink for $10? (y/n): ");
            UserAnswer = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You go back to the bar and order another dwink.");
            UserAnswer = "y";
        }
        if (UserAnswer == "y")
        {
            gameState.money -= 10;
            Random rand = new Random();
            int RandNum = rand.Next(1, 4);
            Thread.Sleep(1000);
            Console.Write("You take a drink.");
            for (int i = 0; i < 4; i++)
            {
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

    static void Credits()
    {
        foreach (string key in Constants.Credits.Keys) {
            Helpers.Typing(gameState, key, 50);
            foreach (string value in Constants.Credits[key]) {
                Helpers.Typing(gameState, $" - {value}", 50);
                Thread.Sleep(100);
            }
            Thread.Sleep(250);
        }
    }
}