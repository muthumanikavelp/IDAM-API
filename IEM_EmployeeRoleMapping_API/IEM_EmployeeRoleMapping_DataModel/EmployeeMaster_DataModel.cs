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
   public class EmployeeMaster_DataModel
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        ErrorLog_DataModel objerr_dm = new ErrorLog_DataModel();

        //Connection String
        private void GetConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                con.Open();
            }
        }
        //Employee Master Datamodel
        public DataTable EmployeeList()
        {
            try
            {
                GetConnection();
                cmd = new SqlCommand("pr_iem_mst_temployeerole", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ACTION", SqlDbType.VarChar).Value = "SELECTEMPLOYEE";
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch(Exception ex)
            {
                objerr_dm.WriteErrorLog("data model - catch", ex.Message.ToString());
            }
            return dt;
        }
    }
}
