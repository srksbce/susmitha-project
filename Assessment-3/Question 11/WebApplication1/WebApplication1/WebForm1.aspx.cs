using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            con.ConnectionString = "Data Source=SUSMITHA; user id=sa; password=susmitha;initial catalog=snaddb";
            cmd.CommandText = "select * from Employee";
            cmd.Connection = con;
            da.SelectCommand= cmd;
            DataTable dt = new DataTable();
            da.Fill (dt);
            
            GridView1.DataBind();   
        }
    }
}