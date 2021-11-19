using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class basic_recover : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_recover_password.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("emp_recover_password.aspx");
    }
     protected void Button3_Click(object sender, EventArgs e)
    {
        System.Web.UI.ScriptManager.RegisterStartupScript(this, GetType(), "Password has been given on the table , click on login", "alert('Password has been given on the table , click on login');", true);
         
    }

}