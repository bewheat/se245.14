/* D Davis
Lab 1
SE245.04
7/23/20
*/

/*

PROMPT: Enter Student name & four grades and calculate average and assign a letter grade 
(Bonus if they use 20%, 20%, 25%, 35%)

*/ 
using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greet User
            Console.WriteLine("Welcome to my grade calculator");

            //declare variables
            String fName, lName, strGrade1, strGrade2, strGrade3, strGrade4, letterGrade;
            int grade1, grade2, grade3, grade4;
            Double grd1Weight = 0.20, grd2Weight = 0.20, grd3Weight = 0.25, grd4Weight = 0.35, avgGrade;

            //---add user input: ----

            //Ask for student's name
            Console.Write("Enter First Name Here: ");
            fName = Console.ReadLine();
            Console.Write("Enter Last Name Here: ");
            lName = Console.ReadLine();

            //Ask for grades
            Console.Write("Enter First Grade Here: ");
            strGrade1 = Console.ReadLine();

            Console.Write("Enter Second Grade Here: ");
            strGrade2 = Console.ReadLine();

            Console.Write("Enter Third Grade Here: ");
            strGrade3 = Console.ReadLine();

            Console.Write("Enter Fourth Grade Here: ");
            strGrade4 = Console.ReadLine();

            //Convert string values to integers
            grade1 = Convert.ToInt32(strGrade1);
            grade2 = Convert.ToInt32(strGrade2);
            grade3 = Convert.ToInt32(strGrade3);
            grade4 = Convert.ToInt32(strGrade4);

            //calculate weighted average of grades
            avgGrade = ((grade1 * grd1Weight) + (grade2 * grd2Weight) + (grade3 * grd3Weight) + (grade4 * grd4Weight));

            //determine grade letter using if/else statement

            if(avgGrade >= 90)
            {
                letterGrade = "A";
            }

            else if(avgGrade < 90 && avgGrade >= 80)
            {
                letterGrade = "B";
            }

            else if(avgGrade < 80 && avgGrade >= 70)
            {
                letterGrade = "C";
            }

            else if(avgGrade < 70 && avgGrade >= 60)
            {
                letterGrade = "D";
            }

            else
            {
                letterGrade = "F";
            }

            //print student's name, grades, average grade, and letter grade
            Console.WriteLine($"\n\n{fName} {lName} had grades of: \n\t\t{grade1} \n\t\t{grade2} \n\t\t{grade3} \n\t\t{grade4}\n\nTheir average is: {avgGrade}.\nTheir final grade is: {letterGrade}.");

            //close program
            Console.Write("Press Any Key to Continue");
            Console.ReadKey();
        }
    }
}
