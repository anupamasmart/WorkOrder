using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


using System.Data.SqlClient;
namespace WorkOrder
{
    public class Connection
    {
       SqlConnection conn =new SqlConnection("Data Source=.;Initial Catalog=WorkOrder;Integrated Security=True");
        public SqlConnection ActiveConnection()
        {
          if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
          return conn;
        }
    }
}
