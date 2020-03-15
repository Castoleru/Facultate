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

    public partial class Xand0 : Form
    {
        private bool turn = true;
        private int turnCount = 0;
        private string user;
        public Xand0(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                button1.Text = "X";
            }
            else button1.Text = "0";
            turn = !turn;
            turnCount++;
            button1.Enabled = false;
            check();
        }
       
        public void check()
        {
            bool winner = false;
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Text != ""))
                winner = true;
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Text != ""))
                winner = true;
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button7.Text != ""))
                winner = true;
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button1.Text != ""))
                winner = true;
            if ((button2.Text == button5.Text) && (button2.Text == button8.Text) && (button2.Text != ""))
                winner = true;
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (button3.Text != ""))
                winner = true;
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button1.Text != ""))
                winner = true;
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (button3.Text != ""))
                winner = true;
            if (winner)
            {
                MessageBox.Show("Castigatorul este " + (turn ? "0" : "X"));
                reset();
            }else if (turnCount == 9)
            {
                MessageBox.Show("Egalitate");
                reset();
            }

        }
        public void reset()
        {
            foreach(Control b in Controls.OfType<Button>())
            {
                b.Enabled = true;
                b.Text = "";
            }
            Reset.Text = "Reset";
            button10.Text = "Exit";
            turn = true;
            turnCount = 0;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(user);
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                button2.Text = "X";
            }
            else button2.Text = "0";
            turn = !turn;
            turnCount++;
            button2.Enabled = false;
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                button3.Text = "X";
            }
            else button3.Text = "0";
            turn = !turn;
            turnCount++;
            button3.Enabled = false;
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                button4.Text = "X";
            }
            else button4.Text = "0";
            turn = !turn;
            turnCount++;
            button4.Enabled = false;
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                button5.Text = "X";
            }
            else button5.Text = "0";
            turn = !turn;
            turnCount++;
            button5.Enabled = false;
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                button6.Text = "X";
            }
            else button6.Text = "0";
            turn = !turn;
            turnCount++;
            button6.Enabled = false;
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                button7.Text = "X";
            }
            else button7.Text = "0";
            turn = !turn;
            turnCount++;
            button7.Enabled = false;
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                button8.Text = "X";
            }
            else button8.Text = "0";
            turn = !turn;
            turnCount++;
            button8.Enabled = false;
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn == true)
            {
                button9.Text = "X";
            }
            else button9.Text = "0";
            turn = !turn;
            turnCount++;
            button9.Enabled = false;
            check();
        }

        private void Xand0_Load(object sender, EventArgs e)
        {

        }
    }
}
