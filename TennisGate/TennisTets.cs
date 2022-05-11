/*Tennis has a rather quirky scoring system, and to newcomers it can be a little difficult to keep track of. The tennis society has contracted you to build a scoreboard to display the current score during tennis games.

You can read more about Tennis scores on wikipedia which is summarized below:

A game is won by the first player to have won at least four points in total and at least two points more than the opponent.
The running score of each game is described in a manner peculiar to tennis: scores from zero to three points are described as “Love”, “Fifteen”, “Thirty”, and “Forty” respectively.
If at least three points have been scored by each player, and the scores are equal, the score is “Deuce”.
If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is “Advantage” for the player in the lead.
You need only report the score for the current game. Sets and Matches are out of scope.
*/







using NUnit.Framework;

namespace TennisGate
{
    public class TennisTests
    {  
      private Player _player;
        [SetUp]
        public void Setup()
        {
            _player = new Player();
        }

        [Test]
        public void GetPlayer()
        {
            var PlayerOne = new Player();
            var PlayerTwo = new Player();
            Assert.Pass();
        }


        [TestCase(0, 0, "Love-All")]
        [TestCase(1, 1, "Fifteen-All")]
        [TestCase(2, 2, "Thirty-All")]
        [TestCase(3, 3, "Deuce")]
        [TestCase(4, 4, "Deuce")]
        [TestCase(1, 0, "Fifteen-Love")]
        [TestCase(0, 1, "Love-Fifteen")]
        [TestCase(2, 0, "Thirty-Love")]
        [TestCase(0, 2, "Love-Thirty")]
        [TestCase(3, 0, "Forty-Love")]
        [TestCase(0, 3, "Love-Forty")]
        [TestCase(4, 0, "Win for PlayerOne")]
        [TestCase(0, 4, "Win for PlayerTwo")]
        [TestCase(2, 1, "Thirty-Fifteen")]
        [TestCase(1, 2, "Fifteen-Thirty")]
        [TestCase(3, 1, "Forty-Fifteen")]
        [TestCase(1, 3, "Fifteen-Forty")]
        [TestCase(4, 1, "Win for PlayerOne")]
        [TestCase(1, 4, "Win for PlayerTwo")]
        [TestCase(3, 2, "Forty-Thirty")]
        [TestCase(2, 3, "Thirty-Forty")]
        [TestCase(4, 2, "Win for PlayerOne")]
        [TestCase(2, 4, "Win for PlayerTwo")]
        [TestCase(4, 3, "Advantage PlayerOne")]
        [TestCase(3, 4, "Advantage PlayerTwo")]
        [TestCase(5, 4, "Advantage PlayerOne")]
        [TestCase(4, 5, "Advantage PlayerTwo")]
        [TestCase(6, 4, "Win for PlayerOne")]
        [TestCase(4, 6, "Win for PlayerTwo")]
        public void ShareResult(int input, int expected)
        {
            Assert.AreEqual(input, Is.EqualTo(expected));

        }

    }

    
}