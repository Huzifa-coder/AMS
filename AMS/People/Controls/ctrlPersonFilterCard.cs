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

namespace AMS.People.Controls
{
    public partial class ctrlPersonFilterCard : UserControl
    {
        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        public int PersonID { 
            
            get { return ctrlPersonInfoCard1.PersonID; }
            
        }

        public clsPerson Person
        {
            get { return ctrlPersonInfoCard1.Person; }

        }
        
        public bool FilterEnabled { get { return gbFilter.Enabled; } set { gbFilter.Enabled = value; } }

        public ctrlPersonFilterCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            tbPersonID.Text = PersonID.ToString();
            ctrlPersonInfoCard1.LoadPersonInfo(PersonID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Pleace Enter failed Number");    
                return; 
            }
        
            if (clsPerson.IsExist(int.Parse(tbPersonID.Text.ToString())))
            {
                ctrlPersonInfoCard1.LoadPersonInfo(int.Parse(tbPersonID.Text.ToString()));

                if (OnPersonSelected != null)
                    // Raise the event with a parameter
                    OnPersonSelected(ctrlPersonInfoCard1.PersonID);
            }
            else
            {
                MessageBox.Show("They Are No Person With This ID");
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.DataBack += dataBake;
            frm.ShowDialog();


        }

        private void dataBake(object sender, int PersonID)
        {

            if (clsPerson.IsExist(PersonID))
            {
                ctrlPersonInfoCard1.LoadPersonInfo(PersonID);
                tbPersonID.Text = PersonID.ToString();
                if (OnPersonSelected != null)
                    // Raise the event with a parameter
                    OnPersonSelected(ctrlPersonInfoCard1.PersonID);
            }

        }

        private void tbPersonID_Validating(object sender, CancelEventArgs e)
        {
            
            if(int.TryParse(tbPersonID.Text, out int id))
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPersonID, "");
            }
            else
            {
                e.Cancel = true;
                tbPersonID.Focus();
                errorProvider1.SetError(tbPersonID, "Pleace Enter A number");
            }

        }
    }
}
