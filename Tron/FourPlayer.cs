﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;


namespace Tron
{
    public partial class FourPlayer : UserControl
    {
        List<Trail> playerTrailList = new List<Trail>();
        Rider OrangeRider = new Rider(1475, 10, 5);
        Rider BlueRider = new Rider(150, 1148, 5);
        Rider GreenRider = new Rider(10, 150, 5);
        Rider YellowRider = new Rider(1600, 1040, 5);
        int bufferDistanceY = 10, bufferDistanceX = 1;
        Image blueRider = Properties.Resources.BlueBikeUp;
        Image orangeRider = Properties.Resources.RedBikeDown;
        Image yellowRider = Properties.Resources.YellowBikeLeft;
        Image greenRider = Properties.Resources.GreenBikeRight;
        SolidBrush blueBrush = new SolidBrush(Color.DeepSkyBlue);
        SolidBrush orangeBrush = new SolidBrush(Color.OrangeRed);
        SolidBrush greenBrush = new SolidBrush(Color.Lime);
        SolidBrush yellowBrush = new SolidBrush(Color.Gold);
        SolidBrush blackBrush = new SolidBrush(Color.FromArgb(17, 17, 17));
        public int riderWidth = 20;
        public int riderHeight = 55;
        int musicCounter = 0;
        public static string blueDirection = "Up", greenDirection = "Right", yellowDirection = "Left", orangeDirection = "Down";
        Boolean rightArrowDown, leftArrowDown, upArrowDown, downArrowDown, aDown, wDown, sDown, dDown, escDown, bDown, nDown, mDown, spaceDown, cDown, vDown, xDown, zDown;
        Boolean blueAlive = true, orangeAlive = true, greenAlive = true, yellowAlive = true;
        System.Windows.Media.MediaPlayer musicPlayer = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer buttonClickPlayer = new System.Windows.Media.MediaPlayer();

