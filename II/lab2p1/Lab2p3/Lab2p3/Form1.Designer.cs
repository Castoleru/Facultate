namespace Lab2p3
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
            this.nr1 = new System.Windows.Forms.TextBox();
            this.nr2 = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nr1
            // 
            this.nr1.Location = new System.Drawing.Point(12, 51);
            this.nr1.Name = "nr1";
            this.nr1.Size = new System.Drawing.Size(221, 20);
            this.nr1.TabIndex = 0;
            // 
            // nr2
            // 
            this.nr2.Location = new System.Drawing.Point(12, 96);
            this.nr2.Name = "nr2";
            this.nr2.Size = new System.Drawing.Size(221, 20);
            this.nr2.TabIndex = 1;
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(12, 139);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(221, 20);
            this.rez.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numarul1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numarul2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rezultatul";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siToolStripMenuItem,
            this.sauToolStripMenuItem,
            this.xorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siToolStripMenuItem
            // 
            this.siToolStripMenuItem.Name = "siToolStripMenuItem";
            this.siToolStripMenuItem.Size = new System.Drawing.Size(27, 20);
            this.siToolStripMenuItem.Text = "si";
            this.siToolStripMenuItem.Click += new System.EventHandler(this.siToolStripMenuItem_Click);
            // 
            // sauToolStripMenuItem
            // 
            this.sauToolStripMenuItem.Name = "sauToolStripMenuItem";
            this.sauToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sauToolStripMenuItem.Text = "sau";
            this.sauToolStripMenuItem.Click += new System.EventHandler(this.sauToolStripMenuItem_Click);
            // 
            // xorToolStripMenuItem
            // 
            this.xorToolStripMenuItem.Name = "xorToolStripMenuItem";
            this.xorToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.xorToolStripMenuItem.Text = "xor";
            this.xorToolStripMenuItem.Click += new System.EventHandler(this.xorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.nr2);
            this.Controls.Add(this.nr1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nr1;
        private System.Windows.Forms.TextBox nr2;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xorToolStripMenuItem;
    }
}

