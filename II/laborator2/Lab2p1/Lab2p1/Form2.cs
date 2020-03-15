using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2p1
{
    public partial class Form2 : Form
    {
        public Form2(string username)
        {
            InitializeComponent();
            salutLabel.Text ="Hello "+ username;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
