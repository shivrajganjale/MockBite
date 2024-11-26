using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectmockbite
{
    public partial class homepagepython : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int score = 0;
            if (RadioButtonList1.SelectedValue == " Guido van Rossum")
            {
                score++;
                Label13.Visible = true;
                Label13.Text = "Correct Answer ";
            }
            else
            {

                Label13.Visible = true;
                Label13.Text = "Correct Answer : Guido van Rossum";
            }
            if (RadioButtonList2.SelectedValue == " all of the mentioned")
            {
                score++;
                Label11.Visible = true;
                Label11.Text = "Correct Answer ";
            }
            else
            {

                Label11.Visible = true;
                Label11.Text = "Correct Answer :all of the mentioned";
            }

            if (RadioButtonList3.SelectedValue == " no")
            {
                score++;
                Label14.Visible = true;
                Label14.Text = "Correct Answer ";
            }
            else
            {
                Label14.Visible = true;
                Label14.Text = "Correct Answer : no";

            }

            if (RadioButtonList4.SelectedValue == " .py")
            {
                score++;
                Label15.Visible = true;
                Label15.Text = "Correct Answer ";
            }
            else
            {

                Label15.Visible = true;
                Label15.Text = "Correct Answer : .py";
            }

            if (RadioButtonList5.SelectedValue == " Python code is neither compiled nor interpreted")
            {
                score++;
                Label16.Visible = true;
                Label16.Text = "Correct Answer ";
            }
            else
            {

                Label16.Visible = true;
                Label16.Text = "Correct Answer : Python code is neither compiled nor interpreted";
            }

            if (RadioButtonList6.SelectedValue == " None of the mentioned")
            {
                score++;
                Label17.Visible = true;
                Label17.Text = "Correct Answer ";
            }
            else
            {
                Label17.Visible = true;
                Label17.Text = "Correct Answer :None of the mentioned ";

            }

            if (RadioButtonList7.SelectedValue == " all private members must have leading and trailing underscores")
            {
                score++;
                Label18.Visible = true;
                Label18.Text = "Correct Answer ";
            }
            else
            {

                Label18.Visible = true;
                Label18.Text = "Correct Answer : all private members must have leading and trailing underscores";
            }

            if (RadioButtonList8.SelectedValue == " Indentation")
            {
                score++;
                Label19.Visible = true;
                Label19.Text = "Correct Answer ";
            }
            else
            {

                Label19.Visible = true;
                Label19.Text = "Correct Answer : Indentation";
            }

            if (RadioButtonList9.SelectedValue == " Def")
            {
                score++;
                Label20.Visible = true;
                Label20.Text = "Correct Answer ";

            }
            else
            {

                Label20.Visible = true;
                Label20.Text = "Correct Answer : Def";

            }
            if (RadioButtonList10.SelectedValue == " lambda")
            {
                score++;
                Label21.Visible = true;
                Label21.Text = "Correct Answer  ";
            }
            else
            {

                Label21.Visible = true;
                Label21.Text = "Correct Answer :lambda ";
            }

            Label12.Visible = true;
            Label12.Text = "Score : " + score.ToString();
        }
    }
}
  