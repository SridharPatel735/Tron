namespace Tron
{
    partial class FourPlayer
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
            this.countDownBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.blueLives = new System.Windows.Forms.Label();
            this.greenLives = new System.Windows.Forms.Label();
            this.orangeLives = new System.Windows.Forms.Label();
            this.yellowLives = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).BeginInit();
            this.SuspendLayout();
            // 
            // countDownBox
            // 
            this.countDownBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.countDownBox.Location = new System.Drawing.Point(365, 294);
            this.countDownBox.Name = "countDownBox";
            this.countDownBox.Size = new System.Drawing.Size(855, 766);
            this.countDownBox.TabIndex = 0;
            this.countDownBox.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 13;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // blueLives
            // 
            this.blueLives.AutoSize = true;
            this.blueLives.BackColor = System.Drawing.Color.Transparent;
            this.blueLives.Font = new System.Drawing.Font("Digital-7 Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLives.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.blueLives.Location = new System.Drawing.Point(3, 1258);
            this.blueLives.Name = "blueLives";
            this.blueLives.Size = new System.Drawing.Size(63, 72);
            this.blueLives.TabIndex = 1;
            this.blueLives.Text = "3";
            this.blueLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenLives
            // 
            this.greenLives.AutoSize = true;
            this.greenLives.BackColor = System.Drawing.Color.Transparent;
            this.greenLives.Font = new System.Drawing.Font("Digital-7 Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLives.ForeColor = System.Drawing.Color.Lime;
            this.greenLives.Location = new System.Drawing.Point(72, 1258);
            this.greenLives.Name = "greenLives";
            this.greenLives.Size = new System.Drawing.Size(63, 72);
            this.greenLives.TabIndex = 2;
            this.greenLives.Text = "3";
            this.greenLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orangeLives
            // 
            this.orangeLives.AutoSize = true;
            this.orangeLives.BackColor = System.Drawing.Color.Transparent;
            this.orangeLives.Font = new System.Drawing.Font("Digital-7 Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orangeLives.ForeColor = System.Drawing.Color.OrangeRed;
            this.orangeLives.Location = new System.Drawing.Point(1490, 1258);
            this.orangeLives.Name = "orangeLives";
            this.orangeLives.Size = new System.Drawing.Size(63, 72);
            this.orangeLives.TabIndex = 3;
            this.orangeLives.Text = "3";
            this.orangeLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yellowLives
            // 
            this.yellowLives.AutoSize = true;
            this.yellowLives.BackColor = System.Drawing.Color.Transparent;
            this.yellowLives.Font = new System.Drawing.Font("Digital-7 Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLives.ForeColor = System.Drawing.Color.Yellow;
            this.yellowLives.Location = new System.Drawing.Point(1559, 1258);
            this.yellowLives.Name = "yellowLives";
            this.yellowLives.Size = new System.Drawing.Size(63, 72);
            this.yellowLives.TabIndex = 4;
            this.yellowLives.Text = "3";
            this.yellowLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winnerLabel
            // 
            this.winnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.winnerLabel.Location = new System.Drawing.Point(434, 392);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(756, 566);
            this.winnerLabel.TabIndex = 5;
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winnerLabel.Visible = false;
            // 
            // FourPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.yellowLives);
            this.Controls.Add(this.orangeLives);
            this.Controls.Add(this.greenLives);
            this.Controls.Add(this.blueLives);
            this.Controls.Add(this.countDownBox);
            this.DoubleBuffered = true;
            this.Name = "FourPlayer";
            this.Size = new System.Drawing.Size(1625, 1350);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FourPlayer_Paint);
            this.Enter += new System.EventHandler(this.FourPlayer_Enter);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FourPlayer_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FourPlayer_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox countDownBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label blueLives;
        private System.Windows.Forms.Label greenLives;
        private System.Windows.Forms.Label orangeLives;
        private System.Windows.Forms.Label yellowLives;
        private System.Windows.Forms.Label winnerLabel;
    }
}
