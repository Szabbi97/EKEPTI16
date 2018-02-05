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
            this.sb_Level = new System.Windows.Forms.HScrollBar();
            this.lbl_Level = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.Location = new System.Drawing.Point(13, 45);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1041, 108);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // sb_Level
            // 
            this.sb_Level.LargeChange = 1;
            this.sb_Level.Location = new System.Drawing.Point(13, 13);
            this.sb_Level.Maximum = 9;
            this.sb_Level.Minimum = 1;
            this.sb_Level.Name = "sb_Level";
            this.sb_Level.Size = new System.Drawing.Size(941, 29);
            this.sb_Level.TabIndex = 1;
            this.sb_Level.Value = 1;
            this.sb_Level.ValueChanged += new System.EventHandler(this.sb_Level_ValueChanged);
            // 
            // lbl_Level
            // 
            this.lbl_Level.AutoSize = true;
            this.lbl_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Level.Location = new System.Drawing.Point(957, 13);
            this.lbl_Level.Name = "lbl_Level";
            this.lbl_Level.Size = new System.Drawing.Size(96, 29);
            this.lbl_Level.TabIndex = 2;
            this.lbl_Level.Text = "Level: 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 164);
            this.Controls.Add(this.lbl_Level);
            this.Controls.Add(this.sb_Level);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.HScrollBar sb_Level;
        private System.Windows.Forms.Label lbl_Level;
    }
}

