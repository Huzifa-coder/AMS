using AMS.Attendance;
using AMS.Employees;
using AMS.Global;
using AMS.Login;
using AMS.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;

        public frmMain(frmLogin login)
        {
            InitializeComponent();

            _frmLogin = login;
        }

        private void btnTakeAttendance_Click(object sender, EventArgs e)
        {
            frmTakeAttendance frm = new frmTakeAttendance();
            frm.ShowDialog();
        }

        private void btnEmployeesList_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentEmployee.HasAccessTo(BusinessLayer.clsEmployee.enPermissions.EmployeesList))
            {
                MessageBox.Show("You Don't Have Access To This Option, Pleace Contact Your Admin...");
                return;
            }
            frmEmployeesList frm = new frmEmployeesList();
            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsGlobal.CurrentEmployee = null;
            _frmLogin.Show();
        }

        private void btnAttendanceList_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentEmployee.HasAccessTo(BusinessLayer.clsEmployee.enPermissions.AttendanceList))
            {
                MessageBox.Show("You Don't Have Access To This Option, Pleace Contact Your Admin...");
                return;
            }

            frmListAttendance frm = new frmListAttendance();
            frm.ShowDialog();
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            frmEmployeeAccountSetting frm = new frmEmployeeAccountSetting(clsGlobal.CurrentEmployee.EmployeeID);
            frm.ShowDialog();
        }
    }
}
