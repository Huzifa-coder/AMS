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
    public partial class frmAddEditEmployee : Form
    {
        enum enMode { Add, Edit }

        enMode _Mode;

        string _EmployeeID = string.Empty;

        clsEmployee _Employee;

        public frmAddEditEmployee()
        {
            InitializeComponent();

            _Mode = enMode.Add;

        }

        public frmAddEditEmployee(string EmployeeID)
        {
            InitializeComponent();

            _Mode = enMode.Edit;
            _EmployeeID = EmployeeID;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            if (_Mode == enMode.Edit)
            {
                
                tcEmployee.SelectedTab = tcEmployee.TabPages["tpEmployee"];
                return;
            }

            if (ctrlPersonFilterCard1.PersonID <= 0)
            {
                MessageBox.Show("Pleace Choose A Person");
                return;
            }
            else
            {
                btnSave.Enabled = true;
                tpEmployee.Enabled = true;
                tcEmployee.SelectedTab = tcEmployee.TabPages["tpEmployee"];
                
            }

        }

        private void frmAddEditEmployee_Load(object sender, EventArgs e)
        {
            _RestDefualtValues();

            if(_Mode == enMode.Edit)
            {
                _LoadData();
            }
        }

        private void _LoadData()
        {
            _Employee = clsEmployee.Find(_EmployeeID);

            if( _Employee == null )
            {
                MessageBox.Show("?There Are No Employee With : "  +_EmployeeID +" ID");
                this.Close();
            }

            ctrlPersonFilterCard1.LoadPersonInfo(_Employee.PersonID);

            tbEmployeeID.Enabled = false;
            tbEmployeeID.Text = _Employee.EmployeeID.ToString();
            tbPassword.Text = _Employee.Password;

            cbDepartment.SelectedIndex = _Employee.DepartmentID - 1;

            cbAttendanceList.Checked = clsEmployee.CheckAccessPermission(_EmployeeID, clsEmployee.enPermissions.AttendanceList);
            cbEmployeesList.Checked = clsEmployee.CheckAccessPermission(_EmployeeID, clsEmployee.enPermissions.EmployeesList);

        }

        private void _RestDefualtValues()
        {

            _FillDepartmentCompoBox();


            if(_Mode == enMode.Edit)
            {
                this.Text = "Edit Employee Info";
                lbTitle.Text = "Edit Employee Info";

                tpEmployee.Enabled = true;
                btnSave.Enabled = true;

                ctrlPersonFilterCard1.FilterEnabled = false;

            }
            else
            {
                this.Text = "Add New Employee";
                lbTitle.Text = "Add New Employee";

                tpEmployee.Enabled = false;
                btnSave.Enabled = false;

                tbEmployeeID.Text = string.Empty;
                tbPassword.Text = string.Empty;

                cbDepartment.SelectedIndex = 0;

                _Employee = new clsEmployee();
            }

        }

        private void _FillDepartmentCompoBox()
        {
            
            DataTable dt = clsDepartment.GetAllDepartments();

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    cbDepartment.Items.Add(dr["Name"]);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Pleace Fill Empty Failds....");
                return;
            }


            if (_Mode == enMode.Add)
            {
                if (MessageBox.Show("Confirm This ID : \n" + tbEmployeeID.Text, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return;
                }
            }

            _Employee.EmployeeID = tbEmployeeID.Text;
            _Employee.PersonID = ctrlPersonFilterCard1.PersonID;
            _Employee.DepartmentID = cbDepartment.SelectedIndex + 1;
            _Employee.Password = tbPassword.Text;
            _Employee.Permissions = _TakePermissions();
            
            if (_Employee.Save())
            {

                MessageBox.Show("Employee Info Saved Successfully.", "Success");
                btnSave.Enabled = false;
            }
            else
            {

                MessageBox.Show("Employee Info Not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private short _TakePermissions()
        {
            short total = 0;

            if (cbAttendanceList.Checked)
                total += ((short)clsEmployee.enPermissions.AttendanceList);

            if (cbEmployeesList.Checked)
                total += ((short)clsEmployee.enPermissions.EmployeesList);

            return total;
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = (TextBox)sender;

            if (string.IsNullOrEmpty(temp.Text))
            {
                temp.Focus();
                e.Cancel = true;
                errorProvider1.SetError(temp, "Pleace Fill This Fialed");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(temp, "");
            }

        }

        private void ctrlPersonFilterCard1_OnPersonSelected(int obj)
        {
            if(clsEmployee.IsExist(obj))
            {
                MessageBox.Show("This Person Is Already An Employee, Pleace Choose Anther Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }

        }
    }
}
