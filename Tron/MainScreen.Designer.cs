namespace Tron
{
    partial class MainScreen
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
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.titlePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.multiPlayerButton = new System.Windows.Forms.Button();
            this.musicTimer = new System.Windows.Forms.Timer(this.components);
            this.highScoreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.BackgroundImage = global::Tron.Properties.Resources.exitImage;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(922, 586);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(338, 126);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Black;
            this.playButton.BackgroundImage = global::Tron.Properties.Resources.playImage;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(98, 586);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(338, 126);
            this.playButton.TabIndex = 1;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.playButton_Enter);
            // 
            // titlePictureBox
            // 
            this.titlePictureBox.BackgroundImage = global::Tron.Properties.Resources.mainScreenTitle;
            this.titlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titlePictureBox.Location = new System.Drawing.Point(98, 0);
            this.titlePictureBox.Name = "titlePictureBox";
            this.titlePictureBox.Size = new System.Drawing.Size(1162, 543);
            this.titlePictureBox.TabIndex = 1;
            this.titlePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(476, 730);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press Space to Select\r\n";
            // 
            // multiPlayerButton
            // 
            this.multiPlayerButton.BackColor = System.Drawing.Color.Black;
            this.multiPlayerButton.BackgroundImage = global::Tron.Properties.Resources._4PlayerButton;
            this.multiPlayerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiPlayerButton.FlatAppearance.BorderSize = 0;
            this.multiPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiPlayerButton.Location = new System.Drawing.Point(441, 586);
            this.multiPlayerButton.Name = "multiPlayerButton";
            this.multiPlayerButton.Size = new System.Drawing.Size(476, 126);
            this.multiPlayerButton.TabIndex = 2;
            this.multiPlayerButton.UseVisualStyleBackColor = false;
            this.multiPlayerButton.Click += new System.EventHandler(this.multiPlayerButton_Click);
            this.multiPlayerButton.Enter += new System.EventHandler(this.multiPlayerButton_Enter);
            // 
            // musicTimer
            // 
            this.musicTimer.Enabled = true;
            this.musicTimer.Tick += new System.EventHandler(this.musicTimer_Tick);
            // 
            // highScoreButton
            // 
            this.highScoreButton.BackColor = System.Drawing.Color.Black;
            this.highScoreButton.BackgroundImage = global::Tron.Properties.Resources.highScore;
            this.highScoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.highScoreButton.FlatAppearance.BorderSize = 0;
            this.highScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highScoreButton.Location = new System.Drawing.Point(1014, 722);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(246, 68);
            this.highScoreButton.TabIndex = 4;
            this.highScoreButton.UseVisualStyleBackColor = false;
            this.highScoreButton.Click += new System.EventHandler(this.highScoreButton_Click);
            this.highScoreButton.Enter += new System.EventHandler(this.highScoreButton_Enter);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.highScoreButton);
            this.Controls.Add(this.multiPlayerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.titlePictureBox);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1350, 800);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titlePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox titlePictureBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button multiPlayerButton;
        private System.Windows.Forms.Timer musicTimer;
        private System.Windows.Forms.Button highScoreButton;
    }
}
