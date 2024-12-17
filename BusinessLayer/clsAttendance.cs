using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsAttendance
    {
        enum enMode { New, Update }
        enMode _Mode;

        public enum enStatus { Absent, Attend, InCollage }

        public int AttendanceID {get; set;}
        public string EmployeeID {get; set;}
        public clsEmployee EmployeeInfo {get; set;}
        public DateTime Date {get; set;}
        public TimeSpan AttendTime {get; set;}
        public TimeSpan ArrivalTime {get; set;}
        public enStatus Status { get; set;}

        public clsAttendance()
        {
            AttendanceID = -1;
            EmployeeID = string.Empty;
            Date = DateTime.MinValue;
            AttendTime = TimeSpan.Zero;
            ArrivalTime = TimeSpan.Zero;
            Status = enStatus.Absent;

            _Mode = enMode.New;
        }

        private clsAttendance(int attendanceID, string employeeID, DateTime date, TimeSpan attendTime, TimeSpan arrivalTime, enStatus status)
        {
            AttendanceID = attendanceID;
            EmployeeID = employeeID;
            EmployeeInfo = clsEmployee.Find(employeeID);
            Date = date;
            AttendTime = attendTime;
            ArrivalTime = arrivalTime;
            Status = status;

            _Mode = enMode.Update;
        }

        static public clsAttendance Find(int AttendanceID)
        {
            string employeeID = string.Empty;
            DateTime date = DateTime.MinValue;
            TimeSpan attendTime = TimeSpan.Zero, arrivalTime = TimeSpan.Zero;
            short status = 0;

            if(clsAttandanceData.GetAttendance(AttendanceID, ref employeeID, ref date, ref attendTime, ref arrivalTime, ref status))
            {
                return new clsAttendance(AttendanceID, employeeID, date, attendTime, arrivalTime, (enStatus)status);
            }

            return null;
        }
        
        static public bool IsExist(int AttendanceID)
        {

            return clsAttandanceData.IsExist(AttendanceID);
        }

        static public bool Delete(int AttendanceID)
        {
            return clsAttandanceData.DeleteAttendance(AttendanceID);
        }

        static public DataTable GetAttendanceList()
        {
            return clsAttandanceData.GetAttendances();
        }

        private bool _AddNewAttendance()
        {
            int ID = clsAttandanceData.AddNewAttendance(EmployeeID, Date, AttendTime, ArrivalTime, ((short)Status));

            if (ID > 0) {
            
                this.AttendanceID = ID;
                return true;
            }

            return false;
        }

        private bool _UpdateAttendanceAttendance() {

            return clsAttandanceData.UpdateAttendanceInfo(AttendanceID, EmployeeID, Date, AttendTime, ArrivalTime, ((short)Status));
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.New:
                    if (_AddNewAttendance())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateAttendanceAttendance();

            }

            return false;
        }
    }
}
