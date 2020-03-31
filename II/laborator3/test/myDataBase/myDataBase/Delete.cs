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
    public partial class Delete : Form
    {
        private SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=S:\git_Facultate\Facultate\II\laborator3\test\myDataBase\myDataBase\Database1.mdf;Integrated Security=True");
        private SqlCommand cmd;
        private ListBox listBox;
        private DataSet dsUniv;
        public Delete(ListBox listBox)
        {
            InitializeComponent();
            this.listBox = listBox;
        }

        private void btReady_Click(object sender, EventArgs e)
        {
            bool ok = true;
            cn.Open();
            listBox.Items.Clear();

            if (!tbID.Text.Equals(""))
            {
                try
                {
                    cmd = new SqlCommand("DELETE FROM Facultati WHERE Code= @id", cn);
                    cmd.Parameters.Add("id", tbID.Text);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE FROM Universitati WHERE Code= @id", cn);
                    cmd.Parameters.Add("id",tbID.Text);
                    cmd.ExecuteNonQuery();
                    ok = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(tbID.Text+ex.StackTrace);
                    ok = false;
                }
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
                MessageBox.Show("Item Deleted");
                this.Close();
            }
        }
    }
}
