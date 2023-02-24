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
  public  class RoleMaster_Service
    {
        DataTable dt = new DataTable();
        RoleMaster_Datamodel ObjDatamodel = new RoleMaster_Datamodel();//datamodel obj
        List<RoleMaster_Model> emp = new List<RoleMaster_Model>();//model obj
        //role master service

        public List<RoleMaster_Model> RoleList()
        {
            try
            {
                dt = ObjDatamodel.RoleList();
                foreach (DataRow row in dt.Rows)
                {
                    RoleMaster_Model
                    objModel = new RoleMaster_Model();
                    objModel.RoleId = Convert.ToInt32(row["role_gid"].ToString());
                    objModel.RoleCode = row["role_code"].ToString();
                    objModel.RoleName = row["role_name"].ToString();
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
