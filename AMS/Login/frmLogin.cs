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

namespace AMS.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsEmployee employee = clsEmployee.Find(tbEmployeeID.Text);

            if(employee != null && employee.Password == tbPassword.Text)
            {
               
                clsGlobal.CurrentEmployee = employee;
                this.Hide();
                frmMain frm  = new frmMain(this);   
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Pleace Try Again EmployeeID/Password Is Wrong", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
