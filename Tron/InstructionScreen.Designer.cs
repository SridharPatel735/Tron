namespace Tron
{
    partial class InstructionScreen
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
            this.nameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput3 = new System.Windows.Forms.Label();
            this.nameInput2 = new System.Windows.Forms.Label();
            this.nameInput1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTimer
            // 
            this.nameTimer.Enabled = true;
            this.nameTimer.Interval = 20;
            this.nameTimer.Tick += new System.EventHandler(this.nameTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(331, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name: ";
            // 
            // nameInput3
            // 
            this.nameInput3.AutoSize = true;
            this.nameInput3.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput3.ForeColor = System.Drawing.Color.OrangeRed;
            this.nameInput3.Location = new System.Drawing.Point(778, 653);
            this.nameInput3.Name = "nameInput3";
            this.nameInput3.Size = new System.Drawing.Size(116, 116);
            this.nameInput3.TabIndex = 6;
            this.nameInput3.Text = "A";
            // 
            // nameInput2
            // 
            this.nameInput2.AutoSize = true;
            this.nameInput2.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput2.ForeColor = System.Drawing.Color.OrangeRed;
            this.nameInput2.Location = new System.Drawing.Point(656, 653);
            this.nameInput2.Name = "nameInput2";
            this.nameInput2.Size = new System.Drawing.Size(116, 116);
            this.nameInput2.TabIndex = 5;
            this.nameInput2.Text = "A";
            // 
            // nameInput1
            // 
            this.nameInput1.AutoSize = true;
            this.nameInput1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput1.ForeColor = System.Drawing.Color.OrangeRed;
            this.nameInput1.Location = new System.Drawing.Point(534, 653);
            this.nameInput1.Name = "nameInput1";
            this.nameInput1.Size = new System.Drawing.Size(116, 116);
            this.nameInput1.TabIndex = 4;
            this.nameInput1.Text = "A";
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput3);
            this.Controls.Add(this.nameInput2);
            this.Controls.Add(this.nameInput1);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(1350, 800);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InstructionScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.InstructionScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer nameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameInput3;
        private System.Windows.Forms.Label nameInput2;
        private System.Windows.Forms.Label nameInput1;
    }
}
