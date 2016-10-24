using NUnit.Framework;

namespace Tennis
{
  [TestFixture]
  public class ExampleGameTennisTest
  {
    [Test]
    public void CheckGame3()
    {
      var game = new TennisGame3("player1", "player2");
      RealisticTennisGame(game);
      var game2 = new TennisGame3("player1", "player2");
      RealisticTennisGame2(game2);
    }

    private void RealisticTennisGame(ITennisGame game)
    {
      string[] points = {"player1", "player1", "player2", "player2", "player1", "player1"};
      string[] expectedScores =
      {
        "Fifteen-Love", "Thirty-Love", "Thirty-Fifteen", "Thirty-All", "Forty-Thirty",
        "Win for player1"
      };
      for (var i = 0; i < 6; i++)
      {
        game.WonPoint(points[i]);
        Assert.AreEqual(expectedScores[i], game.GetScore());
      }
    }

    private void RealisticTennisGame2(ITennisGame game)
    {
      string[] points = {"player2", "player2", "player1", "player1", "player2", "player2"};
      string[] expectedScores =
      {
        "Love-Fifteen", "Love-Thirty", "Fifteen-Thirty", "Thirty-All", "Thirty-Forty",
        "Win for player2"
      };
      for (var i = 0; i < 6; i++)
      {
        game.WonPoint(points[i]);
        Assert.AreEqual(expectedScores[i], game.GetScore());
      }
    }
  }
}