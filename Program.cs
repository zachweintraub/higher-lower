using System;

namespace higherLower
{
  class Program
  {
    static void StartGame(bool firstGame)
    {
      if (firstGame)
      {
        Console.WriteLine("Would you like to play the higher/lower game? (yes/no)");
      }
      else
      {
        Console.WriteLine("Wanna play again? (yes/no)");
      }
      string userStart = Console.ReadLine();
      if (userStart == "yes")
      {
        SelectMode();
      }
      else if (userStart == "no")
      {
        Console.WriteLine("Oh.");
        return;
      }
      else
      {
        Console.WriteLine("I don't understand.");
        StartGame(firstGame);
      }
    }

    static void SelectMode()
    {
      Console.WriteLine("Who will be guessing? (me/you)");
      string modeResponse = Console.ReadLine();
      if (modeResponse == "you")
      {
        Player player = new Player();
        Gameplay(player);
      }
      else if (modeResponse == "me")
      {
        Random rnd = new Random();
        int secretNumber = rnd.Next(1, 101);
        altGameplay(secretNumber);
      }
      else
      {
      Console.WriteLine("I don't understand.");
      SelectMode();
      }
    }

    static void Gameplay(Player player)
    {
      Console.WriteLine("Think of a number between 1 and 100.");
      int compGuess = player.GetLowerBound() + (player.GetUpperBound() - player.GetLowerBound())/2;
      Console.WriteLine("Is your number " + compGuess + "? (higher/lower/correct)");
      string playerResponse = Console.ReadLine();
      if (playerResponse == "higher")
      {
        player.SetLowerBound(compGuess);
        Gameplay(player);
      }
      else if (playerResponse == "lower")
      {
        player.SetUpperBound(compGuess);
        Gameplay(player);
      }
      else if (playerResponse == "correct")
      {
        Console.WriteLine("Nice, thought so.");
        StartGame(false);
      }
    }

    static void altGameplay(int secretNumber)
    {
      Console.WriteLine("So, what's my number?");
      string playerGuessString = Console.ReadLine();
      int playerGuess = int.Parse(playerGuessString);
      if (playerGuess == secretNumber)
      {
        Console.WriteLine("Nice, you got it.");
        StartGame(false);
      }
      else if (playerGuess > secretNumber)
      {
        Console.WriteLine("My number is lower.");
        altGameplay(secretNumber);
      }
      else if (playerGuess < secretNumber)
      {
        Console.WriteLine("My number is higher.");
        altGameplay(secretNumber);
      }
    }

    static void Main()
    {
      StartGame(true);
    }
  }
}
