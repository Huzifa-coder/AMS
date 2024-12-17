using AMS.Global;
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

namespace AMS.Attendance
{
    public partial class frmTakeAttendance : Form
    {

        enum enMode { Attend, Arrival }

        enMode _mode = enMode.Attend;

        string _EmployeeID = string.Empty;
        clsEmployee _Employee;

        clsAttendance _Attendance = new clsAttendance();

        public frmTakeAttendance()
        {
            InitializeComponent();

            _Employee = clsGlobal.CurrentEmployee;
            _EmployeeID = clsGlobal.CurrentEmployee.EmployeeID;

            _mode = (_Employee.HasAttendToday())?enMode.Arrival:enMode.Attend;
        }

        public frmTakeAttendance(string EmployeeID)
        {
            InitializeComponent();
            
            _EmployeeID = EmployeeID;
            _Employee = clsEmployee.Find(EmployeeID);

            _mode = (_Employee.HasAttendToday()) ? enMode.Arrival : enMode.Attend;
        }

        private void _ResetDefulatValues()
        {

            lbEmployeeID.Text = _EmployeeID;
            lbFullName.Text = _Employee.FullName;
            lbDate.Text = DateTime.Now.ToShortDateString();
            lbTime.Text = DateTime.Now.ToShortTimeString();
            
        }

        private void frmTakeAttendance_Load(object sender, EventArgs e)
        {

            _ResetDefulatValues();

            if (_mode == enMode.Arrival)
            {
                _LoadData();
            }

        }

        private void _LoadData()
        {
            _Attendance = clsAttendance.Find(_Employee.GetTodayAttendanceID());

            if (_Attendance == null)
                return;
            
            if (_Attendance.Date.ToShortDateString() != DateTime.Today.Date.ToShortDateString())
            {
                MessageBox.Show("This Attendance Can't Be Taken Because it Belong For Other Day");

            }

            //Check if the attendance is taken as absent or in Coollage
            if (_Attendance.Status == clsAttendance.enStatus.Absent || _Attendance.Status == clsAttendance.enStatus.InCollage)
            {
                MessageBox.Show("Employee With ID : " + _EmployeeID.ToString() + "\nHas Already Take His/Her Attendance For Today As Absent/Incollage.");
                this.Close();
            }

            //check if the attendance is taken for today
            if (_Attendance.ArrivalTime != TimeSpan.Zero)
            {
                btnSave.Enabled = false;
                MessageBox.Show("You have taken today attendance", "Copleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            
            lbAttendanceID.Text = _Employee.GetTodayAttendanceID().ToString();
            lbAttendTitle.Text = "Arrival Time : ";
           
            rbAbsent.Enabled = false;
            rbAttend.Enabled = false;
            rbInCollage.Enabled = false;

        }

        private void _ChangeStatus()
        {

            lbAttendTitle.Enabled = !(rbAbsent.Checked == true || rbInCollage.Checked == true);
            lbTime.Enabled = !(rbAbsent.Checked == true || rbInCollage.Checked == true);
          
        }

        private void rbAbsent_CheckedChanged(object sender, EventArgs e)
        {
            _ChangeStatus();
        }

        private void rbInCollage_CheckedChanged(object sender, EventArgs e)
        {
            _ChangeStatus();
        }

        private void rbAttend_CheckedChanged(object sender, EventArgs e)
        {
            _ChangeStatus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private clsAttendance.enStatus GetStatus()
        {

            return (rbAttend.Checked)?clsAttendance.enStatus.Attend:(rbAbsent.Checked?clsAttendance.enStatus.Absent:clsAttendance.enStatus.InCollage);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            _Attendance.EmployeeID = _EmployeeID;
            _Attendance.Date = DateTime.Now;
            _Attendance.Status = GetStatus();

            if (_Attendance.Status == clsAttendance.enStatus.Attend)
            {

                if (_mode == enMode.Arrival)
                {

                    _Attendance.ArrivalTime = DateTime.Now.TimeOfDay;
                }
                else
                {
                    _Attendance.AttendTime = DateTime.Now.TimeOfDay;
                }

            }

            if (_Attendance.Save())
            {
                lbAttendanceID.Text= _Attendance.AttendanceID.ToString();
                btnSave.Enabled = false;
                MessageBox.Show("The attendance has saved successfully.");
            }
            else
            {
                MessageBox.Show("Error : attendance has not save successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
