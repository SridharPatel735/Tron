using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tron
{
    public partial class GameScreen : UserControl
    {
        List<Trail> playerTrailList = new List<Trail>();
        Rider OrangeRider = new Rider(745, 2, 5);
        Rider BlueRider = new Rider(150, 503, 5);
        int bufferDistanceY = 10, bufferDistanceX = 1;
        SolidBrush blueBrush = new SolidBrush(Color.DeepSkyBlue);
        SolidBrush orangeBrush = new SolidBrush(Color.OrangeRed);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        public int riderWidth = 20;
        public int riderHeight = 55;
        public string blueDirection = "Up", orangeDirection = "Down";
        int blueLives = 3, orangeLives = 3;
        Boolean rightArrowDown, leftArrowDown, upArrowDown, downArrowDown, aDown, wDown, sDown, dDown;
        Boolean rightBool = true, leftBool = true, upBool = false, downBool = false, wBool = false, dBool = true, sBool = false, aBool = true;

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    rightBool = false;
                    upBool = true;
                    downBool = true;
                    if (leftArrowDown == true && downArrowDown == true && blueDirection == "Left")
                    {
                        blueDirection = "Down";
                    }
                    else if (leftArrowDown == true && upArrowDown == true && blueDirection == "Left")
                    {
                        blueDirection = "Up";
                    }
                    else if (downArrowDown == true && leftArrowDown == true && blueDirection == "Down")
                    {
                        blueDirection = "Left";
                    }
                    else if (upArrowDown == true && leftArrowDown == true && blueDirection == "Up")
                    {
                        blueDirection = "Left";
                    }
                    if (leftBool == true)
                    {
                        BlueRider.X -= BlueRider.riderHeight - BlueRider.riderWidth + 15;
                        leftBool = false;
                    }
                    if (blueDirection == "Right" && leftArrowDown == true)
                    {
                        blueDirection = "Right";
                    }
                    else
                    {
                        blueDirection = "Left";
                    }
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    leftBool = false;
                    upBool = true;
                    downBool = true;
                    if (rightArrowDown == true && upArrowDown == true && blueDirection == "Right")
                    {
                        blueDirection = "Up";
                    }
                    else if (rightArrowDown == true && downArrowDown == true && blueDirection == "Right")
                    {
                        blueDirection = "Down";
                    }
                    else if (downArrowDown == true && rightArrowDown == true && blueDirection == "Down")
                    {
                        blueDirection = "Right";
                    }
                    else if (upArrowDown == true && rightArrowDown == true && blueDirection == "Up")
                    {
                        blueDirection = "Right";
                    }
                    if (rightBool == true)
                    {
                        BlueRider.X += BlueRider.riderHeight - BlueRider.riderWidth - 15;
                        rightBool = false;
                    }
                    if (blueDirection == "Left" && rightArrowDown == true)
                    {
                        blueDirection = "Left";
                    }
                    else
                    {
                        blueDirection = "Right";
                    }
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    leftBool = true;
                    upBool = false;
                    rightBool = true;
                    if (rightArrowDown == true && downArrowDown == true && blueDirection == "Right")
                    {
                        blueDirection = "Down";
                    }
                    else if (leftArrowDown == true && downArrowDown == true && blueDirection == "Left")
                    {
                        blueDirection = "Down";
                    }
                    else if (downArrowDown == true && rightArrowDown == true && blueDirection == "Down")
                    {
                        blueDirection = "Right";
                    }
                    else if (downArrowDown == true && leftArrowDown == true && blueDirection == "Down")
                    {
                        blueDirection = "Left";
                    }
                    if (downBool == true)
                    {
                        BlueRider.Y += 15;
                        downBool = false;
                    }
                    if (blueDirection == "Up" && downArrowDown == true)
                    {
                        blueDirection = "Up";
                    }
                    else
                    {
                        blueDirection = "Down";
                    }
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    leftBool = true;
                    downBool = false;
                    rightBool = true;
                    if (rightArrowDown == true && upArrowDown == true && blueDirection == "Right")
                    {
                        blueDirection = "Up";
                    }
                    else if (leftArrowDown == true && upArrowDown == true && blueDirection == "Left")
                    {
                        blueDirection = "Up";
                    }
                    else if (upArrowDown == true && rightArrowDown == true && blueDirection == "Up")
                    {
                        blueDirection = "Right";
                    }
                    else if (upArrowDown == true && leftArrowDown == true && blueDirection == "Up")
                    {
                        blueDirection = "Left";
                    }
                    if (upBool == true)
                    {
                        BlueRider.Y -= BlueRider.riderWidth - BlueRider.riderHeight + 15;
                        upBool = false;
                    }
                    if (blueDirection == "Down" && upArrowDown == true)
                    {
                        blueDirection = "Down";
                    }
                    else
                    {
                        blueDirection = "Up";
                    }
                    break;
                case Keys.A:
                    aDown = true;
                    dBool = false;
                    wBool = true;
                    sBool = true;
                    if (wDown == true && aDown == true && orangeDirection == "Up")
                    {
                        orangeDirection = "Left";
                    }
                    else if (sDown == true && aDown == true && orangeDirection == "Down")
                    {
                        orangeDirection = "Left";
                    }
                    else if (aDown == true && wDown == true && orangeDirection == "Left")
                    {
                        orangeDirection = "Up";
                    }
                    else if (aDown == true && sDown == true && orangeDirection == "Left")
                    {
                        orangeDirection = "Down";
                    }
                    if (aBool == true)
                    {
                        OrangeRider.X -= OrangeRider.riderHeight - OrangeRider.riderWidth + 5;
                        aBool = false;
                    }
                    if (orangeDirection == "Right" && aDown == true)
                    {
                        orangeDirection = "Right";
                    }
                    else
                    {
                        orangeDirection = "Left";
                    }
                    break;
                case Keys.W:
                    wDown = true;
                    aBool = true;
                    sBool = false;
                    dBool = true;
                    if (wDown == true && aDown == true && orangeDirection == "Up")
                    {
                        orangeDirection = "Left";
                    }
                    else if (wDown == true && dDown == true && orangeDirection == "Up")
                    {
                        orangeDirection = "Right";
                    }
                    else if (aDown == true && wDown == true && orangeDirection == "Left")
                    {
                        orangeDirection = "Up";
                    }
                    else if (dDown == true && wDown == true && orangeDirection == "Right")
                    {
                        orangeDirection = "Up";
                    }
                    if (wBool == true)
                    {
                        OrangeRider.Y -= OrangeRider.riderWidth - OrangeRider.riderHeight + 15;
                        wBool = false;
                    }
                    if (orangeDirection == "Down" && wDown == true)
                    {
                        orangeDirection = "Down";
                    }
                    else
                    {
                        orangeDirection = "Up";
                    }
                    break;
                case Keys.S:
                    sDown = true;
                    aBool = true;
                    wBool = false;
                    dBool = true;
                    if (sDown == true && dDown == true && orangeDirection == "Down")
                    {
                        orangeDirection = "Right";
                    }
                    else if (sDown == true && aDown == true && orangeDirection == "Down")
                    {
                        orangeDirection = "Left";
                    }
                    else if (aDown == true && sDown == true && orangeDirection == "Left")
                    {
                        orangeDirection = "Down";
                    }
                    else if (dDown == true && sDown == true && orangeDirection == "Right")
                    {
                        orangeDirection = "Down";
                    }
                    if (sBool == true)
                    {
                        OrangeRider.Y += OrangeRider.riderWidth - OrangeRider.riderHeight - 15;
                        sBool = false;
                    }
                    if (orangeDirection == "Up" && sDown == true)
                    {
                        orangeDirection = "Up";
                    }
                    else
                    {
                        orangeDirection = "Down";
                    }
                    break;
                case Keys.D:
                    dDown = true;
                    aBool = false;
                    wBool = true;
                    sBool = true;
                    if (wDown == true && dDown == true && orangeDirection == "Up")
                    {
                        orangeDirection = "Right";
                    }
                    else if (sDown == true && dDown == true && orangeDirection == "Down")
                    {
                        orangeDirection = "Right";
                    }
                    else if (dDown == true && wDown == true && orangeDirection == "Right")
                    {
                        orangeDirection = "Up";
                    }
                    else if (dDown == true && sDown == true && orangeDirection == "Right")
                    {
                        orangeDirection = "Down";
                    }
                    if (dBool == true)
                    {
                        OrangeRider.X += OrangeRider.riderHeight - OrangeRider.riderWidth - 15;
                        dBool = false;
                    }
                    if (orangeDirection == "Left" && dDown == true)
                    {
                        orangeDirection = "Left";
                    }
                    else
                    {
                        orangeDirection = "Right";
                    }
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
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
            }
        }

        public GameScreen()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region Movement & Adding Trail
            if (blueDirection == "Up" && BlueRider.Y > 0)
            {
                BlueRider.PlayerMoveUpDown(blueDirection);
                Trail newtrail = new Trail(BlueRider.X + bufferDistanceX, BlueRider.Y + BlueRider.riderHeight + bufferDistanceY, blueBrush);
                playerTrailList.Add(newtrail);
            }
            else if (blueDirection == "Down" && BlueRider.Y + BlueRider.riderHeight < this.Height)
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
            else if (orangeDirection == "Down" && OrangeRider.Y + OrangeRider.riderHeight < this.Height)
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
            if (BlueRider.Y <= 0 || BlueRider.Y + BlueRider.riderHeight >= this.Height || BlueRider.X <= 0 || BlueRider.X + BlueRider.riderWidth >= this.Width || OrangeRider.Y <= 0 || OrangeRider.Y + OrangeRider.riderHeight >= this.Height || OrangeRider.X <= 0 || OrangeRider.X + OrangeRider.riderWidth >= this.Width)
            {
                playerTrailList.Clear();
                BlueRider.Reset();
                OrangeRider.Reset();
                blueDirection = "Up";
                orangeDirection = "Down";
                rightBool = true;
                leftBool = true;
                upBool = false;
                downBool = false;
                wBool = false;
                dBool = true;
                sBool = false;
                aBool = true;
            }
            foreach (Trail x in playerTrailList)
            {
                Trail tempTrail = new Trail(x.trailX, x.trailY, x.colour);
                if (BlueRider.Collision(tempTrail) || OrangeRider.Collision(tempTrail))
                {
                    //gameTimer.Enabled = false;
                    BlueRider.Reset();
                    OrangeRider.Reset();
                    blueDirection = "Up";
                    orangeDirection = "Down";
                    rightBool = true;
                    leftBool = true;
                    upBool = false;
                    downBool = false;
                    wBool = false;
                    dBool = true;
                    sBool = false;
                    aBool = true;
                    playerTrailList.Clear();
                }
            }
            #endregion

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Trail b in playerTrailList)
            {
                e.Graphics.FillRectangle(b.colour, b.trailX, b.trailY, b.trailWidth, b.trailHeight);
            }
            e.Graphics.FillRectangle(whiteBrush, BlueRider.X, BlueRider.Y, BlueRider.riderWidth, BlueRider.riderHeight);
            e.Graphics.FillRectangle(whiteBrush, OrangeRider.X, OrangeRider.Y, OrangeRider.riderWidth, OrangeRider.riderHeight);
        }
    }
}
