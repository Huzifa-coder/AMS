using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsEmployeeData
    {
        static public bool GetEmployeeByEmployeeID(string EmployeeID, ref int PersonID, ref int DepartmentID, ref string Password, ref short Permissions)
        {
            bool isFound  = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from Employees where ID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        PersonID = (int)reader["PersonID"];
                        DepartmentID = (int)reader["DepartmentID"];
                        Password = (string)reader["Password"];
                        Permissions = Convert.ToInt16((byte)reader["Permissions"]);

                        isFound = true;
                    }
                }

            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool GetEmployeeByPersonID(int PersonID, ref string EmployeeID, ref int DepartmentID, ref string Password, ref short Permissions)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from Employees where PersonID = @PersonID";

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
                        EmployeeID = (string)reader["EmployeeID"];
                        DepartmentID = (int)reader["DepartmentID"];
                        Password = (string)reader["Password"];
                        Permissions = Convert.ToInt16((byte)reader["Permissions"]);

                        isFound = true;
                    }
                }

            }
            catch (Exception ex)
            {
                isFound = false;

                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        static public bool AddNewEmployee(string EmployeeID,int PersonID, int DepartmentID, string Password, short Permissions)
        {
            bool isAdded = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[Employees]([ID],[PersonID],[DepartmentID],[Password] ,[Permissions]) VALUES" +
                           "(@ID,@PersonID,@DepartmentID,@Password, @Permissions);" +
                           "SELECT CASE WHEN ID=@ID then 1 else 0 End from Employees;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", EmployeeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();
                object ob = command.ExecuteScalar();

                if (ob != null)
                {
                    isAdded = (int)ob > 0;
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

            return isAdded;
        }
         
        static public bool UpdateEmployeeInfo(string EmployeeID, int PersonID, int DepartmentID, string Password, short Permissions)
        {
            int AffectedRows = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "UPDATE [dbo].[Employees] SET [PersonID] = @PersonID, [DepartmentID] = @DepartmentID" +
                           ", [Password] = @Password, [Permissions] =  @Permissions " +
                           "WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", EmployeeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();

                object ob = command.ExecuteNonQuery();

                if (ob != null) {
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
         
        static public bool DeleteEmployee(string EmployeeID) 
        {
            int AffectedRows = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "DELETE FROM [dbo].[Employees] WHERE ID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();

                object ob = command.ExecuteNonQuery();

                if (ob != null)
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
         
        static public DataTable GetAllEmployees()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from Employees_List_View";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    if (reader.HasRows)
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
         
        static public bool IsExist(string EmployeeID) 
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select ID from Employees where ID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                connection.Open();

                object ob = command.ExecuteScalar();

                if (ob != null) {

                    IsFound = true;
                }

            }
            catch (Exception ex)
            {

                IsFound = false;
                Console.WriteLine(ex.Message);

            }
            finally 
            {
                connection.Close();
            }

            return IsFound;

        }
         
        static public bool IsExist(int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select ID from Employees where PersonID = @PersonID";

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

                IsFound = false;
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }

    }
}
