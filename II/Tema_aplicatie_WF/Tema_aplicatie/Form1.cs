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
using System.Runtime.InteropServices;

namespace Tema_aplicatie
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void singup_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 100)
            {
                progressBar2.Value=i++;
            }
            StreamReader streamReader = new StreamReader(path: "date.txt");
            string line;
            bool ok = false;
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] cuvinte = line.Split(' ');
                if (cuvinte[0] == user.Text)
                {
                    ok = true;
                }
            }
            streamReader.Close();

            if (ok == false)
            {
                StreamWriter str = new StreamWriter("date.txt", true);
                str.WriteLine("{0} {1}", user.Text, pass.Text);
                user.Clear();
                pass.Clear();
                str.Close();
                progressBar2.SetState(1);
            }
            else
            {
                progressBar2.SetState(2);
                MessageBox.Show("Username existent");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 100)
            {
                progressBar1.Value = i++;
            }

            StreamReader streamReader = new StreamReader(path: "date.txt");
            string line;
            bool ok = false;
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] cuvinte = line.Split(' ');
                if (cuvinte[0] == user.Text & cuvinte[1] == pass.Text)
                {
                    Form2 secondForm = new Form2(user.Text);
                    secondForm.Show();
                    ok = true;
                    this.Hide();
                }
            }
            if (ok == false)
            {
                progressBar1.SetState(2);
                MessageBox.Show("Parola gresita");
            }
           
            streamReader.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
