using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace GameS
{
    public class Snake
    {
        public Rectangle[] SnakePart;
        public SolidBrush solidBrush; 
   
        int x, y, widith, height;
        public Rectangle Head;
        Random random = new Random();

        public Snake(int x, int y, int widith, int height)
        {
            SnakePart = new Rectangle[4];
            solidBrush = new SolidBrush(Color.Chartreuse);

          //  this.x = random.Next(30, 300);
           // this.y = random.Next(30, 300);
            this.widith = 13;
            this.height = 13;          
            
            for (int i = 0; i < SnakePart.Length;  i++)
            {
               SnakePart[i] = new Rectangle(x, y, widith, height);
               x -= 14;
            }
            Head = SnakePart[0];
        }

        public void DrawSnake(Graphics paper)
        {
            foreach (Rectangle rec in SnakePart)
            {
                paper.FillRectangle(solidBrush, rec);
            }
        }

        //części snake'a "podążają" za sobą, tj. poprzedni zajmuje miejsce następnego
        public void DrawSnake()
        {
            for (int i = SnakePart.Length - 1; i >0; i--)
             {
                 SnakePart[i] = SnakePart[i - 1];
             }
        }

        //obsluga poruszania się
        public void MoveUp()
        {         
            DrawSnake();
            SnakePart[0].Y -= 14;
        }
        public void MoveDown()
        {         
            DrawSnake();
            SnakePart[0].Y += 14;
        }
        public void MoveRight()
        {   DrawSnake();
            SnakePart[0].X += 14;
        }
        public void MoveLeft()
        {          
            DrawSnake();
            SnakePart[0].X -= 14;
        }

        public void GrowUp(int a)
        {
            Array.Resize(ref SnakePart, 4 + a);
            SnakePart[4 + a - 1] = new Rectangle(((x - 16)* 4 + a - 1), y, widith, height);
        }
    }
}

        
    

