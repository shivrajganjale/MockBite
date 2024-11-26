using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectmockbite
{
    public partial class homepageCpp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (RadioButtonList1.SelectedValue == " Dennis Ritchie")
            {
                score++;
                Label13.Visible = true;
                Label13.Text = "Correct Answer ";
            }
            else
            {

                Label13.Visible = true;
                Label13.Text = "Correct Answer : Dennis Ritchie";
            }
            if (RadioButtonList2.SelectedValue == " C++ supports both procedural and object oriented programming language")
            {
                score++;
                Label11.Visible = true;
                Label11.Text = "Correct Answer ";
            }
            else
            {

                Label11.Visible = true;
                Label11.Text = "Correct Answer : C++ supports both procedural and object oriented programming language";
            }

            if (RadioButtonList3.SelectedValue == " #include “userdefined”")
            {
                score++;
                Label14.Visible = true;
                Label14.Text = "Correct Answer ";
            }
            else
            {
                Label14.Visible = true;
                Label14.Text = "Correct Answer : #include “userdefined”";

            }

            if (RadioButtonList4.SelectedValue == " h")
            {
                score++;
                Label15.Visible = true;
                Label15.Text = "Correct Answer ";
            }
            else
            {

                Label15.Visible = true;
                Label15.Text = "Correct Answer : h";
            }

            if (RadioButtonList5.SelectedValue == " VAR_1234")
            {
                score++;
                Label16.Visible = true;
                Label16.Text = "Correct Answer ";
            }
            else
            {

                Label16.Visible = true;
                Label16.Text = "Correct Answer : VAR_1234";
            }

            if (RadioButtonList6.SelectedValue == " Friend constructor")
            {
                score++;
                Label17.Visible = true;
                Label17.Text = "Correct Answer ";
            }
            else
            {
                Label17.Visible = true;
                Label17.Text = "Correct Answer :Friend constructor ";

            }

            if (RadioButtonList7.SelectedValue == " Bottom-up")
            {
                score++;
                Label18.Visible = true;
                Label18.Text = "Correct Answer ";
            }
            else
            {

                Label18.Visible = true;
                Label18.Text = "Correct Answer : Bottom-up";
            }

            if (RadioButtonList8.SelectedValue == " cin")
            {
                score++;
                Label19.Visible = true;
                Label19.Text = "Correct Answer ";
            }
            else
            {

                Label19.Visible = true;
                Label19.Text = "Correct Answer : cin";
            }

            if (RadioButtonList9.SelectedValue == " do-while")
            {
                score++;
                Label20.Visible = true;
                Label20.Text = "Correct Answer ";

            }
            else
            {

                Label20.Visible = true;
                Label20.Text = "Correct Answer : do-while";

            }
            if (RadioButtonList10.SelectedValue == " No error in both C and C++")
            {
                score++;
                Label21.Visible = true;
                Label21.Text = "Correct Answer  ";
            }
            else
            {

                Label21.Visible = true;
                Label21.Text = "Correct Answer :No error in both C and C++ ";
            }

            Label12.Visible = true;
            Label12.Text = "Score : " + score.ToString();
        }
    }
}
    
