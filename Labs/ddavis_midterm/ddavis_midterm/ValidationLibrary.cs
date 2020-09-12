﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ddavis_midterm
{
    class ValidationLibrary
    {
        

        /******************************************************************************
        
                Library of validation functions we can use in future projects
         
         ******************************************************************************/

        //recieves a string and we can let user know if it is filled in
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }

        //recieves a string and we can let user know if it is filled in
        //de ja vu?
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length >= minlen)
            {
                result = true;
            }

            return result;
        }

        //recieves a date and determines if it's a future date
        public static bool IsAFutureDate(DateTime temp)
        {
            bool blnResult;

            if (temp <= DateTime.Now)
            {
                blnResult = false;
            }

            else
            {
                blnResult = true;
            }

            return blnResult;

        }

        //recieves a string and we can let user know if it has a semi-valid email format
        public static bool IsValidEmail(string temp)
        {
            //assume true but look for 'bad stuff' to make it false
            bool blnResult = true;

            //look for position of '@'
            int atLocation = temp.IndexOf("@");
            int NextatLocation =  temp.IndexOf("@", atLocation + 1);

            //temp = scott@neit.ca
            //length = 13
            //position of last period = 10

            //look for position of last period "."
            int periodLocation = temp.LastIndexOf(".");

            //check for minimum length
            if (temp.Length < 8)
            {
                blnResult = false;
            }

            else if (atLocation < 2) //if it is -1, not found and needs at least two chars in front)
            {
                blnResult = false;
            }

            else if (periodLocation +2 > (temp.Length)) 
            {
                blnResult = false;
            }

            return blnResult;

        }

        public static bool IsMinimumAmount(int temp, int min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }

            else
            {
                blnResult = false;
            }

            return blnResult;

        }

        public static bool IsMinimumAmount(double temp, double min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }

            else
            {
                blnResult = false;
            }

            return blnResult;

        }

        public static bool CharLengthEqualTo(string temp, double rightLen)
        {
            bool blnResult;

            if (temp.Length == rightLen)
            {
                blnResult = true;
            }

            else
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool IsItADbl(string potNum)
        {
            bool blnResult;
            double num;

            blnResult = double.TryParse(potNum, out num);
            return blnResult;
        }
    }
}