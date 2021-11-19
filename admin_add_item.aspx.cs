//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//public partial class admin_add_item : System.Web.UI.Page
//{
//    protected void Page_Load(object sender, EventArgs e)
//    {

//    }
//}
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

public partial class admin_add_item : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True");
        con.Open();

        //first path for driver pics...
        string filename1 = Path.GetFileName(FileUpload1.PostedFile.FileName);
        FileUpload1.SaveAs(Server.MapPath("menu/" + filename1));




       
        SqlCommand cmd2 = new SqlCommand("Insert into menu_table(food_id,menu,sub_menu,picture,picture_path,ingredients,serve_people,price,spicy_food) values(@id,@menu, @s_menu, @pic, @path,@ing,@s_peo,@price,@spicy)", con);
        
        cmd2.Parameters.AddWithValue("@id", TextBox1.Text);
        cmd2.Parameters.AddWithValue("@menu", TextBox2.Text);
        cmd2.Parameters.AddWithValue("@s_menu", TextBox3.Text);
        cmd2.Parameters.AddWithValue("@pic", filename1);
        cmd2.Parameters.AddWithValue("@path", "menu/" + filename1);
        cmd2.Parameters.AddWithValue("@ing", TextBox4.Text);
        cmd2.Parameters.AddWithValue("@s_peo", TextBox5.Text);
        cmd2.Parameters.AddWithValue("@price", TextBox6.Text);
        cmd2.Parameters.AddWithValue("@spicy", TextBox7.Text);


        cmd2.ExecuteNonQuery();
        con.Close();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
    }
}