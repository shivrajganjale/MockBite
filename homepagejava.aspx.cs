using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectmockbite
{
    public partial class homepagejava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (RadioButtonList1.SelectedValue == " 8")
            {
                score++;
                Label13.Visible = true;
                Label13.Text = "Correct Answer ";
            }
            else
            {

                Label13.Visible = true;
                Label13.Text = "Correct Answer : 8";
            }
            if (RadioButtonList2.SelectedValue == " Java is a platform-dependent programming language")
            {
                score++;
                Label11.Visible = true;
                Label11.Text = "Correct Answer ";
            }
            else {

                Label11.Visible = true;
                Label11.Text = "Correct Answer : Java is a platform-dependent programming language";
            }

            if (RadioButtonList3.SelectedValue == " JDK")
            {
                score++;
                Label14.Visible = true;
                Label14.Text = "Correct Answer ";
            }
            else {
                Label14.Visible = true;
                Label14.Text = "Correct Answer : JDK";

            }

            if (RadioButtonList4.SelectedValue == " Use of pointers")
            {
                score++;
                Label15.Visible = true;
                Label15.Text = "Correct Answer ";
            }
            else {

                Label15.Visible = true;
                Label15.Text = "Correct Answer : Use of pointers";
            }

            if (RadioButtonList5.SelectedValue == " keyword")
            {
                score++;
                Label16.Visible = true;
                Label16.Text = "Correct Answer ";
            }
            else {

                Label16.Visible = true;
                Label16.Text = "Correct Answer : keyword";
            }

            if (RadioButtonList6.SelectedValue == ".java")
            {
                score++;
                Label17.Visible = true;
                Label17.Text = "Correct Answer ";
            }
            else {
                Label17.Visible = true;
                Label17.Text = "Correct Answer :.java ";

            }

            if (RadioButtonList7.SelectedValue == " JAVA_HOME")
            {
                score++;
                Label18.Visible = true;
                Label18.Text = "Correct Answer ";
            }
            else {

                Label18.Visible = true;
                Label18.Text = "Correct Answer : JAVA_HOME";
            }

            if (RadioButtonList8.SelectedValue == " Passing itself to the method of the same class")
            {
                score++;
                Label19.Visible = true;
                Label19.Text = "Correct Answer ";
            }
            else {

                Label19.Visible = true;
                Label19.Text = "Correct Answer : Passing itself to the method of the same class";
            }

            if (RadioButtonList9.SelectedValue == " Compile time polymorphism")
            {
                score++;
                Label20.Visible = true;
                Label20.Text = "Correct Answer ";

            }
            else {

                Label20.Visible = true;
                Label20.Text = "Correct Answer : Compile time polymorphism";

            }
            if (RadioButtonList10.SelectedValue == " Floating-point value assigned to an integer type")
            {
                score++;
                Label21.Visible = true;
                Label21.Text = "Correct Answer  ";
            }
            else {

                Label21.Visible = true;
                Label21.Text = "Correct Answer :Floating-point value assigned to an integer type ";
            }

            Label12.Visible = true;
            Label12.Text = "Score : "+score.ToString();
        }
            }

        }
    
