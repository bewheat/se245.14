using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_davis_lab_3
{
    class Program
    {

        //---FUNCTIONS---

        //Pause the console so that user can review it until they decide to end program
        static void Pause()
        {
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }//end Pause()

        //check to see if user input is valid data type
        static bool ValidNum(String num)
        {

            bool blnResult;
            double dNum = 0;

            blnResult = Double.TryParse(num, out dNum);
            return blnResult;

        }//end ValidNum()

        static double ConvertNum(String sNum)
        {
            bool check;
            double dNum;

            do
            {
                check = ValidNum(sNum);

                if (check == false)
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("\n\nEnter Number Here: ");
                    sNum = Console.ReadLine();
                }

            } while (check == false);

            dNum = Double.Parse(sNum);
            return dNum;
        }

        //populate lab grade lists and add students grades together
        static void StoreToList(List<double> gradeList, ref double finalGrade, double grade)
        {
            gradeList.Add(grade);
            finalGrade += grade;

        }//end StoreToList()

        //calculate average
        static double FindAvg(double sum, double num)
        {

            return sum / num;

        }//end FindAvg

        static void Main(string[] args)
        {
            //Declare Variables
            String fName, lName, sTempGrade, strNumStudents, goAgain = "y";
            Double finalGrade = 0, tempAvg, numStudents = 0, tempGrade;

            //Declare Lists
            List<string> listFNames = new List<string>();
            List<string> listLNames = new List<string>();
            List<double> lab1Grades = new List<double>();
            List<double> lab2Grades = new List<double>();
            List<double> lab3Grades = new List<double>();
            List<double> lab4Grades = new List<double>();
            List<double> lab5Grades = new List<double>();
            List<double> labAverages = new List<double>();
            List<string> letterGrades = new List<string>();
            List<double> avgGrades = new List<double>();

            Console.WriteLine("Calculate your student's grade average and teh average of all lab grades.");


            //prompt for grades
            Console.Write("\n\nEnter Student's Info Below: \n");

            //use for loop to enter student info
            //add function only works for numbers so names must be added to lists manually
            while (goAgain == "y")
            {
                Console.Write("\nFirst Name: ");
                fName = Console.ReadLine();
                listFNames.Add(fName);

                Console.Write("Last Name: ");
                lName = Console.ReadLine();
                listLNames.Add(lName);

                Console.WriteLine("Grades: ");

                Console.Write("Lab 1: ");
                sTempGrade = Console.ReadLine();
                tempGrade = ConvertNum(sTempGrade);
                StoreToList(lab1Grades, ref finalGrade, tempGrade);

                Console.Write("Lab 2: ");
                sTempGrade = Console.ReadLine();
                tempGrade = ConvertNum(sTempGrade);
                StoreToList(lab2Grades, ref finalGrade, tempGrade);

                Console.Write("Lab 3: ");
                sTempGrade = Console.ReadLine();
                tempGrade = ConvertNum(sTempGrade);
                StoreToList(lab3Grades, ref finalGrade, tempGrade);

                Console.Write("Lab 4: ");
                sTempGrade = Console.ReadLine();
                tempGrade = ConvertNum(sTempGrade);
                StoreToList(lab4Grades, ref finalGrade, tempGrade);

                Console.Write("Lab 5: ");
                sTempGrade = Console.ReadLine();
                tempGrade = ConvertNum(sTempGrade);
                StoreToList(lab5Grades, ref finalGrade, tempGrade);

                //calculate student average. add to list
                tempAvg = FindAvg(finalGrade, 5);
                avgGrades.Add(tempAvg);

                //find letter grade
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

                //reset final grade for next loop around
                finalGrade = 0;

                //increment number of students to keep count
                numStudents++;

                //ask user if they have another student's info to enter
                //control variable for while loop
                Console.Write("\n\nWould you like to enter another student's information? [y/n]");
                goAgain = Console.ReadLine();
                goAgain = goAgain.ToLower();

            }//end for loop

            //print student info
            Console.WriteLine("\n\nStudent's Grades: ");

            for (int index = 0; index < numStudents; index++)
            {
                Console.WriteLine($"\n{listFNames[index]} {listLNames[index]}: | {lab1Grades[index]}, {lab2Grades[index]}, {lab3Grades[index]}, {lab4Grades[index]}, {lab5Grades[index]} | {avgGrades[index]}   | {letterGrades[index]}");
            }//end for loop

            //Calculate lab averages and add them to their list
            labAverages.Add(FindAvg(lab1Grades.Sum(), numStudents));
            labAverages.Add(FindAvg(lab2Grades.Sum(), numStudents));
            labAverages.Add(FindAvg(lab3Grades.Sum(), numStudents));
            labAverages.Add(FindAvg(lab4Grades.Sum(), numStudents));
            labAverages.Add(FindAvg(lab5Grades.Sum(), numStudents));

            //print each lab's average
            Console.WriteLine("\n\nLab Averages: ");

            int counter = 1;

            foreach (double l in labAverages)
            {
                Console.WriteLine($"Lab #{counter}: {l}");
            }

            Pause();

        }

    }
}
