using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.Employees
{
    public partial class ctrlEmployeesInfoCard : UserControl
    {
        string _EmployeeID = string.Empty;

        clsEmployee _Employee;

        public string EmployeeID { get { return _EmployeeID; } }

        public clsEmployee Employee { get { return _Employee; } }

        public ctrlEmployeesInfoCard()
        {
            InitializeComponent();
        }

        private void lnlEditEmployeeInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditEmployee frm = new frmAddEditEmployee(_EmployeeID);
            frm.ShowDialog();

            LoadEmployeeInfo(_EmployeeID);
        }

        public void LoadEmployeeInfo(string EmployeeID)
        {
            if (clsEmployee.IsExist(EmployeeID))
            {
                _EmployeeID = EmployeeID;
                _Employee = clsEmployee.Find(EmployeeID);

                _LoadData();
            }
            else
            {
                MessageBox.Show("This Employee ID " + EmployeeID + " Is Not Exist..");
            }
        }

        private void _LoadData()
        {

            ctrlPersonInfoCard1.LoadPersonInfo(_Employee.PersonID);
            lbEmployeeID.Text = _EmployeeID;
            lbDepartment.Text = _Employee.Department.Name;

            cbAttendanceList.Checked = clsEmployee.CheckAccessPermission(_EmployeeID, clsEmployee.enPermissions.AttendanceList);
            cbEmployeesList.Checked = clsEmployee.CheckAccessPermission(_EmployeeID, clsEmployee.enPermissions.EmployeesList);

        }

 
    }
}
