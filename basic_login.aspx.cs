using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Drawing;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ros.mdf;Integrated Security=True;User Instance=True;");
        con.Open();
        SqlCommand cmd = new SqlCommand("select COUNT(*)FROM Login_table WHERE email_id='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'");
        cmd.Connection = con;

        int OBJ = Convert.ToInt32(cmd.ExecuteScalar ());
            
        if (OBJ > 0)
        {
            Session["email_id"] = TextBox1.Text;

            SqlCommand cmd1 = new SqlCommand("select * FROM Login_table WHERE email_id='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'");
            cmd1.Connection = con;
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {

                string type = reader["type"].ToString();

                if (type == "1")
                {
                    Response.Redirect("admin_home.aspx");
                    Session["email_id"] = TextBox1.Text;
                }
                else if (type == "3")
                {
                    Response.Redirect("cst_home.aspx");
                    Session["email_id"] = TextBox1.Text;
                }
                
                else
                {
                    Response.Redirect("emp_home.aspx");
                    Session["email_id"] = TextBox1.Text;
                }
            }
        }
        else
        {
            Label1.Text = "Invalid username or password";
            Label1.ForeColor = System.Drawing.Color.Red;

        }
    }


    protected void frgt_btn_Click(object sender, EventArgs e)
    {
        //forgot password....
        Response.Redirect("basic_recover.aspx");
    }

}