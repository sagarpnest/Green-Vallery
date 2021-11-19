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

public partial class Default2 : System.Web.UI.Page
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
        FileUpload1.SaveAs(Server.MapPath("aadhar_card/" + filename1));


        //second  path for license pics....
        string filename2 = Path.GetFileName(FileUpload2.PostedFile.FileName);
        FileUpload2.SaveAs(Server.MapPath("Pan_card/" + filename2));



        //String str = "insert into passport values('" + TextBox1.Text + "','" + TextBox2.Text + "','" +
        //    TextBox3.Text + "','" + TextBox4.Text + "','" + "(@per_pic)" + "','" + "(@pic_path)" + "')";

        SqlCommand cmd = new SqlCommand("Insert into Employee_table(Email_id,Password,Name,Address,Contact_number,Aadhar_card,Aadhar_card_pic,Aadhar_card_path,Pan_card,Pan_card_pic,Pan_card_path,type) values(@id,@pass, @name, @addr, @no,@aadh,@aadh_pic,@aadh_path,@pan,@pan_pic,@pan_path,@type)", con);
        // SqlCommand cmd = new SqlCommand(str, con);

        cmd.Parameters.AddWithValue("@id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
        cmd.Parameters.AddWithValue("@name", TextBox3.Text);
        cmd.Parameters.AddWithValue("@addr", TextBox4.Text);
        cmd.Parameters.AddWithValue("@no", TextBox5.Text);
        cmd.Parameters.AddWithValue("@aadh", TextBox6.Text);
        cmd.Parameters.AddWithValue("@aadh_pic", filename1);
        cmd.Parameters.AddWithValue("@aadh_path", "aadhar_card/" + filename1);
        cmd.Parameters.AddWithValue("@pan", TextBox7.Text);
        cmd.Parameters.AddWithValue("@pan_pic", filename2);
        cmd.Parameters.AddWithValue("@pan_path", "images/" + filename2);
        cmd.Parameters.AddWithValue("@type", 2);

        cmd.ExecuteNonQuery();
        con.Close();
        
        


        SqlConnection con1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True");
        con1.Open();

        SqlCommand cmd1 = new SqlCommand("Insert into Login_table(Email_id,Password,type) values(@id,@pass,@type)", con1);
        // SqlCommand cmd = new SqlCommand(str, con);

        cmd1.Parameters.AddWithValue("@id", TextBox1.Text);
        cmd1.Parameters.AddWithValue("@pass", TextBox2.Text);
        cmd1.Parameters.AddWithValue("@type", 2);

        cmd1.ExecuteNonQuery();
        con1.Close();
        

        //Session["name"] = TextBox1.Text;
        // Response.Redirect("display.aspx");

    }
}