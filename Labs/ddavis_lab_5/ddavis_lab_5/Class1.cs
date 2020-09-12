using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddavis_lab_5
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private string email;
        protected string feedback = "";

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {

                if (ValidationLibrary.IsItFilledIn(value, 1) == true)
                {
                    firstName = value;
                }
                
                else
                {
                    feedback += "\nERROR: NO FIRST NAME ENTERED";
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == true)
                {
                    lastName = value;
                }

                else
                {
                    feedback += "\nERROR: NO LAST NAME ENTERED";
                }
            }
        }

        public string Street1
        {
            get
            {
                return street1;
            }

            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 3) == true)
                {
                    street1 = value;
                }

                else
                {
                    feedback += "\nERROR: INVALID STREET NAME ENTERED.";
                }
            }
        }

        public string Street2
        {
            get
            {
                return street2;
            }

            set
            {
                street2 = value;
            }
        }


        public string City
        {
            get
            {
                return city;
            }

            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                {
                    feedback += "\nERROR: NO CITY ENTERED";
                }

                else if (ValidationLibrary.IsItFilledIn(value, 3) == false)
                {
                    feedback += "\nERROR: INVALID CITY ENTERED";
                }

                else
                {
                    city = value;
                }
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                
                

                if (ValidationLibrary.CharLengthEqualTo(value, 0) == true)
                {
                    feedback += "\nERROR: NO STATE ENTERED";
                }

                else if (ValidationLibrary.CharLengthEqualTo(value, 2) == false)
                {
                    feedback += "\nERROR: INVALID STATE ENTERED. EX: RI";
                }

                else
                {
                    state = value;
                }
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }

            set
            {
                if (ValidationLibrary.CharLengthEqualTo(value, 0) == true)
                {
                    feedback += "\nERROR: NO ZIP CODE ENTERED";
                }

                else if (ValidationLibrary.IsItADbl(value) == false)
                {
                    feedback += "\nERROR: INVALID ZIP CODE ENTERED. EX: 02893";
                }

                else if (ValidationLibrary.IsItFilledIn(value, 5) == false)
                {
                    feedback += "\nERROR: INVALID ZIP CODE ENTERED. EX: 02893";
                }                

                else
                {
                    zip = value;
                }
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                if ((ValidationLibrary.CharLengthEqualTo(value, 10) == true) && (ValidationLibrary.IsItADbl(value) == true))
                {
                    phone = value;
                }

                else if (ValidationLibrary.CharLengthEqualTo(value, 0) == true)
                {
                    feedback += "\nERROR: NO PHONE NUMBER ENTERED.";
                }

                else
                {
                    feedback += "\nERROR: INVALID PHONE NUMBER ENTERED. EX: 4015551234";
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (ValidationLibrary.IsValidEmail(value) == true)
                {
                    email = value;
                }

                else if (ValidationLibrary.CharLengthEqualTo(value, 0) == true)
                {
                    feedback += "\nERROR: NO EMAIL ENTERED.";
                }

                else
                {
                    feedback += "\nERROR: INVALID EMAIL ENTERED.";
                }
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }

            set
            {
                feedback = value;
            }
        }

        //default constructor
        public Person()
        {

            firstName = "";
            middleName = "";
            lastName = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            zip = "";
            phone = "";
            email = "";
            feedback = "";

        }
    }
}
