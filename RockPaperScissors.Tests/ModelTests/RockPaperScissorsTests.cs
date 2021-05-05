using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {
    [TestMethod]
    public void WhoWon_SameSelected_Draw()
    {
      string outcome = RockPaperScissors.Game.WhoWon("rock", "rock");
      Assert.AreEqual("Draw", outcome);
    }

    [TestMethod]
    public void WhoWon_RockBeatsScissors_PlayerOneWins()
    {
      string outcome = RockPaperScissors.Game.WhoWon("rock", "scissors");
      Assert.AreEqual("Player One Wins!", outcome);
    }

    [TestMethod]
    public void WhoWon_PaperBeatsRock_PlayerOneWins()
    {
      string outcome = RockPaperScissors.Game.WhoWon("paper", "rock");
      Assert.AreEqual("Player One Wins!", outcome);
    }

    [TestMethod]
    public void WhoWon_ScissorsBeatsPaper_PlayerOneWins()
    {
      string outcome = RockPaperScissors.Game.WhoWon("scissors", "paper");
      Assert.AreEqual("Player One Wins!", outcome);
    }
  }
}
