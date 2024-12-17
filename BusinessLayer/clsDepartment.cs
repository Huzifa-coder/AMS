using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDepartment
    {
        
        public int ID { get; set; }
        public string Name { get; set; }

        public clsDepartment() 
        {
            ID = -1;
            Name = string.Empty;
        }

        private clsDepartment(int id, string Name)
        {
            this.ID = id;
            this.Name = Name;
        }

        static public clsDepartment Find(int id) 
        {
            string name = string.Empty;

            if(clsDepartmentData.GetDepartment(id, ref name))
                return new clsDepartment(id,name);

            return null;
        }

        static public clsDepartment Find(string Name)
        {
            int id = -1;

            if (clsDepartmentData.GetDepartment(Name, ref id))
                return new clsDepartment(id, Name);

            return null;
        }

        public static DataTable GetAllDepartments() {
        
            return clsDepartmentData.GetAllDepartments();
        }

        private bool _update()
        {

            return clsDepartmentData.UpdateDepartmentInfo(ID, Name);
        }

        public bool save()
        {

            return _update(); 
        }

    }
    
}
