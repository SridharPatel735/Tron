using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//Programed by Sammy McNab
namespace Tron
{
    class AI
    {
        public static string botDirection = "up";
        public int X, Y, speed, startX, startY;
        public int riderWidth = 7, riderHeight = 28, riderWidthUpDown = 7, riderWidthLeftRight = 28, riderHeightUpDown = 28, riderHeightLeftRight = 7;
        //creating the AI
        public AI(int _X, int _Y, int _speed)
        {
            X = _X;
            Y = _Y;
            speed = _speed;
            startX = X;
            startY = Y;
        }

        //calculates distance of center of player from center of bot(radius)
        public double Distance(int _playerX, int _playerY)
        {
            double dx = X - _playerX;
            double dy = Y - _playerY;
            double distance = Math.Sqrt(dx * dx + dy * dy);
            return (distance);
        }
        //Moving the robot according to the distance and direction of the player
        public void AIMove(int _playerX, int _playerY)
        {
            if (Distance(_playerX, _playerY) < 400)
            {
                if (X > _playerX && GameScreen.blueDirection == "left" && botDirection == "left")//add if trail y is not within 10 of either side (&& trailY + 10 > Y && trailY - 10 < Y)     
                {
                    if (Y > _playerY || Y < _playerY && X > 20)
                    {
                        Go(botDirection);
                    }
                    else if (Y < _playerY)
                    {
                        TurnRight(botDirection);
                    }
                }
                else if (X > _playerX && GameScreen.blueDirection == "left" && botDirection == "left")
                {

                }

                else if (X < _playerX && GameScreen.blueDirection == "right" && botDirection == "right")//add if trail y is not within 10 of either side (&& trailY + 10 > Y && trailY - 10 < Y)
                {
                    Go(botDirection);
                }
                else if (Y < _playerY && GameScreen.blueDirection == "up" && botDirection == "up")//add if trail x is not within 10 of either side (&& trailX + 10 > X && trailX - 10 < X)
                {
                    Go(botDirection);
                }
                else if (Y > _playerY && GameScreen.blueDirection == "down" && botDirection == "down")//add if trail x is not within 10 of either side (&& trailX + 10 > X && trailX - 10 < X)
                {
                    Go(botDirection);
                }
                else if (X > _playerX && GameScreen.blueDirection == "down" && botDirection == "up")
                {

                }
            }
        }
        //Turning right for the Move method
        public void TurnRight(string _direction)
        {
            if (_direction == "down")
            {
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;

                botDirection = "left";

                X -= speed;
            }
            else if (_direction == "up")
            {
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;

                botDirection = "right";

                X += speed;
            }
            else if (_direction == "left")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;

                botDirection = "up";

                Y -= speed;
            }
            else if (_direction == "right")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;

                botDirection = "down";

                Y += speed;
            }
        }
        //Turning left for the move method
        public void TurnLeft(string _direction)
        {
            if (_direction == "down")
            {
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;

                botDirection = "right";

                X += speed;
            }
            else if (_direction == "up")
            {
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;

                botDirection = "left";

                X -= speed;
            }
            else if (_direction == "left")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;

                botDirection = "down";

                Y += speed;
            }
            else if (_direction == "right")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;

                botDirection = "up";

                Y -= speed;
            }
        }
        public void Go(string _direction)
        {
            if (_direction == "down")
            {
                Y += speed;
            }
            else if (_direction == "up")
            {
                Y -= speed;
            }
            else if (_direction == "left")
            {
                X -= speed;
            }
            else if (_direction == "right")
            {

                X += speed;
            }
        }
    }
}
