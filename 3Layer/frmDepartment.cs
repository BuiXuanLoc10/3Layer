using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Layer
{
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            try
            {
                dGVDepartment.DataSource = new DepartmentBUS().GetData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("...\n" + ex.Message);
            }
        }
    }
}
