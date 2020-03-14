namespace Tema_aplicatie
{
    partial class Convertor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ron = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.euro = new System.Windows.Forms.RadioButton();
            this.convLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.detinTB = new System.Windows.Forms.TextBox();
            this.Temperatura = new System.Windows.Forms.GroupBox();
            this.gradeTB = new System.Windows.Forms.TextBox();
            this.grdButt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.conGrd = new System.Windows.Forms.Label();
            this.Far = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.celsius = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.masaTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.kg = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.masaLb = new System.Windows.Forms.Label();
            this.pounds = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Temperatura.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detinTB);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.convLabel);
            this.groupBox1.Controls.Add(this.euro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ron);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curs Valutar";
            // 
            // ron
            // 
            this.ron.AutoSize = true;
            this.ron.Location = new System.Drawing.Point(227, 29);
            this.ron.Name = "ron";
            this.ron.Size = new System.Drawing.Size(49, 17);
            this.ron.TabIndex = 0;
            this.ron.TabStop = true;
            this.ron.Text = "RON";
            this.ron.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ron.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detin:";
            // 
            // euro
            // 
            this.euro.AutoSize = true;
            this.euro.Location = new System.Drawing.Point(277, 30);
            this.euro.Name = "euro";
            this.euro.Size = new System.Drawing.Size(56, 17);
            this.euro.TabIndex = 2;
            this.euro.TabStop = true;
            this.euro.Text = "EURO";
            this.euro.UseVisualStyleBackColor = true;
            // 
            // convLabel
            // 
            this.convLabel.AutoSize = true;
            this.convLabel.Location = new System.Drawing.Point(90, 86);
            this.convLabel.Name = "convLabel";
            this.convLabel.Size = new System.Drawing.Size(0, 13);
            this.convLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Primesc:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Conversie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detinTB
            // 
            this.detinTB.Location = new System.Drawing.Point(90, 29);
            this.detinTB.Name = "detinTB";
            this.detinTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.detinTB.Size = new System.Drawing.Size(128, 20);
            this.detinTB.TabIndex = 7;
            // 
            // Temperatura
            // 
            this.Temperatura.Controls.Add(this.gradeTB);
            this.Temperatura.Controls.Add(this.label3);
            this.Temperatura.Controls.Add(this.grdButt);
            this.Temperatura.Controls.Add(this.celsius);
            this.Temperatura.Controls.Add(this.label5);
            this.Temperatura.Controls.Add(this.conGrd);
            this.Temperatura.Controls.Add(this.Far);
            this.Temperatura.Location = new System.Drawing.Point(30, 152);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(339, 143);
            this.Temperatura.TabIndex = 1;
            this.Temperatura.TabStop = false;
            this.Temperatura.Text = "Temperatura";
            // 
            // gradeTB
            // 
            this.gradeTB.Location = new System.Drawing.Point(96, 30);
            this.gradeTB.Name = "gradeTB";
            this.gradeTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gradeTB.Size = new System.Drawing.Size(128, 20);
            this.gradeTB.TabIndex = 14;
            // 
            // grdButt
            // 
            this.grdButt.Location = new System.Drawing.Point(238, 63);
            this.grdButt.Name = "grdButt";
            this.grdButt.Size = new System.Drawing.Size(99, 23);
            this.grdButt.TabIndex = 13;
            this.grdButt.Text = "Conversie";
            this.grdButt.UseVisualStyleBackColor = true;
            this.grdButt.Click += new System.EventHandler(this.grdButt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultat:";
            // 
            // conGrd
            // 
            this.conGrd.AutoSize = true;
            this.conGrd.Location = new System.Drawing.Point(96, 87);
            this.conGrd.Name = "conGrd";
            this.conGrd.Size = new System.Drawing.Size(0, 13);
            this.conGrd.TabIndex = 11;
            // 
            // Far
            // 
            this.Far.AutoSize = true;
            this.Far.Location = new System.Drawing.Point(302, 33);
            this.Far.Name = "Far";
            this.Far.Size = new System.Drawing.Size(31, 17);
            this.Far.TabIndex = 10;
            this.Far.TabStop = true;
            this.Far.Text = "F";
            this.Far.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grade:";
            // 
            // celsius
            // 
            this.celsius.AutoSize = true;
            this.celsius.Location = new System.Drawing.Point(244, 33);
            this.celsius.Name = "celsius";
            this.celsius.Size = new System.Drawing.Size(32, 17);
            this.celsius.TabIndex = 8;
            this.celsius.TabStop = true;
            this.celsius.Text = "C";
            this.celsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.celsius.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.masaTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.kg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.masaLb);
            this.groupBox2.Controls.Add(this.pounds);
            this.groupBox2.Location = new System.Drawing.Point(30, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Masa";
            // 
            // masaTB
            // 
            this.masaTB.Location = new System.Drawing.Point(91, 33);
            this.masaTB.Name = "masaTB";
            this.masaTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.masaTB.Size = new System.Drawing.Size(128, 20);
            this.masaTB.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Resultat:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Conversie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kg
            // 
            this.kg.AutoSize = true;
            this.kg.Location = new System.Drawing.Point(227, 34);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(38, 17);
            this.kg.TabIndex = 15;
            this.kg.TabStop = true;
            this.kg.Text = "Kg";
            this.kg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kg.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Masa:";
            // 
            // masaLb
            // 
            this.masaLb.AutoSize = true;
            this.masaLb.Location = new System.Drawing.Point(91, 90);
            this.masaLb.Name = "masaLb";
            this.masaLb.Size = new System.Drawing.Size(0, 13);
            this.masaLb.TabIndex = 18;
            // 
            // pounds
            // 
            this.pounds.AutoSize = true;
            this.pounds.Location = new System.Drawing.Point(272, 34);
            this.pounds.Name = "pounds";
            this.pounds.Size = new System.Drawing.Size(61, 17);
            this.pounds.TabIndex = 17;
            this.pounds.TabStop = true;
            this.pounds.Text = "Pounds";
            this.pounds.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(375, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 63);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 449);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.groupBox1);
            this.Name = "Convertor";
            this.Text = "Convertor";
            this.Load += new System.EventHandler(this.Convertor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Temperatura.ResumeLayout(false);
            this.Temperatura.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label convLabel;
        private System.Windows.Forms.RadioButton euro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ron;
        private System.Windows.Forms.TextBox detinTB;
        private System.Windows.Forms.GroupBox Temperatura;
        private System.Windows.Forms.TextBox gradeTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button grdButt;
        private System.Windows.Forms.RadioButton celsius;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label conGrd;
        private System.Windows.Forms.RadioButton Far;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox masaTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton kg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label masaLb;
        private System.Windows.Forms.RadioButton pounds;
        private System.Windows.Forms.Button button3;
    }
}