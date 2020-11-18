namespace Tron
{
    partial class InstructionScreen4Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionScreen4Player));
            this.label3 = new System.Windows.Forms.Label();
            this.intructionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Digital-7 Mono", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(502, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 60);
            this.label3.TabIndex = 17;
            this.label3.Text = "Press Space to Select\r\n";
            // 
            // intructionLabel
            // 
            this.intructionLabel.Font = new System.Drawing.Font("Digital-7 Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intructionLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.intructionLabel.Location = new System.Drawing.Point(3, 236);
            this.intructionLabel.Name = "intructionLabel";
            this.intructionLabel.Size = new System.Drawing.Size(1328, 363);
            this.intructionLabel.TabIndex = 16;
            this.intructionLabel.Text = resources.GetString("intructionLabel.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tron.Properties.Resources.instructionTitle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1319, 159);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Digital-7 Mono", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(249, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 101);
            this.label1.TabIndex = 18;
            this.label1.Text = "BluePlayer = ArrowKeys | OrangePlayer = WASD GreenPlayer = BNMSpace | YellowPlaye" +
    "r = ZXCV\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionScreen4Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intructionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InstructionScreen4Player";
            this.Size = new System.Drawing.Size(1350, 800);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InstructionScreen4Player_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label intructionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
