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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            InstructionScreen gs = new InstructionScreen();
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            playButton.BackgroundImage = Properties.Resources.playImage;
            exitButton.BackgroundImage = Properties.Resources.exitImageSelected;
        }

        private void playButton_Enter(object sender, EventArgs e)
        {
            playButton.BackgroundImage = Properties.Resources.playImageSelected;
            exitButton.BackgroundImage = Properties.Resources.exitImage;
        }
    }
}
