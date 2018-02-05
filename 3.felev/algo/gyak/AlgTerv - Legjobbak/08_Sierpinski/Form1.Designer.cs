namespace _08_Sierpinski
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.lbl_Level = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(13, 13);
            this.hScrollBar1.Maximum = 10;
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1041, 37);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Level.Location = new System.Drawing.Point(1058, 13);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(96, 29);
            this.lbl_Level.TabIndex = 1;
            this.lbl_Level.Text = "Level: 1";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.OliveDrab;
            this.canvas.Location = new System.Drawing.Point(13, 54);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1141, 644);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 710);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label lbl_Level;
        private System.Windows.Forms.PictureBox canvas;
    }
}

