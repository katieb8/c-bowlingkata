using NUnit.Framework;

namespace BowlingKata
{
    [TestFixture]
    public class GameTest
    {
        private const int MaxFrames = 10;
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();
        }

        [Test]
        public void GutterFrame()
        {
            _game.Roll(0);
            _game.Roll(0);
            Assert.That(_game.Score(), Is.EqualTo(0));
        }

        [Test]
        public void RollTwoOnes()
        {
            _game.Roll(1);
            _game.Roll(1);
            Assert.That(_game.Score(), Is.EqualTo(2));
        }

        [Test]
        public void ScoreASpare()
        {
            RollASingleSpare();
            Assert.That(_game.Score(), Is.EqualTo(12));
        }

        [Test]
        public void GutterGame()
        {
            for (var i = 0; i < MaxFrames; i++)
            {
                _game.Roll(0);
                _game.Roll(0);
            }
            Assert.That(_game.Score(), Is.EqualTo(0));
        }
        
        private void RollASingleSpare()
        {
            _game.Roll(1);
            _game.Roll(9);

            _game.Roll(1);
            _game.Roll(0);
        }
    }
}
