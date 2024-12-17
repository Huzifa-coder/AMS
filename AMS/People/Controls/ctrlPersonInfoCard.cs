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
    public partial class ctrlPersonInfoCard : UserControl
    {
        int _PersonID = -1;
        clsPerson _Person;

        public int PersonID { get { return _PersonID; } }

        public clsPerson Person { get{ return _Person; }}

        public ctrlPersonInfoCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            if(!clsPerson.IsExist(PersonID))
            {
                MessageBox.Show(("Not Found Person With = %d" + PersonID));
                return;
            }

            _PersonID = PersonID;
            _Person = clsPerson.Find(PersonID);

            lbPersonID.Text = PersonID.ToString();
            lbFullName.Text = Person.FullName;

            linkLabel1.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();

        }
    }
}
