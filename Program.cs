using System;

namespace higherLower
{
  class Program
  {
    static void StartGame()
    {
      Console.WriteLine("Would you like to play the higher/lower game? (yes/no)");
      string userStart = Console.ReadLine();
      if (userStart == "yes")
      {
        Player player = new Player();
        Gameplay(player);
      }
      else if (userStart == "no")
      {
        Console.WriteLine("Oh.");
        return;
      }
      else
      {
        Console.WriteLine("I don't understand.");
        StartGame();
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
        Console.WriteLine("Nice, thought so. Play again? (yes/no)");
        string playAgain = Console.ReadLine();
        if(playAgain == "yes")
        {
          player.Reset();
          Gameplay(player);
        }
        else
        {
          Console.WriteLine("Fine, peace.");
          return;
        }
      }
      else
      {
        Console.WriteLine("I don't understand.");
        Gameplay(player);
      }
    }

    static void Main()
    {
      StartGame();
    }
  }
}
