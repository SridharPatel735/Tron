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
        //Moving the robot according to the distance from the player
        public void AIMove(int _playerX, int _playerY)
        {
            //if (Distance(_playerX, _playerY) < 400)
            //{
            //    //If player is to the left of bot and headning in left direction whilst bot is heading left on the bottom half
            //    if(_playerX < X && GameScreen.blueDirection == "left" && botDirection == "left" && 533 / 2 > Y)
            //    {
            //        Go(botDirection);
            //    }
            //    //If player is to the left of bot and heading in left direction whilst bot is heading left and on the top half of screen
            //    else if (_playerX < X && GameScreen.blueDirection == "left" && botDirection == "left" && 533 / 2 < Y)
            //    {
            //        Go(botDirection);
            //    }
            //    //If player is heading left of bot whilst bot is moving in same direction on the bottum half of screen
            //    else if (_playerY < Y && GameScreen.blueDirection == "down" && botDirection == "down" && 900 / 2 < X)
            //    {
            //        Go(botDirection);
            //    }

            //}
            //else 
            //{ 
            //    Go(botDirection); 
            //}
            if (Distance(_playerX, _playerY) < 400)
            {
                if (X > _playerX && GameScreen.blueDirection == "left" && botDirection == "left")
                {
                    Go(botDirection);
                }
                else if (X < _playerX && GameScreen.blueDirection == "right" && botDirection == "right")
                {
                    Go(botDirection);
                }
                else if (Y < _playerY && GameScreen.blueDirection == "up" && botDirection == "up")
                {
                    Go(botDirection);
                }
                else if (Y > _playerY && GameScreen.blueDirection == "down" && botDirection == "down")
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
                X -= speed;
            }
            else if (_direction == "up")
            {
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;
                X += speed;
            }
            else if (_direction == "left")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;
                Y -= speed;
            }
            else if (_direction == "right")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;
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
                X += speed;
            }
            else if (_direction == "up")
            {
                riderHeight = riderHeightLeftRight;
                riderWidth = riderWidthLeftRight;
                X -= speed;
            }
            else if (_direction == "left")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;
                Y += speed;
            }
            else if (_direction == "right")
            {
                riderHeight = riderHeightUpDown;
                riderWidth = riderWidthUpDown;
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
