using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace projectmockbite
{
    public partial class adminlogin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
            con.Open();
                SqlCommand cmd = new SqlCommand(" select * from adminlogintable where adminID='"+TextBox1.Text.Trim()+"' AND password='" + TextBox2.Text.Trim() + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Session["adminid"] = dr.GetValue(0).ToString();
                        Session["adminname"] = dr.GetValue(1).ToString();
                        Session["role"] = "admin";
                       // Response.Write("<script>alert('Hello ' + '" + dr.GetValue(2).ToString() + "');</script>");
                    }
                    Response.Redirect("adminpanel.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
        }
    }
