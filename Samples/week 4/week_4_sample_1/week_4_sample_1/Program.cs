using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4_sample_1
{
    class Program
    {

        //create struct
        struct Book
        {
            //inititalize struct 'columns'(views? can't remember what goes parallel to records?)
            public string Title;
            public string AuthorFirst;
            public string AuthorLast;
            public string Email;
            public DateTime DatePublished;
            public int Pages;
            public double Price;
        }//end Book

        static void Main(string[] args)
        {
            //initialize variable
            bool blnResult = false;

            //create variable for struct
            Book temp = new Book();

            //populate instance of struct by filling the 'columns' with info
            Console.Write("\nPlease enter the title: ");
            temp.Title = Console.ReadLine();

            Console.Write("\nPlease enter the Author's First Name: ");
            temp.AuthorFirst = Console.ReadLine();

            Console.Write("\nPlease enter the Author's Last Name: ");
            temp.AuthorLast = Console.ReadLine();

            Console.Write("\nPlease enter the Author's Email: ");
            temp.Email = Console.ReadLine();


            //use do/while loops to ensure user enters the correct data type
            do
            {
                Console.Write("\nPlease enter the Date Published: ");
                blnResult = DateTime.TryParse(Console.ReadLine(), out temp.DatePublished);

                if (blnResult == false)
                {

                    Console.Write("\nSorry incorrect data format. Please try again. (Ex 10/31/2000) ");

                }
            } while (blnResult == false);

            do
            {
                Console.Write("\nPlease enter the Cost of the book: $");
                blnResult = Double.TryParse(Console.ReadLine(), out temp.Price);

                if (blnResult == false)
                {

                    Console.Write("\nSorry incorrect price. Please try again. (Ex: 19.50) ");

                }

            } while (blnResult == false);

            //print the struct's 'columns' out to the console
            Console.Write("\nWe now have the following book: ");
            Console.Write($"\n Title: {temp.Title}");
            Console.Write($"\n Writteb by: {temp.AuthorFirst} {temp.AuthorLast}");
            Console.Write($"\n Email: {temp.Email}");
            Console.Write($"\n Published: {temp.DatePublished.ToShortDateString()}");
            Console.Write($"\n Pages: {temp.Pages}");
            Console.Write($"\n Price: {temp.Price}");

            //call class saved in different cs file to pause console screen
            BasicTools.Pause();
        }
    }
}
