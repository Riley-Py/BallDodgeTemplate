using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallDodgeTemplate
{
   
    internal class Ball
    {
        public int x, y, ballXSpeed, ballYSpeed;
        public int size = 30;

        public Ball(int _x, int _y, int _ballXSpeed,int _ballYSpeed )
        {
            x = _x;
            y = _y;
            ballXSpeed = _ballXSpeed;
            ballYSpeed = _ballYSpeed;
        }
        public void Move(int width, int height)
        {
            x += ballXSpeed;
            y += ballYSpeed;


            if (x > width - size || x < 0)
            {
                ballXSpeed = -ballXSpeed;
            }
            if (y > height - size || y < 0)
            {
                ballYSpeed = -ballYSpeed;
            }
        }
    }
}
