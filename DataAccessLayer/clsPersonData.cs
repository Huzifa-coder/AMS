using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPersonData
    {
        static public bool GetPerson(int PersonID, ref string FirstName, ref string SecondName, ref string LastName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from People where ID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        FirstName = (string)reader["FirstName"];

                        if (reader["SecondName"] != DBNull.Value)
                            SecondName = (string)reader["SecondName"];
                        else
                            SecondName = "";

                        LastName = (string)reader["LastName"];

                        isFound = true;
                    }
                }

            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public int AddNewPerson(string FirstName, string SecondName, string LastName)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[People] ([FirstName],[SecondName],[LastName]) VALUES " +
                           "(@FirstName, @SecondName, @LastName) ; " +
                           "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            if (SecondName == "")
            {
                command.Parameters.AddWithValue("@SecondName", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@SecondName", SecondName);
            }
            command.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != DBNull.Value) 
                {
                   ID = decimal.ToInt32((decimal)result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }

        static public bool UpdatePersonInfo(int PersonID, string FirstName, string SecondName, string LastName)
        {
            int AffectedRows = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "UPDATE [dbo].[People] SET [FirstName] =  @FirstName ,[SecondName] = @SecondName," +
                           "[LastName] = @LastName " +
                           "WHERE ID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            if (SecondName != "")
                command.Parameters.AddWithValue("@SecondName", SecondName);
            else
                command.Parameters.AddWithValue("@SecondName", DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                connection.Open();

                object ob = command.ExecuteNonQuery();
                
                if (ob != DBNull.Value)
                {
                    AffectedRows = (int)ob;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return AffectedRows > 0;
        }

        static public bool DeletePerson(int PersonID)
        {
            int AffectedRows = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "DELETE FROM [dbo].[People] WHERE ID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object ob = command.ExecuteNonQuery();

                if (int.TryParse((string)ob, out int ar))
                {
                    AffectedRows = ar;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return AffectedRows > 0;
        }

        static public DataTable GetPeople()
        {

            DataTable dt = null;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from People";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        dt.Load(reader);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return dt;
        }

        static public bool IsExist(int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select ID from People where ID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object ob = command.ExecuteScalar();

                if (ob != null)
                {

                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }
    }
}
