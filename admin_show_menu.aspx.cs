using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class admin_show_menu : System.Web.UI.Page
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
        SqlCommand mycommand = new SqlCommand("select * from menu_table where food_id like'" + TextBox1.Text + "%'", con);

        myreader = mycommand.ExecuteReader();

        while (myreader.Read())
        {

            TextBox2.Text = (myreader["food_id"].ToString());
            TextBox3.Text = (myreader["sub_menu"].ToString());
            TextBox4.Text = (myreader["price"].ToString());
            TextBox5.Text = (myreader["serve_people"].ToString());

        }

        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True");

        con1.Open();
        SqlCommand mycommand = new SqlCommand("delete from menu_table where food_id ='" + TextBox1.Text + "'", con1);

        mycommand.ExecuteNonQuery();



        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        System.Web.UI.ScriptManager.RegisterStartupScript(this, GetType(), "Item has been remove", "alert('Item has been remove');", true);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True");

        con1.Open();
        SqlCommand mycommand = new SqlCommand("update menu_table set price='" + TextBox4.Text + "' where food_id ='" + TextBox1.Text + "'", con1);

        mycommand.ExecuteNonQuery();
    }
}