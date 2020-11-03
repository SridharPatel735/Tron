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
    public partial class GameScreenSinglePlayer : UserControl
    {
        public GameScreenSinglePlayer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GameScreenSinglePlayer
            // 
            this.Name = "GameScreenSinglePlayer";
            this.Size = new System.Drawing.Size(1350, 800);
            this.ResumeLayout(false);

        }
    }
}
