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
    public partial class updateForm : Form
    {
        public updateForm()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=mydb;Integrated Security=True");
        private void insertButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("UPDATE cardb SET Id=@ID, make=@MAKE, model=@MODEL, year=@YEAR WHERE Id=@ID", conn);
            cmd.Parameters.Add("@ID", idInput.Text);
            cmd.Parameters.Add("@MAKE", makeInput.Text);
            cmd.Parameters.Add("@MODEL", modelInput.Text);
            cmd.Parameters.Add("@YEAR", yearInput.Text);
            cmd.Parameters.Add("@PRICE", priceInput.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product Details Updated");
        }
    }
}
