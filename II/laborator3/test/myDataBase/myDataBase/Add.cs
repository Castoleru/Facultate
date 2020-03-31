using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDataBase
{
    public partial class Add : Form
    {
        SqlCommand cmd;
        SqlConnection myCon;
        DataSet dsUniv;
        private string name;
        private string city;
        private int id;
        private ListBox listBox;
        public Add(ListBox listbox)
        {
            InitializeComponent();
            this.listBox = listbox;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbCity.Text.Equals("") && tbName.Text.Equals("") && tbID.Text.Equals(""))
            {
                MessageBox.Show("All textBoxex must be completed");
            }
            else
            {
                bool ok = true;
                dsUniv = new DataSet();
                name = tbName.Text;
                city = tbCity.Text;

                try
                { 
                    id = Convert.ToInt32(tbID.Text);
                }catch(Exception ex)
                {
                    MessageBox.Show("Id is a number");
                    ok = false;
                }
                try
                {
                    myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=S:\git_Facultate\Facultate\II\laborator3\test\myDataBase\myDataBase\Database1.mdf;Integrated Security=True");
                    myCon.Open();
                    cmd = new SqlCommand("INSERT INTO Universitati (Id,NumeUniv,City) VALUES (@Id,@Name,@City) ", myCon);
                    cmd.Parameters.Add("@Id", id);
                    cmd.Parameters.Add("@Name", name);
                    cmd.Parameters.Add("@City", city);
                    cmd.ExecuteNonQuery();
                    ok = true;
                }catch(Exception ex)
                {
                    MessageBox.Show("Id is already used");
                    tbID.Text = "";
                    ok = false;
                }
                if (ok)
                {
                    listBox.Items.Add(name);
                    myCon.Close();
                    this.Close();
                }
            }

        }
    }
}
