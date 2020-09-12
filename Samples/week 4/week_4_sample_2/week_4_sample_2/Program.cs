using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4_sample_2
{
    class Program
    {
        //create class Book to get book information and create a record of it.
        public class Book
        {
            //initialize variables used in class. set as private cause they are only used inside the class.
            private string title;
            private string authorFirst;
            private string authorLast;
            private string email;
            private DateTime datePublished;
            private int pages;
            private double price;

            //set class to recieve information to save to variables
            public string Title
            {
                //get info
                get
                {
                    return title;
                }

                //save info to variable(in this case title)
                set
                {
                    title = value;
                }
            }

            public string AuthorFirst
            {
                get
                {
                    return authorFirst;
                }

                set
                {
                    authorFirst = value;
                }
            }

            public string AuthorLast
            {
                get
                {
                    return authorLast;
                }

                set
                {
                    authorLast = value;
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    //use if/else statement to determine if user entered a valid entry
                    if (ValidationLibrary.IsValidEmail(value))
                    {
                        email = value;
                    }

                    else
                    {
                        email = "INVALID";
                    }
                }
            }

            public DateTime DatePublished
            {
                get
                {
                    return datePublished;
                }

                set
                {
                    if (ValidationLibrary.IsAFutureDate(value) == false)
                    {
                        datePublished = value;
                    }

                    else
                    {
                        datePublished = DateTime.Parse("1/1/1900 12:00 am");
                    }
                }
            }

            public int Pages
            {
                get
                {
                    return pages;
                }

                set
                {
                    if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                    {
                        pages = value;
                    }

                    else
                    {
                        pages = 0;
                    }
                }
            }

            public double Price
            {
                get
                {
                    return price;
                }

                set
                {
                    if (ValidationLibrary.IsMinimumAmount(value, 1) == true)
                    {
                        price = value;
                    }

                    else
                    {
                        price = 0;
                    }
                }
            }


        }

        static void Main(string[] args)
        {

            //initialize variables
            bool blnResult = false;

            //initialize new class object
            Book temp = new Book();

            //fill in class variables
            Console.Write("\nPlease enter the title: ");
            temp.Title = Console.ReadLine();

            Console.Write("\nPlease enter the Author's First Name: ");
            temp.AuthorFirst = Console.ReadLine();

            Console.Write("\nPlease enter the Author's Last Name: ");
            temp.AuthorLast = Console.ReadLine();

            Console.Write("\nPlease enter the Author's Email: ");
            temp.Email = Console.ReadLine();

            //use do/while loop to ensure user enters valid data type
            do
            {
                Console.Write("\nPlease enter the Date Published: ");
                DateTime dtTempDate;
                blnResult = DateTime.TryParse(Console.ReadLine(), out dtTempDate);

                if (blnResult == false)
                {
                    Console.Write("\nSorry incorrect data format. Please try again. (Ex: 10/31/2000) ");
                }

                else
                {
                    temp.DatePublished = dtTempDate;
                }
            } while (blnResult == false);

            do
            {
                Console.Write("\nPlease enter the # of pages: ");
                int intTempPages;
                blnResult = Int32.TryParse(Console.ReadLine(), out intTempPages);

                if (blnResult == false)
                {
                    Console.Write("\nSorry incorrect page #. Please try again. (Ex: 214) ");
                }

                else
                {
                    temp.Pages = intTempPages;
                }

            } while (blnResult == false);

            do
            {
                Console.Write("\nPlease enter the Cost of the book: $");
                double dblTempPrice;
                blnResult = Double.TryParse(Console.ReadLine(), out dblTempPrice);

                if (blnResult == false)
                {

                    Console.Write("\nSorry incorrect price. Please try again. (Ex: 19.50) ");

                }

                else
                {

                    temp.Price = dblTempPrice;

                }

            } while (blnResult == false);

            //print the class object's 'columns' out to the console
            Console.Write("\nWe now have the following book: ");
            Console.Write($"\n Title: {temp.Title}");
            Console.Write($"\n Writteb by: {temp.AuthorFirst} {temp.AuthorLast}");
            Console.Write($"\n Email: {temp.Email}");
            Console.Write($"\n Published: {temp.DatePublished.ToShortDateString()}");
            Console.Write($"\n Pages: {temp.Pages}");
            Console.Write($"\n Price: ${temp.Price}");

            //call class saved in different cs file to pause console screen
            BasicTools.Pause();
        }
    }
}
