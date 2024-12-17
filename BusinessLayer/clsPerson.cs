using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsPerson
    {

        enum enMode { New , Update }

        enMode mode;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string FullName {

            get { return FirstName + " " + SecondName + " " + LastName; }
        }

        public clsPerson() {

            PersonID = -1;
            FirstName = string.Empty;
            SecondName = string.Empty;
            LastName = string.Empty;

            mode = enMode.New;
        }

        private clsPerson(int personID, string FirstName, string SecondName, string LastName) {
        
            this.PersonID = personID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;

            mode = enMode.Update;
        }

        static public clsPerson Find(int PersonID)
        {
            string firstName = string.Empty, secondName = string.Empty, lastName = string.Empty;

            if(clsPersonData.GetPerson(PersonID,ref firstName, ref secondName, ref lastName))
            {
                return new clsPerson(PersonID, firstName, secondName, lastName);
            }

            return null;
        }

        static public bool IsExist(int PersonID)
        {

            return clsPersonData.IsExist(PersonID);
        }

        static public bool Delete(int PersonID)
        {

            if(IsExist(PersonID))
                return clsPersonData.DeletePerson(PersonID);

            return false;
        }

        private bool _AddNewPerson()
        {
            int ID = clsPersonData.AddNewPerson(this.FirstName, this.SecondName, this.LastName);

            if (ID > 0) { 
                
                PersonID = ID;
                return true;
            }

            return false;
        }

        private bool _UpadataPersonInfo()
        { 

            return clsPersonData.UpdatePersonInfo(this.PersonID, this.FirstName, this.SecondName, this.LastName);
        }

        public bool Save()
        {
            switch (mode) 
            {
                case enMode.New:
                    if (_AddNewPerson()) {
                        mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpadataPersonInfo();

                default: 
                    return false;
            }
        }


    }
}
