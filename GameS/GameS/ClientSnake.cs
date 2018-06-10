using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//Sterowany WSADem
namespace GameS
{
    class ClientSnake : Snake
    {
        
        public ClientSnake(int x, int y, int widith, int height) : base(x, y, widith, height)
        {
            solidBrush = new SolidBrush(Color.Aqua);
        }

    }
}

