using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddavis_lab_4
{
    class Program
    {

        //initialize structure
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

            public string FirstName
            {
                get
                {
                    return firstName;
                }

                set
                {
                    firstName = value;
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
                    lastName = value;
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
                    street1 = value;
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
                    city = value;
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
                        state = "";
                    }

                    else
                    {
                        state = "INVALID";
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
                        zip = "";
                    }

                    else if (ValidationLibrary.CharLengthEqualTo(value, 5) == false)
                    {
                        zip = "INVALID";
                    }


                    else if (ValidationLibrary.IsItADbl(value) == false)
                    {
                        zip = "INVALID";
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
                        phone = "";
                    }

                    else
                    {
                        phone = "INVALID";
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
                        email = "";
                    }

                    else
                    {
                        email = "INVALID";
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            //initialize variables

            //create variable to hold struc record
            Person record = new Person();



            //save information to struct/variable
            Console.Write("\nEnter First Name Here: ");
            record.FirstName = Console.ReadLine();

            Console.Write("\nEnter Middle Name Here: ");
            record.MiddleName = Console.ReadLine();

            Console.Write("\nEnter Last Name Here: ");
            record.LastName = Console.ReadLine();


            Console.Write("\nEnter Address Below: ");

            Console.Write("\nStreet Line 1: ");
            record.Street1 = Console.ReadLine();

            Console.Write("\nStreet Line 2: ");
            record.Street2 = Console.ReadLine();

            Console.Write("\nCity: ");
            record.City = Console.ReadLine();

            Console.Write("\nState: ");
            record.State = Console.ReadLine();

            Console.Write("\nZip Code: ");
            record.Zip = Console.ReadLine();

            Console.Write("\nEnter Ten Digit Phone Number Here: ");
            record.Phone = Console.ReadLine();

            Console.Write("\nEnter Email Here: ");
            record.Email = Console.ReadLine();

            //print to console
            Console.Write("\n\n\nData Saved: ");
            Console.Write($"\n\n\tFull Name: {record.FirstName} {record.MiddleName} {record.LastName}");
            Console.Write("\n\tAddress: ");
            Console.Write($"\n\t\t{record.Street1}");
            Console.Write($"\n\t\t{record.Street2}");
            Console.Write($"\n\t\t{record.City} {record.State}");
            Console.Write($"\n\t\t{record.Zip}");
            Console.Write("\n\nAlternate Contact Methods: ");
            Console.Write($"\n\n\tPhone Number: {record.Phone}");
            Console.Write($"\n\tEmail Address: {record.Email}\n\n");

            BasicTools.Pause();

        }
    }
}
