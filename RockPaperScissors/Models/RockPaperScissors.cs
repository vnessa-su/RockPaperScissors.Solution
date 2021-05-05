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
      return "Error";
    }
  }
}
