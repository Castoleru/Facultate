namespace myDataBase
{
    partial class Delete
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.btReady = new System.Windows.Forms.Button();
            this.CodF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(157, 30);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(217, 20);
            this.tbID.TabIndex = 1;
            // 
            // btReady
            // 
            this.btReady.Location = new System.Drawing.Point(299, 69);
            this.btReady.Name = "btReady";
            this.btReady.Size = new System.Drawing.Size(75, 23);
            this.btReady.TabIndex = 4;
            this.btReady.Text = "Ready";
            this.btReady.UseVisualStyleBackColor = true;
            this.btReady.Click += new System.EventHandler(this.btReady_Click);
            // 
            // CodF
            // 
            this.CodF.AutoSize = true;
            this.CodF.Location = new System.Drawing.Point(43, 37);
            this.CodF.Name = "CodF";
            this.CodF.Size = new System.Drawing.Size(32, 13);
            this.CodF.TabIndex = 5;
            this.CodF.Text = "Code";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 129);
            this.Controls.Add(this.CodF);
            this.Controls.Add(this.btReady);
            this.Controls.Add(this.tbID);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btReady;
        private System.Windows.Forms.Label CodF;
    }
}