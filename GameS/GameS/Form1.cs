using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameS
{
    public partial class Form1 : Form
    {
        private TimeSpan timee = new TimeSpan();
        int speed = 250;
        Graphics g;
        Snake snake = new Snake(150, 50, 13,13);
        ClientSnake clientSnake = new ClientSnake(150, 400, 13, 13); 
        Score score;
        Random randScore = new Random();
        public int ScoreQuantity1 = 0;
        public int ScoreQuantity2 = 0;
       // bool game = false;

        SoundPlayer player;

        bool Up = false;
        bool Down = false;
        bool Left = false;
        bool Right = false;

        bool Cup = false;
        bool Cdown = false;
        bool Cright = false;
        bool Cleft = false; 

        public Form1()
        {
            InitializeComponent();

            //dzwięk
            player = new System.Media.SoundPlayer(@"D:\studia\semestr6\PO\GameS\Blip-Blop.wav");
            player.Play();
            player.PlayLooping();

            score = new Score(randScore);
            //obsługa napisów
            gameover.Visible = false;
            GreenWin.Visible = false;
            BlueWin.Visible = false;
            result1.Text = Convert.ToString(ScoreQuantity1);
            result2.Text = Convert.ToString(ScoreQuantity2);
          //  game = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            snake.DrawSnake(g);
            clientSnake.DrawSnake(g);
            score.DrawScore(g);
        }
        //Move
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   //snake
            if (e.KeyData == Keys.Down && Up == false)
            {
                Up = false;
                Down = true;
                Left = false;
                Right = false;
            }

            if (e.KeyData == Keys.Up && Down == false)
            {
                Up = true;
                Down = false;
                Left = false;
                Right = false;
            }

            if (e.KeyData == Keys.Right && Left == false)
            {
                Up = false;
                Down = false;
                Left = false;
                Right = true;
            }

            if (e.KeyData == Keys.Left && Right == false)
            {
                Up = false;
                Down = false;
                Left = true;
                Right = false;
            }

            //Client Snake
            if(e.KeyData == Keys.W && Cdown == false)
            {
                Cup = true;
                Cdown = false;
                Cright = false;
                Cleft = false;
            }

            if (e.KeyData == Keys.S && Cup == false)
            {
                Cup = false;
                Cdown = true;
                Cright = false;
                Cleft = false;
            }

            if (e.KeyData == Keys.A && Cright == false)
            {
                Cup = false;
                Cdown = false;
                Cright = false;
                Cleft = true;
            }

            if (e.KeyData == Keys.D && Cleft == false)
            {
                Cup = false;
                Cdown = false;
                Cright = true;
                Cleft = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   //zegar
            timee = timee.Add(TimeSpan.FromMilliseconds(speed));
            time.Text = string.Format("{0}:{1}", timee.Minutes, timee.Seconds);

            //Snake
            if (Up) snake.MoveUp();
            
            if (Down) snake.MoveDown();

            if (Right) snake.MoveRight();
           
            if (Left) snake.MoveLeft();

            //ClientSnake
            if (Cup) clientSnake.MoveUp();

            if (Cdown) clientSnake.MoveDown();

            if (Cright) clientSnake.MoveRight();
       
            if (Cleft) clientSnake.MoveLeft();
       
            //speed       
            if (ScoreQuantity1 == 10 || ScoreQuantity2 == 10)
            {
                speed = 200;
                timer1.Interval = speed;
            }
            if (ScoreQuantity1 == 20 || ScoreQuantity2 == 20)
            {
                speed = 150;
                timer1.Interval = speed;
            }
            if (ScoreQuantity1 == 30 || ScoreQuantity2 == 30)
            {
                speed = 100;
                timer1.Interval = speed;
            }
            if (ScoreQuantity1 == 40 || ScoreQuantity2 == 40)
            {
                speed = 50;
                timer1.Interval = speed;
            }

            this.Invalidate();
            Collision();
            Eat();
        }

        public void Collision()
        {
            //5 przypadków kolizji
            //kolizja ze ścianą
            if (snake.SnakePart[0].X <= 15 || snake.SnakePart[0].X >= 425 )
            {
                gameover.Visible = true;               
                BlueWin.Visible = true;
                timer1.Stop();               
            }
            if (clientSnake.SnakePart[0].X <= 15 || clientSnake.SnakePart[0].X >= 425)
            {
                gameover.Visible = true;
                GreenWin.Visible = true;
                timer1.Stop();
            }
            if (snake.SnakePart[0].Y <= 1 || snake.SnakePart[0].Y >= 430 )
            {
                gameover.Visible = true;
                BlueWin.Visible = true;
                timer1.Stop();            
            }
            if (clientSnake.SnakePart[0].Y <= 1 || clientSnake.SnakePart[0].Y >= 430)
            {
                gameover.Visible = true;
                GreenWin.Visible = true;
                timer1.Stop();
            }

            //kolizja z samym sobą
            for (int i = 1; i < snake.SnakePart.Length; i++)
            {
                if (snake.SnakePart[0].IntersectsWith(snake.SnakePart[i]))
                {
                    gameover.Visible = true;
                    BlueWin.Visible = true;
                    timer1.Enabled = false;                   
                }
            }

            for (int i = 1; i < clientSnake.SnakePart.Length; i++)
            {
                if (clientSnake.SnakePart[0].IntersectsWith(clientSnake.SnakePart[i]))
                {
                    gameover.Visible = true;
                    GreenWin.Visible = true;
                    timer1.Enabled = false;
                }
            }

           //kolizja z innym snake

            for (int i = 1; i < clientSnake.SnakePart.Length; i++)
            {
                if (snake.SnakePart[0].IntersectsWith(clientSnake.SnakePart[i]))
               {
                  gameover.Visible = true;
                  BlueWin.Visible = true;
                  timer1.Enabled = false;
                }
            }

            for (int i = 1; i < snake.SnakePart.Length; i++)
            {
                if (clientSnake.SnakePart[0].IntersectsWith(snake.SnakePart[i]))
                {
                    gameover.Visible = true;
                    GreenWin.Visible = true;
                    timer1.Enabled = false;
                }
            }
            //restert gry
            if (gameover.Visible)
            {
                if ((MessageBox.Show("Would you like to play again?", "Message", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }
        //"jedzenie" punktów
        public void Eat()
        {
            if (snake.SnakePart[0].IntersectsWith(score.ScoreRectangle))
            {
                ScoreQuantity1 += 1;
                result1.Text = Convert.ToString(ScoreQuantity1);
                snake.GrowUp(ScoreQuantity1);

                score.ScoreLocation(randScore);
            }

            if (clientSnake.SnakePart[0].IntersectsWith(score.ScoreRectangle))
            {
                ScoreQuantity2 += 1;
                result2.Text = Convert.ToString(ScoreQuantity2);
                clientSnake.GrowUp(ScoreQuantity2);

                score.ScoreLocation(randScore);
            }
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green Snake use arrows to move. \n" +
                            "Blue Snake use WSAD to move. \n" +
                            "Good Luck!");
        }
    }
}
