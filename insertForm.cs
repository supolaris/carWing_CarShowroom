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
    public partial class insertForm : Form
    {
        public insertForm()
        {
            InitializeComponent();
        }


        SqlCommand cmd;
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=mydb;Integrated Security=True");
        private void insertButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd = new SqlCommand("INSERT INTO cardb (Id, make, model, year, price) VALUES (@ID, @MAKE, @MODEL, @YEAR, @PRICE)", conn);
            cmd.Parameters.Add("@ID", idInput.Text);
            cmd.Parameters.Add("@MAKE", makeInput.Text);
            cmd.Parameters.Add("@MODEL", modelInput.Text);
            cmd.Parameters.Add("@YEAR", yearInput.Text);
            cmd.Parameters.Add("@PRICE", priceInput.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Product Added");
            idInput.Text = "";
            makeInput.Text = "";
            modelInput.Text = "";
            yearInput.Text = "";
            priceInput.Text = "";

            conn.Close();
        }
    }
}
