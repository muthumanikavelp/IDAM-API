using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEM_EmployeeRoleMapping_Model
{
   public class EmployeeRole_Model
    {
        public int Employee_Id { get; set; }
        public string Employee_Code { get; set; }
        public string Employee_name { get; set; }
        public int Role_id { get; set; }
        public string Role_Code { get; set; }
        public string Role_name { get; set; }
        public string[] Checkedlist { get; set; }
        public string[] uncheckedlist { get; set; }
        public string insertedby { get; set; }
    }
}
