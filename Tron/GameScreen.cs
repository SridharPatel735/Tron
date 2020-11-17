using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;

namespace Tron
{
    public partial class GameScreen : UserControl
    {
        List<Score> highScoreList = new List<Score>();
        List<Trail> playerTrailList = new List<Trail>();
        List<Rectangle> obstaclesList = new List<Rectangle>();
        Rider OrangeRider = new Rider(1475, 10, 5);
        Rider BlueRider = new Rider(150, 1148, 5);
        int bufferDistanceY = 10, bufferDistanceX = 1;
        public static Image blueRider = Properties.Resources.BlueBikeUp;
        public static Image orangeRider = Properties.Resources.RedBikeUp;
        SolidBrush blueBrush = new SolidBrush(Color.DeepSkyBlue);
        SolidBrush orangeBrush = new SolidBrush(Color.OrangeRed);
        SolidBrush blackBrush = new SolidBrush(Color.FromArgb(17, 17, 17));
        int counter = 0;
        int timer = 0;
        SolidBrush obsBrush = new SolidBrush(Color.White);
        public int riderWidth = 20;
        public int riderHeight = 55;
        public static string blueDirection = "Up", orangeDirection = "Down";
        int obsWidth = 10, obsHeight = 500;
        Random randGen = new Random();
        Boolean rightArrowDown, leftArrowDown, upArrowDown, downArrowDown, aDown, wDown, sDown, dDown, escDown;
        Boolean reset = true;
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
                case Keys.Escape:
                    escDown = true;
                    Pause();
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
                case Keys.Escape:
                    escDown = false;
                    break;
            }
        }

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        public void OnStart()
        {
            for (int i = 0; i <= randGen.Next(3,6); i++)
            {
                int x = randGen.Next(55, this.Width - 55);
                if (x >= 130 && x <= 170)
                {
                    x = randGen.Next(55, this.Width - 55);
                }
                if (x >= 1455 && x <= 1495)
                {
                    x = randGen.Next(55, this.Width - 55);
                }
                foreach (Rectangle b in obstaclesList)
                {
                    while (b.X <= x + 175 && b.X >= x - 175)
                    {
                        x = randGen.Next(55, this.Width - 55);
                    }
                }
                int y = randGen.Next(55, this.Height - 715);
                Rectangle newRec = new Rectangle(x, y, obsWidth, obsHeight);
                obstaclesList.Add(newRec);
            }
        }
        private void GameScreen_Enter(object sender, EventArgs e)
        {
            CountDown();
            reset = false;
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region direction
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

            #region Movement & Adding Trail
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

            if (reset == false)
            {
                HighScore();
            }

            #region Collision
            //Collision with walls
            if (BlueRider.Y <= 0 || BlueRider.Y + BlueRider.riderHeight >= this.Height - 160 || BlueRider.X <= 0 || BlueRider.X + BlueRider.riderWidth >= this.Width)
            {
                BlueRider.lives--;
                collisionReset();
            }
            else if (OrangeRider.Y <= 0 || OrangeRider.Y + OrangeRider.riderHeight >= this.Height - 160 || OrangeRider.X <= 0 || OrangeRider.X + OrangeRider.riderWidth >= this.Width)
            {
                OrangeRider.lives--;
                collisionReset();
            }
            //Collision with other player
            if (BlueRider.PlayerCollision(OrangeRider) || OrangeRider.PlayerCollision(BlueRider))
            {
                collisionReset();
            }
            //Collision with trail
            foreach (Trail x in playerTrailList)
            {
                Trail tempTrail = new Trail(x.trailX, x.trailY, x.colour);
                if (BlueRider.Collision(tempTrail) || OrangeRider.Collision(tempTrail))
                {
                    collisionReset();
                    break;
                }
            }

            foreach (Rectangle x in obstaclesList)
            {
                Rectangle tempObstacle = new Rectangle(x.X, x.Y, x.Width, x.Height);
                if (BlueRider.BarrierCollision(tempObstacle) || OrangeRider.BarrierCollision(tempObstacle))
                {
                    collisionReset();
                    break;
                }
            }
            #endregion

            #region Life Check
            //Blue Life
            if (BlueRider.lives == 3)
            {
                blueLife1.BackgroundImage = Properties.Resources.bluelife_1_png;
                blueLife2.BackgroundImage = Properties.Resources.bluelife_1_png;
                blueLife3.BackgroundImage = Properties.Resources.bluelife_1_png;
            }
            else if (BlueRider.lives == 2)
            {
                blueLife1.BackgroundImage = Properties.Resources.bluelife_1_png;
                blueLife2.BackgroundImage = Properties.Resources.bluelife_1_png;
                blueLife3.BackgroundImage = null;
            }
            else if (BlueRider.lives == 1)
            {
                blueLife1.BackgroundImage = Properties.Resources.bluelife_1_png;
                blueLife2.BackgroundImage = null;
                blueLife3.BackgroundImage = null;
            }
            else if (BlueRider.lives == 0)
            {
                blueLife1.BackgroundImage = null;
                blueLife2.BackgroundImage = null;
                blueLife3.BackgroundImage = null;
            }
            //Orange Life
            if (OrangeRider.lives == 3)
            {
                orangeLife1.BackgroundImage = Properties.Resources.orangeLife_1_png;
                orangeLife2.BackgroundImage = Properties.Resources.orangeLife_1_png;
                orangeLife3.BackgroundImage = Properties.Resources.orangeLife_1_png;
            }
            else if (OrangeRider.lives == 2)
            {
                orangeLife1.BackgroundImage = Properties.Resources.orangeLife_1_png;
                orangeLife2.BackgroundImage = Properties.Resources.orangeLife_1_png;
                orangeLife3.BackgroundImage = null;
            }
            else if (OrangeRider.lives == 1)
            {
                orangeLife1.BackgroundImage = Properties.Resources.orangeLife_1_png;
                orangeLife2.BackgroundImage = null;
                orangeLife3.BackgroundImage = null;
            }
            else if (OrangeRider.lives == 0)
            {
                orangeLife1.BackgroundImage = null;
                orangeLife2.BackgroundImage = null;
                orangeLife3.BackgroundImage = null;
            }

            if (BlueRider.lives == 0 || OrangeRider.lives == 0)
            {
                gameTimer.Enabled = false;
                countDownBox.Visible = false;
                winnerLabel.Visible = true;
                if (BlueRider.lives == 0)
                {
                    winnerLabel.Text = InstructionScreen.orangePlayerName + " is the Winner!!!";
                }
                else
                {
                    winnerLabel.Text = InstructionScreen.bluePlayerName + " is the Winner!!!";
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
            #endregion

            Refresh();
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
                    ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
                    form.Controls.Remove(this);
                }
            }
        }
        public void CountDown()
        {
            countDownBox.Location = new Point((this.Width / 2) - (countDownBox.Width / 2), (this.Height / 2) - (countDownBox.Height / 2));

            countDownBox.Visible = true;
            countDownBox.BackgroundImage = Properties.Resources.Number3;
            countDownBox.Refresh();

            Refresh();
            Thread.Sleep(1000);

            countDownBox.BackgroundImage = Properties.Resources.Number2;
            countDownBox.Refresh();

            Refresh();
            Thread.Sleep(1000);

            countDownBox.BackgroundImage = Properties.Resources.Number1;
            countDownBox.Refresh();

            Refresh();
            Thread.Sleep(1000);

            countDownBox.Visible = false;
        }
        public void HighScore()
        {
            counter++;
            if (counter > 80)
            {
                timer++;
                counter = 0;
            }
            timerLabel.Text = "" + timer;
        }
        public void HighScoreRead()
        {
            XmlReader reader = XmlReader.Create("Resources/HighScores.xml", null);


            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    string player1 = reader.ReadString();

                    reader.ReadToNextSibling("name2");
                    string player2 = reader.ReadString();

                    reader.ReadToFollowing("time");
                    string score = reader.ReadString();

                    Score s = new Score(player1, player2, score);
                    highScoreList.Add(s);
                }
            }
            highScoreList.RemoveAt(highScoreList.Count - 1);
            reader.Close();

            //Checks for 10 highgscores
            if (highScoreList.Count > 10)
            {
                highScoreList.RemoveAt(10);
            }
            if (Convert.ToInt32(highScoreList[highScoreList.Count - 1].score) <= timer)
            {
                for (int i = 0; i <= highScoreList.Count; i++)
                {
                    if (Convert.ToInt32(highScoreList[i].score) <= timer)
                    {
                        Score s = new Score(InstructionScreen.bluePlayerName, InstructionScreen.orangePlayerName, Convert.ToString(timer));
                        highScoreList.Insert(i, s);
                        break;
                    }
                }
            }
            if (highScoreList.Count > 10)
            {
                highScoreList.RemoveAt(10);
            }

        }
        public void HighScoreWrite()
        {
            XmlWriter writer = XmlWriter.Create("Resources/HighScore.xml", null);

            writer.WriteStartElement("HighScore");

            foreach (Score s in highScoreList)
            {
                writer.WriteStartElement("Score");

                writer.WriteElementString("name1", s.name1);
                writer.WriteElementString("name2", s.name2);
                writer.WriteElementString("time", s.score);

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Trail b in playerTrailList)
            {
                e.Graphics.FillRectangle(b.colour, b.trailX, b.trailY, b.trailWidth, b.trailHeight);
            }
            foreach (Rectangle x in obstaclesList)
            {
                e.Graphics.FillRectangle(obsBrush, x.X, x.Y, x.Width, x.Height);
            }
            e.Graphics.DrawImage(blueRider, BlueRider.X, BlueRider.Y, BlueRider.riderWidth, BlueRider.riderHeight);
            e.Graphics.DrawImage(orangeRider, OrangeRider.X, OrangeRider.Y, OrangeRider.riderWidth, OrangeRider.riderHeight);

            e.Graphics.FillRectangle(blackBrush, 0, this.Height - 160, this.Width, 160);
        }
        public void collisionReset()
        {
            blueDirection = "Up";
            BlueRider.PlayerMoveUpDown(blueDirection);
            orangeDirection = "Down";
            OrangeRider.PlayerMoveUpDown(orangeDirection);
            reset = true;
            playerTrailList.Clear();
            BlueRider.Reset();
            OrangeRider.Reset();
            HighScoreRead();
            HighScoreWrite();
            timer = 0;
            Refresh();
            if (BlueRider.lives == 0 || OrangeRider.lives == 0)
            {}
            else
            {
                CountDown();
            }
            reset = false;
            obstaclesList.Clear();
            OnStart();
        }
    }
}