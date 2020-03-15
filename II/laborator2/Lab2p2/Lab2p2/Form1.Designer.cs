namespace Lab2p2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.copiaza = new System.Windows.Forms.Button();
            this.sterge = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 251);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(317, 21);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(143, 251);
            this.listBox2.TabIndex = 1;
            // 
            // copiaza
            // 
            this.copiaza.Location = new System.Drawing.Point(190, 21);
            this.copiaza.Name = "copiaza";
            this.copiaza.Size = new System.Drawing.Size(95, 37);
            this.copiaza.TabIndex = 2;
            this.copiaza.Text = "Copiaza";
            this.copiaza.UseVisualStyleBackColor = true;
            this.copiaza.Click += new System.EventHandler(this.copiaza_Click);
            // 
            // sterge
            // 
            this.sterge.Location = new System.Drawing.Point(190, 118);
            this.sterge.Name = "sterge";
            this.sterge.Size = new System.Drawing.Size(95, 37);
            this.sterge.TabIndex = 3;
            this.sterge.Text = "Sterge";
            this.sterge.UseVisualStyleBackColor = true;
            this.sterge.Click += new System.EventHandler(this.sterge_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(190, 235);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(95, 37);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 310);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.sterge);
            this.Controls.Add(this.copiaza);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button copiaza;
        private System.Windows.Forms.Button sterge;
        private System.Windows.Forms.Button exit;
    }
}

