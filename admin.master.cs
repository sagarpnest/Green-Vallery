using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class colorMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnchngpswd_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_chng_pswd.aspx");
    }
    protected void btnempreg_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_emp_res.aspx");
    }
    protected void btnempdetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_employee_detail.aspx");
    }
    protected void btnsctdetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_table_details.aspx");
    }
    
    protected void btnbilldet_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_add_table.aspx");
    }
    protected void btnvehdet_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_paid_order.aspx");
    }
    protected void btntandc_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_pending_order.aspx");
    }
}