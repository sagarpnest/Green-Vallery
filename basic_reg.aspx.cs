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



public partial class basic_reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\jadibuti.mdf;Integrated Security=True;User Instance=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from regform where emailid='" + TextBox1.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            Label1.Text = "User Name is Already Exist";
            this.Label1.ForeColor = Color.Red;
        }
        else
        {
            Label1.Text = "UserName is Available";
            this.Label1.ForeColor = Color.Red;
        }
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        captcha1.ValidateCaptcha(TextBox6.Text.Trim());
        if (captcha1.UserValidated)
        {
            //you can use disconnected architecture also,here i have used connected architecture.

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\jadibuti.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            String str = "insert into regform values('" + TextBox1.Text + "','" + TextBox5.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + 2 + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();

            Session["name"] = TextBox1.Text;

            using (MailMessage mm = new MailMessage(ConfigurationManager.AppSettings["SMTPuser"], TextBox1.Text))
            {
                mm.Subject = "welcome to our family...";
                mm.Body = "Hello, welcome to our family.Now you are a part of healthy family. we are happy to welcome you...";
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
            Response.Redirect("basic_login.aspx");
            con.Close();
        }
        else
        {
            
            Label2.ForeColor = System.Drawing.Color.Red;
            Label2.Text = "You have Entered InValid Captcha Characters please Enter again";
        }

    }
}