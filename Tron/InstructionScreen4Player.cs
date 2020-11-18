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
    public partial class InstructionScreen4Player : UserControl
    {
        public InstructionScreen4Player()
        {
            InitializeComponent();
        }

        private void InstructionScreen4Player_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    // Goes to the game screen
                    MainScreen.buttonClickPlayer.Open(new Uri(Application.StartupPath + "/Resources/ButtonClick.wav"));
                    MainScreen.buttonClickPlayer.Play();
                    MainScreen.backgroundPlayer.Stop();
                    FourPlayer gs = new FourPlayer();
                    Form form = this.FindForm();

                    form.Controls.Add(gs);
                    gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
                    form.Controls.Remove(this);
                    break;
            }
        }
    }
}
