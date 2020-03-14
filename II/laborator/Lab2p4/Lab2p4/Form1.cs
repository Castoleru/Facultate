using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2p4
{
    public partial class Form1 : Form
    {
        private string text;
        public Form1()
        {
            
            InitializeComponent();
            listBox1.Items.Add("Cluj");
            listBox1.Items.Add("Piatra");
            listBox1.Items.Add("Oradea");
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(""+listBox1.SelectedItem);
            form2.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                text = radioButton1.Text;
            }else if(radioButton2.Checked)
            {
                text = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                text = radioButton3.Text;
            }

            if (radioButton4.Checked)
            {
                text +=" "+ radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                text += " " + radioButton5.Text;
            }
            else if (radioButton6.Checked)
            {
                text += " " + radioButton6.Text;
            }
            MessageBox.Show(text);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
