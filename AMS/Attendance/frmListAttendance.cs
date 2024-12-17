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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AMS.Attendance
{
    public partial class frmListAttendance : Form
    {
        DataTable _dtAttendance;
        public frmListAttendance()
        {
            InitializeComponent();
        }

        private void frmListAttendance_Load(object sender, EventArgs e)
        {
            _dtAttendance = clsAttendance.GetAttendanceList();
            dgvAttendances.DataSource = _dtAttendance;
            lbRecords.Text = dgvAttendances.RowCount.ToString();

            if(dgvAttendances.RowCount > 0)
            {
                cbFilterBy.SelectedIndex = 0;

                dgvAttendances.Columns[0].HeaderText = "ID";
                dgvAttendances.Columns[0].Width = 110;

                dgvAttendances.Columns[1].HeaderText = "Employee ID";
                dgvAttendances.Columns[1].Width = 200;

                dgvAttendances.Columns[2].HeaderText = "Full Name";
                dgvAttendances.Columns[2].Width = 400;

                dgvAttendances.Columns[3].HeaderText = "Date";
                dgvAttendances.Columns[3].Width = 100;

                dgvAttendances.Columns[4].HeaderText = "Attend Time";
                dgvAttendances.Columns[4].Width = 120;

                dgvAttendances.Columns[5].HeaderText = "Arrival Time";
                dgvAttendances.Columns[5].Width = 120;

                dgvAttendances.Columns[6].HeaderText = "Status";
                dgvAttendances.Columns[6].Width = 100;

            }

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

        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string filterColumn = "";


            switch ((string)cbFilterBy.SelectedItem)
            {
                case "Employee ID":
                    filterColumn = "ID";
                    break;

                case "Full Name":
                    filterColumn = "FullName";

                    break;

                case "Status":
                    filterColumn = "CountryName";

                    break;

                default:
                    filterColumn = "None";
                    break;
            }

            if (filterColumn == "None" || tbFilterValue.Text.Trim() == "")
            {

                _dtAttendance.DefaultView.RowFilter = "";
                lbRecords.Text = dgvAttendances.Rows.Count.ToString();
                return;
            }



            _dtAttendance.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, tbFilterValue.Text.Trim());

            lbRecords.Text = dgvAttendances.Rows.Count.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeAttendance frm = new frmTakeAttendance((string)dgvAttendances.CurrentRow.Cells[1].Value);
            frm.ShowDialog();

            frmListAttendance_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are Sure Do You Want To Delete This Attendance For : \n" + (string)dgvAttendances.CurrentRow.Cells[1].Value, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            if (clsAttendance.Delete((int)dgvAttendances.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("This Attendance Has Been Deleted");
                frmListAttendance_Load(null, null);
            }
            else
            {
                MessageBox.Show("Something Went Wrong Pleace Try Again");
            }
        }
    }
}
