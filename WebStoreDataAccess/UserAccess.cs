using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreModel;
using System.Data;
using System.Data.SqlClient;

namespace WebStoreDataAccess
{
    public class UserAccess : DBHandler
    {
        public int AuthenticateUser(User user)
        {
            int result = 0;

            SqlCommand cmd = null;

            try
            {
                conn.Open();
                cmd = new SqlCommand("USER_LOG_IN", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("pLoginName", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("pPassword", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("pStatus", SqlDbType.Int);

                cmd.Parameters["pLoginName"].Value = user.email;
                cmd.Parameters["pPassword"].Value = user.password;
                cmd.Parameters["pStatus"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                result = Convert.ToInt32(cmd.Parameters["pStatus"].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }
    }
}
