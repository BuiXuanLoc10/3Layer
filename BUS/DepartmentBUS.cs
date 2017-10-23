using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DepartmentBUS
    {
        public List<Department> GetData()
        {
            try
            {
                return (new DepartmentDAO().GetData());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
