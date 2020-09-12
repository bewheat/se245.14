//import libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//name program
namespace Week1_Sample_1
{
    class Program
    {
        //Code goes after this:
        static void Main(string[] args)
        {

            //declare variables
            String strFirst, str0perand, strNum1, strNum2;
            //not adding intNum3 because it isn't used.
            Int32 intNum1 = 0, intNum2 = 0, intResult = 0;
            Double dblResult;

            //opening message
            Console.WriteLine("Hello There!");

            //personalized message
            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine();
            Console.WriteLine("Hello " + strFirst + "! Let's do some math!");

            //get user input
            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            str0perand = Console.ReadLine();
            str0perand = str0perand.ToUpper();

            Console.Write("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            //convert user input to int for math
            intNum1 = Int32.Parse(strNum1);
            intNum2 = Int32.Parse(strNum2);

            //use case statement to determine how user wanted to calculate numbers and do the calculations
            switch(str0perand)
            {
                //addition
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break;

                //subtraction
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    break;

                //division
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;

                //multiplication --> EDIT. ORIGINALLY WAS MISSING FROM CODE.
                case "MULTIPLY":
                    intResult = intNum1 * intNum2;
                    break;
            }

            //double the result of calcultaion
            dblResult = (Double)intResult;

            //use if/else statement to write out the proper message to the console, including the results of the calculation and its double.
            //EDIT. ORIGINALLY WRITTEN TO SHOW THE DOUBLE AS THE RESULT. NO MENTION OF DOUBLE AND THE RESULT IS NEVER SHOWN.
            //addition
            if(str0perand == "PLUS")
            {
                Console.WriteLine("\n\nThe sum of " + intNum1 + " and " + intNum2 + " equals: " + intResult + "\nDouble the sum is: " + dblResult);
            }
            
            //subtraction
            else if(str0perand == "MINUS")
            {
                Console.WriteLine($"\n\nThe difference between " + intNum1 + " and " + intNum2 + " equals: " + intResult + "\nDouble the difference is: " + dblResult);
            }

            //division\
            else if(str0perand == "DIVIDE")
            {
                Console.WriteLine($"\n\nThe quotient of {intNum1} and {intNum2} equals: {intResult} \nDouble the quotient is: {dblResult}");
            }

            //multiplication --> EDIT. ORIGINALLY WAS MISSING FROM CODE
            else if(str0perand == "MULTIPLY")
            {
                Console.WriteLine($"\n\nThe product of {intNum1} and {intNum2} equals: {intResult} \nDouble the product is: {dblResult}");
            }

            //else statement in case user made a mistake. personally i like to always add this in. Not originally part of the code
            else
            {
                Console.WriteLine("Not an option. Try Again.");
            }

            //close program
            Console.Write("\n\nPress Any Key to Continue");
            Console.ReadKey();


        }
    }
}
