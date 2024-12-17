using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsEmployee : clsPerson
    {
        enum enMode { New, Update }
        enMode _mode;


        public enum enPermissions {AttendanceList = 2, EmployeesList = 4}

        public string EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public clsDepartment Department { get; set; }
        public string Password { get; set; }
        public short Permissions { get; set; }

        public clsEmployee()
        {
            
            EmployeeID = string.Empty;
            DepartmentID = -1;
            DepartmentID = -1;
            Department = null;
            Password = string.Empty;
            Permissions = 0;

            _mode = enMode.New;
        }

        private clsEmployee(string employeeID, int personID, string firstName, string secondName, string lastName, int departmentID, string password, short permissions)
        {
            this.EmployeeID = employeeID;

            this.DepartmentID = departmentID;
            this.Department = clsDepartment.Find(departmentID);

            this.Password = password;
            this.Permissions = permissions;
            this.PersonID = personID;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;

            _mode = enMode.Update;
        }

        static public clsEmployee Find(string EmployeeID)
        {
            int personID = 0, departmentID = 0;
            short permissions = 0;
            string password = string.Empty;

            bool isFound = clsEmployeeData.GetEmployeeByEmployeeID(EmployeeID, ref personID, ref departmentID, ref password, ref permissions);

            if (isFound)
            {

                clsPerson person = clsPerson.Find(personID);

                return new clsEmployee(EmployeeID, personID, person.FirstName, person.SecondName, person.LastName
                                       , departmentID, password, permissions);

            }

            return null;
        }

        static public clsEmployee Find(int PersonID)
        {
            string employeeID = string.Empty;
            int departmentID = 0;
            short permissions = 0;
            string password = string.Empty;

            bool isFound = clsEmployeeData.GetEmployeeByPersonID(PersonID, ref employeeID, ref departmentID, ref password, ref permissions);

            if (isFound)
            {

                clsPerson person = clsPerson.Find(PersonID);

                return new clsEmployee(employeeID, PersonID, person.FirstName, person.SecondName, person.LastName
                                       , departmentID, password, permissions);

            }

            return null;
        }

        static public bool IsExist(string EmployeeID)
        {

            return clsEmployeeData.IsExist(EmployeeID);
        }

        static public bool IsExist(int Person)
        {

            return clsEmployeeData.IsExist(Person);
        }

        static public DataTable GetAllEmployees()
        {
            return clsEmployeeData.GetAllEmployees();
        }

        static public bool CheckAccessPermission(string EmployeeID, enPermissions Permission)
        {
            clsEmployee em = clsEmployee.Find(EmployeeID);

            if( (((short)Permission) & em.Permissions) == ((short)Permission))
            {
                return true;
            }

            return false;
        }

        static public bool Delete(string EmployeeID)
        {

            if (IsExist(EmployeeID))
            {

                return clsEmployeeData.DeleteEmployee(EmployeeID);
            }

            return false;
        }

        public int GetTodayAttendanceID()
        {

            return clsAttandanceData.GetEmployeeTodayAttendanceID(EmployeeID);
        }

        public bool HasAttendToday()
        {

            return clsAttandanceData.GetEmployeeTodayAttendanceID(EmployeeID) > 0;
        }

        private bool _AddNewEmployee()
        {

            return clsEmployeeData.AddNewEmployee(EmployeeID, PersonID, DepartmentID, Password, Permissions);
        }

        private bool _UpdateEmployee() {

            return clsEmployeeData.UpdateEmployeeInfo(EmployeeID, PersonID, DepartmentID, Password, Permissions);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.New:
                    if (_AddNewEmployee())
                    {
                        _mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateEmployee();

            }

            return false;
        }

        public bool HasAccessTo(enPermissions permissions)
        {
            return CheckAccessPermission(EmployeeID, permissions);
        }
    }
}
