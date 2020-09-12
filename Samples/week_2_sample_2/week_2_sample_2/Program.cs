using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2_sample_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare vars
            String strFirst, strNum, strCntr;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false;


            //Declare list <list type> list name
            List<double> dblEarnings = new List<double>();

            Console.WriteLine("Averager Program: Enter weekly earnings. (a -1 to end entries)\n\n");

            //use do/while loop to have user enter amount earned each week individually. enter negative number to end loop.
            do
            {

                //use do/while loop to have user enter input and ensure it's a real number
                do
                {

                    //have user input amount earned each week
                    Console.Write("\nPlease enter payroll #" + (intCntr + 1) + ": ");
                    strNum = Console.ReadLine();

                    //try to convert to double. if successful blnResult == true; dblNum == strNum. else: false. 
                    blnResult = Double.TryParse(strNum, out dblNum);

                    if (blnResult == false)
                    {
                        Console.WriteLine("\n\nSorry, but you did not enter a valid real number in digits. Ex: 1051.00.");
                    }//end if block
                } while (blnResult == false); //run do block until blnResult is true. have user keep trying until they enter a real number

                //if number entered is positive
                if (dblNum >= 0)
                {
                    //add number to dblEarnings list
                    dblEarnings.Add(dblNum);

                    //add number to total
                    dblTotal += dblNum;

                    //increment counter by 1
                    intCntr++;

                }//end if block

            } while (dblNum >= 0);


            //output border to seperate input from output
            Console.WriteLine("---------------------------------------------------------------");

            //Calculate average
            dblResult = (dblTotal / intCntr);

            //reset counter
            intCntr = 1;

            //iterate through each item in the list dblEarnings and output the items to the console
            foreach(double d in dblEarnings)
            {
                Console.WriteLine($"\n\nWeekly entry #{intCntr}: ${d}");
                intCntr++;
            }

            //output total average
            Console.WriteLine("\n\nThe average of the weekly earnings entered is: $" + dblResult);


            //Pause output so that user can view it
            Console.WriteLine("\n\n\nPress Any Key to Continue");
            //when user presses key program ends
            Console.ReadKey();
        }
    }
}
