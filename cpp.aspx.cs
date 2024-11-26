using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace projectmockbite
{
    public partial class cpp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);
            try {
                SqlCommand cmd = new SqlCommand("select * from Questions10 where (select * from testdesc where subject=cpp");

            }
            catch (Exception ex)
            {
            }


        }
    }
}