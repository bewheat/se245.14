using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Added to use Ebook & Validation items
using Week_6_Sample1_DataValidation;    

namespace Week7_Sample3_WindowsVersion
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EBook temp = new EBook();

            //Getting the strings from the form and setting them in object
            temp.Title = txtTitle.Text;
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            temp.Email = txtEmail.Text;

            //Getting te dates from the datetime pickers
            temp.DatePublished = dtpDatePublished.Value;
            temp.DateRentalExpires = dtpDateRentalExpires.Value;

            //**************************************************************************
            //get the string from page # textboxes,convert to ints, set their values
            //**************************************************************************
            int intTempPages;
            bool blnResult = Int32.TryParse(txtPages.Text, out intTempPages);

            if (blnResult == false)
            {
                lblFeedback.Text += "ERROR: Sorry incorrect page #.  Please try again. (Ex: 214) ";
            }
            else
            {
                temp.Pages = intTempPages;
            }
            //**************************************************************************


            //**************************************************************************
            //get the string from Bookmark page # textboxes,convert to ints, set their values
            //**************************************************************************
            int intBMPage;
            blnResult = Int32.TryParse(txtBookmarkPage.Text, out intBMPage);

            if (blnResult == false)
            {
                lblFeedback.Text += "ERROR: Sorry incorrect Bookmark page #.  Please try again. (Ex: 214) ";
            }
            else
            {
                temp.BookmarkPage = intBMPage;
            }
            //**************************************************************************


            if (lblFeedback.Text.Contains("ERROR:"))
            {
                //Do nothing...already displaying error that user needs to fix
            }
            else if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;       //dispay the error msg
                
            }
            else
            {
                lblFeedback.Text = temp.AddARecord();   //if no errors weh setting values, then perform the insertion into db
            }

        }
    }
}
