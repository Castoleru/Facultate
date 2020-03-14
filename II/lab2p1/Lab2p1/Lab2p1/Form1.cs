using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "date.txt");
                string line;
                bool ok = false;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] cuvinte = line.Split(' ');
                    if (cuvinte[0] == usertb.Text & cuvinte[1] == passtb.Text)
                    {
                        Form2 secondForm = new Form2(usertb.Text);
                        secondForm.Show();
                        ok = true;
                    }
                }
                if (ok == false)
                    MessageBox.Show("Parola gresita");
            streamReader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter str = new StreamWriter("date.txt", true);
            str.WriteLine("{0} {1}",usertb.Text,passtb.Text);
            usertb.Clear();
            passtb.Clear();
            str.Close();
        }
    }
}
