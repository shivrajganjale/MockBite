using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace projectmockbite
{
    public partial class createtest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into testdesc(subject,title,description,noofques) values('" + TextBox426.Text + "','" + TextBox427.Text + "','" + TextBox428.Text + "','" + DropDownList2.SelectedItem.Value + "')", con);


                cmd.ExecuteNonQuery();
                con.Close();
                if (DropDownList2.SelectedValue.Equals("10"))
                {
                    MultiView1.ActiveViewIndex = 1;
                }
                else if (DropDownList2.SelectedValue.Equals("25"))
                {
                    MultiView1.ActiveViewIndex = 2;
                }
                else if (DropDownList2.SelectedValue.Equals("50"))
                {
                    MultiView1.ActiveViewIndex = 3;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }





        }

        //10 Questions
        protected void Button1_Click(object sender, EventArgs e)
        {
            string ans1 = "";
            string ans2 = "";
            string ans3 = "";
            string ans4 = "";
            string ans5 = "";
            string ans6 = "";
            string ans7 = "";
            string ans8 = "";
            string ans9 = "";
            string ans10 = "";

            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);
            try
            {

                con.Open();
                //Q1
                if (RadioButton1.Checked)
                {
                    ans1 = TextBox5.Text;
                }
                if (RadioButton2.Checked)
                {
                    ans1 = TextBox4.Text;
                }
                if (RadioButton3.Checked)
                {
                    ans1 = TextBox3.Text;
                }
                if (RadioButton4.Checked)
                {
                    ans1 = TextBox2.Text;
                }
                //Q2
                if (RadioButton5.Checked)
                {
                    ans2 = TextBox7.Text;
                }
                if (RadioButton6.Checked)
                {
                    ans2 = TextBox8.Text;
                }
                if (RadioButton7.Checked)
                {
                    ans2 = TextBox9.Text;
                }
                if (RadioButton8.Checked)
                {
                    ans2 = TextBox10.Text;
                }
                //Q3
                if (RadioButton9.Checked)
                {
                    ans3 = TextBox12.Text;
                }
                if (RadioButton10.Checked)
                {
                    ans3 = TextBox13.Text;
                }
                if (RadioButton11.Checked)
                {
                    ans3 = TextBox14.Text;
                }
                if (RadioButton12.Checked)
                {
                    ans3 = TextBox15.Text;
                }
                //Q4
                if (RadioButton13.Checked)
                {
                    ans4 = TextBox17.Text;
                }
                if (RadioButton14.Checked)
                {
                    ans4 = TextBox18.Text;
                }
                if (RadioButton15.Checked)
                {
                    ans4 = TextBox19.Text;
                }
                if (RadioButton16.Checked)
                {
                    ans4 = TextBox20.Text;
                }


                //Q5
                if (RadioButton17.Checked)
                {
                    ans5 = TextBox22.Text;
                }
                if (RadioButton18.Checked)
                {
                    ans5 = TextBox23.Text;
                }
                if (RadioButton19.Checked)
                {
                    ans5 = TextBox24.Text;
                }
                if (RadioButton20.Checked)
                {
                    ans5 = TextBox25.Text;
                }

                //Q6
                if (RadioButton21.Checked)
                {
                    ans6 = TextBox27.Text;
                }
                if (RadioButton22.Checked)
                {
                    ans6 = TextBox28.Text;
                }
                if (RadioButton23.Checked)
                {
                    ans6 = TextBox29.Text;
                }
                if (RadioButton24.Checked)
                {
                    ans6 = TextBox30.Text;
                }

                //Q7
                if (RadioButton25.Checked)
                {
                    ans7 = TextBox32.Text;
                }
                if (RadioButton26.Checked)
                {
                    ans7 = TextBox33.Text;
                }
                if (RadioButton27.Checked)
                {
                    ans7 = TextBox34.Text;
                }
                if (RadioButton28.Checked)
                {
                    ans7 = TextBox35.Text;
                }

                //Q8
                if (RadioButton29.Checked)
                {
                    ans8 = TextBox37.Text;
                }
                if (RadioButton30.Checked)
                {
                    ans8 = TextBox38.Text;
                }
                if (RadioButton31.Checked)
                {
                    ans8 = TextBox39.Text;
                }
                if (RadioButton32.Checked)
                {
                    ans8 = TextBox40.Text;
                }

                //Q9
                if (RadioButton33.Checked)
                {
                    ans9 = TextBox42.Text;
                }
                if (RadioButton34.Checked)
                {
                    ans9 = TextBox43.Text;
                }
                if (RadioButton35.Checked)
                {
                    ans9 = TextBox44.Text;
                }
                if (RadioButton36.Checked)
                {
                    ans9 = TextBox45.Text;
                }

                //Q10
                if (RadioButton37.Checked)
                {
                    ans10 = TextBox47.Text;
                }
                if (RadioButton38.Checked)
                {
                    ans10 = TextBox48.Text;
                }
                if (RadioButton39.Checked)
                {
                    ans10 = TextBox49.Text;
                }
                if (RadioButton40.Checked)
                {
                    ans10 = TextBox50.Text;
                }

                SqlCommand cmd = new SqlCommand("insert into Questions10(question,option1,option2,option3,option4,correctanswer) values('" + TextBox1.Text + "','" + TextBox5.Text + "','" + TextBox4.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "','" + ans1 + "'),/*Q2*/('" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + ans2 + "'),/*Q3*/('" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + ans3 + "'),/*Q4*/('" + TextBox16.Text + "','" + TextBox17.Text + "','" + TextBox18.Text + "','" + TextBox19.Text + "','" + TextBox20.Text + "','" + ans4 + "'),/*Q5*/('" + TextBox21.Text + "','" + TextBox22.Text + "','" + TextBox23.Text + "','" + TextBox24.Text + "','" + TextBox25.Text + "','" + ans5 + "'),/*Q6*/('" + TextBox26.Text + "','" + TextBox27.Text + "','" + TextBox28.Text + "','" + TextBox29.Text + "','" + TextBox30.Text + "','" + ans6 + "'),/*Q7*/('" + TextBox31.Text + "','" + TextBox32.Text + "','" + TextBox33.Text + "','" + TextBox34.Text + "','" + TextBox35.Text + "','" + ans7 + "'),/*Q8*/('" + TextBox36.Text + "','" + TextBox37.Text + "','" + TextBox38.Text + "','" + TextBox39.Text + "','" + TextBox40.Text + "','" + ans8 + "'),/*Q9*/('" + TextBox41.Text + "','" + TextBox42.Text + "','" + TextBox43.Text + "','" + TextBox44.Text + "','" + TextBox45.Text + "','" + ans9 + "'),/*Q10*/('" + TextBox46.Text + "','" + TextBox47.Text + "','" + TextBox48.Text + "','" + TextBox49.Text + "','" + TextBox50.Text + "','" + ans10 + "')", con);


                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                Response.Write("<script>alert('Data submitted');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        //25 Questions
        protected void Button2_Click(object sender, EventArgs e)
        {
            string answ1 = "";
            string answ2 = "";
            string answ3 = "";
            string answ4 = "";
            string answ5 = "";
            string answ6 = "";
            string answ7 = "";
            string answ8 = "";
            string answ9 = "";
            string answ10 = "";
            string answ11 = "";
            string answ12 = "";
            string answ13 = "";
            string answ14 = "";
            string answ15 = "";
            string answ16 = "";
            string answ17 = "";
            string answ18 = "";
            string answ19 = "";
            string answ20 = "";
            string answ21 = "";
            string answ22 = "";
            string answ23 = "";
            string answ24 = "";
            string answ25 = "";



            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);
            try
            {

                con.Open();
                //Q1
                if (RadioButton41.Checked)
                {
                    answ1 = TextBox52.Text;
                }
                if (RadioButton42.Checked)
                {
                    answ1 = TextBox53.Text;
                }
                if (RadioButton43.Checked)
                {
                    answ1 = TextBox54.Text;
                }
                if (RadioButton44.Checked)
                {
                    answ1 = TextBox55.Text;
                }
                //Q2
                if (RadioButton45.Checked)
                {
                    answ2 = TextBox57.Text;
                }
                if (RadioButton46.Checked)
                {
                    answ2 = TextBox58.Text;
                }
                if (RadioButton47.Checked)
                {
                    answ2 = TextBox59.Text;
                }
                if (RadioButton48.Checked)
                {
                    answ2 = TextBox60.Text;
                }
                //Q3
                if (RadioButton49.Checked)
                {
                    answ3 = TextBox62.Text;
                }
                if (RadioButton50.Checked)
                {
                    answ3 = TextBox63.Text;
                }
                if (RadioButton51.Checked)
                {
                    answ3 = TextBox64.Text;
                }
                if (RadioButton52.Checked)
                {
                    answ3 = TextBox65.Text;
                }
                //Q4
                if (RadioButton53.Checked)
                {
                    answ4 = TextBox67.Text;
                }
                if (RadioButton54.Checked)
                {
                    answ4 = TextBox68.Text;
                }
                if (RadioButton55.Checked)
                {
                    answ4 = TextBox69.Text;
                }
                if (RadioButton56.Checked)
                {
                    answ4 = TextBox70.Text;
                }


                //Q5
                if (RadioButton57.Checked)
                {
                    answ5 = TextBox72.Text;
                }
                if (RadioButton58.Checked)
                {
                    answ5 = TextBox73.Text;
                }
                if (RadioButton59.Checked)
                {
                    answ5 = TextBox74.Text;
                }
                if (RadioButton60.Checked)
                {
                    answ5 = TextBox75.Text;
                }

                //Q6
                if (RadioButton61.Checked)
                {
                    answ6 = TextBox77.Text;
                }
                if (RadioButton62.Checked)
                {
                    answ6 = TextBox78.Text;
                }
                if (RadioButton63.Checked)
                {
                    answ6 = TextBox79.Text;
                }
                if (RadioButton64.Checked)
                {
                    answ6 = TextBox80.Text;
                }

                //Q7
                if (RadioButton65.Checked)
                {
                    answ7 = TextBox82.Text;
                }
                if (RadioButton66.Checked)
                {
                    answ7 = TextBox83.Text;
                }
                if (RadioButton67.Checked)
                {
                    answ7 = TextBox84.Text;
                }
                if (RadioButton68.Checked)
                {
                    answ7 = TextBox85.Text;
                }

                //Q8
                if (RadioButton69.Checked)
                {
                    answ8 = TextBox87.Text;
                }
                if (RadioButton70.Checked)
                {
                    answ8 = TextBox88.Text;
                }
                if (RadioButton71.Checked)
                {
                    answ8 = TextBox89.Text;
                }
                if (RadioButton72.Checked)
                {
                    answ8 = TextBox90.Text;
                }

                //Q9
                if (RadioButton73.Checked)
                {
                    answ9 = TextBox92.Text;
                }
                if (RadioButton74.Checked)
                {
                    answ9 = TextBox93.Text;
                }
                if (RadioButton75.Checked)
                {
                    answ9 = TextBox94.Text;
                }
                if (RadioButton76.Checked)
                {
                    answ9 = TextBox95.Text;
                }

                //Q10
                if (RadioButton77.Checked)
                {
                    answ10 = TextBox97.Text;
                }
                if (RadioButton78.Checked)
                {
                    answ10 = TextBox98.Text;
                }
                if (RadioButton79.Checked)
                {
                    answ10 = TextBox99.Text;
                }
                if (RadioButton80.Checked)
                {
                    answ10 = TextBox100.Text;
                }

                //Q11
                if (RadioButton81.Checked)
                {
                    answ11 = TextBox102.Text;
                }
                if (RadioButton82.Checked)
                {
                    answ11 = TextBox103.Text;
                }
                if (RadioButton83.Checked)
                {
                    answ11 = TextBox104.Text;
                }
                if (RadioButton84.Checked)
                {
                    answ11 = TextBox105.Text;
                }
                //Q12
                if (RadioButton85.Checked)
                {
                    answ12 = TextBox107.Text;
                }
                if (RadioButton86.Checked)
                {
                    answ12 = TextBox108.Text;
                }
                if (RadioButton87.Checked)
                {
                    answ12 = TextBox109.Text;
                }
                if (RadioButton88.Checked)
                {
                    answ12 = TextBox110.Text;
                }
                //Q13
                if (RadioButton89.Checked)
                {
                    answ13 = TextBox112.Text;
                }
                if (RadioButton90.Checked)
                {
                    answ13 = TextBox113.Text;
                }
                if (RadioButton91.Checked)
                {
                    answ13 = TextBox114.Text;
                }
                if (RadioButton92.Checked)
                {
                    answ13 = TextBox115.Text;
                }
                //Q14
                if (RadioButton93.Checked)
                {
                    answ14 = TextBox117.Text;
                }
                if (RadioButton94.Checked)
                {
                    answ14 = TextBox118.Text;
                }
                if (RadioButton95.Checked)
                {
                    answ14 = TextBox119.Text;
                }
                if (RadioButton96.Checked)
                {
                    answ14 = TextBox120.Text;
                }


                //Q15
                if (RadioButton97.Checked)
                {
                    answ15 = TextBox122.Text;
                }
                if (RadioButton98.Checked)
                {
                    answ15 = TextBox123.Text;
                }
                if (RadioButton99.Checked)
                {
                    answ15 = TextBox124.Text;
                }
                if (RadioButton100.Checked)
                {
                    answ15 = TextBox125.Text;
                }

                //Q16
                if (RadioButton101.Checked)
                {
                    answ16 = TextBox127.Text;
                }
                if (RadioButton102.Checked)
                {
                    answ16 = TextBox128.Text;
                }
                if (RadioButton103.Checked)
                {
                    answ16 = TextBox129.Text;
                }
                if (RadioButton104.Checked)
                {
                    answ16 = TextBox130.Text;
                }

                //Q17
                if (RadioButton105.Checked)
                {
                    answ17 = TextBox132.Text;
                }
                if (RadioButton106.Checked)
                {
                    answ17 = TextBox133.Text;
                }
                if (RadioButton107.Checked)
                {
                    answ17 = TextBox134.Text;
                }
                if (RadioButton108.Checked)
                {
                    answ17 = TextBox135.Text;
                }

                //Q18
                if (RadioButton109.Checked)
                {
                    answ18 = TextBox137.Text;
                }
                if (RadioButton110.Checked)
                {
                    answ18 = TextBox138.Text;
                }
                if (RadioButton111.Checked)
                {
                    answ18 = TextBox139.Text;
                }
                if (RadioButton112.Checked)
                {
                    answ18 = TextBox140.Text;
                }

                //Q19
                if (RadioButton113.Checked)
                {
                    answ19 = TextBox142.Text;
                }
                if (RadioButton114.Checked)
                {
                    answ19 = TextBox143.Text;
                }
                if (RadioButton115.Checked)
                {
                    answ19 = TextBox144.Text;
                }
                if (RadioButton116.Checked)
                {
                    answ19 = TextBox145.Text;
                }

                //Q20
                if (RadioButton117.Checked)
                {
                    answ20 = TextBox147.Text;
                }
                if (RadioButton118.Checked)
                {
                    answ20 = TextBox148.Text;
                }
                if (RadioButton119.Checked)
                {
                    answ20 = TextBox149.Text;
                }
                if (RadioButton120.Checked)
                {
                    answ20 = TextBox150.Text;
                }
                //Q21
                if (RadioButton121.Checked)
                {
                    answ21 = TextBox152.Text;
                }
                if (RadioButton122.Checked)
                {
                    answ21 = TextBox153.Text;
                }
                if (RadioButton123.Checked)
                {
                    answ21 = TextBox154.Text;
                }
                if (RadioButton124.Checked)
                {
                    answ21 = TextBox155.Text;
                }
                //Q22
                if (RadioButton125.Checked)
                {
                    answ22 = TextBox157.Text;
                }
                if (RadioButton126.Checked)
                {
                    answ22 = TextBox158.Text;
                }
                if (RadioButton127.Checked)
                {
                    answ22 = TextBox159.Text;
                }
                if (RadioButton128.Checked)
                {
                    answ22 = TextBox160.Text;
                }
                //Q23
                if (RadioButton129.Checked)
                {
                    answ23 = TextBox162.Text;
                }
                if (RadioButton130.Checked)
                {
                    answ23 = TextBox163.Text;
                }
                if (RadioButton131.Checked)
                {
                    answ23 = TextBox164.Text;
                }
                if (RadioButton132.Checked)
                {
                    answ23 = TextBox165.Text;
                }
                //Q24
                if (RadioButton133.Checked)
                {
                    answ24 = TextBox167.Text;
                }
                if (RadioButton134.Checked)
                {
                    answ24 = TextBox168.Text;
                }
                if (RadioButton135.Checked)
                {
                    answ24 = TextBox169.Text;
                }
                if (RadioButton136.Checked)
                {
                    answ24 = TextBox170.Text;
                }


                //Q25
                if (RadioButton137.Checked)
                {
                    answ25 = TextBox172.Text;
                }
                if (RadioButton138.Checked)
                {
                    answ25 = TextBox173.Text;
                }
                if (RadioButton139.Checked)
                {
                    answ25 = TextBox174.Text;
                }
                if (RadioButton140.Checked)
                {
                    answ25 = TextBox175.Text;
                }


                SqlCommand cmd = new SqlCommand("insert into Questions25(question,option1,option2,option3,option4,correctanswer) values('" + TextBox51.Text + "','" + TextBox52.Text + "','" + TextBox53.Text + "','" + TextBox54.Text + "','" + TextBox55.Text + "','" + answ1 + "'),/*Q2*/('" + TextBox56.Text + "','" + TextBox57.Text + "','" + TextBox58.Text + "','" + TextBox59.Text + "','" + TextBox60.Text + "','" + answ2 + "'),/*Q3*/('" + TextBox61.Text + "','" + TextBox62.Text + "','" + TextBox63.Text + "','" + TextBox64.Text + "','" + TextBox65.Text + "','" + answ3 + "'),/*Q4*/('" + TextBox66.Text + "','" + TextBox67.Text + "','" + TextBox68.Text + "','" + TextBox69.Text + "','" + TextBox70.Text + "','" + answ4 + "'),/*Q5*/('" + TextBox71.Text + "','" + TextBox72.Text + "','" + TextBox73.Text + "','" + TextBox74.Text + "','" + TextBox75.Text + "','" + answ5 + "'),/*Q6*/('" + TextBox76.Text + "','" + TextBox77.Text + "','" + TextBox78.Text + "','" + TextBox79.Text + "','" + TextBox80.Text + "','" + answ6 + "'),/*Q7*/('" + TextBox81.Text + "','" + TextBox82.Text + "','" + TextBox83.Text + "','" + TextBox84.Text + "','" + TextBox85.Text + "','" + answ7 + "'),/*Q8*/('" + TextBox86.Text + "','" + TextBox87.Text + "','" + TextBox88.Text + "','" + TextBox89.Text + "','" + TextBox90.Text + "','" + answ8 + "'),/*Q9*/('" + TextBox91.Text + "','" + TextBox92.Text + "','" + TextBox93.Text + "','" + TextBox94.Text + "','" + TextBox95.Text + "','" + answ9 + "'),/*Q10*/('" + TextBox96.Text + "','" + TextBox97.Text + "','" + TextBox98.Text + "','" + TextBox99.Text + "','" + TextBox100.Text + "','" + answ10 + "'),/*Q11*/('" + TextBox101.Text + "','" + TextBox102.Text + "','" + TextBox103.Text + "','" + TextBox104.Text + "','" + TextBox105.Text + "','" + answ11 + "'),/*Q12*/('" + TextBox106.Text + "','" + TextBox107.Text + "','" + TextBox108.Text + "','" + TextBox109.Text + "','" + TextBox110.Text + "','" + answ12 + "'),/*Q13*/('" + TextBox111.Text + "','" + TextBox112.Text + "','" + TextBox113.Text + "','" + TextBox114.Text + "','" + TextBox115.Text + "','" + answ13 + "'),/*Q14*/('" + TextBox116.Text + "','" + TextBox117.Text + "','" + TextBox118.Text + "','" + TextBox119.Text + "','" + TextBox120.Text + "','" + answ14 + "'),/*Q15*/('" + TextBox121.Text + "','" + TextBox122.Text + "','" + TextBox123.Text + "','" + TextBox124.Text + "','" + TextBox125.Text + "','" + answ15 + "'),/*Q16*/('" + TextBox126.Text + "','" + TextBox127.Text + "','" + TextBox128.Text + "','" + TextBox129.Text + "','" + TextBox130.Text + "','" + answ16 + "'),/*Q17*/('" + TextBox131.Text + "','" + TextBox132.Text + "','" + TextBox133.Text + "','" + TextBox134.Text + "','" + TextBox135.Text + "','" + answ17 + "'),/*Q18*/('" + TextBox136.Text + "','" + TextBox137.Text + "','" + TextBox138.Text + "','" + TextBox139.Text + "','" + TextBox140.Text + "','" + answ18 + "'),/*Q19*/('" + TextBox141.Text + "','" + TextBox142.Text + "','" + TextBox143.Text + "','" + TextBox144.Text + "','" + TextBox145.Text + "','" + answ19 + "'),/*Q20*/('" + TextBox146.Text + "','" + TextBox147.Text + "','" + TextBox148.Text + "','" + TextBox149.Text + "','" + TextBox150.Text + "','" + answ20 + "'),*Q21*/('" + TextBox151.Text + "','" + TextBox152.Text + "','" + TextBox153.Text + "','" + TextBox154.Text + "','" + TextBox155.Text + "','" + answ21 + "'),/*Q22*/('" + TextBox156.Text + "','" + TextBox157.Text + "','" + TextBox158.Text + "','" + TextBox159.Text + "','" + TextBox160.Text + "','" + answ22 + "'),/*Q23*/('" + TextBox161.Text + "','" + TextBox162.Text + "','" + TextBox163.Text + "','" + TextBox164.Text + "','" + TextBox165.Text + "','" + answ23 + "'),/*Q24*/('" + TextBox166.Text + "','" + TextBox167.Text + "','" + TextBox168.Text + "','" + TextBox169.Text + "','" + TextBox170.Text + "','" + answ24 + "'),/*25*/('" + TextBox171.Text + "','" + TextBox172.Text + "','" + TextBox173.Text + "','" + TextBox174.Text + "','" + TextBox175.Text + "','" + answ25 + "')", con);


                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                Response.Write("<script>alert('Data submitted');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        //50 Questions
        protected void Button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["constring"].ConnectionString);


                string ansr1 = "";
                string ansr2 = "";
                string ansr3 = "";
                string ansr4 = "";
                string ansr5 = "";
                string ansr6 = "";
                string ansr7 = "";
                string ansr8 = "";
                string ansr9 = "";
                string ansr10 = "";
                string ansr11 = "";
                string ansr12 = "";
                string ansr13 = "";
                string ansr14 = "";
                string ansr15 = "";
                string ansr16 = "";
                string ansr17 = "";
                string ansr18 = "";
                string ansr19 = "";
                string ansr20 = "";
                string ansr21 = "";
                string ansr22 = "";
                string ansr23 = "";
                string ansr24 = "";
                string ansr25 = "";
                string ansr26 = "";
                string ansr27 = "";
                string ansr28 = "";
                string ansr29 = "";
                string ansr30 = "";
                string ansr31 = "";
                string ansr32 = "";
                string ansr33 = "";
                string ansr34 = "";
                string ansr35 = "";
                string ansr36 = "";
                string ansr37 = "";
                string ansr38 = "";
                string ansr39 = "";
                string ansr40 = "";
                string ansr41 = "";
                string ansr42 = "";
                string ansr43 = "";
                string ansr44 = "";
                string ansr45 = "";
                string ansr46 = "";
                string ansr47 = "";
                string ansr48 = "";
                string ansr49 = "";
                string ansr50 = "";

                try
                {

                    con.Open();
                    //Q1
                    if (RadioButton141.Checked)
                    {
                        ansr1 = TextBox177.Text;
                    }
                    if (RadioButton142.Checked)
                    {
                        ansr1 = TextBox178.Text;
                    }
                    if (RadioButton143.Checked)
                    {
                        ansr1 = TextBox179.Text;
                    }
                    if (RadioButton144.Checked)
                    {
                        ansr1 = TextBox180.Text;
                    }
                    //Q2
                    if (RadioButton145.Checked)
                    {
                        ansr2 = TextBox182.Text;
                    }
                    if (RadioButton146.Checked)
                    {
                        ansr2 = TextBox183.Text;
                    }
                    if (RadioButton147.Checked)
                    {
                        ansr2 = TextBox184.Text;
                    }
                    if (RadioButton148.Checked)
                    {
                        ansr2 = TextBox185.Text;
                    }
                    //Q3
                    if (RadioButton149.Checked)
                    {
                        ansr3 = TextBox187.Text;
                    }
                    if (RadioButton150.Checked)
                    {
                        ansr3 = TextBox188.Text;
                    }
                    if (RadioButton151.Checked)
                    {
                        ansr3 = TextBox189.Text;
                    }
                    if (RadioButton152.Checked)
                    {
                        ansr3 = TextBox190.Text;
                    }
                    //Q4
                    if (RadioButton153.Checked)
                    {
                        ansr4 = TextBox192.Text;
                    }
                    if (RadioButton154.Checked)
                    {
                        ansr4 = TextBox193.Text;
                    }
                    if (RadioButton155.Checked)
                    {
                        ansr4 = TextBox194.Text;
                    }
                    if (RadioButton156.Checked)
                    {
                        ansr4 = TextBox195.Text;
                    }


                    //Q5
                    if (RadioButton157.Checked)
                    {
                        ansr5 = TextBox197.Text;
                    }
                    if (RadioButton158.Checked)
                    {
                        ansr5 = TextBox198.Text;
                    }
                    if (RadioButton159.Checked)
                    {
                        ansr5 = TextBox199.Text;
                    }
                    if (RadioButton160.Checked)
                    {
                        ansr5 = TextBox200.Text;
                    }

                    //Q6
                    if (RadioButton161.Checked)
                    {
                        ansr6 = TextBox202.Text;
                    }
                    if (RadioButton162.Checked)
                    {
                        ansr6 = TextBox203.Text;
                    }
                    if (RadioButton163.Checked)
                    {
                        ansr6 = TextBox204.Text;
                    }
                    if (RadioButton164.Checked)
                    {
                        ansr6 = TextBox205.Text;
                    }

                    //Q7
                    if (RadioButton165.Checked)
                    {
                        ansr7 = TextBox207.Text;
                    }
                    if (RadioButton166.Checked)
                    {
                        ansr7 = TextBox208.Text;
                    }
                    if (RadioButton167.Checked)
                    {
                        ansr7 = TextBox209.Text;
                    }
                    if (RadioButton168.Checked)
                    {
                        ansr7 = TextBox210.Text;
                    }

                    //Q8
                    if (RadioButton169.Checked)
                    {
                        ansr8 = TextBox212.Text;
                    }
                    if (RadioButton170.Checked)
                    {
                        ansr8 = TextBox213.Text;
                    }
                    if (RadioButton171.Checked)
                    {
                        ansr8 = TextBox214.Text;
                    }
                    if (RadioButton172.Checked)
                    {
                        ansr8 = TextBox215.Text;
                    }

                    //Q9
                    if (RadioButton173.Checked)
                    {
                        ansr9 = TextBox217.Text;
                    }
                    if (RadioButton174.Checked)
                    {
                        ansr9 = TextBox218.Text;
                    }
                    if (RadioButton175.Checked)
                    {
                        ansr9 = TextBox219.Text;
                    }
                    if (RadioButton176.Checked)
                    {
                        ansr9 = TextBox220.Text;
                    }

                    //Q10
                    if (RadioButton177.Checked)
                    {
                        ansr10 = TextBox222.Text;
                    }
                    if (RadioButton178.Checked)
                    {
                        ansr10 = TextBox223.Text;
                    }
                    if (RadioButton179.Checked)
                    {
                        ansr10 = TextBox224.Text;
                    }
                    if (RadioButton180.Checked)
                    {
                        ansr10 = TextBox225.Text;
                    }

                    //Q11
                    if (RadioButton181.Checked)
                    {
                        ansr11 = TextBox227.Text;
                    }
                    if (RadioButton182.Checked)
                    {
                        ansr11 = TextBox228.Text;
                    }
                    if (RadioButton183.Checked)
                    {
                        ansr11 = TextBox229.Text;
                    }
                    if (RadioButton184.Checked)
                    {
                        ansr11 = TextBox230.Text;
                    }
                    //Q12
                    if (RadioButton185.Checked)
                    {
                        ansr12 = TextBox232.Text;
                    }
                    if (RadioButton186.Checked)
                    {
                        ansr12 = TextBox233.Text;
                    }
                    if (RadioButton187.Checked)
                    {
                        ansr12 = TextBox234.Text;
                    }
                    if (RadioButton188.Checked)
                    {
                        ansr12 = TextBox235.Text;
                    }
                    //Q13
                    if (RadioButton189.Checked)
                    {
                        ansr13 = TextBox237.Text;
                    }
                    if (RadioButton190.Checked)
                    {
                        ansr13 = TextBox238.Text;
                    }
                    if (RadioButton191.Checked)
                    {
                        ansr13 = TextBox239.Text;
                    }
                    if (RadioButton192.Checked)
                    {
                        ansr13 = TextBox240.Text;
                    }
                    //Q14
                    if (RadioButton193.Checked)
                    {
                        ansr14 = TextBox242.Text;
                    }
                    if (RadioButton194.Checked)
                    {
                        ansr14 = TextBox243.Text;
                    }
                    if (RadioButton195.Checked)
                    {
                        ansr14 = TextBox244.Text;
                    }
                    if (RadioButton196.Checked)
                    {
                        ansr14 = TextBox245.Text;
                    }


                    //Q15
                    if (RadioButton197.Checked)
                    {
                        ansr15 = TextBox247.Text;
                    }
                    if (RadioButton198.Checked)
                    {
                        ansr15 = TextBox248.Text;
                    }
                    if (RadioButton199.Checked)
                    {
                        ansr15 = TextBox249.Text;
                    }
                    if (RadioButton200.Checked)
                    {
                        ansr15 = TextBox250.Text;
                    }

                    //Q16
                    if (RadioButton201.Checked)
                    {
                        ansr16 = TextBox252.Text;
                    }
                    if (RadioButton202.Checked)
                    {
                        ansr16 = TextBox253.Text;
                    }
                    if (RadioButton203.Checked)
                    {
                        ansr16 = TextBox254.Text;
                    }
                    if (RadioButton204.Checked)
                    {
                        ansr16 = TextBox255.Text;
                    }

                    //Q17
                    if (RadioButton205.Checked)
                    {
                        ansr17 = TextBox257.Text;
                    }
                    if (RadioButton206.Checked)
                    {
                        ansr17 = TextBox258.Text;
                    }
                    if (RadioButton207.Checked)
                    {
                        ansr17 = TextBox259.Text;
                    }
                    if (RadioButton208.Checked)
                    {
                        ansr17 = TextBox260.Text;
                    }

                    //Q18
                    if (RadioButton209.Checked)
                    {
                        ansr18 = TextBox262.Text;
                    }
                    if (RadioButton210.Checked)
                    {
                        ansr18 = TextBox263.Text;
                    }
                    if (RadioButton211.Checked)
                    {
                        ansr18 = TextBox264.Text;
                    }
                    if (RadioButton212.Checked)
                    {
                        ansr18 = TextBox265.Text;
                    }

                    //Q19
                    if (RadioButton213.Checked)
                    {
                        ansr19 = TextBox267.Text;
                    }
                    if (RadioButton214.Checked)
                    {
                        ansr19 = TextBox268.Text;
                    }
                    if (RadioButton215.Checked)
                    {
                        ansr19 = TextBox269.Text;
                    }
                    if (RadioButton216.Checked)
                    {
                        ansr19 = TextBox270.Text;
                    }

                    //Q20
                    if (RadioButton217.Checked)
                    {
                        ansr20 = TextBox272.Text;
                    }
                    if (RadioButton218.Checked)
                    {
                        ansr20 = TextBox273.Text;
                    }
                    if (RadioButton219.Checked)
                    {
                        ansr20 = TextBox274.Text;
                    }
                    if (RadioButton220.Checked)
                    {
                        ansr20 = TextBox275.Text;
                    }
                    //Q21
                    if (RadioButton221.Checked)
                    {
                        ansr21 = TextBox277.Text;
                    }
                    if (RadioButton222.Checked)
                    {
                        ansr21 = TextBox278.Text;
                    }
                    if (RadioButton223.Checked)
                    {
                        ansr21 = TextBox279.Text;
                    }
                    if (RadioButton224.Checked)
                    {
                        ansr21 = TextBox280.Text;
                    }
                    //Q22
                    if (RadioButton225.Checked)
                    {
                        ansr22 = TextBox282.Text;
                    }
                    if (RadioButton226.Checked)
                    {
                        ansr22 = TextBox283.Text;
                    }
                    if (RadioButton227.Checked)
                    {
                        ansr22 = TextBox284.Text;
                    }
                    if (RadioButton228.Checked)
                    {
                        ansr22 = TextBox285.Text;
                    }
                    //Q23
                    if (RadioButton229.Checked)
                    {
                        ansr23 = TextBox287.Text;
                    }
                    if (RadioButton230.Checked)
                    {
                        ansr23 = TextBox288.Text;
                    }
                    if (RadioButton231.Checked)
                    {
                        ansr23 = TextBox289.Text;
                    }
                    if (RadioButton232.Checked)
                    {
                        ansr23 = TextBox290.Text;
                    }
                    //Q24
                    if (RadioButton233.Checked)
                    {
                        ansr24 = TextBox292.Text;
                    }
                    if (RadioButton234.Checked)
                    {
                        ansr24 = TextBox293.Text;
                    }
                    if (RadioButton235.Checked)
                    {
                        ansr24 = TextBox294.Text;
                    }
                    if (RadioButton236.Checked)
                    {
                        ansr24 = TextBox295.Text;
                    }


                    //Q25
                    if (RadioButton237.Checked)
                    {
                        ansr25 = TextBox297.Text;
                    }
                    if (RadioButton238.Checked)
                    {
                        ansr25 = TextBox298.Text;
                    }
                    if (RadioButton239.Checked)
                    {
                        ansr25 = TextBox299.Text;
                    }
                    if (RadioButton240.Checked)
                    {
                        ansr25 = TextBox300.Text;
                    }

                    //Q26
                    if (RadioButton241.Checked)
                    {
                        ansr26 = TextBox302.Text;
                    }
                    if (RadioButton242.Checked)
                    {
                        ansr26 = TextBox303.Text;
                    }
                    if (RadioButton243.Checked)
                    {
                        ansr26 = TextBox304.Text;
                    }
                    if (RadioButton244.Checked)
                    {
                        ansr26 = TextBox305.Text;
                    }
                    //Q27
                    if (RadioButton245.Checked)
                    {
                        ansr27 = TextBox307.Text;
                    }
                    if (RadioButton246.Checked)
                    {
                        ansr27 = TextBox308.Text;
                    }
                    if (RadioButton247.Checked)
                    {
                        ansr27 = TextBox309.Text;
                    }
                    if (RadioButton248.Checked)
                    {
                        ansr27 = TextBox310.Text;
                    }
                    //Q28
                    if (RadioButton249.Checked)
                    {
                        ansr28 = TextBox312.Text;
                    }
                    if (RadioButton250.Checked)
                    {
                        ansr28 = TextBox313.Text;
                    }
                    if (RadioButton251.Checked)
                    {
                        ansr28 = TextBox314.Text;
                    }
                    if (RadioButton252.Checked)
                    {
                        ansr28 = TextBox315.Text;
                    }
                    //Q29
                    if (RadioButton253.Checked)
                    {
                        ansr29 = TextBox317.Text;
                    }
                    if (RadioButton254.Checked)
                    {
                        ansr29 = TextBox318.Text;
                    }
                    if (RadioButton255.Checked)
                    {
                        ansr29 = TextBox319.Text;
                    }
                    if (RadioButton256.Checked)
                    {
                        ansr29 = TextBox320.Text;
                    }


                    //Q30
                    if (RadioButton257.Checked)
                    {
                        ansr30 = TextBox322.Text;
                    }
                    if (RadioButton258.Checked)
                    {
                        ansr30 = TextBox323.Text;
                    }
                    if (RadioButton259.Checked)
                    {
                        ansr30 = TextBox324.Text;
                    }
                    if (RadioButton260.Checked)
                    {
                        ansr30 = TextBox325.Text;
                    }

                    //Q31
                    if (RadioButton261.Checked)
                    {
                        ansr31 = TextBox327.Text;
                    }
                    if (RadioButton262.Checked)
                    {
                        ansr31 = TextBox328.Text;
                    }
                    if (RadioButton263.Checked)
                    {
                        ansr31 = TextBox329.Text;
                    }
                    if (RadioButton264.Checked)
                    {
                        ansr31 = TextBox330.Text;
                    }

                    //Q32
                    if (RadioButton265.Checked)
                    {
                        ansr32 = TextBox332.Text;
                    }
                    if (RadioButton266.Checked)
                    {
                        ansr32 = TextBox333.Text;
                    }
                    if (RadioButton267.Checked)
                    {
                        ansr32 = TextBox334.Text;
                    }
                    if (RadioButton268.Checked)
                    {
                        ansr32 = TextBox335.Text;
                    }

                    //Q33
                    if (RadioButton269.Checked)
                    {
                        ansr33 = TextBox337.Text;
                    }
                    if (RadioButton270.Checked)
                    {
                        ansr33 = TextBox338.Text;
                    }
                    if (RadioButton271.Checked)
                    {
                        ansr33 = TextBox339.Text;
                    }
                    if (RadioButton272.Checked)
                    {
                        ansr33 = TextBox340.Text;
                    }

                    //Q34
                    if (RadioButton273.Checked)
                    {
                        ansr34 = TextBox342.Text;
                    }
                    if (RadioButton274.Checked)
                    {
                        ansr34 = TextBox343.Text;
                    }
                    if (RadioButton275.Checked)
                    {
                        ansr34 = TextBox344.Text;
                    }
                    if (RadioButton276.Checked)
                    {
                        ansr34 = TextBox345.Text;
                    }

                    //Q35
                    if (RadioButton277.Checked)
                    {
                        ansr35 = TextBox347.Text;
                    }
                    if (RadioButton278.Checked)
                    {
                        ansr35 = TextBox348.Text;
                    }
                    if (RadioButton279.Checked)
                    {
                        ansr35 = TextBox349.Text;
                    }
                    if (RadioButton280.Checked)
                    {
                        ansr35 = TextBox350.Text;
                    }

                    //Q36
                    if (RadioButton281.Checked)
                    {
                        ansr36 = TextBox352.Text;
                    }
                    if (RadioButton282.Checked)
                    {
                        ansr36 = TextBox353.Text;
                    }
                    if (RadioButton283.Checked)
                    {
                        ansr36 = TextBox354.Text;
                    }
                    if (RadioButton284.Checked)
                    {
                        ansr36 = TextBox355.Text;
                    }
                    //Q37
                    if (RadioButton285.Checked)
                    {
                        ansr37 = TextBox357.Text;
                    }
                    if (RadioButton286.Checked)
                    {
                        ansr37 = TextBox358.Text;
                    }
                    if (RadioButton287.Checked)
                    {
                        ansr37 = TextBox359.Text;
                    }
                    if (RadioButton288.Checked)
                    {
                        ansr37 = TextBox360.Text;
                    }
                    //Q38
                    if (RadioButton289.Checked)
                    {
                        ansr38 = TextBox362.Text;
                    }
                    if (RadioButton290.Checked)
                    {
                        ansr38 = TextBox363.Text;
                    }
                    if (RadioButton291.Checked)
                    {
                        ansr38 = TextBox364.Text;
                    }
                    if (RadioButton292.Checked)
                    {
                        ansr38 = TextBox365.Text;
                    }
                    //Q39
                    if (RadioButton293.Checked)
                    {
                        ansr39 = TextBox367.Text;
                    }
                    if (RadioButton294.Checked)
                    {
                        ansr39 = TextBox368.Text;
                    }
                    if (RadioButton295.Checked)
                    {
                        ansr39 = TextBox369.Text;
                    }
                    if (RadioButton296.Checked)
                    {
                        ansr39 = TextBox370.Text;
                    }


                    //Q40
                    if (RadioButton297.Checked)
                    {
                        ansr40 = TextBox372.Text;
                    }
                    if (RadioButton298.Checked)
                    {
                        ansr40 = TextBox373.Text;
                    }
                    if (RadioButton299.Checked)
                    {
                        ansr40 = TextBox374.Text;
                    }
                    if (RadioButton300.Checked)
                    {
                        ansr40 = TextBox375.Text;
                    }

                    //Q41
                    if (RadioButton301.Checked)
                    {
                        ansr41 = TextBox377.Text;
                    }
                    if (RadioButton302.Checked)
                    {
                        ansr41 = TextBox378.Text;
                    }
                    if (RadioButton303.Checked)
                    {
                        ansr41 = TextBox379.Text;
                    }
                    if (RadioButton304.Checked)
                    {
                        ansr41 = TextBox380.Text;
                    }

                    //Q42
                    if (RadioButton305.Checked)
                    {
                        ansr42 = TextBox382.Text;
                    }
                    if (RadioButton306.Checked)
                    {
                        ansr42 = TextBox383.Text;
                    }
                    if (RadioButton307.Checked)
                    {
                        ansr42 = TextBox384.Text;
                    }
                    if (RadioButton308.Checked)
                    {
                        ansr42 = TextBox385.Text;
                    }

                    //Q43
                    if (RadioButton309.Checked)
                    {
                        ansr43 = TextBox387.Text;
                    }
                    if (RadioButton310.Checked)
                    {
                        ansr43 = TextBox388.Text;
                    }
                    if (RadioButton311.Checked)
                    {
                        ansr43 = TextBox389.Text;
                    }
                    if (RadioButton312.Checked)
                    {
                        ansr43 = TextBox390.Text;
                    }

                    //Q44
                    if (RadioButton313.Checked)
                    {
                        ansr44 = TextBox392.Text;
                    }
                    if (RadioButton314.Checked)
                    {
                        ansr44 = TextBox393.Text;
                    }
                    if (RadioButton315.Checked)
                    {
                        ansr44 = TextBox394.Text;
                    }
                    if (RadioButton316.Checked)
                    {
                        ansr44 = TextBox395.Text;
                    }

                    //Q45
                    if (RadioButton317.Checked)
                    {
                        ansr45 = TextBox397.Text;
                    }
                    if (RadioButton318.Checked)
                    {
                        ansr45 = TextBox398.Text;
                    }
                    if (RadioButton319.Checked)
                    {
                        ansr45 = TextBox399.Text;
                    }
                    if (RadioButton320.Checked)
                    {
                        ansr45 = TextBox400.Text;
                    }
                    //Q46
                    if (RadioButton321.Checked)
                    {
                        ansr46 = TextBox402.Text;
                    }
                    if (RadioButton322.Checked)
                    {
                        ansr46 = TextBox403.Text;
                    }
                    if (RadioButton323.Checked)
                    {
                        ansr46 = TextBox404.Text;
                    }
                    if (RadioButton324.Checked)
                    {
                        ansr46 = TextBox405.Text;
                    }
                    //Q47
                    if (RadioButton325.Checked)
                    {
                        ansr47 = TextBox407.Text;
                    }
                    if (RadioButton326.Checked)
                    {
                        ansr47 = TextBox408.Text;
                    }
                    if (RadioButton327.Checked)
                    {
                        ansr47 = TextBox409.Text;
                    }
                    if (RadioButton328.Checked)
                    {
                        ansr47 = TextBox410.Text;
                    }
                    //Q48
                    if (RadioButton329.Checked)
                    {
                        ansr48 = TextBox412.Text;
                    }
                    if (RadioButton330.Checked)
                    {
                        ansr48 = TextBox413.Text;
                    }
                    if (RadioButton331.Checked)
                    {
                        ansr48 = TextBox414.Text;
                    }
                    if (RadioButton332.Checked)
                    {
                        ansr48 = TextBox415.Text;
                    }
                    //Q49
                    if (RadioButton333.Checked)
                    {
                        ansr49 = TextBox417.Text;
                    }
                    if (RadioButton334.Checked)
                    {
                        ansr49 = TextBox418.Text;
                    }
                    if (RadioButton335.Checked)
                    {
                        ansr49 = TextBox419.Text;
                    }
                    if (RadioButton336.Checked)
                    {
                        ansr49 = TextBox420.Text;
                    }


                    //Q50
                    if (RadioButton337.Checked)
                    {
                        ansr50 = TextBox422.Text;
                    }
                    if (RadioButton338.Checked)
                    {
                        ansr50 = TextBox423.Text;
                    }
                    if (RadioButton339.Checked)
                    {
                        ansr50 = TextBox424.Text;
                    }
                    if (RadioButton340.Checked)
                    {
                        ansr50 = TextBox425.Text;
                    }

                    SqlCommand cmd = new SqlCommand("insert into Questions50(question,option1,option2,option3,option4,correctanswer) values(/*Q1*/'" + TextBox176.Text + "','" + TextBox177.Text + "','" + TextBox178.Text + "','" + TextBox179.Text + "','" + TextBox180.Text + "','" + ansr1 + "'),/*Q2*/('" + TextBox181.Text + "','" + TextBox182.Text + "','" + TextBox183.Text + "','" + TextBox184.Text + "','" + TextBox185.Text + "','" + ansr2 + "'),/*Q3*/('" + TextBox186.Text + "','" + TextBox187.Text + "','" + TextBox188.Text + "','" + TextBox189.Text + "','" + TextBox190.Text + "','" + ansr3 + "'),/*Q4*/('" + TextBox191.Text + "','" + TextBox192.Text + "','" + TextBox193.Text + "','" + TextBox194.Text + "','" + TextBox195.Text + "','" + ansr4 + "'),/*Q5*/('" + TextBox196.Text + "','" + TextBox197.Text + "','" + TextBox198.Text + "','" + TextBox199.Text + "','" + TextBox200.Text + "','" + ansr5 + "'),/*Q6*/('" + TextBox201.Text + "','" + TextBox202.Text + "','" + TextBox203.Text + "','" + TextBox204.Text + "','" + TextBox205.Text + "','" + ansr6 + "'),/*Q7*/('" + TextBox206.Text + "','" + TextBox207.Text + "','" + TextBox208.Text + "','" + TextBox209.Text + "','" + TextBox210.Text + "','" + ansr7 + "'),/*Q8*/('" + TextBox211.Text + "','" + TextBox212.Text + "','" + TextBox213.Text + "','" + TextBox214.Text + "','" + TextBox215.Text + "','" + ansr8 + "'),/*Q9*/('" + TextBox216.Text + "','" + TextBox217.Text + "','" + TextBox218.Text + "','" + TextBox219.Text + "','" + TextBox220.Text + "','" + ansr9 + "'),/*Q10*/('" + TextBox221.Text + "','" + TextBox222.Text + "','" + TextBox223.Text + "','" + TextBox224.Text + "','" + TextBox225.Text + "','" + ansr10 + "'),/*Q11*/('" + TextBox226.Text + "','" + TextBox227.Text + "','" + TextBox228.Text + "','" + TextBox229.Text + "','" + TextBox230.Text + "','" + ansr11 + "'),/*Q12*/('" + TextBox231.Text + "','" + TextBox232.Text + "','" + TextBox233.Text + "','" + TextBox234.Text + "','" + TextBox235.Text + "','" + ansr12 + "'),/*Q13*/('" + TextBox236.Text + "','" + TextBox237.Text + "','" + TextBox238.Text + "','" + TextBox239.Text + "','" + TextBox240.Text + "','" + ansr13 + "'),/*Q14*/('" + TextBox241.Text + "','" + TextBox242.Text + "','" + TextBox243.Text + "','" + TextBox244.Text + "','" + TextBox245.Text + "','" + ansr14 + "'),/*Q15*/('" + TextBox246.Text + "','" + TextBox247.Text + "','" + TextBox248.Text + "','" + TextBox249.Text + "','" + TextBox250.Text + "','" + ansr15 + "'),/*Q16*/('" + TextBox251.Text + "','" + TextBox252.Text + "','" + TextBox253.Text + "','" + TextBox254.Text + "','" + TextBox255.Text + "','" + ansr16 + "'),/*Q17*/('" + TextBox256.Text + "','" + TextBox257.Text + "','" + TextBox258.Text + "','" + TextBox259.Text + "','" + TextBox260.Text + "','" + ansr17 + "'),/*Q18*/('" + TextBox261.Text + "','" + TextBox262.Text + "','" + TextBox263.Text + "','" + TextBox264.Text + "','" + TextBox265.Text + "','" + ansr18 + "'),/*Q19*/('" + TextBox266.Text + "','" + TextBox267.Text + "','" + TextBox268.Text + "','" + TextBox269.Text + "','" + TextBox270.Text + "','" + ansr19 + "'),/*Q20*/('" + TextBox271.Text + "','" + TextBox272.Text + "','" + TextBox273.Text + "','" + TextBox274.Text + "','" + TextBox275.Text + "','" + ansr20 + "'),*Q21*/('" + TextBox276.Text + "','" + TextBox277.Text + "','" + TextBox278.Text + "','" + TextBox279.Text + "','" + TextBox280.Text + "','" + ansr21 + "'),/*Q22*/('" + TextBox281.Text + "','" + TextBox282.Text + "','" + TextBox283.Text + "','" + TextBox284.Text + "','" + TextBox285.Text + "','" + ansr22 + "'),/*Q23*/('" + TextBox286.Text + "','" + TextBox287.Text + "','" + TextBox288.Text + "','" + TextBox289.Text + "','" + TextBox290.Text + "','" + ansr23 + "'),/*Q24*/('" + TextBox291.Text + "','" + TextBox292.Text + "','" + TextBox293.Text + "','" + TextBox294.Text + "','" + TextBox295.Text + "','" + ansr24 + "'),/*Q25*/('" + TextBox296.Text + "','" + TextBox297.Text + "','" + TextBox298.Text + "','" + TextBox299.Text + "','" + TextBox300.Text + "','" + ansr25 + "'),/*Q26*/('" + TextBox301.Text + "','" + TextBox302.Text + "','" + TextBox303.Text + "','" + TextBox304.Text + "','" + TextBox305.Text + "','" + ansr26 + "'),/*Q27*/('" + TextBox306.Text + "','" + TextBox307.Text + "','" + TextBox308.Text + "','" + TextBox309.Text + "','" + TextBox310.Text + "','" + ansr27 + "'),/*Q28*/('" + TextBox311.Text + "','" + TextBox312.Text + "','" + TextBox313.Text + "','" + TextBox314.Text + "','" + TextBox315.Text + "','" + ansr28 + "'),/*Q29*/('" + TextBox316.Text + "','" + TextBox317.Text + "','" + TextBox318.Text + "','" + TextBox319.Text + "','" + TextBox320.Text + "','" + ansr29 + "'),/*Q30*/('" + TextBox321.Text + "','" + TextBox322.Text + "','" + TextBox323.Text + "','" + TextBox324.Text + "','" + TextBox325.Text + "','" + ansr30 + "'),/*Q31*/('" + TextBox326.Text + "','" + TextBox327.Text + "','" + TextBox328.Text + "','" + TextBox329.Text + "','" + TextBox330.Text + "','" + ansr31 + "'),/*Q32*/('" + TextBox331.Text + "','" + TextBox332.Text + "','" + TextBox333.Text + "','" + TextBox334.Text + "','" + TextBox335.Text + "','" + ansr32 + "'),/*Q33*/('" + TextBox336.Text + "','" + TextBox337.Text + "','" + TextBox338.Text + "','" + TextBox339.Text + "','" + TextBox340.Text + "','" + ansr33 + "'),/*Q34*/('" + TextBox341.Text + "','" + TextBox342.Text + "','" + TextBox343.Text + "','" + TextBox344.Text + "','" + TextBox345.Text + "','" + ansr34 + "'),/*Q35*/('" + TextBox346.Text + "','" + TextBox347.Text + "','" + TextBox348.Text + "','" + TextBox349.Text + "','" + TextBox350.Text + "','" + ansr35 + "'),/*Q36*/('" + TextBox351.Text + "','" + TextBox352.Text + "','" + TextBox353.Text + "','" + TextBox354.Text + "','" + TextBox355.Text + "','" + ansr36 + "'),/*Q37*/('" + TextBox356.Text + "','" + TextBox357.Text + "','" + TextBox358.Text + "','" + TextBox359.Text + "','" + TextBox360.Text + "','" + ansr37 + "'),/*Q38*/('" + TextBox361.Text + "','" + TextBox362.Text + "','" + TextBox363.Text + "','" + TextBox364.Text + "','" + TextBox365.Text + "','" + ansr38 + "'),/*Q39*/('" + TextBox366.Text + "','" + TextBox367.Text + "','" + TextBox368.Text + "','" + TextBox369.Text + "','" + TextBox370.Text + "','" + ansr39 + "'),/*Q40*/('" + TextBox371.Text + "','" + TextBox372.Text + "','" + TextBox373.Text + "','" + TextBox374.Text + "','" + TextBox375.Text + "','" + ansr40 + "'),/*Q41*/('" + TextBox376.Text + "','" + TextBox377.Text + "','" + TextBox378.Text + "','" + TextBox379.Text + "','" + TextBox380.Text + "','" + ansr41 + "'),/*Q42*/('" + TextBox381.Text + "','" + TextBox382.Text + "','" + TextBox383.Text + "','" + TextBox384.Text + "','" + TextBox385.Text + "','" + ansr42 + "'),/*Q43*/('" + TextBox386.Text + "','" + TextBox387.Text + "','" + TextBox388.Text + "','" + TextBox389.Text + "','" + TextBox390.Text + "','" + ansr43 + "'),/*Q44*/('" + TextBox391.Text + "','" + TextBox392.Text + "','" + TextBox393.Text + "','" + TextBox394.Text + "','" + TextBox395.Text + "','" + ansr44 + "'),/*Q45*/('" + TextBox396.Text + "','" + TextBox397.Text + "','" + TextBox398.Text + "','" + TextBox399.Text + "','" + TextBox400.Text + "','" + ansr45 + "'),*Q46*/('" + TextBox401.Text + "','" + TextBox402.Text + "','" + TextBox403.Text + "','" + TextBox404.Text + "','" + TextBox405.Text + "','" + ansr46 + "'),/*Q47*/('" + TextBox406.Text + "','" + TextBox407.Text + "','" + TextBox408.Text + "','" + TextBox409.Text + "','" + TextBox410.Text + "','" + ansr47 + "'),/*Q48*/('" + TextBox411.Text + "','" + TextBox412.Text + "','" + TextBox413.Text + "','" + TextBox414.Text + "','" + TextBox415.Text + "','" + ansr48 + "'),/*Q49*/('" + TextBox416.Text + "','" + TextBox417.Text + "','" + TextBox418.Text + "','" + TextBox419.Text + "','" + TextBox420.Text + "','" + ansr49 + "'),/*50*/('" + TextBox421.Text + "','" + TextBox422.Text + "','" + TextBox423.Text + "','" + TextBox424.Text + "','" + TextBox425.Text + "','" + ansr50 + "')", con);


                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    con.Close();

                    Response.Write("<script>alert('Data submitted');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");

                }
            }
        }
         
        
        
    }
