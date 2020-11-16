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
            this.countDownBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).BeginInit();
            this.SuspendLayout();
            // 
            // countDownBox
            // 
            this.countDownBox.Location = new System.Drawing.Point(496, 598);
            this.countDownBox.Name = "countDownBox";
            this.countDownBox.Size = new System.Drawing.Size(612, 417);
            this.countDownBox.TabIndex = 0;
            this.countDownBox.TabStop = false;
            // 
            // FourPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.countDownBox);
            this.Name = "FourPlayer";
            this.Size = new System.Drawing.Size(1652, 1348);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FourPlayer_Paint);
            this.Enter += new System.EventHandler(this.FourPlayer_Enter);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FourPlayer_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FourPlayer_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.countDownBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox countDownBox;
    }
}
