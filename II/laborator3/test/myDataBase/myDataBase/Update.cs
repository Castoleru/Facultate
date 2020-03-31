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
    public partial class Update : Form
    {

        private SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=S:\git_Facultate\Facultate\II\laborator3\test\myDataBase\myDataBase\Database1.mdf;Integrated Security=True");
        private SqlCommand cmd;
        private ListBox listBox;
        private DataSet dsUniv;
        private string name;
        private string city;
        private int id;
        public Update(ListBox listBox)
        {
            InitializeComponent();
            this.listBox = listBox;
        }

        private void btReady_Click(object sender, EventArgs e)
        {
            cn.Open();
            listBox.Items.Clear();
            if (tbCity.Text.Equals("") && tbName.Text.Equals("") && tbId.Text.Equals(""))
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
                    id = Convert.ToInt32(tbId.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Id is a number");
                    ok = false;
                }
                if (ok)
                {
                    try
                    {
                        cmd = new SqlCommand("UPDATE Universitati SET City= @City, NumeUniv= @Name WHERE Id= @Id ", cn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.ExecuteNonQuery();
                        ok = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Id is incorect");
                        tbId.Text = "";
                        ok = false;
                    }
                    dsUniv = new DataSet();
                    SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", cn);
                    daUniv.Fill(dsUniv, "Universitati");
                    foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
                    {
                        String name = dr.ItemArray.GetValue(1).ToString();
                        listBox.Items.Add(name);
                    }
                    cn.Close();
                    if (ok)
                    {
                        MessageBox.Show("Item Updated");
                        this.Close();
                    }
                }
            }
        }
    }
}
    