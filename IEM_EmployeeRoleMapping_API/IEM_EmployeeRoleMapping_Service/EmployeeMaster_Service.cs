using IEM_EmployeeRoleMapping_DataModel;
using IEM_EmployeeRoleMapping_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEM_EmployeeRoleMapping_Service
{
   public class EmployeeMaster_Service
    {
        DataTable dt = new DataTable();
        EmployeeMaster_DataModel ObjDatamodel = new EmployeeMaster_DataModel();//datamodel obj
        List<EmployeeMaster_Model> emp = new List<EmployeeMaster_Model>();//model obj

        //Employee Master Service

        public List<EmployeeMaster_Model> EmployeeList()
        {
            try
            {
                dt = ObjDatamodel.EmployeeList();

                foreach (DataRow row in dt.Rows)
                {
                    EmployeeMaster_Model
                    objModel = new EmployeeMaster_Model();
                    objModel.EmployeeId = Convert.ToInt32(row["employee_gid"].ToString());
                    objModel.EmployeeCode = row["employee_code"].ToString();
                    objModel.EmployeeName = row["employee_name"].ToString();
                    emp.Add(objModel);
                }
                return emp;
            }
            catch (Exception ex)
            {
                return emp;
            }

        }
    }
}
