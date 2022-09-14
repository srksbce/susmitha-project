using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class EmployeeBusiness
    { 
        EmployeeDataAccess da=new EmployeeDataAccess();
        public DataSet GetData(string query)
        {
            DataSet ds = new DataSet(); 
            ds=da.GetData(query);
            return ds;
        }
    }
}
