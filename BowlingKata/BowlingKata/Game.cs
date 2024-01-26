
namespace BowlingKata
{
    public class Game
    {
        private readonly List<int> _rolls = [];

        public void Roll(int pins)
        {
            _rolls.Add(pins);
        }

        public int Score()
        {
            var score = 0;
            var prevFrameWasSpare = false;

            for (int i = 0; i < _rolls.Count; i += 2)
            {
                var roll1 = _rolls[i];
                var roll2 = _rolls[i+1];
                var roll1Score = roll1;

                if (prevFrameWasSpare)
                {
                    score = 10 + (roll1 * 2);
                    prevFrameWasSpare = false;
                    roll1Score = 0;
                }

                if (isSpare(roll1, roll2))
                {
                    prevFrameWasSpare = true;
                    continue;
                }

                score += roll1Score + roll2;
            }

            return score;
        }

        private bool isSpare(int roll1, int roll2)
        {
            return roll1 < 10 && roll2 < 10 && roll1 + roll2 == 10;
        }
    }
}
