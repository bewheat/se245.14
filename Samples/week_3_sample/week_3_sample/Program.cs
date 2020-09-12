using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_sample
{
    class Program
    {

        //FUNCTIONS
        static void Pause()
        {
            //pauses console
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();

        }//end pause

        static double CalcAvg(double dblTotal, int intNumofPaychecks)
        {

            //calculates the average pay of user based on total pay divided by number of checks

            double dblResult = (dblTotal / intNumofPaychecks);
            return dblResult;

        }

        static void DisplayTheList(List<double> dblListIncoming)
        {
            
            //iterates through list. Outputs weekly earnings.
            
            int intCntr = 1;

            foreach (double d in dblListIncoming)
                {
                    Console.WriteLine($"Weekly entry #{intCntr}: ${d}");
                    intCntr++;
                }

        }//end DisplayTheList

        static void StoreToTheList(List<double> dblEarnings, ref double dblTotal, ref int intCounter, double dblPaycheck)
        {

            //add earnings to list

            dblEarnings.Add(dblPaycheck);

            dblTotal += dblPaycheck;

            intCounter++;
        }//end StoreToTheList

        static bool IsValidDouble(string strNum)
        {
            //confirms proper user input. is it a double?

            double dblNum = 0;
            bool blnResult = Double.TryParse(strNum, out dblNum);

            return blnResult;
        }

        //--------------------START MAIN CODE--------------------

        static void Main(string[] args)
        {
            //declare vars
            String strNum;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false;

            //declare string
            List<double> dblEarnings = new List<double>();


            Console.WriteLine("Averager Program: Enter weekly earnings. (-1 to end entries)\n\n");

            do
            {
                do
                {

                    //enter weekly earnings

                    Console.Write("Please enter payroll #" + (intCntr + 1) + ": ");
                    strNum = Console.ReadLine();

                    //check to see is number was entered
                    blnResult = IsValidDouble(strNum);

                    if (blnResult == false)
                    {
                        Console.WriteLine("\n\nSorry, but you did not enter a valid real number in digits: ex 1051.00.");
                    }

                    //convert string to double
                    else
                    {
                        dblNum = Double.Parse(strNum);
                    }

                    //run do/while block until user enters number.
                } while (blnResult == false);

                //store weekly earned amount to list
                if (dblNum >= 0)
                {
                    StoreToTheList(dblEarnings, ref dblTotal, ref intCntr, dblNum);
                }

                //run do/while block until negative number is entered
            } while (dblNum >= 0);

            //display list to console
            DisplayTheList(dblEarnings);

            //calculate the average total earned
            dblResult = CalcAvg(dblTotal, intCntr);
            Console.WriteLine("The average of the weekly earnings entered is: $" + dblResult);

            //pause the console so that user can review
            Pause();
        }
    }
}
