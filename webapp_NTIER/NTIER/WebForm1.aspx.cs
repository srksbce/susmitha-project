using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLayer;

namespace NTIER
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string st = "select * from Employee";
            EmployeeBusiness empB = new EmployeeBusiness();
            DataSet ds = new DataSet();
            ds=empB.GetData(st);
            
            GridView1.DataBind();
        }
    }
}