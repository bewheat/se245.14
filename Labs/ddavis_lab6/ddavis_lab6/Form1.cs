using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddavis_lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            PersonV2 record = new PersonV2();

            record.FirstName = txtFName.Text;
            record.MiddleName = txtMName.Text;
            record.LastName = txtLName.Text;
            record.Street1 = txtStreet1.Text;
            record.Street2 = txtStreet2.Text;
            record.City = txtCity.Text;
            record.State = txtState.Text;
            record.Phone = txtPhone.Text;
            record.Email = txtEmail.Text;
            record.CellPhone = txtCell.Text;
            record.InstagramURL = txtInstagramURL.Text;
            record.Zip = txtZip.Text;

            if (record.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = record.Feedback;
            }
            else
            {
                lblFeedback.Text = record.AddARecord();
            }

            /*else
            {
                lblFeedback.Text = "Name: " + record.FirstName + " " + record.MiddleName + " " + record.LastName + "\n\n--CONTACT INFO--\nPhone Number: " + record.Phone + "\nCellphone Number: " + record.CellPhone + "\nEmail: " + record.Email + "\nInstagram: " + record.InstagramURL + "\n\n--ADDRESS--\n  " + record.Street1 + "\n  " + record.Street2 + "\n  " + record.City + "\n  " + record.State + ", " + record.Zip;
            }*/



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
