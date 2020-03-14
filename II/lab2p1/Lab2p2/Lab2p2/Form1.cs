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

namespace Lab2p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader(path: "date.txt");
            string line;
            bool ok = false;
            while ((line = streamReader.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
        }

        private void copiaza_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("" + listBox1.SelectedItem);

        }

        private void sterge_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
