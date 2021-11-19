
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

public partial class admin_recover_password : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ROS.mdf;Integrated Security=True;User Instance=True;");
        con.Open();
        SqlCommand cmd = new SqlCommand("select COUNT(*)FROM Admin_table WHERE Email_id='" + TextBox1.Text + "' and Contact_number='" + TextBox2.Text + "'");
        cmd.Connection = con;
        int OBJ = Convert.ToInt32(cmd.ExecuteScalar());
        if (OBJ > 0)
        {

            Session["name"] = TextBox1.Text;

            SqlCommand cmd1 = new SqlCommand("select * FROM Admin_table WHERE Email_id='" + TextBox1.Text + "' and Contact_number='" + TextBox2.Text + "'");
            cmd1.Connection = con;
            SqlDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {

                string psw = reader["password"].ToString();


                using (MailMessage mm = new MailMessage(ConfigurationManager.AppSettings["SMTPuser"], TextBox1.Text))
                {
                    mm.Subject = "This is your old password. please login and change...";
                    mm.Body = psw;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = ConfigurationManager.AppSettings["Host"];
                    smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSSL"]);
                    NetworkCredential NetworkCred = new NetworkCredential(ConfigurationManager.AppSettings["SMTPuser"],
                        ConfigurationManager.AppSettings["SMTPpassword"]);

                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = int.Parse(ConfigurationManager.AppSettings["Port"]);
                    smtp.Send(mm);


                }

            }
            Response.Redirect("basic_login.aspx");
            con.Close();
        }
        else
        {
            Label1.Text = "Invalid Email Id or Mobile ";


        }
    }
}