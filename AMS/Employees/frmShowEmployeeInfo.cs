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
    public partial class frmShowEmployeeInfo : Form
    {
        string _EmployeeID = string.Empty;

        public frmShowEmployeeInfo(string EmployeeID)
        {
            InitializeComponent();

            _EmployeeID = EmployeeID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowEmployeeInfo_Load(object sender, EventArgs e)
        {
            ctrlEmployeesInfoCard1.LoadEmployeeInfo(_EmployeeID);
        }
    }
}
