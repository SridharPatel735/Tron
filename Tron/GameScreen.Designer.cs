namespace Tron
{
    partial class GameScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.blueLifeLabel = new System.Windows.Forms.Label();
            this.redLifeLabel = new System.Windows.Forms.Label();
            this.countDownBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 13;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.timerLabel.Location = new System.Drawing.Point(530, 1252);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(318, 55);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "0";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueLifeLabel
            // 
            this.blueLifeLabel.BackColor = System.Drawing.Color.Black;
            this.blueLifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLifeLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.blueLifeLabel.Location = new System.Drawing.Point(15, 1252);
            this.blueLifeLabel.Name = "blueLifeLabel";
            this.blueLifeLabel.Size = new System.Drawing.Size(348, 46);
            this.blueLifeLabel.TabIndex = 1;
            this.blueLifeLabel.Text = "BLUE LIVES:";
            // 
            // redLifeLabel
            // 
            this.redLifeLabel.BackColor = System.Drawing.Color.Black;
            this.redLifeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLifeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.redLifeLabel.Location = new System.Drawing.Point(1134, 1252);
            this.redLifeLabel.Name = "redLifeLabel";
            this.redLifeLabel.Size = new System.Drawing.Size(328, 46);
            this.redLifeLabel.TabIndex = 2;
            this.redLifeLabel.Text = "RED LIVES:";
            // 
            // countDownBox
            // 
            this.countDownBox.BackgroundImage = global::Tron.Properties.Resources.Number3;
            this.countDownBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.countDownBox.Location = new System.Drawing.Point(363, 156);
            this.countDownBox.Name = "countDownBox";
            this.countDownBox.Size = new System.Drawing.Size(372, 381);
            this.countDownBox.TabIndex = 3;
            this.countDownBox.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.countDownBox);
            this.Controls.Add(this.redLifeLabel);
            this.Controls.Add(this.blueLifeLabel);
            this.Controls.Add(this.timerLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1622, 1348);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label blueLifeLabel;
        private System.Windows.Forms.Label redLifeLabel;
        private System.Windows.Forms.PictureBox countDownBox;
    }
}
