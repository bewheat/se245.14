using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ddavis_lab6
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

        //connect to DB
        public string AddARecord()
        {
            string strResult = "";

            //make a connection object
            SqlConnection Conn = new SqlConnection();

            //initialize its properties
            Conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE245_DDavis;User Id=SE245_DDavis;Password=008006221;";

            //store command in variable
            string strSQL = "INSERT INTO PersonV2 (FirstName, MiddleName, LastName, Street1, Street2, City, State, ZipCode, Phone, Email, Cell, Instagram) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @ZipCode, @Phone, @Email, @Cell, @Instagram)";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            //fill in the parameters
            comm.Parameters.AddWithValue("@FName", FirstName);
            comm.Parameters.AddWithValue("@MName", MiddleName);
            comm.Parameters.AddWithValue("@LName", LastName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@ZipCode", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Cell", CellPhone);
            comm.Parameters.AddWithValue("@Instagram", InstagramURL);

            //attempt to connect to the server
            try
            {
                Conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";
                Conn.Close();
            }
            catch (Exception err) //catch error and output error message
            {
                strResult = "ERROR: " + err.Message; 
            }
            finally
            {

            }

            //return results
            return strResult;
        }

        public PersonV2(): base()
        {
            cellPhone = "";
            instagramURL = "";
        }
    }
}
