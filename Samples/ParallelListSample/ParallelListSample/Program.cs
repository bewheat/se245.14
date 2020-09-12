using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelListSample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare vars
            List<String> FName = new List<String>();
            List<String> LName = new List<String>();
            List<Double> GPA = new List<Double>();
            int NumOfStudents = 0;
            String tLName;
            Double tGPA;

            //Get # of Students
            Console.Write("How many students? ");
            NumOfStudents = int.Parse(Console.ReadLine());  //Gets string and converts to int

            //Loop thru each student & Get their info

            for (int cntr = 1; cntr <= NumOfStudents; cntr++)
            {
                //Get the user's First name
                //Prompt for info
                Console.Write("Enter first name: ");
                //Get Info
                FName.Add(Console.ReadLine());  //Get answer from user and added to the list

                //Get the user's Last Name
                Console.Write("Enter last name: ");
                tLName = Console.ReadLine();    //Get answer from user
                LName.Add(tLName);              //Added it to the list

                //Get the user's GPA
                Console.Write("Enter GPA: ");
                tGPA = Double.Parse(Console.ReadLine());    //Get answer from user and convert to a double
                GPA.Add(tGPA);              //Added it to the list


            }


            //Create for loop to output student info
            for (int cntr = 0; cntr < NumOfStudents; cntr++)
            {
                //Output a line of a student's info
                Console.WriteLine(FName[cntr] + " " + LName[cntr] + "\t\t" + GPA[cntr]);
            }


            //Pause the program so user can see results
            Console.WriteLine("Press Enter to exit program.");
            Console.ReadLine();
        }
    }
}
