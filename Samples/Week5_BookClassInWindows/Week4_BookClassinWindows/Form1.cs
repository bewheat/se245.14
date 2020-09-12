using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_BookClassinWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book temp = new Book();
            temp.Title = txtTitle.Text;
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;

            double dblPrice;
            if (Double.TryParse(txtPrice.Text, out dblPrice) == true)
            {
                temp.Price = dblPrice;
            }
            else
            {
                temp.Price = 0;
                temp.Feedback = "ERROR: Invalid Price. Ex: 5.99";
            }
           
            
            
            
            temp.Pages = Int32.Parse(txtPages.Text);

            temp.Email = txtEmail.Text;
            temp.DatePublished = dtpDatePublished.Value;


            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.Title + " was created by " + temp.AuthorFirst + " " + temp.AuthorLast;
            }

        }
    }
}
