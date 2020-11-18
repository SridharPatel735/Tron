using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tron
{
    public partial class InstructionScreen : UserControl
    {
        #region variable declarations
        //player name global string
        public static string bluePlayerName, orangePlayerName;
        public static Label l1, l2, l3, l4, l5, l6, l7, l8;
        //booleans for key presses
        Boolean upArrowDown, downArrowDown, leftArrowDown, rightArrowDown, wDown, aDown, sDown, dDown;

        //booleans for checking which label the user is on
        Boolean char1Selected, char2Selected, char3Selected, char4Selected, char5Selected, char6Selected;

        //integers corresponding to each label's letter
        int i1 = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;
        int i6 = 0;

        //create a list with for letters A-Z
        List<string> letters = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "Y", "X", "Z", };
        #endregion variable declarations

        #region component initialization and general setup
        public InstructionScreen()
        {
            InitializeComponent();
            l1 = label1;
            l2 = nameInput1;
            l3 = nameInput2;
            l4 = nameInput3;
            l5 = label2;
            l6 = nameInput4;
            l7 = nameInput5;
            l8 = nameInput6;
            OnStart();
        }
        #endregion component initialization and general setup

        #region initial setup
        public void OnStart()
        {
            //set char1 to true and the others to false
            char1Selected = true;
            char2Selected = false;
            char3Selected = false;
            char4Selected = true;
            char5Selected = false;
            char6Selected = false;
        }
        #endregion initial setup

        private void InstructionScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player button presses
            switch (e.KeyCode)
            {
                case Keys.Up:
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    rightArrowDown = true;
                    break;
                case Keys.W:
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    wDown = true;
                    break;
                case Keys.A:
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    aDown = true;
                    break;
                case Keys.S:
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    sDown = true;
                    break;
                case Keys.D:
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    dDown = true;
                    break;
                case Keys.Space:
                    // Goes to the game screen
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    MainScreen.backgroundPlayer.Stop();
                    GameScreen gs = new GameScreen();
                    Form form = this.FindForm();

                    form.Controls.Add(gs);
                    gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
                    form.Controls.Remove(this);

                    //set the player name
                    bluePlayerName = nameInput1.Text + nameInput2.Text + nameInput3.Text;
                    orangePlayerName = nameInput4.Text + nameInput5.Text + nameInput6.Text;
                    break;

            }
        }

        private void InstructionScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player button releases
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }

        private void nameTimer_Tick(object sender, EventArgs e)
        {
            #region char1
            if (char1Selected == true)
            {
                //highlight the letter selected
                nameInput1.BackColor = Color.DeepSkyBlue;
                nameInput2.BackColor = Color.Black;
                nameInput3.BackColor = Color.Black;

                #region letter selection
                //if up is pressed, go to the next letter in the alphabet
                if (upArrowDown == true)
                {
                    i1++;
                    LetterLoop();
                    nameInput1.Text = letters[i1];

                    Thread.Sleep(150);
                }
                //if down is pressed, go to the previous letter in the alphabet
                if (downArrowDown == true)
                {
                    i1--;
                    LetterLoop();
                    nameInput1.Text = letters[i1];

                    Thread.Sleep(150);
                }
                //if right is pressed, go to the next letter
                if (rightArrowDown == true)
                {
                    char1Selected = false;
                    char2Selected = true;
                    char3Selected = false;

                    Thread.Sleep(150);
                    return;
                }
                #endregion letter selection
            }
            #endregion

            #region char2
            if (char2Selected == true)
            {
                //highlight the letter selected
                nameInput1.BackColor = Color.Black;
                nameInput2.BackColor = Color.DeepSkyBlue;
                nameInput3.BackColor = Color.Black;

                #region letter selection
                //if up is pressed, go to the next letter in the alphabet
                if (upArrowDown == true)
                {
                    i2++;
                    LetterLoop();
                    nameInput2.Text = letters[i2];

                    Thread.Sleep(150);
                }
                //if down is pressed, go to the previous letter in the alphabet
                if (downArrowDown == true)
                {
                    i2--;
                    LetterLoop();
                    nameInput2.Text = letters[i2];

                    Thread.Sleep(150);
                }
                //if left is pressed, go to the previous letter
                if (leftArrowDown == true)
                {
                    char1Selected = true;
                    char2Selected = false;
                    char3Selected = false;

                    Thread.Sleep(150);
                    return;
                }
                //if right is pressed, go to the next letter
                if (rightArrowDown == true)
                {
                    char1Selected = false;
                    char2Selected = false;
                    char3Selected = true;

                    Thread.Sleep(150);
                    return;
                }
                #endregion letter selection
            }
            #endregion

            #region char3
            if (char3Selected == true)
            {
                //highlight the letter selected
                nameInput1.BackColor = Color.Black;
                nameInput2.BackColor = Color.Black;
                nameInput3.BackColor = Color.DeepSkyBlue;

                #region letter selection
                //if up is pressed, go to the next letter in the alphabet
                if (upArrowDown == true)
                {
                    i3++;
                    LetterLoop();
                    nameInput3.Text = letters[i3];

                    Thread.Sleep(150);
                }
                //if down is pressed, go to the previous letter in the alphabet
                if (downArrowDown == true)
                {
                    i3--;
                    LetterLoop();
                    nameInput3.Text = letters[i3];

                    Thread.Sleep(150);
                }
                //if left is pressed, go to the previous letter
                if (leftArrowDown == true)
                {
                    char1Selected = false;
                    char2Selected = true;
                    char3Selected = false;

                    Thread.Sleep(150);
                    return;
                }
                #endregion letter selection
            }
            #endregion

            #region char4
            if (char4Selected == true)
            {
                //highlight the letter selected
                nameInput4.BackColor = Color.DeepSkyBlue;
                nameInput5.BackColor = Color.Black;
                nameInput6.BackColor = Color.Black;

                #region letter selection
                //if up is pressed, go to the next letter in the alphabet
                if (wDown == true)
                {
                    i4++;
                    LetterLoop();
                    nameInput4.Text = letters[i4];

                    Thread.Sleep(150);
                }
                //if down is pressed, go to the previous letter in the alphabet
                if (sDown == true)
                {
                    i4--;
                    LetterLoop();
                    nameInput4.Text = letters[i4];

                    Thread.Sleep(150);
                }
                //if right is pressed, go to the next letter
                if (dDown == true)
                {
                    char4Selected = false;
                    char5Selected = true;
                    char6Selected = false;

                    Thread.Sleep(150);
                    return;
                }
                #endregion letter selection
            }
            #endregion

            #region char5
            if (char5Selected == true)
            {
                //highlight the letter selected
                nameInput4.BackColor = Color.Black;
                nameInput5.BackColor = Color.DeepSkyBlue;
                nameInput6.BackColor = Color.Black;

                #region letter selection
                //if up is pressed, go to the next letter in the alphabet
                if (wDown == true)
                {
                    i5++;
                    LetterLoop();
                    nameInput5.Text = letters[i5];

                    Thread.Sleep(150);
                }
                //if down is pressed, go to the previous letter in the alphabet
                if (sDown == true)
                {
                    i5--;
                    LetterLoop();
                    nameInput5.Text = letters[i5];

                    Thread.Sleep(150);
                }
                //if left is pressed, go to the previous letter
                if (dDown == true)
                {
                    char4Selected = false;
                    char5Selected = false;
                    char6Selected = true;

                    Thread.Sleep(150);
                    return;
                }
                if (aDown == true)
                {
                    char4Selected = true;
                    char5Selected = false;
                    char6Selected = false;

                    Thread.Sleep(150);
                    return;
                }
                #endregion letter selection
            }
            #endregion

            #region char6
            if (char6Selected == true)
            {
                //highlight the letter selected
                nameInput4.BackColor = Color.Black;
                nameInput5.BackColor = Color.Black;
                nameInput6.BackColor = Color.DeepSkyBlue;

                #region letter selection
                //if up is pressed, go to the next letter in the alphabet
                if (wDown == true)
                {
                    i6++;
                    LetterLoop();
                    nameInput6.Text = letters[i6];

                    Thread.Sleep(150);
                }
                //if down is pressed, go to the previous letter in the alphabet
                if (sDown == true)
                {
                    i6--;
                    LetterLoop();
                    nameInput6.Text = letters[i6];

                    Thread.Sleep(150);
                }
                if (aDown == true)
                {
                    char4Selected = false;
                    char5Selected = true;
                    char6Selected = false;

                    Thread.Sleep(150);
                    return;
                }
                #endregion letter selection
            }
            #endregion
        }
        private void LetterLoop()
        {
            //if i1, i2, or i3 get to the beginning or the end of the alphabet, set it to the opposite
            //(aka if one more than "Z", go to "A" and vise versa)
            if (i1 == 26) { i1 = 0; }
            if (i1 == -1) { i1 = 25; }

            if (i2 == 26) { i2 = 0; }
            if (i2 == -1) { i2 = 25; }

            if (i3 == 26) { i3 = 0; }
            if (i3 == -1) { i3 = 25; }

            if (i4 == 26) { i4 = 0; }
            if (i4 == -1) { i4 = 25; }

            if (i5 == 26) { i5 = 0; }
            if (i5 == -1) { i5 = 25; }

            if (i6 == 26) { i6 = 0; }
            if (i6 == -1) { i6 = 25; }
        }
    }
}