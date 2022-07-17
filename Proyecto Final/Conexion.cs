using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Final
{
     class Conexion
    {
        public SqlConnection Cn()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP - VMSM2NF\\SQLEXPRESS; Initital Catalog = Proyecto; Trusted_Connection = True";
            return cn;
        }
    }
}
