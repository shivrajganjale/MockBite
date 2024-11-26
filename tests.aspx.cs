using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectmockbite
{
    public partial class tests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                int cnt = DataList1.Items.Count;
                for (int i = 0; i < cnt; i++)
                {
                    Label lb1 = DataList1.Items[i].FindControl("Label1") as Label;
                    if (lb1.Text.ToString() == "C++")
                    {
                        Response.Redirect("cpp.aspx");
                    }
                    else if (lb1.Text.ToString() == "Java")
                    {
                        Response.Redirect("java.aspx");
                    }
                    else if (lb1.Text.ToString() == "Aptitude")
                    {
                        Response.Redirect("apti.aspx");
                    }
                }
            }catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
    }
}