//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//public partial class emp_modify : System.Web.UI.Page
//{
//    protected void Page_Load(object sender, EventArgs e)
//    {

//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class emp_modify : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session["emailid"] = "greenvalleyros@gmail.com";
        //TextBox1.Text = Session["emailid"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True");
        SqlDataAdapter sda = new SqlDataAdapter("select * from Employee_table where Email_id='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'", con);
        DataTable dt = new DataTable();

        sda.Fill(dt);

        if (dt.Rows.Count.ToString() == "1")
        {
            if (TextBox3.Text == TextBox4.Text)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Employee_table set Password='" + TextBox4.Text + "' where Email_id='" + TextBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label1.Text = "password change successfully....";
            }
            else
            {
                Label1.Text = "new password and confirm password does not match";
            }

        }
        else
        {
            Label1.Text = "please check your old password";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("emp_recover_password.aspx");
    }
}