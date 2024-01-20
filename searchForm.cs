using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace carWing
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }


        SqlCommand cmd;
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=mydb;Integrated Security=True");
        private void searchButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM cardb WHERE Id=@ID", conn);
            cmd.Parameters.Add("ID", searchInput.Text);
            cmd.ExecuteNonQuery();

            SqlDataAdapter myAdapter = new SqlDataAdapter(cmd);
            DataTable myDataTable = new DataTable();
            myAdapter.Fill(myDataTable);
            dataGridView1.DataSource = myDataTable;

            conn.Close();
        }


        private void allProductButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM cardb ", conn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter myAdapter = new SqlDataAdapter(cmd);
            DataTable myDataTable = new DataTable();
            myAdapter.Fill(myDataTable);
            dataGridView1.DataSource = myDataTable;

            conn.Close();

        }

        private void searchForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
