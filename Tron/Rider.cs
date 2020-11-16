using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Tron
{
    class Rider
    {
        public int X, Y, speed, startX, startY, lives = 3;
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
                if (GameScreen.blueDirection == "Up")
                {
                    GameScreen.blueRider = Properties.Resources.BlueBikeUp;
                }
                if (GameScreen.orangeDirection == "Up")
                {
                    GameScreen.orangeRider = Properties.Resources.RedBikeUp;
                }
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;
                Y -= speed;
                return (Y);
            }
            else if (_direction == "Down")
            {
                if (GameScreen.blueDirection == "Down")
                {
                    GameScreen.blueRider = Properties.Resources.BlueBikeDown;
                }
                if (GameScreen.orangeDirection == "Down")
                {
                    GameScreen.orangeRider = Properties.Resources.RedBikeDown;
                }
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
                if (GameScreen.blueDirection == "Left")
                {
                    GameScreen.blueRider = Properties.Resources.BlueBikeLeft;
                }
                if (GameScreen.orangeDirection == "Left")
                {
                    GameScreen.orangeRider = Properties.Resources.RedBikeLeft;
                }
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;
                X -= speed;
                return (X);
            }
            else if (_direction == "Right")
            {
                if (GameScreen.blueDirection == "Right")
                {
                    GameScreen.blueRider = Properties.Resources.BlueBikeRight;
                }
                if (GameScreen.orangeDirection == "Right")
                {
                    GameScreen.orangeRider = Properties.Resources.RedBikeRight;
                }
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
                lives--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean PlayerCollision(Rider rider)
        {
            Rectangle riderRec = new Rectangle(X, Y, riderWidth, riderHeight);
            Rectangle otherRec = new Rectangle(rider.X, rider.Y, rider.riderWidth, rider.riderHeight);
            if (riderRec.IntersectsWith(otherRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean BarrierCollision(Rectangle obstacles)
        {
            Rectangle riderRec = new Rectangle(X, Y, riderWidth, riderHeight);
            if (riderRec.IntersectsWith(obstacles))
            {
                lives--;
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
