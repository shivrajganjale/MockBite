using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace projectmockbite
{
    public partial class usersignup : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
        //Signup Button
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkMemberExists() == true)
            {
                Response.Write("<script>alert('User already Exists , try another Email-ID');</script>");
            }
            else
            {
                signUpnewmember();
            }
           
        }
        bool checkMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from usersignuptable where emailID='" + TextBox4.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                return false;
            }

        }
        void signUpnewmember() {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);
            try
            {
                string query = "insert into usersignuptable(fullname,DOB,contactno,state,city,pincode,collegename,emailID,password) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DropDownList1.SelectedItem.Value + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox5.Text + "','" + TextBox4.Text + "','" + TextBox8.Text + "'); ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Signup Successfull , Go to Login page');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
    }
    }
