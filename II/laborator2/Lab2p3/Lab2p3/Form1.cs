using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void siToolStripMenuItem_Click(object sender, EventArgs e)
        {
           int numar1, numar2,rezult;
            numar1 = Convert.ToInt32(nr1.Text);
            numar2 = Convert.ToInt32(nr2.Text);
            rezult = numar2 & numar1;
            rez.Text =""+ rezult;


        }

        private void sauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numar1, numar2, rezult;
            numar1 = Convert.ToInt32(nr1.Text);
            numar2 = Convert.ToInt32(nr2.Text);
            rezult = numar2 | numar1;
            rez.Text = "" + rezult;
        }

        private void xorToolStripMenuItem_Click(object sender, EventArgs e)
        {
               int numar1, numar2, rezult;
            numar1 = Convert.ToInt32(nr1.Text);
            numar2 = Convert.ToInt32(nr2.Text);
            rezult = numar2 ^ numar1;
            rez.Text = "" + rezult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
