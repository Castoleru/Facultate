namespace Lab2p1
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
            this.usernamel = new System.Windows.Forms.Label();
            this.passwl = new System.Windows.Forms.Label();
            this.usertb = new System.Windows.Forms.TextBox();
            this.passtb = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamel
            // 
            this.usernamel.AutoSize = true;
            this.usernamel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamel.Location = new System.Drawing.Point(12, 108);
            this.usernamel.Name = "usernamel";
            this.usernamel.Size = new System.Drawing.Size(105, 24);
            this.usernamel.TabIndex = 0;
            this.usernamel.Text = "Username";
            // 
            // passwl
            // 
            this.passwl.AutoSize = true;
            this.passwl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwl.Location = new System.Drawing.Point(27, 158);
            this.passwl.Name = "passwl";
            this.passwl.Size = new System.Drawing.Size(90, 24);
            this.passwl.TabIndex = 1;
            this.passwl.Text = "Pasword";
            // 
            // usertb
            // 
            this.usertb.Location = new System.Drawing.Point(160, 112);
            this.usertb.Name = "usertb";
            this.usertb.Size = new System.Drawing.Size(142, 20);
            this.usertb.TabIndex = 2;
            // 
            // passtb
            // 
            this.passtb.Location = new System.Drawing.Point(160, 158);
            this.passtb.Name = "passtb";
            this.passtb.Size = new System.Drawing.Size(142, 20);
            this.passtb.TabIndex = 3;
            this.passtb.UseSystemPasswordChar = true;
            this.passtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Login.Location = new System.Drawing.Point(42, 224);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 38);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(185, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(314, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.usertb);
            this.Controls.Add(this.passwl);
            this.Controls.Add(this.usernamel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernamel;
        private System.Windows.Forms.Label passwl;
        private System.Windows.Forms.TextBox usertb;
        private System.Windows.Forms.TextBox passtb;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button button2;
    }
}

