using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsAttandanceData
    {
        static public bool GetAttendance(int AttendanceID, ref string EmployeeID, ref DateTime Date, ref TimeSpan AttendTime, ref TimeSpan ArrivalTime, ref short Status)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from Attendances where AttandanceID = @AttendanceID";
                    
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AttendanceID", AttendanceID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader != null)
                {
                    if (reader.Read())
                    {
                        AttendanceID = (int)reader["AttandanceID"];
                        EmployeeID = (string)reader["EmployeeID"];
                        Date = (DateTime)reader["AttendDate"];
                        if (reader["AttendTime"] != DBNull.Value)
                        {
                            AttendTime = (TimeSpan)reader["AttendTime"];
                        }
                        else
                        {
                            AttendTime = TimeSpan.Zero;
                        }

                        if (reader["ArrivalTime"] != DBNull.Value)
                        {
                            ArrivalTime = (TimeSpan)reader["ArrivalTime"];
                        }
                        else
                        {
                            ArrivalTime = TimeSpan.Zero;
                        }
                        Status = Convert.ToInt16((Byte)reader["Status"]);

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
         
        static public int AddNewAttendance(string EmployeeID, DateTime Date, TimeSpan AttendTime, TimeSpan ArrivalTime, short Status)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[Attendances]([EmployeeID],[AttendDate],[AttendTime],[ArrivalTime],[Status])" +
                           "VALUES (@EmployeeID,@Date,@AttendTime,@ArrivalTime,@Status);" +
                           "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            string DateString = DateTime.Today.ToString("yyyy-MM-dd");
            command.Parameters.AddWithValue("@Date", DateString);

            if(AttendTime != TimeSpan.Zero)
                command.Parameters.AddWithValue("@AttendTime", AttendTime);
            else
                command.Parameters.AddWithValue("@AttendTime", DBNull.Value);

            if(ArrivalTime != TimeSpan.Zero)
                command.Parameters.AddWithValue("@ArrivalTime", ArrivalTime);
            else
                command.Parameters.AddWithValue("@ArrivalTime", DBNull.Value);


            command.Parameters.AddWithValue("@Status", Status);

            try
            {
                connection.Open();
                object ob = command.ExecuteScalar();

                if (ob != null)
                {
                    
                        ID = decimal.ToInt32((decimal)ob);
                    
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
         
        static public bool UpdateAttendanceInfo(int AttendanceID, string EmployeeID, DateTime Date, TimeSpan AttendTime, TimeSpan ArrivalTime, short Status)
        {
            int AffectedRows = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "UPDATE [dbo].[Attendances] "
                           + "   SET [EmployeeID]  = @EmployeeID"
                           + "      ,[AttendDate]  = @AttendDate"
                           + "      ,[AttendTime]  = @AttendTime"
                           + "      ,[ArrivalTime] = @ArrivalTime"
                           + "      ,[Status]      = @Status"
                           + " WHERE AttandanceID = @AttandanceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AttandanceID", AttendanceID);
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            string DateString = DateTime.Today.ToString("yyyy-MM-dd");
            command.Parameters.AddWithValue("@AttendDate", DateString);

            if (AttendTime != TimeSpan.Zero)
                command.Parameters.AddWithValue("@AttendTime", AttendTime);
            else
                command.Parameters.AddWithValue("@AttendTime", DBNull.Value);

            if (ArrivalTime != TimeSpan.Zero)
                command.Parameters.AddWithValue("@ArrivalTime", ArrivalTime);
            else
                command.Parameters.AddWithValue("@ArrivalTime", DBNull.Value);

            command.Parameters.AddWithValue("@Status", Status);

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
         
        static public bool DeleteAttendance(int AttendanceID)
        {
            int AffectedRows = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "DELETE FROM [dbo].[Attendances] WHERE AttandanceID = @AttendanceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AttendanceID", AttendanceID);

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
         
        static public bool IsExist(int AttendanceID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select AttendanceID from Attendances where ID = @AttendanceID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AttendanceID", AttendanceID);

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
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }
         
        static public DataTable GetAttendances()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select * from Attendance_List_View";

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

        static public int GetEmployeeTodayAttendanceID(string EmployeeID)
        {
            int AttendanceID = -1;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "select AttandanceID from Attendances where AttendDate = @AttendDate AND EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            string date = DateTime.Today.ToString("yyyy-MM-dd");
            command.Parameters.AddWithValue("@AttendDate",date); 

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader != null) {

                    if (reader.Read())
                    {
                        AttendanceID = (int)reader[0];
                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message ); 
            }
            finally 
            {
                connection.Close(); 
            }

            return AttendanceID;
        }
    }
}
