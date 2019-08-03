using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGolf
{
    class ScoreCard
    {
        public string name { get; set; }

        private int[] scores = new int[18];

        public ScoreCard(string _name, int[] _scores)
        {
            name = _name;
            scores = _scores;
        }

        public ScoreCard(string _name)
        {
            name = _name;
            for (int x = 0; x < scores.GetLength(0); x++)
            {
                scores[x] = 0;
            }
        }

        public void resetGame()
        {
            for (int x = 0; x <= scores.GetLength(0); x++)
            {
                scores[x] = 0;
            }
        }

        public void enterScore(int _hole, int _score)
        {
            _hole--;
            if (_score >= 1 && _score <= 5)
            {
                scores[_hole] = _score;
            }
            else if (_score > 5)
            {
                scores[_hole] = 5;
            }
            else
            {
                scores[_hole] = 0;
            }
        }

        public int totalScore()
        {
            int total = 0;
            for (int x = 0; x < scores.GetLength(0); x++)
            {
                total += scores[x];
            }
            return total;
        }

        public int getScore(int _hole)
        {
            return scores[_hole - 1];
        }
    }
}
