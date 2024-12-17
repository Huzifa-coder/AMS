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
    public partial class frmEmployeesList : Form
    {

        DataTable _dtEmployeesList = null;


        public frmEmployeesList()
        {
            InitializeComponent();
        }

        private void frmEmployeesList_Load(object sender, EventArgs e)
        {
            _dtEmployeesList = clsEmployee.GetAllEmployees();
            

            if (_dtEmployeesList != null)
            {
                dgvEmployees.DataSource = _dtEmployeesList;
                lbRecords.Text = dgvEmployees.Rows.Count.ToString();
                cbFilterBy.SelectedIndex = 0;
            }            

        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddEditEmployee frm = new frmAddEditEmployee();
            frm.ShowDialog();

            frmEmployeesList_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowEmployeeInfo frm = new frmShowEmployeeInfo((string)dgvEmployees.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmEmployeesList_Load(null, null);

        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditEmployee frm = new frmAddEditEmployee();
            frm.ShowDialog();

            frmEmployeesList_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditEmployee frm = new frmAddEditEmployee((string)dgvEmployees.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmEmployeesList_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are Do You Want To Delete This Employee : \n" + (string)dgvEmployees.CurrentRow.Cells[0].Value, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (clsEmployee.Delete((string)dgvEmployees.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Employee Deleted Successfully.");
                    frmEmployeesList_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Faild To delete This Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = "";

            switch ((string)cbFilterBy.SelectedItem)
            {
                case "ID":
                    filterColumn = "ID";
                    break;

                case "Full Name":
                    filterColumn = "FullName";

                    break;

                case "Department":
                    filterColumn = "Department";

                    break;
                
                default:
                    filterColumn = "None";
                    break;
            }

            if (filterColumn == "None" || tbFilterValue.Text.Trim() == "")
            {

                _dtEmployeesList.DefaultView.RowFilter = "";
                lbRecords.Text = dgvEmployees.Rows.Count.ToString();
                return;
            }

            _dtEmployeesList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, tbFilterValue.Text.Trim());

            lbRecords.Text = dgvEmployees.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Visible = ((string)cbFilterBy.SelectedItem != "None");

            if (tbFilterValue.Visible)
            {
                tbFilterValue.Text = "";
                tbFilterValue.Focus();
            }

        }
    }
}
