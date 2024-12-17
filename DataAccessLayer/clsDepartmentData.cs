using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDepartmentData
    {
        static public bool GetDepartment(int DepartmentID, ref string Name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from Departments where ID = @DepartmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        Name = (string)reader["Name"];

                        isFound = true;
                    }
                }

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetDepartment(string Name, ref int DepartmentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from Departments where Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        DepartmentID = (int)reader["ID"];
                    }
                }

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool UpdateDepartmentInfo(int DepartmentID, string Name)
        {
            int AffectedRows = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "UPDATE [dbo].[Departments] SET [Name] =  @Name" +
                           "WHERE ID = @DepartmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@Name", Name);           

            try
            {
                connection.Open();

                object ob = command.ExecuteNonQuery();

                if (int.TryParse((string)ob, out int id))
                {
                    AffectedRows = id;
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

        static public DataTable GetAllDepartments()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from Departments";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();

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


    }
}
