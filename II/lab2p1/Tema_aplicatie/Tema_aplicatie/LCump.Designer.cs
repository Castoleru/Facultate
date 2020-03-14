namespace Tema_aplicatie
{
    partial class LCump
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
            this.label1 = new System.Windows.Forms.Label();
            this.lucruNou = new System.Windows.Forms.TextBox();
            this.listaCumpar = new System.Windows.Forms.ListBox();
            this.adauga = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // lucruNou
            // 
            this.lucruNou.Location = new System.Drawing.Point(114, 25);
            this.lucruNou.Name = "lucruNou";
            this.lucruNou.Size = new System.Drawing.Size(164, 20);
            this.lucruNou.TabIndex = 1;
            // 
            // listaCumpar
            // 
            this.listaCumpar.FormattingEnabled = true;
            this.listaCumpar.Location = new System.Drawing.Point(30, 55);
            this.listaCumpar.Name = "listaCumpar";
            this.listaCumpar.Size = new System.Drawing.Size(247, 212);
            this.listaCumpar.TabIndex = 2;
            // 
            // adauga
            // 
            this.adauga.Location = new System.Drawing.Point(284, 23);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(75, 23);
            this.adauga.TabIndex = 3;
            this.adauga.Text = "Adauga";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(288, 244);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Sterge
            // 
            this.Sterge.Location = new System.Drawing.Point(284, 55);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(75, 23);
            this.Sterge.TabIndex = 5;
            this.Sterge.Text = "Sterge";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // LCump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 283);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.adauga);
            this.Controls.Add(this.listaCumpar);
            this.Controls.Add(this.lucruNou);
            this.Controls.Add(this.label1);
            this.Name = "LCump";
            this.Text = "LCump";
            this.Load += new System.EventHandler(this.LCump_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lucruNou;
        private System.Windows.Forms.ListBox listaCumpar;
        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Sterge;
    }
}