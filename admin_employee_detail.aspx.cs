//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//public partial class admin_employee_detail : System.Web.UI.Page
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


public partial class admin_employee_detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True");
        DataTable dt = new DataTable();
        con.Open();

        SqlDataReader myreader = null;
        SqlCommand mycommand = new SqlCommand("select * from Employee_table where email_id like'" + TextBox1.Text + "%'", con);

        myreader = mycommand.ExecuteReader();

        while (myreader.Read())
        {

            TextBox2.Text = (myreader["Email_id"].ToString());
            TextBox3.Text = (myreader["Name"].ToString());
            TextBox4.Text = (myreader["Address"].ToString());
            TextBox5.Text = (myreader["Contact_number"].ToString());

        }

        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True");

        con1.Open();
        SqlCommand mycommand = new SqlCommand("delete from Employee_table where email_id ='" + TextBox1.Text + "'", con1);

        mycommand.ExecuteNonQuery();

        SqlConnection con= new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True");

        con.Open();
        SqlCommand mycomman = new SqlCommand("delete from Login_table where email_id ='" + TextBox1.Text + "'", con);

        mycomman.ExecuteNonQuery();
        
        con.Close();

        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        System.Web.UI.ScriptManager.RegisterStartupScript(this, GetType(), "Employee has been remove", "alert('Employee has been remove');", true);
    }
}


