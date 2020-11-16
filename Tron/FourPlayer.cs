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
    public partial class FourPlayer : UserControl
    {
        List<Trail> playerTrailList = new List<Trail>();
        Rider OrangeRider = new Rider(745, 2, 5);
        Rider BlueRider = new Rider(150, 503, 5);
        int bufferDistanceY = 10, bufferDistanceX = 1;
        Image blueRider = Properties.Resources.BlueTronBike;
        Image orangeRider = Properties.Resources.RedTronBike;
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
        Boolean rightArrowDown, leftArrowDown, upArrowDown, downArrowDown, aDown, wDown, sDown, dDown, escDown, bDown, nDown, mDown;

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
                case Keys.Escape:
                    escDown = false;
                    break;
            }
        }
        public void CountDown()
        {
            //countDownBox.Visible = true;
            //countDownBox.BackgroundImage = Properties.Resources.Number3;
            //countDownBox.Refresh();

            //Thread.Sleep(1000);

            //countDownBox.BackgroundImage = Properties.Resources.Number2;
            //countDownBox.Refresh();

            //Thread.Sleep(1000);

            //countDownBox.BackgroundImage = Properties.Resources.Number1;
            //countDownBox.Refresh();

            //Thread.Sleep(1000);

            //countDownBox.Visible = false;
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
