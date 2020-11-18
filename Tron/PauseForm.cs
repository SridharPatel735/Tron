using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tron
{
    public partial class PauseForm : Form
    {
        private static PauseForm pauseForm;
        private static DialogResult buttonResult = new DialogResult();

        //Creating button selected
        private int buttonSelected;


        public PauseForm()
        {
            InitializeComponent();
        }
        //creating dialog to show the pauseform
        public static DialogResult Show()
        {
            pauseForm = new PauseForm();
            pauseForm.StartPosition = FormStartPosition.CenterScreen;

            pauseForm.ShowDialog();
            return buttonResult;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            buttonResult = DialogResult.Abort;
            Form form = this.FindForm();
            form.Controls.Remove(this);
            pauseForm.Close();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            buttonResult = DialogResult.Cancel;
            pauseForm.Close();
        }

        private void continueButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackgroundImage = Properties.Resources.Exit;
            continueButton.BackgroundImage = Properties.Resources.ContinueHighlight;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackgroundImage = Properties.Resources.ExitHighlight;
            continueButton.BackgroundImage = Properties.Resources.Continue;
        }
    }
}
