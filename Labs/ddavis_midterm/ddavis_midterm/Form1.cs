using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddavis_midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person record = new Person();

            record.FirstName = txtFName.Text;
            record.MiddleName = txtMiddleName.Text;
            record.LastName = txtLName.Text;
            record.Street1 = txtStreet1.Text;
            record.Street2 = txtStreet2.Text;
            record.City = txtCity.Text;
            record.State = txtState.Text;
            record.Phone = txtPhone.Text;
            record.Email = txtEmail.Text;

            if (record.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = record.Feedback;
            }

            else
            {
                lblFeedback.Text = "Name: " + record.FirstName + " " + record.MiddleName + " " + record.LastName + "\nAddress:\t" + record.Street1 + "\n\t" + record.Street2 + "\n\t" + record.City + "\n\t" + record.State + "\n\nPhone Number:" + " " + record.Phone + "\nEmail: " + record.Email;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
