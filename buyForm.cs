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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace carWing
{
    public partial class buyForm : Form
    {
        public buyForm()
        {
            InitializeComponent();
        }


        SqlCommand cmd;
        SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=mydb;Integrated Security=True");
        string mySelectedCarDetails = "";
        string myCalulatedVal;
        int grandTotal;

        private void searchButton_Click(object sender, EventArgs e)
        {   
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM cardb WHERE Id=@ID", conn);
            cmd.Parameters.Add("ID", searchInput.Text);

            SqlDataReader myReader = cmd.ExecuteReader();

            if (myReader.HasRows)
            {
                while(myReader.Read()){
                    mySelectedCarDetails += $"make: {myReader["Make"]}\nmodel: {myReader["Model"]}\nyear: {myReader["Year"]}\nprice: {myReader["Price"]}\n";
                    myCalulatedVal = $"{myReader["Price"]}";


                }
            }
            else
            {
                mySelectedCarDetails = "No car details found for the selected id";
            }
            mySelectedCarDetails += "Services Charges: 500";
            
            
            grandTotal = Convert.ToInt32(myCalulatedVal) + 500;

            mySelectedCarDetails += "\n\nGrandTotal: " + grandTotal;
            myReader.Close();
            selectedCarDetails.Text = mySelectedCarDetails;
            cmd.ExecuteNonQuery();
            
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

 

        private void pdfButton_Click(object sender, EventArgs e)
        {
            Document myDoc = new Document();
            PdfWriter.GetInstance(myDoc, new FileStream("C:/work/myCar.pdf", FileMode.Create));
            myDoc.Open();
            Paragraph myPara = new Paragraph(mySelectedCarDetails);
            myDoc.Add(myPara);
            myDoc.Close();
            MessageBox.Show("Pdf Saved");
        }





        private void carbillDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
