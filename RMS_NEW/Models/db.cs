using RMS_NEW.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using RMS_NEW.Models;


namespace RMS_NEW.Models
{
    public class db
    {
        string connectionString = ConnectionStringdb.CName;

        public string LoginCheck(Ad_login ad)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("T_SP_CHECKLOGIN", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@P0", ad.Admin_id);
                cmd.Parameters.AddWithValue("@P1", ad.Ad_Password);
                var outParam = new SqlParameter("@OutputParam", SqlDbType.VarChar, 150);
                outParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParam);
                con.Open();
                cmd.ExecuteNonQuery();
                string res = (cmd.Parameters["@OutputParam"].Value.ToString());
                con.Close();
                return res;

            }
        }
    }
}