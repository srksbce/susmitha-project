using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcessLayer
{
    public class EmployeeDataAccess
    {
        SqlConnection con=new SqlConnection("Data Source=SUSMITHA;Initial Catalog=snaddb;User ID=sa;Password=susmitha");
        public DataSet GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query,con);   
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataSet ds=new DataSet();
            da.Fill(ds);
            return ds;

        }
    }
}
