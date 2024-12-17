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

namespace AMS.People
{
    public partial class frmAddEditPerson : Form
    {

        public delegate void DatabackEventHandler(object sender, int PersonID);

        public event DatabackEventHandler DataBack;

        enum enMode { New, Update}

        enMode _mode;

        private int _PersonID = -1;
        private clsPerson _Person = new clsPerson();


        public frmAddEditPerson()
        {
            InitializeComponent();

            _mode = enMode.New;
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _mode = enMode.Update;
            _PersonID = PersonID;
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstName.Text.Equals(""))
            {
                e.Cancel = true;
                tbFirstName.Focus();
                errorProvider1.SetError(tbFirstName, "Pleace Enter Your Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFirstName, "");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (tbLastName.Text.Equals(""))
            {
                e.Cancel = true;
                tbLastName.Focus();
                errorProvider1.SetError(tbLastName, "Pleace Enter Your Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbLastName, "");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, _Person.PersonID);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Pleace Fill Empty Fileds...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            _Person.FirstName = tbFirstName.Text.Trim();
            _Person.SecondName = tbSecondName.Text.Trim();
            _Person.LastName = tbLastName.Text.Trim();

            if (_Person.Save())
            {
                lbPersonID.Text = _Person.PersonID.ToString();
                MessageBox.Show("Person Saved Successfully");
                btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Person Failed to Saved ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetValues();

            if (_mode == enMode.Update) 
            {
                _LoadData();
            }
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if(_Person == null)
            {
                MessageBox.Show("This Person Is Not Exist.");
                this.Close();
                return;
            }

            lbPersonID.Text = _PersonID.ToString();
            tbFirstName.Text = _Person.FirstName.ToString();
            tbSecondName.Text = _Person.SecondName.ToString();
            tbLastName.Text = _Person.LastName.ToString();

        }

        private void _ResetValues()
        {
            lbPersonID.Text = "N/A";
            tbFirstName.Text = string.Empty;
            tbSecondName.Text = string.Empty;
            tbLastName.Text = string.Empty;

            lbTitle.Text = (_mode == enMode.New ? "New" : "Update") + " Person";
        }

    }
}
