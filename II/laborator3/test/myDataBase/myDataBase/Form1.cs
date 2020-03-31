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
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection myCon = new SqlConnection();
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet dsUniv;
        DataSet dsFac;
        DataSet sDs;
        DataTable sTable;
        public Form1()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=S:\git_Facultate\Facultate\II\laborator3\test\myDataBase\myDataBase\Database1.mdf;Integrated Security=True";
            myCon.Open();

            dsUniv = new DataSet();
            dsFac = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name);
            }
            myCon.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Facultati' table. You can move, or remove it, as needed.
            this.facultatiTableAdapter.Fill(this.database1DataSet.Facultati);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=S:\git_Facultate\Facultate\II\laborator3\test\myDataBase\myDataBase\Database1.mdf;Integrated Security=True";
            string sql = "SELECT * FROM Facultati";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            cmd = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(cmd);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Facultati");
            sTable = sDs.Tables["Facultati"];
            connection.Close();
            dataGridView1.DataSource = sDs.Tables["Facultati"];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = false;
            
        }
        public void loaddata()
        {
            //do what you do in load data in order to update data in datagrid
            this.facultatiTableAdapter.Fill(this.database1DataSet.Facultati);

        }

        private void listBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Fac.Items.Clear();
            textBox_Oras.Clear();
            int code = 0;
            int id;
            try
            {
                String UnivSelected = listBox_Univ.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    textBox_Oras.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBox_Cod.Text = code.ToString();
                    id = Convert.ToInt16(dr.ItemArray.GetValue(0));
                        tbId.Text = id.ToString();
                }
            }
            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBox_Fac.Items.Add(nameFac);
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selectie nereusita");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Add add = new Add(listBox_Univ);
            add.Show();
           
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(listBox_Univ);
            delete.Show();

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Update update = new Update(listBox_Univ);
            update.Show();
        }

        private void btDelFac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=S:\git_Facultate\Facultate\II\laborator3\test\myDataBase\myDataBase\Database1.mdf;Integrated Security=True";
                cmd= new SqlCommand("SELECT * FROM Facultati", myCon);
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                sAdapter.Update(sTable);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btAddFac_Click(object sender, EventArgs e)
        { 
            sAdapter.Update(sTable);
        }
    }
}
