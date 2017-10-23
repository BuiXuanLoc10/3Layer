using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DepartmentDAO:DataProvider
    {
        public List<Department> GetData()
        {
            Connect();
            List<Department> list = new List<Department>();
            string sql = "SELECT * FROM Department";
            try
            {
                SqlDataReader dr = ExecuteReader(sql);
                int id;
                string name;
                while (dr.Read())
	            {
	                id = dr.GetInt32(0);
                    name = dr.GetString(1);
                    Department dept = new Department(id, name);
                    list.Add(dept);
	            }
                dr.Close();
                return list;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

    }
}
