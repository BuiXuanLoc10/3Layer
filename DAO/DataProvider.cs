using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAO
{
    public class DataProvider
    {
        SqlConnection cnn = null;
        public DataProvider()
        {
            string cnStr = ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString;
            cnn = new SqlConnection(cnStr);

        }
        public void Connect()
        {
            try
            {
                if (cnn != null && cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void DisConnect()
        {
            if (cnn != null && cnn.State == System.Data.ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            
        }

    }
}
