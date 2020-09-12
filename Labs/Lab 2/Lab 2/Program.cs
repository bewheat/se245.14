/* D Davis
 * Lab 2
 * SE245.04
 * 7/28/20
 */

/* PROMPT:
 * For each student, enter a name and 5 lab grades.  
 * Display each student with each average grade for their 5 labs, and their letter grade.  
 * Drop down a line or two, and then display the average for each lab #. 
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2
{
   class Program
   {
       static void Main(string[] args)
       {

            //Declare variables
            String fName, lName, sTempGrade, strNumStudents;
            Double finalGrade = 0, tempAvg;
            Int32 NumStudents;
            bool blNumStudents;

            //Declare lists
            List<string> listFNames = new List<string>();
            List<string> listLNames = new List<string>();
            List<double> lab1Grades = new List<double>();
            List<double> lab2Grades = new List<double>();
            List<double> lab3Grades = new List<double>();
            List<double> lab4Grades = new List<double>();
            List<double> lab5Grades = new List<double>();
            List<string> letterGrades = new List<string>();
            List<double> avgGrades = new List<double>();


            //use do/while loop to ensure number is entered
            do
            {
                //ask for number of students to be entered and convert to integer
                Console.Write("Enter number of students: ");
                strNumStudents = Console.ReadLine();
                blNumStudents = Int32.TryParse(strNumStudents, out NumStudents);

            } while (blNumStudents == false);

            Console.WriteLine("\nEnter each students info below.");

            //use for loop to add info for each student in order in the lists
            for (int counter = 0; counter < NumStudents; counter++)
            {

                //enter students name
                Console.Write("\n\nEnter First Name Here: ");
                fName = Console.ReadLine();
                listFNames.Add(fName);

                Console.Write("Enter Last Name Here: ");
                lName = Console.ReadLine();
                listLNames.Add(lName);

                Console.WriteLine("Enter numerical lab grades(num between 0 and 100)");
                
                //Enter Students grades & add them to corresponding lists. add grades to find average
                Console.Write("Lab 1 Grade: ");
                sTempGrade = Console.ReadLine();
                lab1Grades.Add(Convert.ToDouble(sTempGrade));
                finalGrade += Convert.ToDouble(sTempGrade);

                Console.Write("Lab 2 Grade: ");
                sTempGrade = Console.ReadLine();
                lab2Grades.Add(Convert.ToDouble(sTempGrade));
                finalGrade += Convert.ToDouble(sTempGrade);

                Console.Write("Lab 3 Grade: ");
                sTempGrade = Console.ReadLine();
                lab3Grades.Add(Convert.ToDouble(sTempGrade));
                finalGrade += Convert.ToDouble(sTempGrade);

                Console.Write("Lab 4 Grade: ");
                sTempGrade = Console.ReadLine();
                lab4Grades.Add(Convert.ToDouble(sTempGrade));
                finalGrade += Convert.ToDouble(sTempGrade);

                Console.Write("Lab 5 Grade: ");
                sTempGrade = Console.ReadLine();
                lab5Grades.Add(Convert.ToDouble(sTempGrade));
                finalGrade += Convert.ToDouble(sTempGrade);

                //calculate student average. add to list
                tempAvg = finalGrade / 5;
                avgGrades.Add(tempAvg);

                //find student's letter grade
                if (tempAvg >= 90)
                {
                    letterGrades.Add("A");
                }

                else if (tempAvg >= 80)
                {
                    letterGrades.Add("B");
                }

                else if (tempAvg >= 70)
                {
                    letterGrades.Add("C");
                }

                else if (tempAvg >= 60)
                {
                    letterGrades.Add("D");
                }

                else if ((tempAvg > 0) && (tempAvg < 100))
                {
                    letterGrades.Add("F");
                }

                else //used for testing
                {
                    letterGrades.Add("ERR0R!");
                }

                //reset finalGrade for next student
                finalGrade = 0;

            }//done entering student info


            Console.WriteLine("\n\n\nClass Info: ");

            //print each student's info
            for (int index = 0; index < NumStudents; index++)
            {
                Console.WriteLine($"\n{listFNames[index]} {listLNames[index]}:   {avgGrades[index]}   | {letterGrades[index]}");
            }


            //calculate and print each labs average grade
            Console.WriteLine("\n\n\nLab Averages:");
            Console.WriteLine("Lab #1 Average: " + (lab1Grades.Sum() / NumStudents));
            Console.WriteLine("Lab #2 Average: " + (lab2Grades.Sum() / NumStudents));
            Console.WriteLine("Lab #3 Average: " + (lab3Grades.Sum() / NumStudents));
            Console.WriteLine("Lab #4 Average: " + (lab4Grades.Sum() / NumStudents));
            Console.WriteLine("Lab #5 Average: " + (lab5Grades.Sum() / NumStudents));




            //Pause program so that user can read console
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
       }
   }
}
