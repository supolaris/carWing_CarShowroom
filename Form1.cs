using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace carWing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void insertButton_Click(object sender, EventArgs e)
        {
            insertForm myForm = new insertForm();
            myForm.Show();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteForm myForm = new deleteForm();
            myForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateForm myForm = new updateForm();
            myForm.Show();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchForm myForm = new searchForm();
            myForm.Show();
        }



        private void purchasingButton_Click(object sender, EventArgs e)
        {
            buyForm myForm = new buyForm();
            myForm.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void idInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
