namespace Tron
{
    partial class HighScoreScreen
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
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.Font = new System.Drawing.Font("Digital-7 Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.highScoreLabel.Location = new System.Drawing.Point(47, 136);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(483, 642);
            this.highScoreLabel.TabIndex = 0;
            this.highScoreLabel.Text = "label1";
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.highScoreLabel);
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(606, 832);
            this.Enter += new System.EventHandler(this.HighScoreScreen_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label highScoreLabel;
    }
}
