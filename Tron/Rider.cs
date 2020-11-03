using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tron
{
    class Rider
    {
        public int X, Y, speed, startX, startY;
        public int riderWidth = 7, riderHeight = 28, riderWidthUpDown = 7, riderWidthLeftRight = 28, riderHeightUpDown = 28, riderHeightLeftRight = 7;

        public Rider (int _X, int _Y, int _speed)
        {
            X = _X;
            Y = _Y;
            speed = _speed;
            startX = X;
            startY = Y;
        }
        //Move method
        public int PlayerMoveUpDown(string _direction)
        {
            if (_direction == "Up")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;
                Y -= speed;
                return (Y);
            }
            else if (_direction == "Down")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;
                Y += speed;
                return (Y);
            }
            else
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;
                return (Y);
            }
        }
        //Move method
        public int PlayerMoveLeftRight(string _direction)
        {
            if (_direction == "Left")
            {
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;
                X -= speed;
                return (X);
            }
            else if (_direction == "Right")
            {
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;
                X += speed;
                return (X);
            }
            else
            {
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;
                return (X);
            }
        }
        public Boolean Collision(Trail playerTrail)
        {
            Rectangle riderRec = new Rectangle(X, Y, riderWidth, riderHeight);
            Rectangle trailRec = new Rectangle(playerTrail.trailX, playerTrail.trailY, playerTrail.trailWidth, playerTrail.trailHeight);
            if (riderRec.IntersectsWith(trailRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            X = startX;
            Y = startY;
        }
    }
}
