namespace _07_CantorSet
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.sb_level = new System.Windows.Forms.HScrollBar();
            this.lbl_level = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.Location = new System.Drawing.Point(12, 42);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1113, 226);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // sb_level
            // 
            this.sb_level.LargeChange = 1;
            this.sb_level.Location = new System.Drawing.Point(12, 9);
            this.sb_level.Maximum = 9;
            this.sb_level.Minimum = 1;
            this.sb_level.Name = "sb_level";
            this.sb_level.Size = new System.Drawing.Size(1075, 17);
            this.sb_level.TabIndex = 1;
            this.sb_level.Value = 1;
            this.sb_level.ValueChanged += new System.EventHandler(this.sb_level_ValueChanged);
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Location = new System.Drawing.Point(1090, 9);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(45, 13);
            this.lbl_level.TabIndex = 2;
            this.lbl_level.Text = "Level: 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 286);
            this.Controls.Add(this.lbl_level);
            this.Controls.Add(this.sb_level);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.HScrollBar sb_level;
        private System.Windows.Forms.Label lbl_level;
    }
}

