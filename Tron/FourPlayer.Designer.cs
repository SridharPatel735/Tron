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
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).BeginInit();
            this.SuspendLayout();
            // 
            // countDownBox
            // 
            this.countDownBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.countDownBox.Location = new System.Drawing.Point(372, 314);
            this.countDownBox.Margin = new System.Windows.Forms.Padding(2);
            this.countDownBox.Name = "countDownBox";
            this.countDownBox.Size = new System.Drawing.Size(570, 511);
            this.countDownBox.TabIndex = 0;
            this.countDownBox.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 13;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // FourPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.countDownBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FourPlayer";
            this.Size = new System.Drawing.Size(1239, 1095);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FourPlayer_Paint);
            this.Enter += new System.EventHandler(this.FourPlayer_Enter);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FourPlayer_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FourPlayer_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox countDownBox;
        private System.Windows.Forms.Timer gameTimer;
    }
}
