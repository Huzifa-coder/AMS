using AMS.People;
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
    public partial class frmEmployeeAccountSetting : Form
    {
        string _EmployeeID = string.Empty;
        clsEmployee _employee;

        public frmEmployeeAccountSetting(string EmployeeID)
        {
            InitializeComponent();

            _EmployeeID = EmployeeID;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_employee.PersonID);
            frm.ShowDialog();
        }

        private void frmEmployeeAccountSetting_Load(object sender, EventArgs e)
        {
            lbEmployeeID.Text = _EmployeeID.ToString();
            _employee= clsEmployee.Find(_EmployeeID);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text != _employee.Password)
            {
                e.Cancel = true;
                tbPassword.Focus();
                errorProvider1.SetError(tbPassword,"The Password Is Not Correct.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPassword, "");
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                e.Cancel = true;
                tbPassword.Focus();
                errorProvider1.SetError(tbConfirmPassword, "The Password Is Not Matches.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbConfirmPassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Pleace Complate Empty Failds.");
                return;
            }

            _employee.Password = tbNewPassword.Text;

            if (_employee.Save())
            {
                MessageBox.Show("The Password Changed Successfully.");
            }
            else
            {
                MessageBox.Show("Error : The Password Is Not Changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
