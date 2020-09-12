using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2_sample_1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Declare vars
            String strFirst, strNum, strCntr; //strCounter not Center. don't know why i keep reading it like that
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false;

            Console.WriteLine("Averger Program: How many week's earning are you going to average?");
            strCntr = Console.ReadLine();
            intCntr = Int32.Parse(strCntr);

            //create a list with the number of records intCntr?
            Double[] dblEarnings = new Double[intCntr];

            Console.WriteLine("Averager Program: Enter weekly earnings. \n\n");


            //use a for loop to have user enter amount earned every week until counter runs out(iterate through until intCounter == intCntr; increment intCounter by 1)
            for (int intCounter = 0; intCounter < intCntr; intCounter++)
            {


                do
                {
                    //Have user input weekly amount earned
                    Console.Write("Please enter payroll #" + (intCounter + 1) + ": ");

                    strNum = Console.ReadLine();

                    //attempt to convert to double. blnResult holds T/F depending on if successful
                    blnResult = Double.TryParse(strNum, out dblNum);

                    //if conversion isn't successful(blnResult == False) tell user input is not a number
                    if (blnResult == false)
                    {
                        Console.WriteLine("\n\nSorry but you did not enter a valid real number in digits: Ex 1051.00.");
                    }// end if block
                } while (blnResult == false); //have do block run until user enters valid input

                //add weekly amount earned to total amount earned
                dblTotal += dblNum;
            }// end for loop

            //calculate total earned average and output to console
            dblResult = (dblTotal / intCntr);
            Console.WriteLine("The average of the weekly earnings entered is: $" + dblResult);


            //pause program so that user can review it
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}
