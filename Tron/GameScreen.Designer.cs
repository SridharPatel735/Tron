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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.countDownBox = new System.Windows.Forms.PictureBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blueLife1 = new System.Windows.Forms.PictureBox();
            this.blueLife2 = new System.Windows.Forms.PictureBox();
            this.blueLife3 = new System.Windows.Forms.PictureBox();
            this.orangeLife3 = new System.Windows.Forms.PictureBox();
            this.orangeLife2 = new System.Windows.Forms.PictureBox();
            this.orangeLife1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeLife3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeLife2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeLife1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
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
            this.timerLabel.Location = new System.Drawing.Point(654, 1244);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(317, 55);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "0";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDownBox
            // 
            this.countDownBox.BackColor = System.Drawing.Color.Transparent;
            this.countDownBox.BackgroundImage = global::Tron.Properties.Resources.Number3;
            this.countDownBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.countDownBox.Location = new System.Drawing.Point(655, 235);
            this.countDownBox.Name = "countDownBox";
            this.countDownBox.Size = new System.Drawing.Size(372, 381);
            this.countDownBox.TabIndex = 3;
            this.countDownBox.TabStop = false;
            // 
            // winnerLabel
            // 
            this.winnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel.Font = new System.Drawing.Font("Digital-7 Mono", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.winnerLabel.Location = new System.Drawing.Point(412, 292);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(756, 566);
            this.winnerLabel.TabIndex = 4;
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winnerLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Tron.Properties.Resources.bluelifebike;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(43, 1244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // blueLife1
            // 
            this.blueLife1.BackColor = System.Drawing.Color.Transparent;
            this.blueLife1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blueLife1.BackgroundImage")));
            this.blueLife1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueLife1.Location = new System.Drawing.Point(149, 1244);
            this.blueLife1.Name = "blueLife1";
            this.blueLife1.Size = new System.Drawing.Size(100, 50);
            this.blueLife1.TabIndex = 6;
            this.blueLife1.TabStop = false;
            // 
            // blueLife2
            // 
            this.blueLife2.BackColor = System.Drawing.Color.Transparent;
            this.blueLife2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blueLife2.BackgroundImage")));
            this.blueLife2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueLife2.Location = new System.Drawing.Point(255, 1244);
            this.blueLife2.Name = "blueLife2";
            this.blueLife2.Size = new System.Drawing.Size(100, 50);
            this.blueLife2.TabIndex = 7;
            this.blueLife2.TabStop = false;
            // 
            // blueLife3
            // 
            this.blueLife3.BackColor = System.Drawing.Color.Transparent;
            this.blueLife3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blueLife3.BackgroundImage")));
            this.blueLife3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueLife3.Location = new System.Drawing.Point(361, 1244);
            this.blueLife3.Name = "blueLife3";
            this.blueLife3.Size = new System.Drawing.Size(100, 50);
            this.blueLife3.TabIndex = 8;
            this.blueLife3.TabStop = false;
            // 
            // orangeLife3
            // 
            this.orangeLife3.BackColor = System.Drawing.Color.Transparent;
            this.orangeLife3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orangeLife3.BackgroundImage")));
            this.orangeLife3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orangeLife3.Location = new System.Drawing.Point(1442, 1244);
            this.orangeLife3.Name = "orangeLife3";
            this.orangeLife3.Size = new System.Drawing.Size(100, 50);
            this.orangeLife3.TabIndex = 12;
            this.orangeLife3.TabStop = false;
            // 
            // orangeLife2
            // 
            this.orangeLife2.BackColor = System.Drawing.Color.Transparent;
            this.orangeLife2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orangeLife2.BackgroundImage")));
            this.orangeLife2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orangeLife2.Location = new System.Drawing.Point(1336, 1244);
            this.orangeLife2.Name = "orangeLife2";
            this.orangeLife2.Size = new System.Drawing.Size(100, 50);
            this.orangeLife2.TabIndex = 11;
            this.orangeLife2.TabStop = false;
            // 
            // orangeLife1
            // 
            this.orangeLife1.BackColor = System.Drawing.Color.Transparent;
            this.orangeLife1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("orangeLife1.BackgroundImage")));
            this.orangeLife1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orangeLife1.Location = new System.Drawing.Point(1230, 1244);
            this.orangeLife1.Name = "orangeLife1";
            this.orangeLife1.Size = new System.Drawing.Size(100, 50);
            this.orangeLife1.TabIndex = 10;
            this.orangeLife1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::Tron.Properties.Resources.orangelifebike;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(1124, 1244);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 50);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.orangeLife3);
            this.Controls.Add(this.orangeLife2);
            this.Controls.Add(this.orangeLife1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.blueLife3);
            this.Controls.Add(this.blueLife2);
            this.Controls.Add(this.blueLife1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.countDownBox);
            this.Controls.Add(this.timerLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1625, 1350);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.Enter += new System.EventHandler(this.GameScreen_Enter);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeLife3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeLife2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeLife1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.PictureBox countDownBox;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox blueLife1;
        private System.Windows.Forms.PictureBox blueLife2;
        private System.Windows.Forms.PictureBox blueLife3;
        private System.Windows.Forms.PictureBox orangeLife3;
        private System.Windows.Forms.PictureBox orangeLife2;
        private System.Windows.Forms.PictureBox orangeLife1;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}