        public FourPlayer()
        {
            InitializeComponent();
            musicPlayer.Open(new Uri(Application.StartupPath + "/Resources/gameBackgroundMusic.wav"));
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            blueLives.Text = BlueRider.lives + "";
            greenLives.Text = GreenRider.lives + "";
            orangeLives.Text = OrangeRider.lives + "";
            yellowLives.Text = YellowRider.lives + "";

            #region Music
            musicCounter++;
            if (musicCounter == 616)
            {
                musicCounter = 0;
                musicPlayer.Open(new Uri(Application.StartupPath + "/Resources/gameBackgroundMusic.wav"));
                musicPlayer.Play();
            }
            #endregion

            #region Changing Direction

            #region Cancel presses on more than one
            //BlueRider
            if (leftArrowDown && (upArrowDown || downArrowDown))
            {
                leftArrowDown = upArrowDown = downArrowDown = false;
            }
            else if (rightArrowDown && (upArrowDown || downArrowDown))
            {
                rightArrowDown = upArrowDown = downArrowDown = false;
            }
            else if (downArrowDown && (rightArrowDown || leftArrowDown))
            {
                downArrowDown = rightArrowDown = leftArrowDown = false;
            }
            else if (upArrowDown && (rightArrowDown || leftArrowDown))
            {
                upArrowDown = rightArrowDown = leftArrowDown = false;
            }

            //OrangeRider
            if (aDown && (wDown || sDown))
            {
                aDown = wDown = sDown = false;
            }
            else if (dDown && (wDown || sDown))
            {
                dDown = wDown = sDown = false;
            }
            else if (sDown && (dDown || aDown))
            {
                sDown = dDown = aDown = false;
            }
            else if (wDown && (dDown || aDown))
            {
                wDown = dDown = aDown = false;
            }

            //YellowRider
            if (cDown && (vDown || zDown))
            {
                cDown = vDown = zDown = false;
            }
            else if (xDown && (vDown || zDown))
            {
                xDown = vDown = zDown = false;
            }
            else if (zDown && (xDown || cDown))
            {
                zDown = xDown = cDown = false;
            }
            else if (vDown && (xDown || cDown))
            {
                vDown = xDown = cDown = false;
            }

            //GreenRider
            if (bDown && (nDown || spaceDown))
            {
                bDown = nDown = spaceDown = false;
            }
            else if (mDown && (nDown || spaceDown))
            {
                mDown = nDown = spaceDown = false;
            }
            else if (spaceDown && (mDown || bDown))
            {
                spaceDown = mDown = bDown = false;
            }
            else if (nDown && (mDown || bDown))
            {
                nDown = mDown = bDown = false;
            }

            #endregion

            //YellowRider
            if (cDown && yellowDirection == "Up")
            {
                yellowDirection = "Left";
                YellowRider.X -= 23;
                YellowRider.Y += 32;
                cDown = false;
            }
            else if (cDown && yellowDirection == "Down")
            {
                yellowDirection = "Left";
                YellowRider.X -= 23;
                YellowRider.Y -= 6;
                cDown = false;
            }
            else if (xDown && yellowDirection != "Right" && yellowDirection == "Up")
            {
                yellowDirection = "Right";
                YellowRider.X += 6;
                YellowRider.Y += 32;
            }
            else if (xDown && yellowDirection != "Right" && yellowDirection == "Down")
            {
                yellowDirection = "Right";
                YellowRider.X += 6;
                YellowRider.Y -= 10;
            }
            else if (vDown && yellowDirection != "Up" && yellowDirection == "Left")
            {
                yellowDirection = "Up";
                YellowRider.X += 23;
                YellowRider.Y -= 32;
            }
            else if (vDown && yellowDirection != "Up" && yellowDirection == "Right")
            {
                yellowDirection = "Up";
                YellowRider.X -= 6;
                YellowRider.Y -= 32;
            }
            else if (zDown && yellowDirection != "Down" && yellowDirection == "Left")
            {
                yellowDirection = "Down";
                YellowRider.X += 23;
                YellowRider.Y += 6;
            }
            else if (zDown && yellowDirection != "Down" && yellowDirection == "Right")
            {
                yellowDirection = "Down";
                YellowRider.X -= 6;
                YellowRider.Y += 6;
            }

            //GreenRider
            if (bDown && greenDirection == "Up")
            {
                greenDirection = "Left";
                GreenRider.X -= 32;
                GreenRider.Y += 32;
                bDown = false;
            }
            else if (bDown && greenDirection == "Down")
            {
                greenDirection = "Left";
                GreenRider.X -= 32;
                GreenRider.Y -= 6;
                bDown = false;
            }
            else if (mDown && greenDirection != "Right" && greenDirection == "Up")
            {
                greenDirection = "Right";
                GreenRider.X += 6;
                GreenRider.Y += 32;
            }
            else if (mDown && greenDirection != "Right" && greenDirection == "Down")
            {
                greenDirection = "Right";
                GreenRider.X += 6;
                GreenRider.Y -= 10;
            }
            else if (nDown && greenDirection != "Up" && greenDirection == "Left")
            {
                greenDirection = "Up";
                GreenRider.X += 32;
                GreenRider.Y -= 32;
            }
            else if (nDown && greenDirection != "Up" && greenDirection == "Right")
            {
                greenDirection = "Up";
                GreenRider.X -= 6;
                GreenRider.Y -= 32;
            }
            else if (spaceDown && greenDirection != "Down" && greenDirection == "Left")
            {
                greenDirection = "Down";
                GreenRider.X += 32;
                GreenRider.Y += 6;
            }
            else if (spaceDown && greenDirection != "Down" && greenDirection == "Right")
            {
                greenDirection = "Down";
                GreenRider.X -= 6;
                GreenRider.Y += 6;
            }


            //BlueRider
            if (leftArrowDown && blueDirection == "Up")
            {
                blueDirection = "Left";
                BlueRider.X -= 32;
                BlueRider.Y += 32;
                leftArrowDown = false;
            }
            else if (leftArrowDown && blueDirection == "Down")
            {
                blueDirection = "Left";
                BlueRider.X -= 32;
                BlueRider.Y -= 6;
                leftArrowDown = false;
            }
            else if (rightArrowDown && blueDirection != "Right" && blueDirection == "Up")
            {
                blueDirection = "Right";
                BlueRider.X += 6;
                BlueRider.Y += 32;
            }
            else if (rightArrowDown && blueDirection != "Right" && blueDirection == "Down")
            {
                blueDirection = "Right";
                BlueRider.X += 6;
                BlueRider.Y -= 10;
            }
            else if (upArrowDown && blueDirection != "Up" && blueDirection == "Left")
            {
                blueDirection = "Up";
                BlueRider.X += 32;
                BlueRider.Y -= 32;
            }
            else if (upArrowDown && blueDirection != "Up" && blueDirection == "Right")
            {
                blueDirection = "Up";
                BlueRider.X -= 6;
                BlueRider.Y -= 32;
            }
            else if (downArrowDown && blueDirection != "Down" && blueDirection == "Left")
            {
                blueDirection = "Down";
                BlueRider.X += 32;
                BlueRider.Y += 6;
            }
            else if (downArrowDown && blueDirection != "Down" && blueDirection == "Right")
            {
                blueDirection = "Down";
                BlueRider.X -= 6;
                BlueRider.Y += 6;
            }

            //OrangeRider
            if (aDown && orangeDirection != "Left" && orangeDirection == "Up")
            {
                orangeDirection = "Left";
                OrangeRider.X -= 23;
                OrangeRider.Y += 32;
            }
            else if (aDown && orangeDirection != "Left" && orangeDirection == "Down")
            {
                orangeDirection = "Left";
                OrangeRider.X -= 23;
                OrangeRider.Y -= 6;
            }
            else if (dDown && orangeDirection != "Right" && orangeDirection == "Up")
            {
                orangeDirection = "Right";
                OrangeRider.X += 6;
                OrangeRider.Y += 32;
            }
            else if (dDown && orangeDirection != "Right" && orangeDirection == "Down")
            {
                orangeDirection = "Right";
                OrangeRider.X += 6;
                OrangeRider.Y -= 10;
            }
            else if (wDown && orangeDirection != "Up" && orangeDirection == "Left")
            {
                orangeDirection = "Up";
                OrangeRider.X += 28;
                OrangeRider.Y -= 32;
            }
            else if (wDown && orangeDirection != "Up" && orangeDirection == "Right")
            {
                orangeDirection = "Up";
                OrangeRider.X -= 6;
                OrangeRider.Y -= 32;
            }
            else if (sDown && orangeDirection != "Down" && orangeDirection == "Left")
            {
                orangeDirection = "Down";
                OrangeRider.X += 28;
                OrangeRider.Y += 6;
            }
            else if (sDown && orangeDirection != "Down" && orangeDirection == "Right")
            {
                orangeDirection = "Down";
                OrangeRider.X -= 6;
                OrangeRider.Y += 6;
            }
            #endregion

            #region Movement and bike trail
            //Green Bike movement and trail generation
            if (greenDirection == "Up" && GreenRider.Y > 0)
            {
                GreenRider.PlayerMoveUpDown(greenDirection);
                Trail newtrail = new Trail(GreenRider.X + bufferDistanceX, GreenRider.Y + GreenRider.riderHeight + bufferDistanceY, greenBrush);
                playerTrailList.Add(newtrail);
            }
            else if (greenDirection == "Down" && GreenRider.Y + GreenRider.riderHeight < this.Height - 160)
            {
                GreenRider.PlayerMoveUpDown(greenDirection);
                Trail newtrail = new Trail(GreenRider.X + bufferDistanceX, GreenRider.Y - bufferDistanceY, greenBrush);
                playerTrailList.Add(newtrail);
            }
            else if (greenDirection == "Left" && GreenRider.X > 0)
            {
                GreenRider.PlayerMoveLeftRight(greenDirection);
                Trail newtrail = new Trail(GreenRider.X + GreenRider.riderWidth + bufferDistanceY, GreenRider.Y + bufferDistanceX, greenBrush);
                playerTrailList.Add(newtrail);
            }
            else if (greenDirection == "Right" && GreenRider.X + GreenRider.riderWidth < this.Width)
            {
                GreenRider.PlayerMoveLeftRight(greenDirection);
                Trail newtrail = new Trail(GreenRider.X - bufferDistanceY, GreenRider.Y + bufferDistanceX, greenBrush);
                playerTrailList.Add(newtrail);
            }

            //Yellow Bike movement and trail generation
            if (yellowDirection == "Up" && YellowRider.Y > 0)
            {
                YellowRider.PlayerMoveUpDown(yellowDirection);
                Trail newtrail = new Trail(YellowRider.X + bufferDistanceX, YellowRider.Y + YellowRider.riderHeight + bufferDistanceY, yellowBrush);
                playerTrailList.Add(newtrail);
            }
            else if (yellowDirection == "Down" && YellowRider.Y + YellowRider.riderHeight < this.Height - 160)
            {
                YellowRider.PlayerMoveUpDown(yellowDirection);
                Trail newtrail = new Trail(YellowRider.X + bufferDistanceX, YellowRider.Y - bufferDistanceY, yellowBrush);
                playerTrailList.Add(newtrail);
            }
            else if (yellowDirection == "Left" && YellowRider.X > 0)
            {
                YellowRider.PlayerMoveLeftRight(yellowDirection);
                Trail newtrail = new Trail(YellowRider.X + YellowRider.riderWidth + bufferDistanceX, YellowRider.Y + bufferDistanceX, yellowBrush);
                playerTrailList.Add(newtrail);
            }
            else if (yellowDirection == "Right" && YellowRider.X + YellowRider.riderWidth < this.Width)
            {
                YellowRider.PlayerMoveLeftRight(yellowDirection);
                Trail newtrail = new Trail(YellowRider.X - bufferDistanceY, YellowRider.Y + bufferDistanceX, yellowBrush);
                playerTrailList.Add(newtrail);
            }



            if (blueDirection == "Up" && BlueRider.Y > 0)
            {
                BlueRider.PlayerMoveUpDown(blueDirection);
                Trail newtrail = new Trail(BlueRider.X + bufferDistanceX, BlueRider.Y + BlueRider.riderHeight + bufferDistanceY, blueBrush);
                playerTrailList.Add(newtrail);
            }
            else if (blueDirection == "Down" && BlueRider.Y + BlueRider.riderHeight < this.Height - 160)
            {
                BlueRider.PlayerMoveUpDown(blueDirection);
                Trail newtrail = new Trail(BlueRider.X + bufferDistanceX, BlueRider.Y - bufferDistanceY, blueBrush);
                playerTrailList.Add(newtrail);
            }
            else if (blueDirection == "Left" && BlueRider.X > 0)
            {
                BlueRider.PlayerMoveLeftRight(blueDirection);
                Trail newtrail = new Trail(BlueRider.X + BlueRider.riderWidth + bufferDistanceY, BlueRider.Y + bufferDistanceX, blueBrush);
                playerTrailList.Add(newtrail);
            }
            else if (blueDirection == "Right" && BlueRider.X + BlueRider.riderWidth < this.Width)
            {
                BlueRider.PlayerMoveLeftRight(blueDirection);
                Trail newtrail = new Trail(BlueRider.X - bufferDistanceY, BlueRider.Y + bufferDistanceX, blueBrush);
                playerTrailList.Add(newtrail);
            }

            if (orangeDirection == "Up" && OrangeRider.Y > 0)
            {
                OrangeRider.PlayerMoveUpDown(orangeDirection);
                Trail newtrail = new Trail(OrangeRider.X + bufferDistanceX, OrangeRider.Y + OrangeRider.riderHeight + bufferDistanceY, orangeBrush);
                playerTrailList.Add(newtrail);
            }
            else if (orangeDirection == "Down" && OrangeRider.Y + OrangeRider.riderHeight < this.Height - 160)
            {
                OrangeRider.PlayerMoveUpDown(orangeDirection);
                Trail newtrail = new Trail(OrangeRider.X + bufferDistanceX, OrangeRider.Y - bufferDistanceY, orangeBrush);
                playerTrailList.Add(newtrail);
            }
            else if (orangeDirection == "Left" && OrangeRider.X > 0)
            {
                OrangeRider.PlayerMoveLeftRight(orangeDirection);
                Trail newtrail = new Trail(OrangeRider.X + OrangeRider.riderWidth + bufferDistanceX, OrangeRider.Y + bufferDistanceX, orangeBrush);
                playerTrailList.Add(newtrail);
            }
            else if (orangeDirection == "Right" && OrangeRider.X + OrangeRider.riderWidth < this.Width)
            {
                OrangeRider.PlayerMoveLeftRight(orangeDirection);
                Trail newtrail = new Trail(OrangeRider.X - bufferDistanceY, OrangeRider.Y + bufferDistanceX, orangeBrush);
                playerTrailList.Add(newtrail);
            }
            #endregion

            #region Collision
            //Blue bike collision with wall
            if (BlueRider.Y <= 0 || BlueRider.Y + BlueRider.riderHeight >= this.Height - 160 || BlueRider.X <= 0 || BlueRider.X + BlueRider.riderWidth >= this.Width)
            {
                BlueRider.lives--;
                if (BlueRider.lives == 0)
                {
                    blueAlive = false;
                    blueDirection = "Up";
                    BlueRider.PlayerMoveUpDown(blueDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == blueBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    BlueRider.Reset();
                }
                else
                {
                    blueDirection = "Up";
                    BlueRider.PlayerMoveUpDown(blueDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == blueBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    BlueRider.Reset();
                    Refresh();
                }
            }
            //Orange bike collision with wall
            if (OrangeRider.Y <= 0 || OrangeRider.Y + OrangeRider.riderHeight >= this.Height - 160 || OrangeRider.X <= 0 || OrangeRider.X + OrangeRider.riderWidth >= this.Width)
            {
                OrangeRider.lives--;
                if (OrangeRider.lives == 0)
                {
                    orangeAlive = false;
                    orangeDirection = "Down";
                    OrangeRider.PlayerMoveUpDown(orangeDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == orangeBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    OrangeRider.Reset();
                }
                else
                {
                    orangeDirection = "Dowm";
                    OrangeRider.PlayerMoveUpDown(orangeDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == orangeBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    OrangeRider.Reset();
                    Refresh();
                }
            }

            //Green bike collision with wall
            if (GreenRider.Y <= 0 || GreenRider.Y + GreenRider.riderHeight >= this.Height - 160 || GreenRider.X <= 0 || GreenRider.X + GreenRider.riderWidth >= this.Width)
            {
                GreenRider.lives--;
                if (GreenRider.lives == 0)
                {
                    greenAlive = false;
                    greenDirection = "Right";
                    GreenRider.PlayerMoveUpDown(greenDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == greenBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    GreenRider.Reset();
                }
                else
                {
                    greenDirection = "Right";
                    GreenRider.PlayerMoveUpDown(greenDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == greenBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    GreenRider.Reset();
                    Refresh();
                }
            }

            //Yellow bike collision with wall
            if (YellowRider.Y <= 0 || YellowRider.Y + YellowRider.riderHeight >= this.Height - 160 || YellowRider.X <= 0 || YellowRider.X + YellowRider.riderWidth >= this.Width)
            {
                YellowRider.lives--;
                if (YellowRider.lives == 0)
                {
                    yellowAlive = false;
                    yellowDirection = "Left";
                    YellowRider.PlayerMoveUpDown(yellowDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == yellowBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    YellowRider.Reset();
                }
                else
                {
                    yellowDirection = "Left";
                    YellowRider.PlayerMoveUpDown(yellowDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == yellowBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    YellowRider.Reset();
                    Refresh();
                }
            }

            //Collision with other player
            if (BlueRider.PlayerCollision(OrangeRider) || BlueRider.PlayerCollision(GreenRider) || BlueRider.PlayerCollision(YellowRider))
            {
                if (BlueRider.PlayerCollision(OrangeRider))
                {
                    blueDirection = "Up";
                    BlueRider.PlayerMoveUpDown(blueDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == blueBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    BlueRider.Reset();
                    orangeDirection = "Dowm";
                    OrangeRider.PlayerMoveUpDown(orangeDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == orangeBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    OrangeRider.Reset();
                    Refresh();
                }
                else if (BlueRider.PlayerCollision(GreenRider))
                {
                    blueDirection = "Up";
                    BlueRider.PlayerMoveUpDown(blueDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == blueBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    BlueRider.Reset();
                    greenDirection = "Right";
                    GreenRider.PlayerMoveUpDown(greenDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == greenBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    GreenRider.Reset();
                    Refresh();
                }
                else if (BlueRider.PlayerCollision(YellowRider))
                {
                    blueDirection = "Up";
                    BlueRider.PlayerMoveUpDown(blueDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == blueBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    BlueRider.Reset();
                    yellowDirection = "Left";
                    YellowRider.PlayerMoveUpDown(yellowDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == yellowBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    YellowRider.Reset();
                    Refresh();
                }
            }
            if (OrangeRider.PlayerCollision(YellowRider) || OrangeRider.PlayerCollision(GreenRider))
            {
                if (OrangeRider.PlayerCollision(YellowRider))
                {
                    orangeDirection = "Dowm";
                    OrangeRider.PlayerMoveUpDown(orangeDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == orangeBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    OrangeRider.Reset();
                    yellowDirection = "Left";
                    YellowRider.PlayerMoveUpDown(yellowDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == yellowBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    YellowRider.Reset();
                    Refresh();
                }
                else if (OrangeRider.PlayerCollision(GreenRider))
                {
                    orangeDirection = "Dowm";
                    OrangeRider.PlayerMoveUpDown(orangeDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == orangeBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    OrangeRider.Reset();
                    greenDirection = "Right";
                    GreenRider.PlayerMoveUpDown(greenDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == greenBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    GreenRider.Reset();
                    Refresh();
                }
            }
            if (YellowRider.PlayerCollision(GreenRider))
            {
                if (YellowRider.PlayerCollision(GreenRider))
                {
                    yellowDirection = "Left";
                    YellowRider.PlayerMoveUpDown(yellowDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == yellowBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    YellowRider.Reset();
                    greenDirection = "Right";
                    GreenRider.PlayerMoveUpDown(greenDirection);
                    foreach (Trail x in playerTrailList)
                    {
                        if (x.colour == greenBrush)
                        {
                            playerTrailList.Remove(x);
                        }
                    }
                    GreenRider.Reset();
                    Refresh();
                }
            }

            #region Collision with trails
            //Collision with trail
            foreach (Trail x in playerTrailList)
            {
                Trail tempTrail = new Trail(x.trailX, x.trailY, x.colour);
                if (BlueRider.Collision(tempTrail))
                {
                    blueDirection = "Up";
                    BlueRider.PlayerMoveUpDown(blueDirection);
                    BlueRider.Reset();
                    foreach (Trail t in playerTrailList)
                    {
                        if (t.colour == blueBrush)
                        {
                            playerTrailList.Remove(t);
                        }
                    }
                }
                if (OrangeRider.Collision(tempTrail))
                {
                    orangeDirection = "Up";
                    OrangeRider.PlayerMoveUpDown(blueDirection);
                    OrangeRider.Reset();
                    foreach (Trail t in playerTrailList)
                    {
                        if (t.colour == orangeBrush)
                        {
                            playerTrailList.Remove(t);
                        }
                    }
                }
                if (GreenRider.Collision(tempTrail))
                {
                    greenDirection = "Up";
                    GreenRider.PlayerMoveUpDown(blueDirection);
                    GreenRider.Reset();
                    foreach (Trail t in playerTrailList)
                    {
                        if (t.colour == greenBrush)
                        {
                            playerTrailList.Remove(t);
                        }
                    }
                }
                if (YellowRider.Collision(tempTrail))
                {
                    yellowDirection = "Up";
                    YellowRider.PlayerMoveUpDown(blueDirection);
                    YellowRider.Reset();
                    foreach (Trail t in playerTrailList)
                    {
                        if (t.colour == yellowBrush)
                        {
                            playerTrailList.Remove(t);
                        }
                    }
                }
            }
            #endregion

            #endregion

            #region lifeCheck
            if ((BlueRider.lives == 0 && OrangeRider.lives == 0 && GreenRider.lives == 0 && YellowRider.lives != 0) || (BlueRider.lives == 0 && OrangeRider.lives == 0 && GreenRider.lives != 0 && YellowRider.lives == 0) || (BlueRider.lives == 0 && OrangeRider.lives != 0 && GreenRider.lives == 0 && YellowRider.lives == 0) || (BlueRider.lives != 0 && OrangeRider.lives == 0 && GreenRider.lives == 0 && YellowRider.lives == 0))
            {
                LifeCheck();
            }
            #endregion

            Refresh();
        }

        public void LifeCheck()
        {
            gameTimer.Enabled = false;
            countDownBox.Visible = false;
            winnerLabel.Visible = true;
            if (BlueRider.lives == 0 && OrangeRider.lives == 0 && GreenRider.lives == 0 && YellowRider.lives != 0)
            {
                winnerLabel.Text = "Yellow is the Winner!!!";
            }
            else if (BlueRider.lives == 0 && OrangeRider.lives == 0 && GreenRider.lives != 0 && YellowRider.lives == 0)
            {
                winnerLabel.Text = "Green is the Winner!!!";
            }
            else if (BlueRider.lives == 0 && OrangeRider.lives != 0 && GreenRider.lives == 0 && YellowRider.lives == 0)
            {
                winnerLabel.Text = "Orange is the Winner!";
            }
            else if (BlueRider.lives != 0 && OrangeRider.lives == 0 && GreenRider.lives == 0 && YellowRider.lives == 0)
            {
                winnerLabel.Text = "Blue is the winner";
            }
            Refresh();
            Thread.Sleep(4000);
            winnerLabel.Visible = false;
            Refresh();
            // Goes to the main screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
            ms.Focus();
        }

        private void FourPlayer_Enter(object sender, EventArgs e)
        {
            CountDown();
            winnerLabel.Visible = false;
        }

        private void FourPlayer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (blueAlive == false)
                    {
                        leftArrowDown = false;
                    }
                    else
                    {
                        leftArrowDown = true;
                    }
                    break;
                case Keys.Right:
                    if (blueAlive == false)
                    {
                        rightArrowDown = false;
                    }
                    else
                    {
                        rightArrowDown = true;
                    }
                    break;
                case Keys.Down:
                    if (blueAlive == false)
                    {
                        downArrowDown = false;
                    }
                    else
                    {
                        downArrowDown = true;
                    }
                    break;
                case Keys.Up:
                    if (blueAlive == false)
                    {
                        upArrowDown = false;
                    }
                    else
                    {
                        upArrowDown = true;
                    }
                    break;
                case Keys.A:
                    if (orangeAlive == false)
                    {
                        aDown = false;
                    }
                    else
                    {
                        aDown = true;
                    }
                    break;
                case Keys.W:
                    if (orangeAlive == false)
                    {
                        wDown = false;
                    }
                    else
                    {
                        wDown = true;
                    }
                    break;
                case Keys.S:
                    if (orangeAlive == false)
                    {
                        sDown = false;
                    }
                    else
                    {
                        sDown = true;
                    }
                    break;
                case Keys.D:
                    if (orangeAlive == false)
                    {
                        dDown = false;
                    }
                    else
                    {
                        dDown = true;
                    }
                    break;
                case Keys.B:
                    if (greenAlive == false)
                    {
                        bDown = false;
                    }
                    else
                    {
                        bDown = true;
                    }
                    break;
                case Keys.N:
                    if (greenAlive == false)
                    {
                        nDown = false;
                    }
                    else
                    {
                        nDown = true;
                    }
                    break;
                case Keys.M:
                    if (greenAlive == false)
                    {
                        mDown = false;
                    }
                    else
                    {
                        mDown = true;
                    }
                    break;
                case Keys.Space:
                    if (greenAlive == false)
                    {
                        spaceDown = false;
                    }
                    else
                    {
                        spaceDown = true;
                    }
                    break;
                case Keys.C:
                    if (yellowAlive == false)
                    {
                        cDown = false;
                    }
                    else
                    {
                        cDown = true;
                    }
                    break;
                case Keys.V:
                    if (yellowAlive == false)
                    {
                        vDown = false;
                    }
                    else
                    {
                        vDown = true;
                    }
                    break;
                case Keys.X:
                    if (yellowAlive == false)
                    {
                        xDown = false;
                    }
                    else
                    {
                        xDown = true;
                    }
                    break;
                case Keys.Z:
                    if (yellowAlive == false)
                    {
                        zDown = false;
                    }
                    else
                    {
                        zDown = true;
                    }
                    break;
                case Keys.Escape:
                    buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    buttonClickPlayer.Play();
                    escDown = true;
                    Pause();
                    break;
            }
        }

        private void FourPlayer_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.C:
                    cDown = false;
                    break;
                case Keys.V:
                    vDown = false;
                    break;
                case Keys.X:
                    xDown = false;
                    break;
                case Keys.Z:
                    zDown = false;
                    break;
                case Keys.Escape:
                    escDown = false;
                    break;
            }
        }
        public void Pause()
        {
            if (gameTimer.Enabled == true)
            {

                gameTimer.Enabled = false;

                DialogResult dr = PauseForm.Show();

                if (dr == DialogResult.Cancel)
                {
                    gameTimer.Enabled = true;
                }
                else if (dr == DialogResult.Abort)
                {
                    Form form = this.FindForm();
                    MainScreen ms = new MainScreen();

                    form.Controls.Add(ms);
                    form.Controls.Remove(this);
                }
            }
        }
        public void CountDown()
        {
            //center to screen
            countDownBox.Location = new Point((this.Width / 2) - (countDownBox.Width / 2), (this.Height / 2) - (countDownBox.Height / 2));

            countDownBox.Visible = true;
            countDownBox.BackgroundImage = Properties.Resources.Number3;
            countDownBox.Refresh();

            Thread.Sleep(1000);

            countDownBox.BackgroundImage = Properties.Resources.Number2;
            countDownBox.Refresh();

            Thread.Sleep(1000);

            countDownBox.BackgroundImage = Properties.Resources.Number1;
            countDownBox.Refresh();

            Thread.Sleep(1000);

            countDownBox.Visible = false;
        }

        private void FourPlayer_Paint(object sender, PaintEventArgs e)
        {
            foreach (Trail b in playerTrailList)
            {
                e.Graphics.FillRectangle(b.colour, b.trailX, b.trailY, b.trailWidth, b.trailHeight);
            }
            e.Graphics.DrawImage(blueRider, BlueRider.X, BlueRider.Y, BlueRider.riderWidth, BlueRider.riderHeight);
            e.Graphics.DrawImage(orangeRider, OrangeRider.X, OrangeRider.Y, OrangeRider.riderWidth, OrangeRider.riderHeight);
            e.Graphics.DrawImage(yellowRider, YellowRider.X, YellowRider.Y, YellowRider.riderWidth, YellowRider.riderHeight);
            e.Graphics.DrawImage(greenRider, GreenRider.X, GreenRider.Y, GreenRider.riderWidth, GreenRider.riderHeight);

            e.Graphics.FillRectangle(blackBrush, 0, this.Height - 160, this.Width, 160);
        }
    }
}
