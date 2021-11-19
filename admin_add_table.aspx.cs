//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


public partial class admin_add_table : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
     protected void BtnTableAdd_Click(object sender, EventArgs e)
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True");
        con1.Open();

        SqlCommand cmd1 = new SqlCommand("Insert into Login_table(Email_id,Password,type) values(@id,@pass,@type)", con1);
        // SqlCommand cmd = new SqlCommand(str, con);

        cmd1.Parameters.AddWithValue("@id", TextBox1.Text);
        cmd1.Parameters.AddWithValue("@pass", TextBox2.Text);
        cmd1.Parameters.AddWithValue("@type", 3);

        cmd1.ExecuteNonQuery();
        con1.Close();
        Label1.Text = "Table is added";
        TextBox1.Text = "";
        TextBox2.Text = "";

    }

    
}