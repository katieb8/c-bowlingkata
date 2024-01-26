
using static System.Formats.Asn1.AsnWriter;

namespace BowlingKata
{
    public class Game
    {
        //private List<int> _rolls = new List<int>();
        private int[] _rolls = new int [21];
        private int _currentRoll = 0;
        private int _score;

        public int Score()
        {
            _currentRoll = 0;
            for (int i = 0; i < 10; i++)
            {
                _score += _rolls[_currentRoll] + _rolls[_currentRoll + 1];
                _currentRoll += 2;
            }

            //if (isSpare())
            //{
            //    _score += 10 + _rolls[_currentRoll + 2];
            //    _score += 2;
            //}

            return _score;
        }

        //public bool isSpare()
        //{
        //    return _rolls[_currentRoll] + _rolls[_currentRoll + 1] == 10;
        //}

        public void Roll(int pinsKnocked)
        {
            _rolls[_currentRoll] += pinsKnocked;
            _currentRoll++;
        }
    }
}
