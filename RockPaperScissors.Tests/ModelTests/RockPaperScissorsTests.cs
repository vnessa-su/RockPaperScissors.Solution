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
  }
}
