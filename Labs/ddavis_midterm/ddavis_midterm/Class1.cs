using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddavis_midterm
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
        private string feedback = "";

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
                    firstName = "ERROR: No First Name Entered";
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
                    lastName = "ERROR: No Last Name Entered";
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
                    street1 = "ERROR: No Street Name Entered";
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
                if (ValidationLibrary.IsItFilledIn(value, 3) == true)
                {
                    city = value;
                }

                else
                {
                    city = "ERROR: No City Entered";
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
                if (ValidationLibrary.CharLengthEqualTo(value, 2) == true)
                {
                    state = value;
                }

                else if (ValidationLibrary.CharLengthEqualTo(value, 0) == true)
                {
                    state = "ERROR: No State Entered";
                }

                else
                {
                    state = "ERROR: INVALID STATE ENTERED. EX: RI";
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
                    zip = "ERROR: NO ZIP CODE ENTERED";
                }

                else if (ValidationLibrary.CharLengthEqualTo(value, 5) == false)
                {
                    zip = "ERROR: INVALID ZIP CODE ENTERED. EX: 02893";
                }


                else if (ValidationLibrary.IsItADbl(value) == false)
                {
                    zip = "ERROR: INVALID ZIP CODE ENTERED. EX: 02893";
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
                    phone = "ERROR: NO PHONE NUMBER ENTERED.";
                }

                else
                {
                    phone = "ERROR: INVALID PHONE NUMBER ENTERED. EX: 4015551234";
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
                    email = "ERROR: NO EMAIL ENTERED.";
                }

                else
                {
                    email = "ERROR: INVALID EMAIL ENTERED. PLEASE TRY AGAIN.";
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
    }
}
