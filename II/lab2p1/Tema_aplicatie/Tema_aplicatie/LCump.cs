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
    public partial class LCump : Form
    {
        private string user;
        private string path;
        public LCump(string user)
        {
            this.user = user;
            this.path = user + "ListaCump.txt";
            InitializeComponent();
            StreamWriter str = new StreamWriter(path, true);
            str.Close();

        }

        private void LCump_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path);
            string line;
        
            while ((line = streamReader.ReadLine()) != null)
            {
                listaCumpar.Items.Add(line);
            }
            streamReader.Close();
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            listaCumpar.Items.Add(lucruNou.Text);
            lucruNou.Clear();
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            listaCumpar.Items.RemoveAt(listaCumpar.SelectedIndex);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, String.Empty);
            StreamWriter str = new StreamWriter(path, true);
            foreach(string item in listaCumpar.Items)
            {
                str.WriteLine(item);
            }
            str.Close();
            Form2 form2 = new Form2(user);
            form2.Show();
            this.Hide();
        }
    }
}
