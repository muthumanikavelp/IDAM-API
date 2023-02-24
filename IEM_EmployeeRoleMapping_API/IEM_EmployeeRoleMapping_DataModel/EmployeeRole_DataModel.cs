using IEM_EmployeeRoleMapping_Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEM_EmployeeRoleMapping_DataModel
{
   public class EmployeeRole_DataModel
    {
        string result;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        EmployeeRole_Model objmodel = new EmployeeRole_Model(); //model object


        //connection string
        private void GetConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                con.Open();
            }
        }

        //Employee mapped role data model
        public string RoleEmployeeSubmit(EmployeeRole_Model objmodel)
        {
            try
            {
                //uncheck list
                foreach (string selctedstate in objmodel.uncheckedlist)
                {
                    GetConnection();
                    SqlCommand cmd = new SqlCommand("pr_iem_mst_temployeerole", con);
                    cmd.Parameters.AddWithValue("@ACTION", "UPDATEROLE");
                    cmd.Parameters.AddWithValue("@ROLEEMPLOYEEGID", objmodel.Employee_Id);
                    cmd.Parameters.AddWithValue("@INSERTBY", SqlDbType.Int).Value = objmodel.insertedby;
                    cmd.Parameters.AddWithValue("@UNCHECKEDROLE", selctedstate);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (string)cmd.ExecuteScalar();
                    result = "rev"; //removed
                }
                //checked list
                foreach (string Checked in objmodel.Checkedlist)
                {
                    GetConnection();
                    SqlCommand cmd = new SqlCommand("pr_iem_mst_temployeerole", con);
                    cmd.Parameters.AddWithValue("@ACTION", SqlDbType.VarChar).Value = "UPDATE";
                    cmd.Parameters.AddWithValue("@ROLEEMPLOYEEGID", SqlDbType.Int).Value = objmodel.Employee_Id;
                    cmd.Parameters.AddWithValue("@INSERTBY", SqlDbType.Int).Value = objmodel.insertedby;
                    cmd.Parameters.AddWithValue("@ROLEGID", SqlDbType.Int).Value = Checked;
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (string)cmd.ExecuteScalar();
                    result = "ins"; //inserted
                }
                if (result == "rev" || result == null)
                {
                    result = "rev";
                }
                if (result == "ins" || result == null)
                {
                    result = "sub";
                }
            }
            catch (Exception ex)
            {
                return "";
            }

            return result;
        }
    }
}
