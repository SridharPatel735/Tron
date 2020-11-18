using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using System.IO;

namespace Tron
{
    public partial class MainScreen : UserControl
    {
        int counter = 0;
        public static System.Windows.Media.MediaPlayer backgroundPlayer = new System.Windows.Media.MediaPlayer();
        public static System.Windows.Media.MediaPlayer buttonMovePlayer = new System.Windows.Media.MediaPlayer();
        public static System.Windows.Media.MediaPlayer buttonClickPlayer = new System.Windows.Media.MediaPlayer();
        public MainScreen()
        {
            InitializeComponent();
            backgroundPlayer.Open(new Uri(Application.StartupPath + "/Resources/backgroundMusic.wav"));
            buttonMovePlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonSwitch.wav"));
            buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
            buttonClickPlayer.Play();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            InstructionScreen gs = new InstructionScreen();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            gs.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
            buttonClickPlayer.Play();
            Application.Exit();
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            buttonMovePlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonSwitch.wav"));
            buttonMovePlayer.Play();
            playButton.BackgroundImage = Properties.Resources.playImage;
            exitButton.BackgroundImage = Properties.Resources.exitImageSelected;
            multiPlayerButton.BackgroundImage = Properties.Resources._4PlayerButton;
        }

        private void playButton_Enter(object sender, EventArgs e)
        {
            buttonMovePlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonSwitch.wav"));
            buttonMovePlayer.Play();
            playButton.BackgroundImage = Properties.Resources.playImageSelected;
            exitButton.BackgroundImage = Properties.Resources.exitImage;
            multiPlayerButton.BackgroundImage = Properties.Resources._4PlayerButton;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            this.Location = new Point((form.Width - this.Width) / 2, (form.Height - this.Height) / 2);
            backgroundPlayer.Play();
        }

        private void multiPlayerButton_Enter(object sender, EventArgs e)
        {
            buttonMovePlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonSwitch.wav"));
            buttonMovePlayer.Play();
            playButton.BackgroundImage = Properties.Resources.playImage;
            exitButton.BackgroundImage = Properties.Resources.exitImage;
            multiPlayerButton.BackgroundImage = Properties.Resources._4PlayerButtonSelected;
        }

        private void musicTimer_Tick(object sender, EventArgs e)
        {
            if (counter == 183)
            {
                backgroundPlayer.Play();
                counter = 0;
            }
            counter++;
        }

        private void multiPlayerButton_Click(object sender, EventArgs e)
        {
            buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
            buttonClickPlayer.Play();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            InstructionScreen4Player gs = new InstructionScreen4Player();
            f.Controls.Add(gs);
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
            gs.Focus();
        }
    }
}
