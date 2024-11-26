using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectmockbite
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton3.Attributes.Add("onclick", "return mm()");

            try
            {

                if (Session["role"].Equals(" "))
                {
                    LinkButton4.Visible = true; //tests
                    LinkButton1.Visible = true; //userlogin
                    LinkButton2.Visible = true; //signup
                    LinkButton3.Visible = false; //logout
                    LinkButton7.Visible = false; //hellouser
                    LinkButton6.Visible = true; //adminlogin
                    LinkButton10.Visible = true; //becomeanadmin
                    LinkButton8.Visible = false; //create a test
                    LinkButton9.Visible = false; //update a test
                    LinkButton5.Visible = false; //delete a test

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton4.Visible = true; //tests
                    LinkButton1.Visible = false; //userlogin
                    LinkButton2.Visible = false; //signup
                    LinkButton3.Visible = true; //logout
                    LinkButton7.Visible = true; //hellouser
                    LinkButton7.Text = "Hello " + Session["username"].ToString();
                    LinkButton6.Visible = true; //adminlogin
                    LinkButton10.Visible = true; //becomeanadmin
                    LinkButton8.Visible = false; //create a test
                    LinkButton9.Visible = false; //update a test
                    LinkButton5.Visible = false; //delete a test
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton4.Visible = true; //tests
                    LinkButton1.Visible = true; //userlogin
                    LinkButton2.Visible = true; //signup
                    LinkButton3.Visible = true; //logout
                    LinkButton7.Visible = true; //hellouser
                    LinkButton7.Text = "Hello " + Session["adminname"].ToString();
                    LinkButton6.Visible = false; //adminlogin
                    LinkButton10.Visible = true; //becomeanadmin
                    LinkButton8.Visible = true; //create a test
                    LinkButton9.Visible = true; //update a test
                    LinkButton5.Visible = true; //delete a test
                }

            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        } 

        

        protected void LinkButton6_Click(object sender, EventArgs e)
        {

             Response.Redirect("adminlogin.aspx");
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("becomeadmin.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("tests.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
         
                Session.RemoveAll();
            LinkButton4.Visible = true; //tests
            LinkButton1.Visible = true; //userlogin
            LinkButton2.Visible = true; //signup
            LinkButton3.Visible = false; //logout
            LinkButton7.Visible = false; //hellouser
            LinkButton6.Visible = true; //adminlogin
            LinkButton10.Visible = true; //becomeanadmin
            LinkButton8.Visible = false; //create a test
            LinkButton9.Visible = false; //update a test
            LinkButton5.Visible = false; //delete a test

            Response.Redirect("homepage.aspx");
        }
            

        

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("contactus.aspx");
        }
    }
}