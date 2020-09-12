using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddavis_lab_5
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

            record.FirstName = fNamelbl.Text;
            record.MiddleName = mNamelbl.Text;
            record.LastName = lNamelbl.Text;
            record.Street1 = street1Lbl.Text;
            record.Street2 = street2Lbl.Text;
            record.City = cityLbl.Text;
            record.State = stateLbl.Text;
            record.Phone = phoneLbl.Text;
            record.Email = emailLbl.Text;
            record.CellPhone = txtCell.Text;
            record.InstagramURL = txtInstagramURL.Text;

            if (record.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = record.Feedback;
            }

            else
            {
                lblFeedback.Text = "Name: " + record.FirstName + " " + record.MiddleName + " " + record.LastName + "\nAddress:\n\t" + record.Street1 + "\n\t" + record.Street2 + "\n\t" + record.City + "\n\t" + record.State + "\n\nContact Info:" + "\n\n" + record.Phone + "\n" + record.Email;
            }

        }
    }
}
