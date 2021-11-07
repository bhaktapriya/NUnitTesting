using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLogicLayer
{
    class SqlHelper
    {
        public static SqlConnection ConnectToDB()
        {
            SqlConnection cn = new SqlConnection("server=H5CG1220K23\\SQLEXPRESS;user id=sa;password=Rashmi@1973;database=Pizzas");
            cn.Open();
            return cn;
        }
        public static string GetENameById(int id)
        {
            SqlConnection cn = ConnectToDB();
            string query = "select Type from tblpizzalist where id=@id";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", id);
            string ename = cmd.ExecuteScalar().ToString();
            return ename;
        }
    }
}
