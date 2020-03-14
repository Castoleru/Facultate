using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_aplicatie
{
    public partial class Convertor : Form
    {
        private string user;
        public Convertor(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Convertor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double suma = Convert.ToDouble(detinTB.Text);
            if (ron.Checked)
            {
                convLabel.Text =suma/4.84 + " EURO";
            }
            if(euro.Checked)
            {
                convLabel.Text = suma * 4.84 + " RON";
            }
        }

        private void grdButt_Click(object sender, EventArgs e)
        {
            double grade = Convert.ToDouble(detinTB.Text);
            if (celsius.Checked)
            {
                conGrd.Text = grade *9/5 +32 + " F";
            }
            if (Far.Checked)
            {
                conGrd.Text = (grade -32)*5/9 + " C";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double grade = Convert.ToDouble(masaTB.Text);
            if (celsius.Checked)
            {
                masaLb.Text = grade * 2.20 + " Pounds";
            }
            if (Far.Checked)
            {
                masaLb.Text = grade/2.20 + " Kg";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(user);
            form2.Show();
            this.Hide();
        }
    }
}
