using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnchngpswd_Click(object sender, EventArgs e)
    {
        Response.Redirect("basic_login.aspx");
    }
    protected void btnempreg_Click(object sender, EventArgs e)
    {
        Response.Redirect("basic_contactus.aspx");
    }
    protected void btnempdetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("basic_aboutus.aspx");
    }
}