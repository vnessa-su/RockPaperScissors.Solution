using System;
using System.Collections;

namespace RockPaperScissors
{
  public class Game
  {
    public static string WhoWon(string playerOneChoice, string playerTwoChoice)
    {
      string[] validInputs = {"rock", "paper", "scissors"};
      if(!((IList)validInputs).Contains(playerOneChoice) || !((IList)validInputs).Contains(playerTwoChoice))
      {
        return "Error";
      }

      if (playerOneChoice == playerTwoChoice)
      {
        return "Draw";
      }
      else if (playerOneChoice == "rock" && playerTwoChoice == "scissors")
      {
        return "Player One Wins!";
      }
      else if (playerOneChoice == "paper" && playerTwoChoice == "rock")
      {
        return "Player One Wins!";
      }
      else if (playerOneChoice == "scissors" && playerTwoChoice == "paper")
      {
        return "Player One Wins!";
      }
      else
      {
        return "Player Two Wins!";
      }
    }
  }
}
