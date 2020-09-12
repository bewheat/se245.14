using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddavis_lab_5
{
    class PersonV2: Person
    {
        private string cellPhone;
        private string instagramURL;

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }

            set
            {
                if ((ValidationLibrary.CharLengthEqualTo(value, 10) == true) && (ValidationLibrary.IsItADbl(value)))
                {
                    cellPhone = value;
                }

                /*else if (ValidationLibrary.CharLengthEqualTo(value, 0) == true)
                {
                    cellPhone = "ERROR: No Number Entered";
                }*/ //cell phone number not necessry if phone number entered


                //ADD ELSE IF STATEMENT
                //CHECK IF NUMBER IS THE SAME AS PHONE NUMBER.
                //MAYBE CREATE A CHECKBOX OPTION TO JUST SAY IT IS INSTEAD?
                //OR PUT SOMETHING IN THE PROGRAM TO MAKE IT SO IT DOESN'T MATTER WHICH ONE IS FILLED IN AS LONG AS AT LEAST ONE OF THEM IS


                else
                {
                    feedback += "\nERROR: INVALID CELL PHONE NUMBERED ENTERED. EX:4015551234";
                }
            }
        }

        public string InstagramURL
        {
            get
            {
                return instagramURL;
            }

            set
            {
                instagramURL = value;
            }
        }

        public PersonV2(): base()
        {
            cellPhone = "";
            instagramURL = "";
        }
    }
}
