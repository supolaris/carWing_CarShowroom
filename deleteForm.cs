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
    public partial class deleteForm : Form
    {
        public deleteForm()
        {
            InitializeComponent();
        }


        SqlCommand cmd;
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=mydb;Integrated Security=True");
        private void searchButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE cardb WHERE Id=@ID", conn);
            cmd.Parameters.Add("ID", productIdInput.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product Deleted");
        }

        private void makeDeleteButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE cardb WHERE make=@MAKE", conn);
            cmd.Parameters.Add("MAKE", productMakeInput.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product Deleted");

        }
    }
}
