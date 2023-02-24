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
   public class RoleMaster_Datamodel
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //Connection string
        private void GetConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                con.Open();
            }
        }

        //Role Master Datamodel
        public DataTable RoleList()
        {
            GetConnection();
            cmd = new SqlCommand("pr_mst_trole_new", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@action", SqlDbType.VarChar).Value = "select";
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
