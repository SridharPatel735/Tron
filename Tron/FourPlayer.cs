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
        Rider OrangeRider = new Rider(745, 2, 5);
        Rider BlueRider = new Rider(150, 503, 5);
        Rider GreenRider = new Rider(150, 2, 5);
        Rider YellowRider = new Rider(745, 503, 5);
        int bufferDistanceY = 10, bufferDistanceX = 1;
        Image blueRider = Properties.Resources.BlueBikeUp;
        Image orangeRider = Properties.Resources.RedBikeDown;
        SolidBrush blueBrush = new SolidBrush(Color.DeepSkyBlue);
        SolidBrush orangeBrush = new SolidBrush(Color.OrangeRed);
        SolidBrush blackBrush = new SolidBrush(Color.FromArgb(17, 17, 17));
        int counter = 0;
        int timer = 0;
        SolidBrush obsBrush = new SolidBrush(Color.White);
        public int riderWidth = 20;
        public int riderHeight = 55;
        public static string blueDirection = "Up", orangeDirection = "Down";
        int obsWidth = 10, obsHeight = 400;
        Random randGen = new Random();
        Boolean rightArrowDown, leftArrowDown, upArrowDown, downArrowDown, aDown, wDown, sDown, dDown, escDown, bDown, nDown, mDown, spaceDown, cDown, vDown, xDown, zDown;

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region Movement
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
                vDown = rightArrowDown = leftArrowDown = false;
            }

            //GreenRider
            if (bDown && (nDown || spaceDown))
            {
                bDown = nDown = spaceDown = false;
            }
            else if (mDown && (nDown || spaceDown))
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
        }

        private void FourPlayer_Enter(object sender, EventArgs e)
        {
            CountDown();
        }

        private void FourPlayer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.C:
                    cDown = true;
                    break;
                case Keys.V:
                    vDown = true;
                    break;
                case Keys.X:
                    xDown = true;
                    break;
                case Keys.Z:
                    zDown = true;
                    break;
                case Keys.Escape:
                    escDown = true;
                    //Pause();
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

                    //ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

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

        public FourPlayer()
        {
            InitializeComponent();
        }
        private void FourPlayer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blackBrush, 0, this.Height - 150, this.Width, 80);
        }
    }
}
