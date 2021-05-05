namespace RockPaperScissors
{
  public class Game
  {
    public static string WhoWon(string playerOneChoice, string playerTwoChoice)
    {
      if (playerOneChoice == playerTwoChoice)
      {
        return "Draw";
      }
      else if (playerOneChoice == "rock" && playerTwoChoice == "scissors")
      {
        return "Player One Wins!";
      }
      return "Error";
    }
  }
}
