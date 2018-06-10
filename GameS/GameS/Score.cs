using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameS
{
    public class Score
    {
        public Rectangle ScoreRectangle; 
        public SolidBrush so;
        public int x, y, widith, height;

        public Score(Random ScoreRandom)
        {
            widith = height = 9;
            so = new SolidBrush(Color.Yellow);

            x = ScoreRandom.Next(100, 420); 
            y = ScoreRandom.Next(100, 420);

          ScoreRectangle = new Rectangle(x, y, widith, height);
        }

        public void ScoreLocation(Random ScoreRandom)
        {
            x = ScoreRandom.Next(20, 420); //405 - 15
            y = ScoreRandom.Next(20, 420);
        }

        public void DrawScore(Graphics paper)
        {
            ScoreRectangle.X = x;
            ScoreRectangle.Y = y;

            paper.FillRectangle(so, ScoreRectangle);
        }
    }
}