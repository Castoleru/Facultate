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

namespace Tema_aplicatie
{
    public partial class Form2 : Form
    {
        private string user;
        public Form2(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LCump listaCumparaturi = new LCump(user);
            listaCumparaturi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Convertor convertor = new Convertor(user);
            convertor.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Xand0 xand0 = new Xand0(user);
            xand0.Show();
            this.Hide();
        }
    }
}
